using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Formatting.Tables;
using GraphicDesign.UI.Models;

namespace GraphicDesign.UI.Settings.Tables
{
    public static class InstrumentTablesFormatting
    {
        public static string[][] ToDataJaggedArray(this List<Instrument> instruments)
        {
            string[][] values = new string[instruments.Count][];
            for(int i = 0; i < instruments.Count; i++)
            {
                Instrument instrument = instruments[i];
                values[i] = new string[InstrumentTableSettings.Current.ColumnsCount];
                values[i][(int)InstrumentTableColumn.Name] = instrument.Name;
                values[i][(int)InstrumentTableColumn.Price] = instrument.Price.ToString();
                values[i][(int)InstrumentTableColumn.PaymentDate] = instrument.PaymentDate.ToString();
                values[i][(int)InstrumentTableColumn.Note] = instrument.Note;
            }
            return values;
        }
        public static string ToTable(this List<Instrument> instruments,
            BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = instruments.ToDataJaggedArray();
            return values.ToTable(InstrumentTableSettings.Current, borderStyle);
        }
        public static string ToTable(this List<Instrument> instruments,
            bool[] visibility, BorderStyle borderStyle = BorderStyle.Single)
        {
            string[][] values = instruments.ToDataJaggedArray();
            return values.ToTable(InstrumentTableSettings.Current, visibility, borderStyle);
        }
    }
}
