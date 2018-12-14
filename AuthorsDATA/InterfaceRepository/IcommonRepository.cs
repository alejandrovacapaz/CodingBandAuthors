using AuthorsDTOs;
using System.Collections.Generic;

namespace AuthorsDATA.InterfaceRepository
{
    public interface ICommonRepository
    {
        List<BookDetail> GetAllBooks();
    }
}
