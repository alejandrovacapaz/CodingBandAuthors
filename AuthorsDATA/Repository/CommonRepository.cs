using System.Collections.Generic;
using AuthorsDATA.InterfaceRepository;
using AuthorsDTOs;
using System.Linq;

namespace AuthorsDATA.Repository
{
    public class CommonRepository : ICommonRepository
    {
        public List<BookDetail> GetAllBooks()
        {
            var books = new List<BookDetail>();
            try
            {
                using (var context = new AutoresEntities())
                {
                    books = context.Libro.Include("Autor").Where(x => x.id > 0).Select(y => new BookDetail()
                    {
                        titulo = y.titulo,
                        edicion = y.fecha_edicion.ToString(),
                        autores = y.Autor.Count()
                    }).ToList();
                }
            }
            catch (System.Exception)
            {
                return books;
            }
           
            return books;
        }
    }
}
