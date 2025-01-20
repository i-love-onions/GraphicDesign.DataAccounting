using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Common.ConsoleIO;

namespace GraphicDesign.DataAccounting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "GraphicDesign.DataAccounting(Лотоцький Н. О.)";
            ConsoleSettings.SetConsoleParam();
            Console.WriteLine("Дослідження роботи програмних засобів");

            Studying.ModelsTraining.Run();
            Console.ReadKey();
        }
    }
}
