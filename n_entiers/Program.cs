using System;

class Program
{
    public static void Main(string[] args)
    {
        
        Console.Write("rentrer un entier : ");
        string entry1 = Console.ReadLine();
        int entryInt = default;
        while (true) 
        {
            if (!(int.TryParse(entry1, out entryInt)))
            {
                Console.WriteLine("ERROR: l'entre n'est pas un entier");
                Console.Write("rentrer un entier : ");
                entry1 = Console.ReadLine();

            }
            else if (entry1 == null || entry1 == "0") 
            {
                Console.WriteLine("valeur vide ou 0. rentrez un entier different de zero");
                entry1 = Console.ReadLine();
            }
            else
            {
                break;
            }
        }
      
        entryInt = Convert.ToInt32(entry1);
        int n = Math.Abs(entryInt);
        List<int> entiers = new List<int>();
        if (n >= 2)
        {
            Random random = new Random();
            int minValue = -1 * n ^ 2;
            int maxValue = n ^ 2;
            int numeroInit = default;
            int i= 0;
            while (i<n)
            {
                
                numeroInit = random.Next(minValue, maxValue);
                entiers.Add((-1 ^ i) * numeroInit);
                i++;
                if (i == n - 1)
                {
                    int somme = entiers.Sum();
                    entiers.Add(-1 * somme);
                    i++;
                }
            }
        }
        else
        {
            entiers[0] = 0;
        }
        string resultat = string.Join(",", entiers);

        Console.WriteLine($"[{resultat}]");

    }   
}