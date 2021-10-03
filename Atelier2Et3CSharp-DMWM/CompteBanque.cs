using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2Et3CSharp_DMWM
{
    class CompteBanque
    {
        public double solde;
        public CompteBanque()
        {
            solde = 0;
        }
        public CompteBanque(double solde)
        {
            this.solde = solde;
        }
        public void credit(double montant)
        {
            if (solde + montant > 0)
                solde += montant;
        }

        public void debit(double montant)
        {
            if (solde - montant > 0)
                solde -= montant;
        }
        public int Liresolde()
        {
            return (int)solde;
        }
    }
}
