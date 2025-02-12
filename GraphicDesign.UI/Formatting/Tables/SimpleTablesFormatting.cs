using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Models;

namespace GraphicDesign.UI.Formatting.Tables
{
    public static class SimpleTablesFormatting
    {
        public static string ToTable(List<IImage> models, string header = null)
        {
            if(header == null)
            {
                header = "Зображення";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            string format = "{0,10} {1,-23} {2,-20} {3,40} {4,12}\n";
            sb.AppendFormat(format, "Назва", "Шлях до файлу", "Дата створення", "Опис", "Нотатка");
            sb.AppendFormat(" {0}\n", new string('-', string.Format(format, 0, 0, 0, 0, 0).Length));
            foreach(IImage model in models)
            {
                sb.AppendFormat(format,
                    model.Name.LimitString(10),
                    model.FilePath.LimitString(23),
                    model.CreationDate.ToString().LimitString(20),
                    model.Desctiption.LimitString(40),
                    model.Note.LimitString(12));
            }
            return sb.ToString();
        }
        public static string ToTable(List<Illustration> models, string header = null)
        {
            if(header == null)
            {
                header = "Зображення";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            string format = "{0,10} {1,-23} {2,-20} {3,40} {4,12}\n";
            sb.AppendFormat(format, "Назва", "Шлях до файлу", "Дата створення", "Опис", "Нотатка");
            sb.AppendFormat(" {0}\n", new string('-', string.Format(format, 0, 0, 0, 0, 0).Length));
            foreach(Illustration model in models)
            {
                sb.AppendFormat(format,
                    model.Name.LimitString(10),
                    model.FilePath.LimitString(23),
                    model.CreationDate.ToString().LimitString(20),
                    model.Desctiption.LimitString(40),
                    model.Note.LimitString(12));
            }
            return sb.ToString();
        }
        public static string ToTable(List<Logo> models, string header = null)
        {
            if(header == null)
            {
                header = "Зображення";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            string format = "{0,10} {1,-23} {2,-20} {3,40} {4,12}\n";
            sb.AppendFormat(format, "Назва", "Шлях до файлу", "Дата створення", "Опис", "Нотатка");
            sb.AppendFormat(" {0}\n", new string('-', string.Format(format, 0, 0, 0, 0, 0).Length));
            foreach(Logo model in models)
            {
                sb.AppendFormat(format,
                    model.Name.LimitString(10),
                    model.FilePath.LimitString(23),
                    model.CreationDate.ToString().LimitString(20),
                    model.Desctiption.LimitString(40),
                    model.Note.LimitString(12));
            }
            return sb.ToString();
        }
        public static string ToTable(List<Instrument> models, string header = null)
        {
            if(header == null)
            {
                header = "Інструмент";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            string format = "{0,15} {1,-23} {2,-20} {3,12}\n";
            sb.AppendFormat(format, "Назва", "Ціна", "Дата оплати", "Нотатка");
            sb.AppendFormat(" {0}\n", new string('-', string.Format(format, 0, 0, 0, 0).Length));
            foreach(Instrument model in models)
            {
                sb.AppendFormat(format,
                    model.Name.LimitString(15),
                    model.Price,
                    model.PaymentDate.ToString().LimitString(20),
                    model.Note.LimitString(12)
                    );
            }
            return sb.ToString();
        }

        private static string LimitString(this string str, int lenght)
        {
            if (str.Length <= lenght) return str;
            return str.Substring(0, lenght);
        }
    }
}
