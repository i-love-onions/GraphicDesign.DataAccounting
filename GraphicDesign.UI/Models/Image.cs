using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GraphicDesign.UI.Models
{
    public abstract class Image
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
        public DateTime CreationDate { get; set; }
        public string Desctiption { get; set; }
        public string Note { get; set; }
    }
    public interface IImage
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
        public DateTime CreationDate { get; set; }
        public string Desctiption { get; set; }
        public string Note { get; set; }
        Order Order { get; set; }
    }
    public class Logo : Image, IImage 
    {       
    }
    public class Illustration : Image, IImage
    {
    }
    public class ImagePlaceholder : Image, IImage 
    {
    } 
}
