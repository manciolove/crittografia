using System.Runtime.CompilerServices;

namespace crittografia
{
    internal class Program
    {
        //funzione cesare
        static char[] Cesare (char[] alfabeto, char[]parola, int k)
        {
           
            for (int i = 0; i < parola.Length; i++)
            {
               int j = 0; int indFin;
                while (parola[i] != alfabeto[j])
                {
                    j++;
                }
                if (j + k > alfabeto.Length - 1)
                {
                     indFin= k - (alfabeto.Length - j);  
                    parola[i] = alfabeto[indFin];
                }
                else
                {
                    parola[i] = alfabeto[j + k];
                }
               
            }
            return parola;
        }

        //funzione Trasposizione
        static char[] Trasposizione(char[] parola, int k)
        {

            char[] vetTrasp = new char[parola.Length];
            int cont = 0;

            for (int i = 0; i < parola.Length; i++)
            {

                if (i + k > parola.Length - 1)
                {

                    cont = k - (parola.Length - i);
                    vetTrasp[cont] = parola[i];
                }
                else
                {

                    vetTrasp[i + k] = parola[i];
                }
            }

            return vetTrasp;
        }
        static void Main(string[] args)
        {
            //cesare
            int k = 3;
            string p;
            char[] a= { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
           
            Console.WriteLine("inserisci la tua parola: ");
            p = Console.ReadLine();
            char[] parolaArray = p.ToCharArray();
            char[] parolaSostituita = Cesare (parolaArray, a, k);
            Console.WriteLine(parolaSostituita);

            //trasposizione
            char[] parolaTraslazione = Trasposizione(parolaSostituita, k);

            Console.Write("Parola con trasposizione: ");

            for (int i = 0; i < parolaTraslazione.Length; i++)
            {
                Console.Write(parolaTraslazione[i]);
            }














        }
    }
}
