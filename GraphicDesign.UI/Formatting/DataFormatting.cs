using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Data;

namespace GraphicDesign.UI.Formatting
{
    public static class DataFormatting
    {
        public static string ToStatisticsString(ModelsListsSet listsSet, string header = null)
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
    }
}
