using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace aula3_cs_ex4
{

    /*Escreva um programa em C# que lê um horário inicial (lê uma hora, minuto e 
    segundo). A seguir o programa deve ler uma quantidade de segundos.
    Essa quantidade de segundos deve ser adicionada ao horário inicial e o programa
    deve escrever o horário final (escrever as horas, minutos e segundos finais)*/

    public class Program
    {

        static void Main(string[] args)
        {
            Program start = new Program();
        }
        public Program() 
        {
            List<string> listaS = new List<string>();
            List<int> listaI = new List<int>();
            Converter Conversao = new Converter();  
            string[] horarios = {"segundos","minutos","horas"};

            for(int i = 0; i<3; i++)
            {
                Console.Write("Digite os(as) {0}: ", horarios[i]);
                listaS.Add(Console.ReadLine());
                listaI = Conversao.conversao(listaS);
                if(i < 2)
                {
                    while (listaI[i] > 60 || listaI[i] < 0)
                    {
                        Console.Write("Erro os(as) {0} se limitam entre 0 a 60, digite um novo valor valido: ", horarios[i]);
                        listaS[i]=(Console.ReadLine());
                        listaI = Conversao.conversao(listaS);
                    }
                }
            }
            Console.WriteLine("Digite um novo valor de segundos: ");
            string seg =(Console.ReadLine());
            int segfinal = Convert.ToInt32(seg);

            Conversao.logic(listaI, segfinal);
            Console.ReadKey();
  
        }
    
    
    }
}
