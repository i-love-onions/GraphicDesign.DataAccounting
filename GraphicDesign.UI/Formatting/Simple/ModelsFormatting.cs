using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Models;

namespace GraphicDesign.UI.Formatting.Simple
{
    public static class ModelsFormatting
    {
        public static string ToDataString(this Instrument instrument)
        {
            return string.Format(
                "\tНазва Інструменту: {0}\n" +
                "\tЦіна: {1}\n" +
                "\tДата оплати: {2}\n" +
                "\tПримітка: {3}",
                instrument.ToolName,
                instrument.Price,
                instrument.PaymentDate,
                instrument.Note
                );
        }
        public static string ToDataString(this Illustration illustration)
        {
            return string.Format("\tНазва ілюстрації: {0}\n" +
                "\tШлях до файлу: {1}\n" +
                "\tДата створення: {2}\n" +
                "\tОпис: {3}\n" +
                "\tПримітка: {4}",
                illustration.Name,
                illustration.FilePath,
                illustration.CreationDate,
                illustration.Desctiption,
                illustration.Note
                );
        }

    }
}
