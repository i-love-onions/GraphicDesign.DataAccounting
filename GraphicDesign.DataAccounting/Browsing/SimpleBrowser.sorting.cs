using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GraphicDesign.UI.Data.Testing;
using GraphicDesign.UI.Models;

namespace GraphicDesign.DataAccounting.Browsing
{
    partial class SimpleBrowser
    {
        static int CompareByImageName(IImage obj1, IImage obj2)
        {
            return obj1.Name.CompareTo(obj2.Name);
        }
        static int CompareByInstrumentName(Instrument obj1, Instrument obj2)
        {
            if(obj1 == null || obj1.Name == null)
            {
                return -1;
            }
            if(obj2 == null || obj2.Name == null)
            {
                return 1;
            }
            return obj1.Name.CompareTo(obj2.Name);
        }
        static int CompareByInstrumentPrice(Instrument obj1, Instrument obj2)
        {
            if (obj1 == null)
            {
                return -1;
            }
            if (obj2 == null)
            {
                return 1;
            }
            return obj1.Price.CompareTo(obj2.Price);
        }
        static int CompareByOrderCreationDate(Order obj1, Order obj2)
        {
            if (obj1 == null)
            {
                return -1;
            }
            if (obj2 == null)
            {
                return 1;
            }
            return obj1.CreationTime.CompareTo(obj2.CreationTime);
        }
        void SortByNameLogo()
        {
            //_listsSet.Logos.Sort(CompareByImageName);
            _listsSet.Logos.Sort((m1, m2) => m1.Name.CompareTo(m2.Name));
        }
        void SortByNameInstrument()
        {
            _listsSet.Instruments.Sort(CompareByInstrumentName);
        }
        void SortByInstrumentPrice()
        {
            _listsSet.Instruments.Sort(CompareByInstrumentPrice);
        }
        void SortByOrderCreationDate()
        {
            _listsSet.Orders.Sort(CompareByOrderCreationDate);
        }
        void SortByIllustrationName()
        {
            _listsSet.Illustrations.Sort(CompareByImageName);
        }

    }
}
