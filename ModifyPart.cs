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
    public partial class ModifyPart : Form
    {
        bool isInHouse;
        private bool allowSave()
        {
            int number;
            return (!string.IsNullOrWhiteSpace(name.Text)) && !string.IsNullOrWhiteSpace(inventory.Text) && !string.IsNullOrWhiteSpace(price.Text) && 
                !string.IsNullOrWhiteSpace(max.Text) && !string.IsNullOrWhiteSpace(min.Text) && (!(string.IsNullOrWhiteSpace(labelText.Text)|| 
                (isInHouse && !Int32.TryParse(labelText.Text, out number))));
        }
        //Main mainForm = (Main)Application.OpenForms["Main"];
        private void checkOnRBSwitch()
        {
            int number; 
            if(string.IsNullOrWhiteSpace(ID.Text) || (isInHouse && !Int32.TryParse(labelText.Text, out number)))
            {
                labelText.BackColor = System.Drawing.Color.Salmon;
            }
            else
            {
                labelText.BackColor = System.Drawing.Color.White;
            }
            saveButton.Enabled = allowSave();
        }

        //Loading data
        /*public ModifyPart()
        {
            InitializeComponent();
            ID.Text = Inventory.CurrentPart.PartID.ToString();
            name.Text = Inventory.CurrentPart.Name.ToString();
            inventory.Text = Inventory.CurrentPart.InStock.ToString();
            price.Text = Inventory.CurrentPart.Price.Substring(1).ToString();
            max.Text = Inventory.CurrentPart.Max.ToString();
            min.Text = Inventory.CurrentPart.Min.ToString();
            if(Inventory.CurrentPart is Inhouse)
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
            }

        }*/
        public ModifyPart(Inhouse inHouse)
        {
            InitializeComponent();
            
            ID.Text = inHouse.PartID.ToString();
            name.Text = inHouse.Name;
            inventory.Text = inHouse.InStock.ToString();
            price.Text = inHouse.Price.Substring(1).ToString();
            max.Text = inHouse.Max.ToString();
            min.Text = inHouse.Min.ToString();
            textBox.Text = inHouse.MachineID.ToString();
            inHouseRadioButton.Checked = true;
        }

        public ModifyPart(Outsourced outSourced)
        {
            InitializeComponent();
            ID.Text = outSourced.PartID.ToString();
            name.Text = outSourced.Name;
            inventory.Text = outSourced.InStock.ToString();
            price.Text = outSourced.Price.Substring(1).ToString();
            max.Text = outSourced.Max.ToString();
            min.Text = outSourced.Min.ToString();
            textBox.Text = outSourced.CompanyName;
            outsourcedRadioButton.Checked = true;
        }
      
        public int thePartID;
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

        /*private void ModifyPart_Load(object sender, EventArgs e)
        {
            var chosenPart = Inventory.lookupPart(thePartID);
            ID.Text = chosenPart.PartID.ToString();
            name.Text = chosenPart.Name;
            inventory.Text = chosenPart.InStock.ToString();
            price.Text = chosenPart.Price.ToString();
            max.Text = chosenPart.Max.ToString();
            min.Text = chosenPart.Min.ToString();
            if(chosenPart is Inhouse)
            {
                textBox.Text = ((Inhouse)chosenPart).MachineID.ToString();
            }
            if(chosenPart is Outsourced)
            {
                textBox.Text = ((Outsourced)chosenPart).CompanyName.ToString();
            }
        }*/
        private void saveButton_Click(object sender, EventArgs e)
        {
            //var chosenPart = Inventory.lookupPart(thePartID);
            int id = Convert.ToInt32(ID.Text);

            string nameModify = name.Text;
            int inventoryPartModify = Convert.ToInt32(inventory.Text);
            decimal pricePartModify = Convert.ToDecimal(price.Text);
            int maxPartModify = Convert.ToInt32(max.Text);
            int minPartModify = Convert.ToInt32(min.Text);
            try
            {            
                inventoryPartModify = int.Parse(inventory.Text);
                pricePartModify = int.Parse(price.Text);
                maxPartModify = int.Parse(max.Text);
                minPartModify = int.Parse(min.Text);
            }
            catch
            {
                MessageBox.Show("Error: Inventory, Price, Max, and Min should be number.");
                return;
            }
            if(minPartModify > maxPartModify)
            {
                MessageBox.Show("Error: Min should be smaller than Max.");
                return;
            }
            if(minPartModify > inventoryPartModify || maxPartModify < inventoryPartModify)
            {
                MessageBox.Show("Error: Iventory cannot be smaller than  Min or greater than Max.");
            }
            if (inHouseRadioButton.Checked)
            {
                int machineIDP = int.Parse(textBox.Text);
                Inhouse inHousePart = new Inhouse(id, nameModify, inventoryPartModify, pricePartModify, maxPartModify, minPartModify, machineIDP);
                Inventory.updateInHousePart(id, inHousePart);
            }
            else
            {
                string companyNameP = textBox.Text;
                Outsourced outsourcedPart = new Outsourced(id, nameModify, inventoryPartModify, pricePartModify, maxPartModify, minPartModify, companyNameP);
                Inventory.updateOutsourcedPart(id, outsourcedPart);
            }

            this.Hide();
            Main mainScreen = new Main();
            mainScreen.Show();
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
                Main main = new Main();
                main.Show();
            }
            else return;
        }

      
    }
}
