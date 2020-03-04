using System.Text.RegularExpressions;
using System.IO;
// возможные ошибки: 
// 1. цикл от 0 до числа в перрвой строке
// 2. неправильное выражение
namespace Taxi
{
    public class Example
    {
        public static void Main()
        {
            int counter = 0;
            Regex regex = new Regex("^(7[T]([ABE])[X]|[1-6][T][AB][X])\\s" +
                "(([0-9][0-9][0-9][1-9])|([0-9][0-9][1-9][0-9])" +
                "|([0-9][1-9][0-9][0-9])|([1-9][0-9][0-9][0-9]))$");
            using (StreamReader sr = new StreamReader(@"D:\visual 2\Taxi\Taxi\text.in"))
            {
                string line;
                while (( line = sr.ReadLine()) != null && counter>=0)
                {
                    if (regex.IsMatch(line))
                    {
                        counter++;
                    }
                }
                StreamWriter output = new StreamWriter("taxi.out");
                output.Write(counter);
                output.Close();
                sr.Close();
            }
        }
    }
}
