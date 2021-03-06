﻿using AuthorsDTOs;
using System.Collections.Generic;

namespace AuthorsService.InterfaceService
{
    public interface ICommonService
    {
        List<BookDetail> GetAllBooks();
        bool AddBook(BookDetailABM book);
        bool EditBook(BookDetailABM book);
        BookDetailABM GetBook(int id);
    }
}
