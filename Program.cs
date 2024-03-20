using System;
using System.Text;

namespace ReverteString
{

    class Program
    {
        public static void Main()
        {

            Console.WriteLine("------------Inverso de palavras-----------");
            Console.WriteLine("\n");
            Console.WriteLine("Digite a palavra que deseja inverter");
            string palavra = Console.ReadLine();
            inverterString(palavra);
            
            
        }

        public static void inverterString(string palavra){
            StringBuilder sb = new StringBuilder();

            for(var i = palavra.Length-1; i>=0; i--)
            {
                sb.Append(palavra[i]);
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}