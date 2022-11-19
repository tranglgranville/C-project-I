using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trang_Granville
{
    public class Inhouse : Part
    {
        private int machineID;
        public int MachineID { get; set; }
        public Inhouse() { }
        public Inhouse(int partID, string name, int inStock, decimal price,  int min, int max, int machineID)
        {
            PartID = partID;
            Name = name;
            Price = price.ToString();
            InStock = inStock;
            Min = min;
            Max = max;
            MachineID = machineID;
        }
    }
}
