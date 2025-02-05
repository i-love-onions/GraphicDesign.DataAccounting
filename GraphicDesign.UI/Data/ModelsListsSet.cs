using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Models;

namespace GraphicDesign.UI.Data
{
    public class ModelsListsSet
    {
        public readonly List<Logo> Logos = new List<Logo>();
        public readonly List<Illustration> Illustrations = new List<Illustration>();
        public readonly List<Instrument> Instruments = new List<Instrument>();
        public readonly List<Order> Orders = new List<Order>();

        public bool isEmpty()
        {
            return Logos.Count == 0 && Illustrations.Count == 0 &&
                Orders.Count == 0 && Instruments.Count == 0;
        }
        public void Clear()
        {
            this.Logos.Clear();
            this.Illustrations.Clear();
            this.Instruments.Clear();
            this.Orders.Clear();
        }
    }
}
