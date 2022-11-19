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
    public partial class AddPart : Form
    {
        bool isInHouse;
        private bool allowSave()
        {
            int number;
            return (!string.IsNullOrWhiteSpace(name.Text)) && !string.IsNullOrWhiteSpace(inventory.Text) && !string.IsNullOrWhiteSpace(price.Text) &&
                !string.IsNullOrWhiteSpace(max.Text) && !string.IsNullOrWhiteSpace(min.Text) && (!(string.IsNullOrWhiteSpace(labelText.Text) ||
                (isInHouse && !Int32.TryParse(labelText.Text, out number))));
        }
        private void checkOnRBSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(ID.Text) || (isInHouse && !Int32.TryParse(labelText.Text, out number)))
            {
                labelText.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                labelText.BackColor = System.Drawing.Color.White;
            }
            saveButton.Enabled = allowSave();
        }
        public AddPart()
        {
            InitializeComponent();
            /*ID.Text = Inventory.CurrentPart.PartID.ToString();
            name.Text = Inventory.CurrentPart.Name.ToString();
            inventory.Text = Inventory.CurrentPart.InStock.ToString();
            price.Text = Inventory.CurrentPart.Price.Substring(1).ToString();
            max.Text = Inventory.CurrentPart.Max.ToString();
            min.Text = Inventory.CurrentPart.Min.ToString();
            if (Inventory.CurrentPart is Inhouse)
            {
                Inhouse e = (Inhouse)Inventory.CurrentPart;
                textBox.Text = e.MachineID.ToString();
                isInHouse = true;
                inHouseRadioButton.Checked = true;
            }
            else
            {
                Outsourced e = (Outsourced)Inventory.CurrentPart;
                textBox.Text = e.CompanyName.ToString();
                isInHouse = false;
                outsourcedRadioButton.Checked = true;
            }*/
        }
           
        //Update label
        private void inHouseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelText.Text = "Machine ID";
            checkOnRBSwitch();         
        }

        private void outsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            labelText.Text = "Company Name";
            checkOnRBSwitch();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int IDP = Inventory.createPartID();
            string nameP = name.Text;
            int minP = int.Parse(min.Text);
            int maxP = int.Parse(max.Text);
            int inventoryP = int.Parse(inventory.Text);
            decimal priceP = decimal.Parse(price.Text);
            
            try
            {
                minP = int.Parse(min.Text);
                maxP = int.Parse(max.Text);
                inventoryP = int.Parse(inventory.Text);
                priceP = decimal.Parse(price.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max, and Min must be number.");
                return;
            }
            if(minP > maxP)
            {
                MessageBox.Show("Error: Min should be smaller than Max.");
                return;
            }
            if(minP > inventoryP || maxP < inventoryP)
            {
                MessageBox.Show("Error: Iventory cannot be smaller than  Min or greater than Max.");
            }
            if (inHouseRadioButton.Checked)
            {
                int machineIDP = int.Parse(textBox.Text);
                Inhouse inHousePart = new Inhouse(IDP, nameP, inventoryP, priceP, maxP, minP, machineIDP);
                Inventory.addPart(inHousePart);
            }
            else
            {
                string companyNameP = textBox.Text;
                Outsourced outsourcedPart = new Outsourced(IDP, nameP, inventoryP, priceP, maxP, minP, companyNameP);
                Inventory.addPart(outsourcedPart);
            }
            Close();
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
            this.Close();
        }

        
    }
}
