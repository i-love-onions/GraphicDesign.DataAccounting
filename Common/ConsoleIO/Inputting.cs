using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GraphicDesign.UI.Models;
using PhoneNumbers;

namespace Common.ConsoleIO
{
    public static class Inputting
    {
        static string s_promtFormat = "{0,40}:";
        static string s_errorMessageFormat = "\t\t{0}";
        public const decimal magicDecimal = -993.1773965m;

        public static void OutPrompt(string prompt)
        {
            Console.Write(s_promtFormat, prompt);
        }
        public static void OutErrorMessage(string message)
        {
            Console.WriteLine(s_errorMessageFormat, message);
        }
        public static void OutInputtingPrompt()
        {
            Console.WriteLine("\tУвага!!! Заміни значень при введенні:\n" +
                "\t порожній рядок (<Enter>) - NULL\n" +
                "\t \"\" - порожній рядок");
        }
        public static int InputInt32(string prompt)
        {
            while (true)
            {
                OutPrompt(prompt);
                string str = Console.ReadLine();
                try
                {
                    return Convert.ToInt32(str);
                }
                catch (Exception)
                {
                    OutErrorMessage("Помилка введеня цілого числа");
                }
            }
        }
        public static int InputInt32(string prompt, int min, int max = int.MaxValue)
        {
            while (true)
            {
                int value = InputInt32(prompt);
                if (min <= value && value <= max)
                {
                    return value;
                }
                OutErrorMessage(string.Format("\t  Введіть значення в межах від {0} до {1}", min, max));
            }
        }
        public static string InputString(string prompt)
        {
            Console.Write(s_promtFormat, prompt);
            string str = Console.ReadLine();
            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            if (str == "\"\"")
            {
                return "";
            }
            str = str.Trim();
            return str;
        }
        public static string InputString(string prompt, int minLenght, int maxLenght)
        {
            while (true)
            {
                string str = InputString(prompt);
                if (string.IsNullOrEmpty(str) && minLenght == 0)
                {
                    return null;
                }
                else if (!string.IsNullOrEmpty(str) && minLenght <= str.Length && str.Length <= maxLenght)
                {
                    return str;
                }
                OutErrorMessage(string.Format(
                    "\tпотрібно ввести від {0} до {1} символів", minLenght, maxLenght));
}
        }
        public static string InputString(string prompt, string pattern,
            string errorMessage, RegexOptions options = RegexOptions.None)
        {
            while(true)
            {
                string str = InputString(prompt);
                if(!string.IsNullOrEmpty(str) && Regex.IsMatch(str, pattern, options))
                {
                    return str;
                }
                OutErrorMessage(errorMessage);
            }
        }
        public static string InputText(string prompt, string errorMessage)
        {
            while (true)
            {
                string str = InputString(prompt);
                if (!string.IsNullOrEmpty(str))
                {
                    return str;
                }
                OutErrorMessage(errorMessage);
            }
        }
        public static ulong InputUInt64(string prompt)
        {
            while (true)
            {
                OutPrompt(prompt);
                string str = Console.ReadLine();
                try
                {
                    return Convert.ToUInt64(str);
                }
                catch (Exception)
                {
                    OutErrorMessage("Помилка введеня цілого додатнього числа");
                }
            }
        }
        public static ulong InputUInt64(string prompt, List<ulong> numbers)
        {
            while (true)
            {
                ulong value = InputUInt64(prompt);
                bool flag = false;
                foreach (ulong number in numbers)
                {
                    if (number == value)
                    {
                        OutErrorMessage(string.Format("\t Данне число вже є в списку. Максимальне на даний час {0}", numbers.Max()));
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    return value;
                }
            }
        }
        public static decimal InputDecimal(string prompt)
        {
            while (true)
            {
                OutPrompt(prompt);
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    return magicDecimal;
                }
                try
                {
                    return Convert.ToDecimal(str);
                }
                catch (Exception)
                {

                    OutErrorMessage("\t\tпомилка введення дійсного числа");
                }
            }
        }
        public static decimal InputDecimal(string prompt, decimal min, decimal max = ulong.MaxValue)
        {
            while (true)
            {
                decimal value = InputDecimal(prompt);
                if (min <= value && value <= max && value != magicDecimal)
                {
                    return value;
                }
                OutErrorMessage(string.Format("\t  Введіть значення в межах від {0} до {1}", min, max));
            }
        }
        public static DateTime InputDateTime(string prompt)
        {
            while (true)
            {
                OutPrompt(prompt);
                string str = Console.ReadLine();
                if (string.IsNullOrEmpty(str))
                {
                    return DateTime.MinValue;
                }
                if (str == "now")
                {
                    return DateTime.Now;
                }
                try
                {
                    return Convert.ToDateTime(str);
                }
                catch (Exception)
                {
                    OutErrorMessage("\tпомилка введення дати");
                }
            }
        }
        public static DateTime InputDateTime(string prompt, DateTime min, DateTime max) 
        {
            DateTime startTime = DateTime.Now;
            TimeSpan nowRange = new TimeSpan(0, 0, 0, 5);
            int state = -1;
            if (startTime - min <= nowRange) state = 0;
            else if (startTime - max <= nowRange) state = 1;
            while (true)
            {
                DateTime value = InputDateTime(prompt);
                switch (state)
                {
                    case 0:
                        if (DateTime.Now <= value && value <= max)
                        {
                            return value;
                        }
                        OutErrorMessage(string.Format("\t  Введіть значення в межах від {0} до {1}", DateTime.Now, max));
                        break;
                    case 1:
                        if (min <= value && value <= DateTime.Now)
                        {
                            return value;
                        }
                        OutErrorMessage(string.Format("\t  Введіть значення в межах від {0} до {1}", min, DateTime.Now));
                        break;
                    default:
                        if (min <= value && value <= max)
                        {
                            return value;
                        }
                        OutErrorMessage(string.Format("\t  Введіть значення в межах від {0} до {1}", min, max));
                        break;
                }
            }
        }
        public static OrderState InputOrderState(string prompt)
        {
            while (true)
            {
                int input = InputInt32(prompt);
                switch (input)
                {
                    case 0:
                        return OrderState.notDefined;
                    case 1:
                        return OrderState.pending;
                    case 2:
                        return OrderState.done;
                    case 3:
                        return OrderState.sent;
                    case 4:
                        return OrderState.paid;
                    case 5:
                        return OrderState.fail;
                }
                OutErrorMessage("\t  Введіть значення в межах від 0 до 5");
            } 
        }
        public static PhoneNumber InputPhoneNumber(string prompt)
        {
            while (true)
            {
                var phoneNumberUtil = PhoneNumberUtil.GetInstance();
                OutPrompt(prompt);
                string str = Console.ReadLine();
                try
                {
                    return phoneNumberUtil.Parse(str, null);
                }
                catch (Exception)
                { 
                    OutErrorMessage("\tпомилка введення номеру");
                }
            }
        } 
    }
}
