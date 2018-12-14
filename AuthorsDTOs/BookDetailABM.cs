using System;
using System.Collections.Generic;

namespace AuthorsDTOs
{  
    public class BookDetailABM
    {
        public class AuthorsABM
        {
            public int id { get; set; }
            public string nombre { get; set; }
            public bool idChecked { get; set; }
        }
        public BookDetailABM()
        {

        }

        public int id { get; set; }
        public string titulo { get; set; }
        public string edicion { get; set; }
        public List<AuthorsABM> autores { get; set; }
    }
}
