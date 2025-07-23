using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Section013Codes.ExercicioPropostoDictionary
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"D:\EEEenxxeee\Documents\MainProjects\UDEMY\C#Poo\code\Section013Codes\ExercicioPropostoDictionary\in.txt";

            Dictionary<string, int> dic = [];

            using StreamReader streamReader = File.OpenText(path);
            while (!streamReader.EndOfStream)
            {
                string[] lines = streamReader.ReadLine().Split(",");
                if (dic.ContainsKey(lines[0]))
                {
                    dic.TryGetValue(lines[0], out int value);
                    dic[lines[0]] = int.Parse(lines[1]) + value;
                }
                else
                {
                    dic.Add(lines[0], int.Parse(lines[1]));
                }
            }

            foreach (KeyValuePair<string, int> item in dic)
            {
                System.Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}