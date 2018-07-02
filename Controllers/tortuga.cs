using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace tortuguita.Controllers
{
    public class tortuga
    {
        int distancia = 0;

        public tortuga(int distancia)
        {
            this.distancia = distancia;
        }
        public tortuga()
        {
            this.distancia = 6;
        }

        public void tortugacorriendo()
        {
            int i = 0;
            int casilla = 0;
            Thread.Sleep(2000);
            Console.Write("arranco la tortuga" + "\n");
            while (i < distancia)
            {
                if (i == ((distancia / 2)))
                {
                    Console.Write("la tortuga llego a la mitad  y paso en silencio para no despertar a la liebre" + "\n");

                }

                casilla = i + 1;

                Thread.Sleep(4000);
                Console.Write("la tortuga avanza a la casilla " + casilla + "\n");

                i++;
            }

            Console.Write("termino la tortuga" + "\n");

        }
    }
}
