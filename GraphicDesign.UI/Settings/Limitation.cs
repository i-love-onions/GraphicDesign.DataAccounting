using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicDesign.UI.Settings
{
    public static class Limitation
    {
        // Order class
        static public int minOrderCustomerNameLenght = 5;
        static public int maxOrderCustomerNameLenght = 50;
        static public string phoneRegex = @"^\d{7,15}$";
        static public decimal minOrderPayment = 0m;
        static public int minOrderDescriptionLenght = 0;
        static public int maxOrderDescriptionLenght = short.MaxValue;
        static public DateTime minOrderDate => DateTime.Now.AddDays(-1);
        static public DateTime maxOrderDate => DateTime.Now;
        static public DateTime maxOrderDeadlineDate => DateTime.Now.AddYears(1);
        static public int minOrderNoteLenght = 0;
        static public int maxOrderNoteLenght = short.MaxValue;

        // Image and related classes
        static public int minImageNameLenght = 3;
        static public int maxImageNameLenght = 50;
        static public int minImagePathLenght = 1;
        static public int maxImagePathLenght = int.MaxValue;
        static public DateTime minImageCreationDate => DateTime.Now.AddYears(-1);
        static public DateTime maxImageCreationDate => DateTime.Now;
        static public int minImageDescriptionLenght = 0;
        static public int maxImageDescriptionLenght = short.MaxValue;
        static public int minImageNoteLenght = 0;
        static public int maxImageNoteLenght = 1023;

        // Instrument class

        static public int minToolNameLenght = 3;
        static public int maxToolNameLenght = 70;
        static public decimal minToolPrice = 0m;
        static public DateTime minToolPaymentDate => DateTime.Now.AddYears(-1);
        static public DateTime maxToolPaymentDate => DateTime.Now;
        static public int minToolNoteLenght = 0;
        static public int maxToolNoteLenght = 1023;
    }
}
