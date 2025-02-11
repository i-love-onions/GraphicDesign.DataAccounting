using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicDesign.UI.Models
{
    public class Instrument
    {
        public string ToolName = "";
        public decimal Price;
        public DateTime PaymentDate;
        public string Note = "";

        public Order Order
        {
            get => default;
            set
            {
            }
        }
    }
}
