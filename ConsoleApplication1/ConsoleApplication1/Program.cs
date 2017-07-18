using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Punkt pierwszyPkt = new Punkt();
            Punkt drugiPkt = new Punkt();

            pierwszyPkt.ustawX(100);
            pierwszyPkt.ustawY(100);

            Console.WriteLine("pierwszyPkt:");
            pierwszyPkt.WyswietlWspolrzedne();
            drugiPkt = pierwszyPkt.pobierzXY();
            Console.WriteLine("drugiPkt:");
            drugiPkt.WyswietlWspolrzedne();
            Punkt trzeciPkt = new Punkt();
            trzeciPkt.ustawXY(drugiPkt);
            Console.WriteLine("trzeciPkt: ");
            trzeciPkt.WyswietlWspolrzedne();
        }
    }

        
}
