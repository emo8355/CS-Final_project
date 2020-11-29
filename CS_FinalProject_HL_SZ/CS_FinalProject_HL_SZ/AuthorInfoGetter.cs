using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_FinalProject_HL_SZ
{
    public class AuthorInfoGetter
    {
        public int author_id { get; private set; }
        public string fullname { get; private set; }
        public string firstname { get; private set; }
        public string lastname { get; private set; }


        public AuthorInfoGetter(int authorId, string fn, string ln)
        {
            this.author_id = authorId;
            this.firstname = fn;
            this.lastname = ln;
        }

        public AuthorInfoGetter(int authorId, string fullname)
        {
            this.author_id = authorId;
            this.fullname = fullname;
        }
    }
}
