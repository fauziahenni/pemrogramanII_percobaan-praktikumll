using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204013
{
    public class book_1204013 : Product_1204013
    {
        protected string pageCount;

        public book_1204013(string Mytype, string title, string pagecount) : base(Mytype, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }


            set
            {
                pageCount = value;
            }


        }

    }
}