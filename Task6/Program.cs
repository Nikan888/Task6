using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>
            {
                new Employee("Yury", "Bolbukou", 18, "Oktyabrya, 48a", "BI", "trainee", "+375293595413", 25),
                new Employee("Stanislav", "Ivanov", 25, "Gagarina, 20", "BI", "junior", "+375441158736", 154),
                new Employee("QWERTYUI", "YCFVGYBKHN", 22, "RDCTFVGBHN", "CTVGYBHUN", "OIJL", "684526454", 98),
                new Employee("fdghjkjh", "dfghjjkh", 20, "efdghkj", "drtyuk", "iokjhg", "123456789", 74),
                new Employee("Ivan", "Apekunov", 18, "Chekalova, 22", "BI", "trainee", "+375291748933", 120)
            };
            try
            {
                list.Add(new Employee("Stanislav", "Verevkin", 12, "Masurova, 25", "BI", "trainee", "+375298745214", 50));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Default list:");
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            list.Sort();
            Console.WriteLine("Sorted list:");
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }
}
