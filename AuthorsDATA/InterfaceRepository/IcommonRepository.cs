using AuthorsDTOs;
using System.Collections.Generic;

namespace AuthorsDATA.InterfaceRepository
{
    public interface ICommonRepository
    {
        List<BookDetail> GetAllBooks();
        bool AddBook(BookDetailABM book);
        bool EditBook(BookDetailABM book);
        BookDetailABM GetBook(int id);
    }
}
