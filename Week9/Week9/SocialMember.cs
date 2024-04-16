using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_Workshops
{
    class SocialMember : GolfClubMemberBase
    {
        //Social membership of Golf Club
        public SocialMember(string n, DateTime b):base(n,b) { }

        public override void emailAlert(string message)
        {
            base.emailAlert(message);
        }
    }
}