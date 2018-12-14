using AuthorsDTOs;
using System.Collections.Generic;

namespace AuthorsService.InterfaceService
{
    public interface ICommonService
    {
        List<BookDetail> GetAllBooks();
    }
}
