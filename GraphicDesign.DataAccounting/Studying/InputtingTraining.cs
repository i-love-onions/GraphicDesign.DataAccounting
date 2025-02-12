using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.ConsoleIO;
using GraphicDesign.UI.Models;
using PhoneNumbers;

namespace GraphicDesign.DataAccounting.Studying
{
    static public class InputtingTraining
    {
        static internal void Run()
        {
            Console.WriteLine("\n --- StudyNumbersInputting ---");
            StudyNumbersInputting();

            Console.WriteLine("\n --- StudyGraphicDesignInputting ---");
            StudyLogoInputting();
            StudyIllustrationInputting();
            StudyInstrumentInputting();
            StudyOrderInputting();
        }
        static private void StudyNumbersInputting()
        {
            Console.WriteLine("\n --- StudyNumbersInputting ---");

            int id = Inputting.InputInt32("Ідентифікатор об'єкта сутності", 0, 10);
            Console.WriteLine("\t id: \t{0}", id);
        }
        static private void StudyLogoInputting()
        {
            Console.WriteLine("\n --- StudyLogoInputting ---");
            
            Logo model = new Logo();

            Console.WriteLine("Введіть дані логотипу");
            Inputting.OutInputtingPrompt();

            model.Name = DataInputting.InputImageName();
            model.FilePath = DataInputting.InputImagePath();
            model.CreationDate = DataInputting.InputImageCreationDate();
            model.Desctiption = DataInputting.InputImageDescription();
            model.Note = DataInputting.InputImageNote();

        }
        static private void StudyIllustrationInputting()
        {
            Console.WriteLine("\n --- StudyIllustrationInputting ---");
            
            Illustration model = new Illustration();

            Console.WriteLine("Введіть дані ілюстрації");
            Inputting.OutInputtingPrompt();

            model.Name = DataInputting.InputImageName();
            model.FilePath = DataInputting.InputImagePath();
            model.CreationDate = DataInputting.InputImageCreationDate();
            model.Desctiption = DataInputting.InputImageDescription();
            model.Note = DataInputting.InputImageNote();

        }
        static private void StudyInstrumentInputting()
        {
            Console.WriteLine("\n --- StudyInstrumentInputting ---");
            
            Instrument model = new Instrument();

            Console.WriteLine("Введіть дані інструменту");
            Inputting.OutInputtingPrompt();

            model.Name = DataInputting.InputInstrumentName();
            model.Price = DataInputting.InputInstrumentPrice();
            model.PaymentDate = DataInputting.InputInstrumentDate();
            model.Note = DataInputting.InputInstrumentNote();
        }
        static private void StudyOrderInputting()
        {
            Console.WriteLine("\n --- StudyOrderInputting ---");
            
            Order model = new Order();

            Console.WriteLine("Введіть дані замовлення");
            Inputting.OutInputtingPrompt();

            model.OrderId = DataInputting.InputOrderId(new List<ulong>(new ulong[] { 999 }));
            model.CustomerFullName = DataInputting.InputOrderCustomerName();
            model.PhoneNumber = DataInputting.InputOrderPhone();
            model.PaymentAmount = DataInputting.InputOrderPayment();
            model.OrderState = DataInputting.InputOrderState();
            model.Description = DataInputting.InputOrderInfo();
            model.CreationTime = DataInputting.InputOrderCreationTime();
            model.Deadline = DataInputting.InputOrderDeadline();
            model.WorkResult = DataInputting.InputOrderResult();
            model.UsedTools = DataInputting.InputOrderInstrumentsList();
            model.Note = DataInputting.InputOrderNote();
        }
    }
}
