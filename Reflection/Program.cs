using System;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Reflection
{
    class Foo
    {
        [JsonProperty("MyCustomName")]
        public string Bar { get; set; }

        public string Baz { get; set; }

        [Custom("MyAttributeTest")]
        public void Test()
        {

        }

        [Custom("MyAttributeHello")]
        public string Hello()
        {
            return "hello";
        }

        public string Hello2()
        {
            return "hello2";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WorkWithAttribute();
            WorkWithReflection();
            WorkWithSerialization();
        }

        private static void WorkWithAttribute()
        {
            foreach (var mi in typeof(Foo).GetMethods())
            {
                CustomAttribute att = (CustomAttribute)Attribute.GetCustomAttribute(mi, typeof(CustomAttribute));
                if (att != null)
                {
                    Console.WriteLine($"Method {mi.Name} will Ье tested; reps= {att}; msg= {att}");
                }
            }
        }

        private static void WorkWithSerialization()
        {
            Foo foo = new Foo
            {
                Bar = "some bar",
                Baz = "some baz"
            };

            string ser = JsonConvert.SerializeObject(foo);
            Console.WriteLine(ser);

            var des = JsonConvert.DeserializeObject<Foo>(ser);
            Console.WriteLine($"{des.Bar} {des.Baz}");
        }

        private static void WorkWithReflection()
        {
            var a = typeof(Enumerable).Assembly;
            Console.WriteLine(a.FullName);

            Type[] types = a.GetTypes();
            foreach (var item in types)
            {
                Console.WriteLine(item.FullName);
            }

            Type stringType = typeof(string);

            string name = stringType.Name;
            Console.WriteLine(name);

            Type baseType = stringType.BaseType;
            Console.WriteLine(baseType.Name);

            MemberInfo[] members = typeof(Door).GetMembers();
            foreach (var item in members)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
