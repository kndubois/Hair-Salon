///     Form1 class
///     
/// I certify that this material is my original 
/// work. No other person's has been used without 
/// due acknowledgement. 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Class for Form1
/// </summary>
namespace HairSalon {

    /// <summary>
    /// Form1 Class
    /// Gathers all information with 4 buttons 
    /// </summary>
    public partial class Form1 : Form {

        /// <summary>
        /// Contains method of Form1.Designer class 
        /// </summary>
        public Form1() {
            InitializeComponent();
            // Select a Hairdresser
            this.dresserComboBox.Items.Add("Jane Samley");
            this.dresserComboBox.Items.Add("Pat Johnson");
            this.dresserComboBox.Items.Add("Ron Chambers");
            this.dresserComboBox.Items.Add("Sue Pallon");
            this.dresserComboBox.Items.Add("Laura Renkins");
            this.dresserComboBox.SelectedIndex = 0;

            // Select a Service
            this.serviceListBox.Items.Add("Cut");
            this.serviceListBox.Items.Add("Wash, blow dry and style");
            this.serviceListBox.Items.Add("Color");
            this.serviceListBox.Items.Add("Highlights");
            this.serviceListBox.Items.Add("Extensions");
            this.serviceListBox.Items.Add("Up-do");
        }

        /// <summary>
        /// Hairdresser section hiding selection after being clicked
        /// </summary>
        /// <param name="sender">refers to object to raise</param>
        /// <param name="e">contains event data</param>
        private void DresserComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            dresserComboBox.Enabled = true; 
        }

        /// <summary>
        /// Parameters used to contain event data
        /// Invoked when Add button is clicked
        /// </summary>
        /// <param name="sender">refers to object to raise</param>
        /// <param name="e">contains event data</param>
        private void AddButton_Click(object sender, EventArgs e) {

            double hairTotalPrice = 0.0;            // double price for hairdresser
            double servTotalPrice = 0.0;         // double price for service

            // gets price by hairdresser 
            if (dresserComboBox.SelectedItem.ToString() == "Jane Samley")
                hairTotalPrice = 30.00;
            else if (dresserComboBox.SelectedItem.ToString() == "Pat Johnson")
                hairTotalPrice = 45.00;
            else if (dresserComboBox.SelectedItem.ToString() == "Ron Chambers")
                hairTotalPrice = 40.00;
            else if (dresserComboBox.SelectedItem.ToString() == "Sue Pallon")
                hairTotalPrice = 50.00;
            else if (dresserComboBox.SelectedItem.ToString() == "Laura Renkins")
                hairTotalPrice = 55.00;

            // gets price by service 
            if (serviceListBox.SelectedItem.ToString() == "Cut")
                servTotalPrice += 30.00;
            else if (serviceListBox.SelectedItem.ToString() == "Wash, blow dry and style")
                servTotalPrice += 20.00;
            else if (serviceListBox.SelectedItem.ToString() == "Color")
                servTotalPrice += 40.00;
            else if (serviceListBox.SelectedItem.ToString() == "Highlights")
                servTotalPrice += 50.00;
            else if (serviceListBox.SelectedItem.ToString() == "Extensions")
                servTotalPrice += 200.00;
            else if (serviceListBox.SelectedItem.ToString() == "Up-do")
                servTotalPrice += 60.00;

            // Adds service total price
            if (chargedListBox.Items.Count > 0) {
                chargedListBox.Items.Add(serviceListBox.SelectedItem);
                priceListBox.Items.Add(servTotalPrice);
            }
            
            // Adds both prices for total price
            else {
                chargedListBox.Items.Add(dresserComboBox.SelectedItem);
                chargedListBox.Items.Add(serviceListBox.SelectedItem);
                priceListBox.Items.Add(hairTotalPrice);
                priceListBox.Items.Add(servTotalPrice);
            }
        }

        /// <summary>
        /// Parameters used to contain event data
        /// Invoked when Calculate button is clicked
        /// </summary>
        /// <param name="sender">refers to object to raise</param>
        /// <param name="e">contains event data</param>
        private void CalculateButton_Click(object sender, EventArgs e) {
            calculateButton.Enabled = true;

            double cal = 0.00;      // double price for total price overall 

            // Array for total price textbox 
            for (int i = 0; i < priceListBox.Items.Count; i++) {
                cal += (double)priceListBox.Items[i];
                totalTextBox.Text = cal.ToString("C");
            }
        }

        /// <summary>
        /// Parameters used to contain event data
        /// Invoked when Reset button is clicked
        /// </summary>
        /// <param name="sender">refers to object to raise</param>
        /// <param name="e">contains event data</param>
        private void ResetButton_Click(object sender, EventArgs e) {
 
            // resets reset form button controls 

            // resets service
            this.dresserComboBox.Enabled = true;

            // deselects service
            this.serviceListBox.SelectedIndex = 0;

            // resets focus 
            this.dresserComboBox.Focus();

            // deselects services
            this.serviceListBox.ClearSelected();

            // resets charged items 
            this.chargedListBox.Items.Clear();

            // resets prices
            this.priceListBox.Items.Clear();
            
            // resets total price
            this.totalTextBox.Text = string.Empty;

            // resets add service
            this.addButton.Enabled = false;

            // resets focus
            this.addButton.Focus();

            // resets calculate total
            this.calculateButton.Enabled = false;

        }

        /// <summary>
        /// Parameters used to contain event data
        /// Invoked when Exit button is clicked
        /// </summary>
        /// <param name="sender">refers to object to raise</param>
        /// <param name="e">contains event data</param>
        private void ExitButton_Click(object sender, EventArgs e) {
            Application.Exit();   // closes the form (exits the application) 
        }

        /// <summary>
        /// Used to open form1 and disables the 
        /// use of add and calculate buttons
        /// </summary>
        /// <param name="sender">refers to object to raise</param>
        /// <param name="e">contains event data</param>
        private void Form1_Load(object sender, EventArgs e) {
            addButton.Enabled = false;
            calculateButton.Enabled = false;
        }

        /// <summary>
        /// Service listbox event handler 
        /// Used to link add button, calculate button and 
        /// dresser combobox altogether
        /// </summary>
        /// <param name="sender">refers to object to raise</param>
        /// <param name="e">contains event data</param>
        private void ServiceListBox_SelectedIndexChanged(object sender, EventArgs e) {
            if (serviceListBox.SelectedIndex > -1) {
                addButton.Enabled = true;
                calculateButton.Enabled = true;
                dresserComboBox.Enabled = false;
            }
            else {
                addButton.Enabled = false;
                calculateButton.Enabled = false;
                dresserComboBox.Enabled = true;
            }
        }
    }
}
