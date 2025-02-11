using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Data;
using GraphicDesign.UI.Data.Testing;
using GraphicDesign.UI.Formatting;

namespace GraphicDesign.DataAccounting.Studying
{
    public static class ListsSetTraining
    {
        internal static void Run()
        {
            Console.WriteLine(" === ListsSetTraining === \n");
            //StudyStatisticsString();

            Console.WriteLine(" --- StudyToDataTraining --- ");
            StudyToDataString();
        }
        static void StudyStatisticsString()
        {
            Console.WriteLine(" --- StudyStatisticsString --- ");

            ModelsListsSet listsSet = new ModelsListsSet();
            ModelsCreation.CreateTestingModels(listsSet);
            Console.WriteLine(DataFormatting.ToStatisticsString(listsSet));
        }
        static void StudyToDataString()
        {
            ModelsListsSet listsSet = new ModelsListsSet();
            Console.WriteLine(listsSet.ToDataString());

            ModelsCreation.CreateTestingModels(listsSet);
            Console.WriteLine(listsSet.ToDataString());
        }
    }
}
