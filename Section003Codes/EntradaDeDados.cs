using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace ThirdSectionCodes
{
    class EntradaDeDados
    {
        public static void Teste()
        {
            string s = Console.ReadLine();
            string[] vet = s.Split(' ');

            foreach (string word in vet)
            {
                Console.WriteLine(word);
            }

            int i = int.Parse(Console.ReadLine());

            Console.WriteLine(i);
        }

        public static void ExercicioMaria()
        {
            string s = Console.ReadLine();
            string[] vs = s.Split(' ');

            string nome = null;
            char sexo = ' ';
            int idade = 0;
            double altura = 0;

            List<string> parteDoNome = new List<string>(); 

            bool temNome = false;
            bool temSexo = false;
            bool temIdade = false;
            bool temAltura = false;

            foreach (string word in vs)
            {
                if (!temIdade && int.TryParse(word, out int tempIdade))
                {
                    idade = tempIdade;
                    temIdade = true;
                }
                else if (!temAltura && double.TryParse(word, out double tempAltura))
                {
                    altura = tempAltura;
                    temAltura = true;
                }
                else if (!temSexo && char.TryParse(word, out char tempSexo))
                {
                    sexo = tempSexo;
                    temSexo = true;
                }
                else
                {
                    parteDoNome.Add(word);
                }
            }

            if (parteDoNome.Any())
            {
                temNome = true;
                nome = string.Join(" ", parteDoNome);
            }
                
            Console.WriteLine($"nome = {nome}, sexo = {sexo}, idade = {idade}, altura = {altura}");
        }
    }
}