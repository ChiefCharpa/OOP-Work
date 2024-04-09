using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshops
{
    abstract class AccountBase
    {
        private string _AccountName = "";
        int AccountNumber { get; set; }
        string AccountName { get { return _AccountName; } 
                             set { _AccountName = value; } 
        }
        decimal Balance { get; set; }
    }
}