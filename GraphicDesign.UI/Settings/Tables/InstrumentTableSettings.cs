using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Formatting.Tables;
using PhoneNumbers;

namespace GraphicDesign.UI.Settings.Tables
{
    public static class InstrumentTableSettings
    {
        public static TableSettings Current;
        private static void IniColumnHeaders(string[] headers)
        {
            headers[(int)InstrumentTableColumn.Name] = "Назва";
            headers[(int)InstrumentTableColumn.Price] = "Ціна";
            headers[(int)InstrumentTableColumn.PaymentDate] = "Дата оплати";
            headers[(int)InstrumentTableColumn.Note] = "Нотатка";
        }
        private static void IniColumnWidthes(int[] widthes)
        {
            widthes[(int)InstrumentTableColumn.Name] = 15;
            widthes[(int)InstrumentTableColumn.Price] = 23;
            widthes[(int)InstrumentTableColumn.PaymentDate] = 20;
            widthes[(int)InstrumentTableColumn.Note] = 12;
        }
        private static void IniTableSettings()
        {
            string header = "Інструменти";
            int columnCount = Enum.GetValues(typeof(InstrumentTableColumn)).Length;
            string[] headers = new string[columnCount];
            IniColumnHeaders(headers);
            int[] widthes = new int[columnCount];
            IniColumnWidthes(widthes);
            Current = new TableSettings(header, headers, widthes);
        }
        static InstrumentTableSettings()
        {
            IniTableSettings();
        }
    }
}
