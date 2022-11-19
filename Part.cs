using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trang_Granville
{
    public abstract class Part
    {
        private int partID;
        private string name;
        private decimal price;
        private int inStock;
        private int max;
        private int min;

        public int PartID { get; set; }
        public string Name { get; set; }
        /*public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }*/
        public string Price
        {
            get { return price.ToString("C"); }
            set
            {
                if (value.StartsWith("$"))
                {
                    price = decimal.Parse(value.Substring(1));

                }
                else
                {
                    price = decimal.Parse(value);
                }
            }
        }
        public int InStock { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

       
        
    }
    
}
