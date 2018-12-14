using System.Collections.Generic;
using AuthorsDATA.InterfaceRepository;
using AuthorsDTOs;
using System.Linq;
using System;
using static AuthorsDTOs.BookDetailABM;

namespace AuthorsDATA.Repository
{
    public class CommonRepository : ICommonRepository
    {
        public bool AddBook(BookDetailABM book)
        {
            try
            {
                using (var context = new AutoresEntities())
                {
                    // adicionar libro
                    var actualBook = new Libro();
                    actualBook.titulo = book.titulo;
                    actualBook.fecha_edicion = DateTime.ParseExact(book.edicion, "yyyy-MM-dd HH:mm:ss,fff",
                                               System.Globalization.CultureInfo.InvariantCulture); 
                    // adicionar autor(es)
                    foreach (var autor in book.autores)
                    {
                        actualBook.Autor.Add(new Autor()
                        {
                            id = autor.id,
                            nombre = autor.nombre
                        });
                    }                    
                    context.Libro.Add(actualBook);
                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {
                return false;                
            }
        }

        public bool EditBook(BookDetailABM book)
        {
            // eliminar el libro (es mas facil eliminarlo y volverlo a crear por la tabla relacion)
            try
            {
                using (var context = new AutoresEntities())
                {
                    // eliminarlo
                    context.Libro.Remove(context.Libro.FirstOrDefault(x => x.id == book.id));
                    // adicionarlo nuevamente
                    AddBook(book);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<BookDetail> GetAllBooks()
        {
            var books = new List<BookDetail>();
            try
            {
                using (var context = new AutoresEntities())
                {
                    books = context.Libro.Include("Autor").Where(x => x.id > 0).Select(y => new BookDetail()
                    {
                        id = y.id,
                        titulo = y.titulo,
                        edicion = y.fecha_edicion.ToString(),
                        autores = y.Autor.Count()
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return books;
            }
           
            return books;
        }

        public BookDetailABM GetBook(int id)
        {
            var book = new BookDetailABM();
            try
            {
                using (var context = new AutoresEntities())
                {
                    var libro = context.Libro.First(x => x.id == id); // el libro en cuestion
                    var autores = context.Autor.Where(x => x.id > 0).ToList(); // todos los autores
                    var autoresLibro = context.Autor.Include("Libro").Where(x => x.Libro.Any(y => y.id == id)).Select(z => z.id).ToList(); // id de autores del libro en particular
                    var autoresChecked = new List<AuthorsABM>(); // listado de autores, idChecked en true si es autor del libro
                    foreach (var autor in autores)
                    {
                        autoresChecked.Add(new AuthorsABM()
                        {
                            id = autor.id,
                            nombre = autor.nombre, 
                            idChecked = autoresLibro.Contains(autor.id) ? true : false
                        });
                    }
                    book.titulo = libro.titulo;
                    book.edicion = libro.fecha_edicion.ToString();
                    book.autores = autoresChecked;
                }
                return book;             
            }
            catch (Exception)
            {
                return book;
            }
        }
    }
}
