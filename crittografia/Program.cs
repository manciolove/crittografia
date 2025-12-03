namespace crittografia
{
    internal class Program
    {
        //funzione cesare
        static char[] Cesare (char[] alfabeto, char[]parola, int k)
        {
           
            for (int i = 0; i < parola.Length; i++)
            {
               int j = 0;
                while (parola[i] != alfabeto[j])
                {
                    j++;
                }
                parola[i] = alfabeto[j + k];
            }
            return parola;
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
            char[] parolaSostituita = parolaArray;
            Console.WriteLine(Cesare(parolaSostituita, a));












        }
    }
}
