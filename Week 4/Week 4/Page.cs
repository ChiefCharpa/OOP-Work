using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshops
{ 
    class Page
    {
        //auto-implemented properties
        public string Title { get; set; }
        public Uri Address { get; set; }

        //constructor
        public Page(string t, string a)
        {
            if(!Uri.IsWellFormedUriString(t, UriKind.Absolute))
            {
                throw new ArgumentException("Invalid URL format. "+ nameof(a));
            }
            else 
            {
                Title = t;
                Address = new Uri(a);
            }
            
        }


    }
}