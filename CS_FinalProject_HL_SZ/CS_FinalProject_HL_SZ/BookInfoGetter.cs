using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_FinalProject_HL_SZ
{
    public class BookInfoGetter
    {
        public int book_id { get; private set; }
        public string title { get; private set; }
        public string language { get; private set; }
        public bool status { get; private set; }
        public string category { get; private set; }
        public string author { get; private set; }

        public BookInfoGetter()
        {

        }
        public BookInfoGetter(book currentBook, string categoryName, string authorName)
        {
            this.book_id = currentBook.book_id;
            this.title = currentBook.title;
            this.language = currentBook.language;
            this.status = (bool)currentBook.isBorrowed;
            this.category = categoryName;
            this.author = authorName;
        }
    }
}
