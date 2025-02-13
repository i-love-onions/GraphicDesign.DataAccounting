using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GraphicDesign.UI.Models;

namespace GraphicDesign.UI.Data.Searching
{
    public static class ModelsSearching
    {
        public static Instrument ByName(this List<Instrument> list, string name)
        {
            foreach (Instrument obj in list)
            {
                if(obj.Name == name) return obj;
            }
            return null;
        }
        public static Logo ByName(this List<Logo> list, string name)
        {
            foreach (Logo obj in list)
            {
                if(obj.Name == name) return obj;
            }
            return null;
        }
        public static Illustration ByName(this List<Illustration> list, string name)
        {
            foreach (Illustration obj in list)
            {
                if(obj.Name == name) return obj;
            }
            return null;
        }
        public static Order ByName(this List<Order> list, ulong id)
        {
            foreach (Order obj in list)
            {
                if(obj.OrderId == id) return obj;
            }
            return null;
        }
    }
}
