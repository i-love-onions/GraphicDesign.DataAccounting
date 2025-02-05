using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Data;
using GraphicDesign.UI.Formatting;

namespace GraphicDesign.DataAccounting.Studying
{
    public static class ListsSetTraining
    {
        internal static void Run()
        {
            Console.WriteLine(" === ListsSetTraining === \n");
            StudyStatisticsString();
        }
        static void StudyStatisticsString()
        {
            Console.WriteLine(" --- StudyStatisticsString --- ");

            ModelsListsSet listsSet = new ModelsListsSet();
            Console.WriteLine(DataFormatting.ToStatisticsString(listsSet));
        }
    }
}
