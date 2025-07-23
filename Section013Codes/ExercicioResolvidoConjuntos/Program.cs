// namespace Section013Codes.ExercicioResolvidoConjuntos
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             HashSet<User> users = [];


//             System.Console.Write("Enter file full path: ");
//             string path = Console.ReadLine();

//             try
//             {
//                 using StreamReader sr = File.OpenText(path);
//                 while (!sr.EndOfStream)
//                 {
//                     string[] line = sr.ReadLine().Split(' ');
//                     string username = line[0];
//                     DateTime instant = DateTime.Parse(line[1]);

//                     users.Add(new(username, instant));
//                 }
//                 int nUsers = users.Count;

//                 System.Console.WriteLine("Total users: " + nUsers);
//             }
//             catch (IOException e)
//             {
//                 Console.WriteLine(e.Message);
//             }
//         }
//     }
// }