using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhoneNumbers;

namespace GraphicDesign.UI.Models
{
    public enum OrderState
    {
        notDefined = 0,
        pending = 1,
        done = 2,
        sent = 3,
        paid = 4,
        fail = 5
    }
    public class Order
    {
        public ulong OrderId;
        public string CustomerFullName = "";
        public PhoneNumber PhoneNumber;
        public decimal PaymentAmount;
        public OrderState OrderState;
        public string Description = "";
        public DateTime CreationTime;
        public DateTime Deadline;
        public IImage WorkResult = new ImagePlaceholder();
        public List<Instrument> UsedTools = new List<Instrument>();
        public string Note = "";

        public static PhoneNumber StringToPhone(string value)
        {
            PhoneNumberUtil phoneNumberUtil = PhoneNumberUtil.GetInstance();
            return phoneNumberUtil.Parse(value, null);
        }
        public static string PhoneToString(PhoneNumber phone)
        {
            return PhoneNumberUtil.GetInstance().Format(phone, PhoneNumberFormat.INTERNATIONAL).ToString();
        }
    }
}
