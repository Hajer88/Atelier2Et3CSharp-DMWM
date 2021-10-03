using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2Et3CSharp_DMWM
{
    public class Interrupteur
    {
        private int position;
        private Lampe l;
        public Interrupteur(Lampe l)
        {
            this.l = l;
            position = 0;
        }
        public void allumer()
        {
            position = 1;
            l.allumer();
        }
        public void eteindre()
        {
            position = 0;
            l.eteindre();
        }
    }
}
