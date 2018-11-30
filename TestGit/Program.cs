using System;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //WorkWithDateTime();
            //WorkWithTuples();

        }

        private static void WorkWithTuples()
        {
            Dimensions dimensions = new Dimensions
            {
                Height = 10,
                Width = 11,
                Length = 12
            };
            (int Height, double Width, byte Length) dim = (11, 12, 8);
            //var dim = Return();
            Console.WriteLine(dim);
        }

        private static void WorkWithDateTime()
        {
            DateTimeOffset twoDays = DateTimeOffset.Now.AddDays(2);
            DateTimeOffset now = DateTimeOffset.Now;

            TimeSpan span = twoDays.Subtract(now);
            DateTimeOffset dateTimeOffset = DateTimeOffset.MinValue.Add(span);
            Console.WriteLine(dateTimeOffset);

            long timeFromFirstJan1970 = DateTimeOffset.Now.ToUnixTimeSeconds();
            Console.WriteLine(timeFromFirstJan1970);
        }

        static (int Height, int Width, int Length) Return()
        {
            return (1, 2, 3);
        }

        void DoWork()
        {
            // local func
            int Sum(int i, int j)
            {
                return i + j;
            }
            int res = Sum(1, 2);
        }

        private struct Dimensions
        {
            public int Height { get; set; }
            public int Width { get; set; }
            public int Length { get; set; }
        }

        private struct SubProgram // nested class (struct)
        {

        }
    }
}
