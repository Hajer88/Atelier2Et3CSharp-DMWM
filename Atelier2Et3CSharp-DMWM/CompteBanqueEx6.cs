using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2Et3CSharp_DMWM
{
    class CompteBanqueEx6
    {
        private int solde;
        public CompteBanqueEx6(int solde)
        {
            this.solde = solde;
        }
        public static bool operator 
            == (CompteBanqueEx6 c1, CompteBanqueEx6 c2)
        {
            if(c1.solde==c2.solde)
            { return true; }
            else { return false; }
        }
        public static bool operator
            !=(CompteBanqueEx6 c1, CompteBanqueEx6 c2)
        {
            return !(c1 == c2);
        }
        public static CompteBanqueEx6 operator + 
            (CompteBanqueEx6 c1, CompteBanqueEx6 c2)
        {
            return new CompteBanqueEx6(c1.solde + c2.solde);
        }

        public override bool Equals(object obj)
        {
            return true;
        }
        

    }
}
