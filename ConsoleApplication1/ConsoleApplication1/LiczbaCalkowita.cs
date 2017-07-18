using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class LiczbaCalkowita
    {
        public int liczba;

        public int PobierzLiczbe()
        {
            return liczba;
        }


        public void wyswietl()
        {
            Console.WriteLine("Zapisana liczba to: " + liczba);
        }
    }
}
