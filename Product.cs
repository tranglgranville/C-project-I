using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Trang_Granville
{
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();
        private int productID;
        private string name;
        private decimal price;
        private int inStock;
        private int min;
        private int max;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
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
        public int Max { get; set; }
        public int Min { get; set; }

        public void addAssociatePart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public Product(int proID, string name, int inv, decimal price, int max, int min)
        {
            ProductID = proID;
            Name = name;
            InStock = inv;
            Price = price.ToString();
            Max = max;
            Min = min;

        }
        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }
        public bool removeAssociatePart(int partID)
        {
            bool remove = false;
            foreach (Part par in AssociatedParts)
            {
                if (par.PartID == partID)
                {
                    AssociatedParts.Remove(par);
                    return remove = true;
                }
                else
                {
                    remove = false;
                }
            }
            return remove;
        }
        public Part lookupAssociatePart(int partID)
        {
            foreach (Part par in AssociatedParts)
            {
                if(par.PartID == partID)
                {
                    return par;
                }
            }
            return null;
        }
    }
}
