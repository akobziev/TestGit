using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //FIlesAndLinq();
            //FilesAndThreads().Wait();
            //WorkWithStrings();
            //WorkWithStringBuilder();
        }

        private static void WorkWithStringBuilder()
        {
            var str = "Lorem ipsum dolor";
            var sb = new StringBuilder();
            sb.AppendLine(str);
            sb.AppendLine("fdasfasdfasdfasdfasd");
            sb.AppendLine("dfasfasdfasdfasdfasdfasdf");
            Console.WriteLine(sb.ToString());
        }

        private static void WorkWithStrings()
        {
            string str1 = "abc";
            string str2 = "abc";
            Console.WriteLine(str1 == str2);
            Console.WriteLine(str1.Equals(str2, StringComparison.CurrentCultureIgnoreCase));

            //$"{str1} {str2}" интерполяция


            string str3 = "  sdfdsfasdfa  ";
            string str4 = "   sfdsafsda   dfasfasdfa  ";
            Console.WriteLine(str3);
            Console.WriteLine(str3.Trim());
            Console.WriteLine(str4.Replace(" ", string.Empty));

            string subStr = str1.Substring(0, 2);
            Console.WriteLine(subStr);
        }

        private static async Task FilesAndThreads()
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "text.txt");

            using (Stream s = File.Create(path))
            using (StreamWriter sw = new StreamWriter(s))
            {
                var str = "Here goes some text.";
                await sw.WriteAsync(str);
            }
        }

        private static void FIlesAndLinq()
        {
            DirectoryInfo directory = new DirectoryInfo(@"C:\Users\Student\source\repos");

            // 1 найти количество всех файлов и подпапок
            int countOfFIles = directory.GetFiles("*.*", SearchOption.AllDirectories).Count();

            // 2 Найти уникальные расширения с помошью Distinct
            var uniqueFileExtens = directory.GetFiles("*.*", SearchOption.AllDirectories).Select(f => Path.GetExtension(f.Name)).Distinct().ToArray();

            //3 найти файлы с размером 0 байт Length
            var fileWithZero = directory.GetFiles("*.*", SearchOption.AllDirectories).Where(f => f.Length == 0).ToArray();
        }
    }
}
