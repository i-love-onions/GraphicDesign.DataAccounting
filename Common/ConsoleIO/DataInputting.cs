using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Models;
using GraphicDesign.UI.Settings;
using PhoneNumbers;

namespace Common.ConsoleIO
{
    public static class DataInputting
    {
        public static ulong InputOrderId(List<ulong> idList)
        {
            return Inputting.InputUInt64("Айді унікальне", idList);
        }
        public static string InputOrderCustomerName() 
        {
            return Inputting.InputString("Повне ім'я замовника", Limitation.minOrderCustomerNameLenght, Limitation.maxOrderCustomerNameLenght);
        }
        public static PhoneNumber InputOrderPhone() 
        {
            return Inputting.InputPhoneNumber("Номер телефону замовника");
        }
        public static decimal InputOrderPayment()
        {
            return Inputting.InputDecimal("Введіть розмір оплати", Limitation.minOrderPayment);
        }
        public static OrderState InputOrderState()
        {
            return Inputting.InputOrderState("Введіть стан замовлення");
        }
        public static string InputOrderInfo()
        {
            return Inputting.InputString("Введть завдання замовлення", Limitation.minOrderDescriptionLenght, Limitation.maxOrderDescriptionLenght);
        }
        public static DateTime InputOrderCreationTime()
        {
            return Inputting.InputDateTime("Введіть дату створення", Limitation.minOrderDate, Limitation.maxOrderDate);
        }
        public static DateTime InputOrderDeadline() 
        {
            return Inputting.InputDateTime("Введіть дату дедлайну", Limitation.minOrderDate, Limitation.maxOrderDeadlineDate);
        }
        public static IImage InputOrderResult()
        {
            // Потрібно доробити
            Console.WriteLine("Створено результат заглушку");
            return new ImagePlaceholder();
        }
        public static List<Instrument> InputOrderInstrumentsList()
        {
            // Потрібно доробити
            Console.WriteLine("Створено список заглушку");
            return new List<Instrument>(new Instrument[] {new Instrument { ToolName = "Foo"} });
        }
        public static string InputOrderNote()
        {
            return Inputting.InputString("Введіть нотатку", Limitation.minOrderNoteLenght, Limitation.maxOrderNoteLenght);
        }
        public static string InputImageName()
        {
            return Inputting.InputString("Введіть назву", Limitation.minImageNameLenght, Limitation.maxImageNameLenght);
        }
        public static string InputImagePath()
        {
            return Inputting.InputString("Введіть шлях до файлу", Limitation.minImagePathLenght, Limitation.maxImagePathLenght);
        }
        public static DateTime InputImageCreationDate()
        {
            return Inputting.InputDateTime("Введіть дату створення", Limitation.minImageCreationDate, Limitation.maxImageCreationDate);
        }
        public static string InputImageDescription() 
        {
            return Inputting.InputString("Введіть опис", Limitation.minImageDescriptionLenght, Limitation.maxImageDescriptionLenght);
        }
        public static string InputImageNote() 
        {
            return Inputting.InputString("Введіть нотатку", Limitation.minImageNoteLenght, Limitation.maxImageNoteLenght);
        }
        public static string InputInstrumentName()
        {
            return Inputting.InputString("Введіть назву", Limitation.minToolNameLenght, Limitation.maxToolNameLenght);
        }
        public static decimal InputInstrumentPrice()
        {
            return Inputting.InputDecimal("Введіть ціну", Limitation.minToolPrice);
        }
        public static DateTime InputInstrumentDate()
        {
            return Inputting.InputDateTime("Введіть дату оплати", Limitation.minToolPaymentDate, Limitation.maxToolPaymentDate);
        }
        public static string InputInstrumentNote()
        {
            return Inputting.InputString("Введіть нотатку", Limitation.minToolNoteLenght, Limitation.maxToolNoteLenght);
        }
    }
}
