using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.ConsoleIO;
using GraphicDesign.DataAccounting.UI;
using GraphicDesign.UI.Data;
using GraphicDesign.UI.Data.Searching;
using GraphicDesign.UI.Data.Testing;
using GraphicDesign.UI.Formatting;
using GraphicDesign.UI.Formatting.Tables;
using GraphicDesign.UI.Models;

namespace GraphicDesign.DataAccounting.Browsing
{
    partial class SimpleBrowser
    {
        SimpleMenuItem[] _menuItems;
        ModelsListsSet _listsSet = new ModelsListsSet();
        private void IniMenuItems()
        {
            _menuItems = new SimpleMenuItem[] {
                new SimpleMenuItem("вийти", null),
                new SimpleMenuItem("створити тестові дані", CreateTestingData),
                new SimpleMenuItem("видалити всі дані", DeleteData),
                new SimpleMenuItem("дані як текст", ShowAsText),
                new SimpleMenuItem("детально про інструмент", ShowInstrumentDetails),
                new SimpleMenuItem("детально про логотип", ShowLogoDetails),
                new SimpleMenuItem("детально про ілюстрацію", ShowIllustrationDetails),
                new SimpleMenuItem("детально про замовлення", ShowOrderDetails),
                new SimpleMenuItem("сортувати логотипи за назвою", SortByNameLogo),
                new SimpleMenuItem("сортувати інструменти за назвою", SortByNameInstrument),
                new SimpleMenuItem("сортувати інструменти за ціною", SortByInstrumentPrice),
                new SimpleMenuItem("сортувати ілюстрації за назвою", SortByIllustrationName),
                new SimpleMenuItem("сортувати замовлення за датою створення", SortByOrderCreationDate),
            };
        }
        public SimpleBrowser()
        {
            IniMenuItems();
        }
        private SimpleMenuItem SelectMenuItem()
        {
            Console.WriteLine("\nСписок команд меню:");
            for (int i = 0; i < _menuItems.Length; i++)
            {
                Console.WriteLine("\t{0,2} - {1}", i, _menuItems[i].CommandName);
            }
            int number = Inputting.InputInt32("\nВведіть номер команди меню", 0, _menuItems.Length - 1);
            return _menuItems[number];
        }
        private static void StopToView()
        {
            Console.WriteLine("\tДля продовження натисніть довільну клавішу");
            Console.ReadKey();
        }
        private void PrepareScreen()
        {
            Console.Clear();
            Console.WriteLine("ПО\"Графічний дизайн\"");
            Console.WriteLine(DataFormatting.ToStatisticsString(_listsSet));

            if (!_listsSet.isEmpty())
            {
                Console.WriteLine();
                Console.WriteLine(SimpleTablesFormatting.ToTable(_listsSet.Logos));
                Console.WriteLine();
                Console.WriteLine(SimpleTablesFormatting.ToTable(_listsSet.Illustrations));
                Console.WriteLine();
                Console.WriteLine(SimpleTablesFormatting.ToTable(_listsSet.Instruments));
                Console.WriteLine();
                Console.WriteLine(SimpleTablesFormatting.ToTable(_listsSet.Orders));
            }
        }
        public void ShowInstrumentDetails()
        {
            string name = Inputting.InputString("Введіть назву інструменту");
            Instrument obj = ModelsSearching.ByName(_listsSet.Instruments, name);
            if (obj == null)
            {
                Console.WriteLine("В списку інструментів немає елемента з Name рівним {0}", name);
                return;
            }
            Console.WriteLine(obj.ToDataString());
            StopToView();
        }
        public void ShowLogoDetails()
        {
            string name = Inputting.InputString("Введіть назву інструменту");
            Logo obj = ModelsSearching.ByName(_listsSet.Logos, name);
            if (obj == null)
            {
                Console.WriteLine("В списку логотипів немає елемента з Name рівним {0}", name);
                return;
            }
            Console.WriteLine(obj.ToDataString());
            StopToView();
        }
        public void ShowIllustrationDetails()
        {
            string name = Inputting.InputString("Введіть назву інструменту");
            Illustration obj = ModelsSearching.ByName(_listsSet.Illustrations, name);
            if (obj == null)
            {
                Console.WriteLine("В списку ілюстрацій немає елемента з Name рівним {0}", name);
                return;
            }
            Console.WriteLine(obj.ToDataString());
            StopToView();
        }
        public void ShowOrderDetails()
        {
            ulong id = Inputting.InputUInt64("");
            Order obj = ModelsSearching.ByName(_listsSet.Orders, id);
            if (obj == null)
            {
                Console.WriteLine("В списку  немає елемента з Id рівним {0}", id);
                return;
            }
            Console.WriteLine(obj.ToDataString());
            StopToView();
        }
        private void ShowAsText()
        {
            Console.WriteLine();
            Console.WriteLine(DataFormatting.ToDataString(_listsSet));
        }
        private void CreateTestingData()
        {
            if (!ModelsCreation.CreateTestingModels(_listsSet))
            {
                Console.WriteLine("\nТестові дані не створені, оскільки сховище не порожнє.");
                StopToView();
            }
        }
        private void DeleteData()
        {
            _listsSet.Clear();
        }
        public void Run()
        {
            while(true)
            {
                PrepareScreen();
                SimpleMenuItem menuItem = SelectMenuItem();
                if(menuItem.Operation == null)
                {
                    return;
                }
                try
                {
                    menuItem.Operation();
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    StopToView();
                }
            }
        }
    }
}
