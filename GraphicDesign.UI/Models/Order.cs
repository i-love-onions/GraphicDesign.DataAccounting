using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public ulong orderId;
        public string customeFullName = "";
        public string phoneNumber = "";
        public decimal paymentAmount;
        public OrderState orderState;
        public string order = "";
        public DateTime creationTime;
        public DateTime deadline;
        public IImage workResult = new ImagePlaceholder();
        public List<Instrument> usedTools = new List<Instrument>();
        public string note = "";
    }
}
