using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atelier2Et3CSharp_DMWM
{
    class Program
    {
        static void Main(string[] args)
        {
            CompteBanque c = new CompteBanque();
            c.credit(100);
            c.debit(50);
            Console.WriteLine(c.Liresolde());
            //Extension Product List
            CartProducts pList = new CartProducts()
            {
                produits =
               {
                   new Produit{Prix=10},
                   new Produit{Prix=20},
               }
            };
            double res = pList.TotalPrix();
            //Interrupteur
            Lampe l = new Lampe();
            l.allumer();
        }
    }
}
