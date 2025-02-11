using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Data;
using GraphicDesign.UI.Models;

namespace GraphicDesign.UI.Formatting
{
    public static class DataFormatting
    {
        public static string ToStatisticsString(this ModelsListsSet listsSet, string header = null)
        {
            if (header == null)
            {
                header = "Статичні дані про об'єкти ПО";
            }
            if (listsSet == null || listsSet.isEmpty())
            {
                return string.Format("{0}\n (дані відсутні)", header);
            }
            return string.Format("{0}\n" +
                " Представлено:\n" +
                "{1,7} логотипів\n" +
                "{2,7} ілюстрацій\n" +
                "{3,7} інструментів\n" +
                "{4,7} замовлень\n",
                header,
                listsSet.Logos.Count,
                listsSet.Illustrations.Count,
                listsSet.Instruments.Count,
                listsSet.Orders.Count
                );
        } 
        public static string ToDataString(this List<Logo> list, string header = null)
        {
            if (header == null)
            {
                header = "Логотипи";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            int i = 1;
            foreach (var item in list)
            {
                sb.Append(string.Format("Логотип №{0}\n", i));
                sb.AppendLine(string.Format("{0}", item.ToDataString()));
                i++;
            }
            return sb.ToString();
        }
        public static string ToDataString(this List<Illustration> list, string header = null)
        {
            if (header == null)
            {
                header = "Ілюстрації";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            int i = 1;
            foreach (var item in list)
            {
                sb.Append(string.Format("Іллюстрація №{0}\n", i));
                sb.AppendLine(string.Format("{0}", item.ToDataString()));
                i++;
            }
            return sb.ToString();
        }
        public static string ToDataString(this List<Instrument> list, string header = null)
        {
            if (header == null)
            {
                header = "Інструменти";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            int i = 1;
            foreach (var item in list)
            {
                sb.Append(string.Format("Інструмент №{0}\n", i));
                sb.AppendLine(string.Format("{0}", item.ToDataString()));
                i++;
            }
            return sb.ToString();
        }
        public static string ToDataString(this List<Order> list, string header = null)
        {
            if (header == null)
            {
                header = "Замовлення";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(" {0}\n", header);
            int i = 1;
            foreach (var item in list)
            {
                sb.Append(string.Format("Замовлення №{0}\n", i));
                sb.AppendLine(string.Format("{0}", item.ToDataString()));
                i++;
            }
            return sb.ToString();
        }
        public static string ToDataString(this ModelsListsSet listsSet)
        {
            return string.Concat("Інформація про логотипи, іллюстрації, інструменти та замовлення\n",
                listsSet.Logos.ToDataString(),
                listsSet.Illustrations.ToDataString(),
                listsSet.Instruments.ToDataString(),
                listsSet.Orders.ToDataString());
        }
    }
}
