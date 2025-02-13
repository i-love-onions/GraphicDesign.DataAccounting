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
        public static string ToTable(List<Order> models, string header = null)
        {
            if(header == null)
            {
                header = "Замовлення";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            string format = "{0,5} {1,-15} {2,-20} {3,6} {4,6} {5,10} {6,10} {7,10} {8,12} {9,10} {10,10}\n";
            sb.AppendFormat(format, "Айді", "Повне ім'я", "Телефон", "Оплата", "Стан", "Опис", "Cтворення", "Дедлайн", "Kартинкa", "Інстр", "Нотатка");
            sb.AppendFormat(" {0}\n", new string('-', string.Format(format, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0).Length));
            foreach(Order model in models)
            {
                sb.AppendFormat(format,
                    model.OrderId.ToString().LimitString(5),
                    model.CustomerFullName.LimitString(15),
                    Order.PhoneToString(model.PhoneNumber).LimitString(20),
                    model.PaymentAmount.ToString().LimitString(6),
                    model.OrderState.ToString().LimitString(6),
                    model.Description.LimitString(10),
                    model.CreationTime.ToString().LimitString(10),
                    model.Deadline.ToString().LimitString(10),
                    model.WorkResult.FilePath.LimitString(12),
                    model.UsedTools.ZeroCountListSolver().LimitString(10),
                    model.Note.LimitString(10)
                    );
                if(model.UsedTools.Count > 1)
                {
                    for(int i = 1; i < model.UsedTools.Count; i++)
                    {
                        sb.AppendFormat(format,
                            "", "", "", "", "", "", "", "", "",
                            model.UsedTools[i].Name.LimitString(12),
                            "");
                    }
                }
            }
            return sb.ToString();
        }
        private static string ZeroCountListSolver(this List<Instrument> list)
        {
            if (list.Count == 0)
            {
                return "";
            }
            return list[0].Name;
        }

        private static string LimitString(this string str, int lenght)
        {
            if(string.IsNullOrEmpty(str))
            {
                return null;
            }
            if (str.Length <= lenght) return str;
            return str.Substring(0, lenght);
        }
    }
}
