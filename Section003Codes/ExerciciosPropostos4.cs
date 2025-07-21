namespace ThirdSectionCodes
{
    public class ExerciciosPropostos4
    {
        public static void Exercicio1()
        {
            System.Console.WriteLine("Digite um número inteiro");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= x; i++)
            {
                if (!(i % 2 == 0))
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        public static void Exercicio2()
        {
            System.Console.WriteLine("Digite quantos valores serão lidos:");
            int x = int.Parse(Console.ReadLine());

            int[] v = new int[x];

            int i = 0;

            int nIn = 0;
            int nOut = 0;

            while (i != v.Length)
            {
                v[i] = int.Parse(Console.ReadLine());
                i++;
            }

            foreach (int num in v)
            {
                if (num >= 10 && num <= 20)
                {
                    nIn++;
                }
                else
                {
                    nOut++;
                }
            }

            System.Console.WriteLine(nIn + " in |" + nOut + " out");
        }         
    }
}