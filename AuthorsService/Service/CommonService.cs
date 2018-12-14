using System.Collections.Generic;
using AuthorsDTOs;
using AuthorsService.InterfaceService;
using AuthorsDATA.InterfaceRepository;
using System;

namespace AuthorsService.Service
{
    public class CommonService : ICommonService
    {
        private ICommonRepository _commonRepository;
        
        public CommonService(ICommonRepository commonRepository)
        {
            _commonRepository = commonRepository;
        }

        public bool AddBook(BookDetailABM book)
        {
            return _commonRepository.AddBook(book);
        }

        public bool EditBook(BookDetailABM book)
        {
            return _commonRepository.EditBook(book);
        }

        public List<BookDetail> GetAllBooks()
        {
            return _commonRepository.GetAllBooks();
        }

        public BookDetailABM GetBook(int id)
        {
            return _commonRepository.GetBook(id);
        }
    }
}
