using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Trang_Granville
{
    class Inventory
    {
        public static BindingList<Product> ProductList = new BindingList<Product>();
        public static BindingList<Product> Products { get { return ProductList; } set { ProductList = value; } }


        public static BindingList<Part> PartList = new BindingList<Part>();
        public static BindingList<Part> Parts { get { return PartList; } set { PartList = value; } }

        public static Product CurrentProduct { get; set; }
        public static int CurrentProductID { get; set; }
        public static int CurrentProductIndex { get; set; }

        public static Part CurrentPart { get; set; }
        public static int CurrentPartID { get; set; }
        public static int CurrentPartIndex { get; set; }
        

        public static void DataList()
        {
            Product prod1 = new Product(0, "Red Bicycle", 15, 11.44m, 1, 24);
            Product prod2 = new Product(1, "Yellow Bicycle", 19, 9.66m, 1, 20);
            Product prod3 = new Product(2, "Blue Bicycle", 5, 12.77m, 1, 25);

            ProductList.Add(prod1);
            ProductList.Add(prod2);
            ProductList.Add(prod3);

            Part part1 = new Inhouse(0, "Wheel", 15, 12.11m, 5, 25, 001);
            Part part2 = new Inhouse(1, "Pedal", 11, 8.22m, 5, 25, 002);
            Part part3 = new Outsourced(2, "Chain", 12, 8.33m, 5, 25, "ABC");
            Part part4 = new Outsourced(3, "Seat", 8, 4.55m, 2, 15, "LLC");

            PartList.Add(part1);
            PartList.Add(part2);
            PartList.Add(part3);
            PartList.Add(part4);

            prod1.AssociatedParts.Add(part1);
            prod1.AssociatedParts.Add(part2);
            prod2.AssociatedParts.Add(part3);
            prod2.AssociatedParts.Add(part4);
            prod3.AssociatedParts.Add(part1);
            prod3.AssociatedParts.Add(part2);
        }        
        
        //Products
        public static void addProduct(Product product)
        {
            ProductList.Add(product);
        }
        
        public static bool removeProduct(int productID)
        {
            bool remove = false;
            foreach (Product pro in ProductList)
            {
                if(pro.ProductID == productID)
                {
                    ProductList.Remove(pro);
                    return remove = true;
                }
                else
                {
                    return remove = false;
                }
            }
            return remove;
        }
        public static Product lookupProduct(int productID)
        {
            for(int i = 0; i < Products.Count; i++)
            {
                if (ProductList[i].ProductID.Equals(i))
                {
                    CurrentProductIndex = i;
                    return Products[i];
                }
            }
            return null;
        }
        public static void updateProduct(int productID, Product newProduct)
        {
            foreach (Product Prod in Products)
            {
                if (Prod.ProductID == productID)
                {
                    Prod.Name = newProduct.Name;
                    Prod.InStock = newProduct.InStock;
                    Prod.Price = newProduct.Price;
                    Prod.Min = newProduct.Min;
                    Prod.Max = newProduct.Max;
                    Prod.AssociatedParts = newProduct.AssociatedParts;
                    return;
                }
            }           
        }

        //Parts
        public static void addPart(Part part)
        {
            PartList.Add(part);
        }
        public static bool deletePart(int partID)
        {
            bool delete = false;
            for(int i =0; i < PartList.Count; i++)
            {
                if (PartList[i].PartID.Equals(partID))
                {
                    PartList.RemoveAt(CurrentPartIndex);
                    return delete = true;
                }
                else
                {                    
                    return false;
                }
            }
            return delete;

            /*foreach (Part par in PartList)
            {
                if(par.PartID == partID)
                {
                    PartList.Remove(par);
                    return delete = true;
                }
                return delete = false;
            }
            return delete;*/
        }
        public static Part lookupPart(int partID)
        {
            for (int i = 0; i< PartList.Count; i++)
            {
                if (PartList[i].PartID.Equals(partID))
                {
                    return PartList[i];
                }
            }
            CurrentProductIndex = -1;
            return null;
            
            /*foreach(Part par in PartList)
            {
                if(par.PartID == partID)
                {
                    return par;
                }
            }
            return null;*/
        }
        
        public static void updateInHousePart(int partID, Inhouse inPart)
        {
            
            for (int i = 0; i < PartList.Count; i++)
            {
                if (PartList[i].GetType() == typeof(Trang_Granville.Inhouse))
                {
                    Inhouse newPart = (Inhouse)PartList[i];
                    if (newPart.PartID == partID)
                    {
                        newPart.Name = inPart.Name;
                        newPart.InStock = inPart.InStock;
                        newPart.Price = inPart.Price;
                        newPart.Min = inPart.Min;
                        newPart.Max = inPart.Max;
                        newPart.MachineID = inPart.MachineID;
                    }
                }
            }
        }
        public static void updateOutsourcedPart(int partID, Outsourced outPart)
        {
            for (int i = 0; i < PartList.Count; i++)
            {
                if (PartList[i].GetType() == typeof(Trang_Granville.Outsourced))
                {
                    Outsourced newPart = (Outsourced)PartList[i];
                    if (newPart.PartID == partID)
                    {
                        newPart.Name = outPart.Name;
                        newPart.InStock = outPart.InStock;
                        newPart.Price = outPart.Price;
                        newPart.Min = outPart.Min;
                        newPart.Max = outPart.Max;
                        newPart.CompanyName = outPart.CompanyName;
                    }
                }
            }
        }

        public static int createPartID()
        {
            int ID = 1;
            foreach(Part par in PartList)
            {
                if(par.PartID > ID)
                {
                    ID = par.PartID;
                }
            }
            return ID;
        }
        public static int createProductID()
        {
            int ID = 1;
            foreach(Product pro in ProductList)
            {
                if(pro.ProductID > ID)
                {
                    ID = pro.ProductID;
                }
            }
            return ID;
        }
    }
}
