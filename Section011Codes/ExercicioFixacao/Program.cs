using System.Globalization;
using System.Text;
try
{

    string source = @"D:\EEEenxxeee\Documents\MainProjects\UDEMY\C#Poo\code\Section011Codes\ExercicioFixacao\files\source file\source.csv";
    string target = @"D:\EEEenxxeee\Documents\MainProjects\UDEMY\C#Poo\code\Section011Codes\ExercicioFixacao\files\output file\target.csv";

    string[] lines = File.ReadAllLines(source);

    using StreamWriter streamWriter = File.CreateText(target);
    foreach (string line in lines)
    {
        string[] lineWords = line.Split(",");
        double value = double.Parse(lineWords[1], CultureInfo.InvariantCulture);
        int quantity = int.Parse(lineWords[2]);
        string totalValue = (value * quantity).ToString();

        StringBuilder stringBuilder = new();
        stringBuilder.Append(lineWords[0]);
        stringBuilder.Append(',');
        stringBuilder.Append(totalValue);

        streamWriter.WriteLine(stringBuilder.ToString());
    }
}
catch (FileNotFoundException)
{
    Console.WriteLine("Erro: O arquivo de origem não foi encontrado.");
}
catch (FormatException)
{
    Console.WriteLine("Erro: O arquivo contém dados em formato inválido.");
}
catch (Exception e)
{
    // Captura qualquer outro erro inesperado
    Console.WriteLine("Ocorreu um erro inesperado: " + e.Message);
}