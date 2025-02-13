using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Data;
using GraphicDesign.UI.Data.Testing;
using GraphicDesign.UI.Formatting;
using GraphicDesign.UI.Formatting.Tables;
using GraphicDesign.UI.Settings.Tables;
using Common.Formatting.Tables;

namespace GraphicDesign.DataAccounting.Studying
{
    public static class TableFormattingTraining
    {
        public static void Run()
        {
            Console.WriteLine(" === TableFormattingTraining === ");
            StudySimpleDataTableFormatting();
            StudyBorderedDataTableFormatting();
            StudyBorderStyles();
            StudyColumnVisibility();
        }
        public static void StudyColumnVisibility()
        {
            Console.WriteLine(" --- StudyColumnVisibility --- ");
            ModelsListsSet listsSet = new ModelsListsSet();
            ModelsCreation.CreateTestingModels(listsSet);
            Console.WriteLine(listsSet.Instruments.ToTable());
            bool[] visibles = new bool[InstrumentTableSettings.Current.ColumnsCount];
            visibles[(int)InstrumentTableColumn.Name] = true;
            visibles[(int)InstrumentTableColumn.Price] = true;
            visibles[(int)InstrumentTableColumn.PaymentDate] = true;
            visibles[(int)InstrumentTableColumn.Note] = false;

            Console.WriteLine(listsSet.Instruments.ToTable(visibles));
        }
        public static void StudyBorderStyles()
        {
            Console.WriteLine(" --- StudyBorderStyles --- ");
            ModelsListsSet listsSet = new ModelsListsSet();
            ModelsCreation.CreateTestingModels(listsSet);
            foreach (BorderStyle el in BorderStylesInfo.Values)
            {
                Console.WriteLine("\n {0} - {1}", el, el.ToCaption());
                Console.WriteLine(InstrumentTablesFormatting.ToTable(listsSet.Instruments,el));
            }
        }
        public static void StudySimpleDataTableFormatting()
        {
            Console.WriteLine(" --- StudySimpleDataTableFormatting --- ");
            ModelsListsSet listsSet = new ModelsListsSet();
            ModelsCreation.CreateTestingModels(listsSet);
            Console.WriteLine(SimpleTablesFormatting.ToTable(listsSet.Logos));
            Console.WriteLine(SimpleTablesFormatting.ToTable(listsSet.Illustrations));
            Console.WriteLine(SimpleTablesFormatting.ToTable(listsSet.Instruments));
        }
        public static void StudyBorderedDataTableFormatting()
        {
            Console.WriteLine(" --- StudyBorderedDataTableFormatting --- ");
            ModelsListsSet listsSet = new ModelsListsSet();
            listsSet.CreateTestingModels();
            Console.WriteLine(listsSet.Instruments.ToTable());
            Console.WriteLine(listsSet.Instruments.ToTable(BorderStyle.InnerHorizontalSingle));
        }
    }
}
