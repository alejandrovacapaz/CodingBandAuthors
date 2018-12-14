using System.Collections.Generic;
using AuthorsDTOs;
using AuthorsService.InterfaceService;
using AuthorsDATA.InterfaceRepository;

namespace AuthorsService.Service
{
    public class CommonService : ICommonService
    {
        private ICommonRepository _commonRepository;
        
        public CommonService(ICommonRepository commonRepository)
        {
            _commonRepository = commonRepository;
        }

        public List<BookDetail> GetAllBooks()
        {
            return _commonRepository.GetAllBooks();
        }
    }
}
