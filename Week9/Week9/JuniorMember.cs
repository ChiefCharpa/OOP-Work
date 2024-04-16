using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshops
{
    class JuniorMember : GolfClubMemberBase
    {
        //Golf Club membership for under 18s
        public JuniorMember(string n, DateTime b) : base(n, b) 
        {
            calculateAge();
            if (Age >= 18)
            {
                throw new Exception($"Junior member {Name} should be less than 18. ");
            }
        }
        public override void emailAlert(string message)
        {
            Output.email($"Sending **{message}** to {Name}");
        }
    }
}
