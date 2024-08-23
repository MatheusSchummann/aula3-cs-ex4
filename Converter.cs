using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3_cs_ex4
{
    public class Converter
    {
        public List<int> conversao(List<string> listaS) 
        {
            List<int> listaI = new List<int>();
            listaI = listaS.ConvertAll(int.Parse);
            return listaI;
        }
        public void logic(List<int> listaI, int segun)
        {
            int aux = segun;
            for(int i =0; i<2; i++)
            {
                if (listaI[i] + aux > 60) 
                {
                    listaI[i] = +aux;
                    int valores = listaI[i] / 60;
                    int resto = listaI[i] % 60;
                    listaI[i + 1] += valores;
                    aux = listaI[i + 1];
                    listaI[i] = resto;
                }
            }
            Console.WriteLine("Os segundos foram: {0}", listaI[0]);
            Console.WriteLine("Os minutos foram: {0}", listaI[1]);
            Console.WriteLine("As horas foram: {0}", listaI[2]);
        }
    }
}
