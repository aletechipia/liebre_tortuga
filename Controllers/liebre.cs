using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace tortuguita.Controllers
{
    public class liebre
    {
        int i = 0;
        int distancia = 0;

        public liebre(int distancia)
        {
            this.distancia = distancia;
        }
        public liebre()
        {
            this.distancia = 6;
        }

        public void liebrecorriendo()
        {
            int casilla = 0;
            Thread.Sleep(2000);
            Console.Write("arranco la liebre" + "\n");
            while (i < distancia)
            {

                if (i == ((distancia / 2)))
                {
                    Console.Write("la liebre llego a la mitad y se quedo dormida esperando a la tortuga" + "\n");
                    Thread.Sleep((2000 * (distancia))+1000);

                }
                casilla = i + 1;

                Thread.Sleep(2000);
                Console.Write("la liebre avanza a la casilla " + casilla + "\n"); i++;
                

            }

            Console.Write("termino la liebre" + "\n");

        }
    }
}
