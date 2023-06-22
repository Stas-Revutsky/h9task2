using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace h9task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textDir = "..\\..\\..\\someText.Txt";
            string[] stringedTxt = new string[0];
            using (StreamReader sr = new StreamReader(textDir, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    stringedTxt = stringedTxt.Append(line).ToArray();
                }
            }
             
            Console.WriteLine($"Total characters : {stringedTxt.Sum(line => line.Length)}");
            Console.WriteLine($"The longest line is {stringedTxt.MaxBy(line => line.Length)} " +
                $"with length of {stringedTxt.MaxBy(line => line.Length).Length}");
            Console.WriteLine($"The shortest line is {stringedTxt.MinBy(line => line.Length)} " +
                $"with length of {stringedTxt.MinBy(line => line.Length).Length}");
            Regex regVar = new Regex("^(var)+$");
            Console.WriteLine("following strings in text consist only of var");
            foreach (string line in stringedTxt)
            {
                if (regVar.IsMatch(line))
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}