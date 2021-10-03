using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2Et3CSharp_DMWM
{
    public static class ExtensionClass
    {
        public static double TotalPrix(this CartProducts cart)
        {
            double total = 0;
            foreach(Produit prod in cart.produits)
            {
                total += prod.Prix;
            }
            return total;
        }
    }
}
