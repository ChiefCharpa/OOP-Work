using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshops
{
    class GolfClubMemberBase
    {
        //Base class GolfClubMember
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthday { get; set; }
        public int ID { get; set; }
        public bool Vote { get; set; }

        public GolfClubMemberBase(string name, DateTime bd)
        {
            Name = name;
            Birthday = bd;
            //calculate age
            calculateAge();
        }

        protected void calculateAge()
        {
            //TODO: Does this work for all ages?
            var now = DateTime.Today;
            Age = now.Year - Birthday.Year;
            if (B)
        }

        public virtual void emailAlert(string message)
        {
            //Default 
            Console.WriteLine("Default alert");
        }
    }
}
