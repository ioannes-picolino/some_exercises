using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leitura_resistores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fx1, fx2, fx3, fx4;

            /*Console.WriteLine("Escreva a cor da primeira faixa do resistor");
            fx1= Console.ReadLine();
            Console.WriteLine("Escreva a cor da segunda faixa do resistor");
            fx2= Console.ReadLine();
            Console.WriteLine("Escreva a cor da terceira faixa do resistor");
            fx3= Console.ReadLine();
            Console.WriteLine("Escreva a cor da quarta faixa do resistor");
            fx4= Console.ReadLine();
            Console.WriteLine("O valor do resistor é: {0} ", ler_resistor());*/
            Console.WriteLine(ler_resistor("VM", "VM", "LR", "DR"));
            Console.ReadKey();
        }
        static string ler_resistor(string fx1, string fx2, string fx3, string fx4)
        {
            List<string> cores = new List<string>();
            cores.Add("PR"); //0
            cores.Add("MR");
            cores.Add("VM");//2
            cores.Add("LR");
            cores.Add("AM");
            cores.Add("VD");
            cores.Add("AZ");
            cores.Add("VL");
            cores.Add("CZ");
            cores.Add("BR");

            int resultado=0;
            string tolerancia;

            resultado+=(cores.IndexOf(fx1)*10);
            resultado+=(cores.IndexOf(fx2));
            resultado*= Convert.ToInt32( Math.Pow(10,cores.IndexOf(fx3)));
            if (fx4)
            return string.Format("{0} Ohms +-{1}", resultado, tolerancia);
        }
    }
}
