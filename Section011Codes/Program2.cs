// // AULA 2

// string path = @"D:\EEEenxxeee\Documents\MainProjects\UDEMY\C#Poo\code\Section011Codes\Stream.txt";

// FileStream fileStream = null;
// StreamReader streamReader = null;

// try
// {
//     fileStream = new(path, FileMode.Open);
//     streamReader = new(fileStream);

//     while (!streamReader.EndOfStream)
//     {
//         string line = streamReader.ReadLine();
//         Console.WriteLine(line);
//     }
// }
// catch (IOException e)
// {
//     Console.WriteLine("ERROR:");
//     Console.WriteLine(e);
// }
// finally
// {
//     fileStream?.Close();
//     streamReader?.Close();
// }

// // Alternativa mais enxuta (explicitamente instância o filestream, não é necessário declarar.): 
// // streamReader = File.OpenText(path);