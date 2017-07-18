using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Punkt
    {
        int x, y;

        public int PobierzX() {
            return x;
        }
        public int PobierzY() {
            return y;
        }

        public void ustawX(int wspX) {
            x = wspX;
        }
        public void ustawY(int wspY) {
            y = wspY;
        }

        public void ustawXY(Punkt pkt) {
            x = pkt.x;
            y = pkt.y;
        }

        public Punkt pobierzXY() {
            Punkt pkt = new Punkt();
            pkt.x = x;
            pkt.y = y;
            return pkt;
        }

        public void WyswietlWspolrzedne() {
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
        }

    }
}
