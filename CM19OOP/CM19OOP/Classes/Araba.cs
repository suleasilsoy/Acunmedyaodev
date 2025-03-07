using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM19OOP.Classes
{
    public class Araba 
    {
        public string modeli;
        public int yil;
        public string renk;
        public double km;


        public void git(string markasi,string rengi)// dışardan parametre alacak şekile getiriyoruz
        {
            Console.WriteLine(markasi +" "+ rengi + "  gidiyor...");
        }

        public void arabanınVitesi(string model,string vites)
        {
            Console.WriteLine(model +" "+vites+" ");
        }

    }
}
