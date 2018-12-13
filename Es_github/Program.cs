using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_github
{
    class Program
    {
        static void Main(string[] args)
        {
            int valore = 0;
            string plainText = " ";
            string base64EncodedData;

            Console.WriteLine("Inserisci il valore della variabile in input");
            plainText = Console.ReadLine();

            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            

            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                Console.WriteLine(plainTextBytes[i]);
                Console.WriteLine(Convert.ToString(plainTextBytes[i], 2));
            }
            base64EncodedData = Convert.ToBase64String(plainTextBytes);
            Console.WriteLine($"la codifica in base 64 della parola {plainText} è :{base64EncodedData}");
            
           byte[] base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            plainText = System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
           

            Console.WriteLine("inserisci un numero");

            valore = Convert.ToInt32(Console.ReadLine());
            char c = Convert.ToChar(valore);
            Console.WriteLine(c);

            Console.ReadLine();
        }
    }
}
