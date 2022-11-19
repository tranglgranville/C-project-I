using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trang_Granville
{
    public partial class Main : Form
    {
        private static int idxPart;
        public Main()
        {
            InitializeComponent();
            idxPart = -1;

            Inventory.DataList();

            BindingSource partTable = new BindingSource();
            partTable.DataSource = Inventory.PartList;
            DataGridViewPart.DataSource = partTable;           

            BindingSource productTable = new BindingSource();
            productTable.DataSource = Inventory.ProductList;
            DataGridViewProduct.DataSource = productTable;
            
        }

        //check part ID, if found, select the row
        private void searchPart_Click(object sender, EventArgs e)
        {
            DataGridViewPart.ClearSelection();
            //DataGridViewPart.DefaultCellStyle.SelectionBackColor = Color.Yellow;           
            bool found = false;
            if(searchPartValue.Text != "")
            {
                for(int i = 0; i < Inventory.PartList.Count; i++)
                {
                    if (Inventory.PartList[i].PartID.ToString().Contains(searchPartValue.Text))
                    {
                        DataGridViewPart.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("ID is not found.");
                
            }         
       

            /*int searchPart = int.Parse(searchPartValue.Text);
            try
            {
                searchPart = int.Parse(searchPartValue.Text);
            }
            catch
            {
                MessageBox.Show("Entered value must be a numeric value.");
                return;
            }
            
            Part foundPart = Inventory.lookupPart(int.Parse(searchPartValue.Text));

            foreach (DataGridViewRow partRow in DataGridViewPart.Rows)
            {
                Part part = (Part)partRow.DataBoundItem;

                if (part.PartID == foundPart.PartID)
                {
                    partRow.Selected = true;
                    break;
                }
                else
                {
                    partRow.Selected = false;
                    MessageBox.Show("ID is not found.");
                }
            }*/
        }
        private void addPart_Click(object sender, EventArgs e)
        {
            var AddPart = new AddPart();
            AddPart.Show();
        } 
        private void modifyPart_Click(object sender, EventArgs e)
        {
            
            /*if (idxPart >= 0)
            {                
                ModifyPart f2 = new ModifyPart();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Please select something to modify.");
            }*/

            /*var ModifyPart = new ModifyPart();
            ModifyPart.Show();
            ModifyPart modifyP = new ModifyPart();
            
            modifyP.ID.Text = this.DataGridViewPart.CurrentRow.Cells[0].Value.ToString();
            modifyP.name.Text = this.DataGridViewPart.CurrentRow.Cells[1].Value.ToString();
            modifyP.inventory.Text = this.DataGridViewPart.CurrentRow.Cells[2].Value.ToString();*/

            if(DataGridViewPart.CurrentRow.DataBoundItem.GetType() == typeof(Trang_Granville.Inhouse))
            {
                Inhouse inHouse = (Inhouse)DataGridViewPart.CurrentRow.DataBoundItem;
                new ModifyPart(inHouse).ShowDialog();
            }
            else
            {
                Outsourced outSourced = (Outsourced)DataGridViewPart.CurrentRow.DataBoundItem;
                new ModifyPart(outSourced).ShowDialog();
            } 

        }
        
        //deleting part
        private void deletePart_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the part?", "Deleting", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow part in DataGridViewPart.SelectedRows)
                {
                    DataGridViewPart.Rows.RemoveAt(part.Index);
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }

        }

        //search product ID, if found, select the row
        private void searchProduct_Click(object sender, EventArgs e)
        {
            DataGridViewProduct.ClearSelection();           

            bool found = false;
            if (searchProductValue.Text != "")
            {
                for (int i = 0; i < Inventory.ProductList.Count; i++)
                {
                    if (Inventory.ProductList[i].ProductID.ToString().Contains(searchProductValue.Text))
                    {
                        DataGridViewProduct.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("ID is not found.");

            }
        }
        private void AddProduct_Click(object sender, EventArgs e)
        {            
            var AddProduct = new AddProduct();
            AddProduct.Show();
        }     
        private void modifyProduct_Click(object sender, EventArgs e)
        {
            Product pro = (Product)DataGridViewProduct.CurrentRow.DataBoundItem;
            new ModifyProduct(pro).ShowDialog();
        }        
            
        //deleting product
        private void deleteProduct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete the product?", "Deleting", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {                
                foreach (DataGridViewRow Product in DataGridViewProduct.SelectedRows)
                {
                    DataGridViewProduct.Rows.RemoveAt(Product.Index);
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewPart_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idxPart = e.RowIndex;
            Inventory.CurrentPartID = (int)DataGridViewPart.Rows[idxPart].Cells[0].Value;
            Inventory.CurrentPart = Inventory.lookupPart(Inventory.CurrentPartID);
            //DataGridViewPart.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
        }
    }
}
