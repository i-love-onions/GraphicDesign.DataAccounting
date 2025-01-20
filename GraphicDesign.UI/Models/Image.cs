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
        public string Name = "";
        public string FilePath = "";
        public DateTime CreationDate;
        public string Desctiption = "";
        public string Note = "";
    }
    public interface IImage
    {
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
