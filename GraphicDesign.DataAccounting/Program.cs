using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Common.ConsoleIO;
using GraphicDesign.DataAccounting.Browsing;

namespace GraphicDesign.DataAccounting
{
    public class Program
    {
        static SimpleBrowser s_simpleBrowser = new SimpleBrowser();
        public static void Main(string[] args)
        {
            Console.Title = "GraphicDesign.DataAccounting(Лотоцький Н. О.)";
            ConsoleSettings.SetConsoleParam();
            Console.WriteLine("Дослідження роботи програмних засобів");

            //Studying.ModelsTraining.Run();
            //Studying.InputtingTraining.Run();
            //Studying.ListsSetTraining.Run();
            //Studying.TableFormattingTraining.Run();
            s_simpleBrowser.Run();
            //Console.ReadKey();
        }
    }
}
