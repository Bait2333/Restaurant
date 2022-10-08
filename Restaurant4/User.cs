using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant4
{
        public class User
        {
            string uname;
            string pwd;
            string phonenumber;
            string email;
            string fullname;

            public User() { }

            public string Uname
            {
                get { return uname; }
                set { uname = value; }
            }  
            
            public string Phonenumber
            {
                get { return phonenumber; }
                set { phonenumber = value; }
            }

                public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public string Fullname
            {
                get { return fullname; }
                set { 
                    fullname = value;
                }
            }


            public string Pwd
            {
                get { return pwd; }
                set { pwd = value; }
            }
    }
}
