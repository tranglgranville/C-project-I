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
    public partial class AddProduct : Form
    {
        private bool allowSave()
        {
            return (!string.IsNullOrWhiteSpace(nameTextBox.Text) && !string.IsNullOrWhiteSpace(inventoryTextBox.Text) && !string.IsNullOrWhiteSpace(priceTextBox.Text) &&
                !string.IsNullOrWhiteSpace(maxTextBox.Text) && !string.IsNullOrWhiteSpace(minTextBox.Text));
        }

        BindingList<Part> addPart = new BindingList<Part>();
        public static BindingList<Part> AddPart { get { return AddPart; } set { AddPart = value; } }
        public AddProduct()
        {
            InitializeComponent();
            BindingSource table1 = new BindingSource();
            table1.DataSource = Inventory.PartList;
            dataGridViewAllPart.DataSource = table1;

            
            BindingSource table2 = new BindingSource();
            table2.DataSource = addPart;
            dataGridViewAssociatedPart.DataSource = table2;
        }

        
        private void cancelButton_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you would like to close this form?";
            const string caption = "Closing Form";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // if yes
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else return;
            
        }

        private void search_Click(object sender, EventArgs e)
        {
            dataGridViewAllPart.ClearSelection();

            bool found = false;
            if (searchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.PartList.Count; i++)
                {
                    if (Inventory.PartList[i].PartID.ToString().Contains(searchTextBox.Text))
                    {
                        dataGridViewAllPart.Rows[i].Selected = true;
                        found = true;
                    }
                }
            }
            if (!found)
            {
                MessageBox.Show("ID is not found.");

            }
            /*int searchID = int.Parse(searchTextBox.Text);
            Part searchingID = Inventory.lookupPart(searchID);
            foreach (DataGridViewRow partRow in dataGridViewAllPart.Rows)
            {
                Part part = (Part)partRow.DataBoundItem;
                if (part.PartID == searchingID.PartID)
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete?", "Deleting", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow chosenRow in dataGridViewAssociatedPart.SelectedRows)
                {
                    dataGridViewAssociatedPart.Rows.RemoveAt(chosenRow.Index);
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Part partAssociate = (Part)dataGridViewAllPart.CurrentRow.DataBoundItem;
            addPart.Add(partAssociate);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int IDProduct = Inventory.createProductID();
            string name = nameTextBox.Text;
            int inventory = int.Parse(inventoryTextBox.Text);
            decimal price = decimal.Parse(priceTextBox.Text);
            int max = int.Parse(maxTextBox.Text);
            int min = int.Parse(minTextBox.Text);

            // non-numeric values in textboxes
            try
            {
                inventory = int.Parse(inventoryTextBox.Text);
                price = decimal.Parse(priceTextBox.Text);
                max = int.Parse(maxTextBox.Text);
                min = int.Parse(minTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Inventory, Price, Max, and Min textbox have to be numeric values.");
                return;
            }

            //Inv between min and max, min < max
            if(min > max)
            {
                MessageBox.Show("The Min value must be smaller than the Max value. ");
                return;
            }
            if(inventory < min || inventory > max)
            {
                MessageBox.Show("The Inventory must be between min and max values.");
                return;
            }

            // Create new product
            Product newProduct = new Product(IDProduct, name, inventory, price, max, min);
            Inventory.addProduct(newProduct);

            foreach (Part part in addPart){
                newProduct.addAssociatedPart(part);
            }
            this.Close();
        }
    }
}
