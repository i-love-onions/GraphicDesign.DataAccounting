using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Common.Formatting;
using GraphicDesign.UI.Models;

namespace GraphicDesign.UI.Formatting
{
    public static class ModelsFormatting
    {
        public static int ValueIndentIndent = 12;
        public static string ValueIndent = "   ";
        public static string ToDataString(this IImage image)
        {
            return string.Format(
                "Назва: {0}\n" +
                "Шлях до файлу: {1}\n" +
                "Дата створення: {2}\n" +
                "Опис: {3}\n" +
                "Нотатка: {4}\n",
                image.Name,
                image.FilePath,
                image.CreationDate.ToString(),
                image.Desctiption,
                image.Note).ToTextBlocks(ValueIndent, true);
        }
        public static string ToDataString(this Instrument tool)
        {
            return string.Format(
                "Назва: {0}\n" +
                "Ціна: {1}\n" +
                "Дата оплати: {2}\n" +
                "Нотатка: {3}\n",
                tool.Name,
                tool.Price.ToString(),
                tool.PaymentDate.ToString(),
                tool.Note).ToTextBlocks(ValueIndent, true);
        }
        public static string ToDataString(this Order order)
        {
            return string.Format(
                "Айді: {0}\n" +
                "Повне ім'я: {1}\n" +
                "Номер телефону: {2}\n" +
                "Оплата: {3}\n" +
                "Стан: {4}\n" +
                "Опис завдання: {5}\n" +
                "Дата створення: {6}\n" +
                "Дедлайн: {7}\n" +
                "Результат роботи: {8}\n" +
                "Використані інструменти: {9}\n" +
                "Нотатка: {10}\n",
                order.OrderId.ToString(),
                order.CustomerFullName,
                Order.PhoneToString(order.PhoneNumber),
                order.PaymentAmount.ToString(),
                order.OrderState.ToString(),
                order.Description,
                order.CreationTime.ToString(),
                order.Deadline.ToString(),
                order.WorkResult.ToDataString(),
                order.UsedTools.ToDataString(),
                order.Note).ToTextBlocks(ValueIndent, true);
        }
    }
}
