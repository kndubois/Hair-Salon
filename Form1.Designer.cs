/// COMP 10204
/// October 12, 2020
/// 
/// Assignment 3: Part B
///     Form1 Designer Class
///     
/// I certify that this material is my original 
/// work. No other person's has been used without 
/// due acknowledgement. 

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// Class for Form1
/// </summary>
namespace HairSalon {

    /// <summary>
    /// Form1 Class
    /// Gathers all variables for the application
    /// </summary>
    partial class Form1 {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// constructors of each in form 
        /// </summary>

        private GroupBox selectDresser;
        private ComboBox dresserComboBox;
        private GroupBox selectService;
        private ListBox serviceListBox;
        private GroupBox chargedItem;
        private ListBox chargedListBox;
        private GroupBox priceResult;
        private ListBox priceListBox;
        private Label totalPriceLabel;
        private Label totalTextBox;
        private Button addButton;
        private Button calculateButton;
        private Button resetButton;
        private Button exitButton;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {

            this.selectDresser = new System.Windows.Forms.GroupBox();
            this.dresserComboBox = new System.Windows.Forms.ComboBox();
            this.selectService = new System.Windows.Forms.GroupBox();
            this.serviceListBox = new System.Windows.Forms.ListBox();
            this.chargedItem = new System.Windows.Forms.GroupBox();
            this.chargedListBox = new System.Windows.Forms.ListBox();
            this.priceResult = new System.Windows.Forms.GroupBox();
            this.priceListBox = new System.Windows.Forms.ListBox();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.totalTextBox = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.selectDresser.SuspendLayout();
            this.selectService.SuspendLayout();
            this.chargedItem.SuspendLayout();
            this.priceResult.SuspendLayout();
            this.SuspendLayout();

            // 
            // Selects Hairdresser
            // 
            this.selectDresser.Controls.Add(this.dresserComboBox);
            this.selectDresser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectDresser.Location = new System.Drawing.Point(7, 11);
            this.selectDresser.Margin = new System.Windows.Forms.Padding(2);
            this.selectDresser.Name = "selectDresser";
            this.selectDresser.Padding = new System.Windows.Forms.Padding(2);
            this.selectDresser.Size = new System.Drawing.Size(200, 196);
            this.selectDresser.TabIndex = 0;
            this.selectDresser.TabStop = false;
            this.selectDresser.Text = "Select a Hairdresser";

            // 
            // Hairdresser Combobox
            // 
            this.dresserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dresserComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dresserComboBox.FormattingEnabled = true;
            this.dresserComboBox.Location = new System.Drawing.Point(5, 23);
            this.dresserComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.dresserComboBox.Name = "dresserComboBox";
            this.dresserComboBox.Size = new System.Drawing.Size(190, 28);
            this.dresserComboBox.TabIndex = 0;
            this.dresserComboBox.SelectedIndexChanged += new System.EventHandler(this.DresserComboBox_SelectedIndexChanged);

            // 
            // Selects Service
            // 
            this.selectService.Controls.Add(this.serviceListBox);
            this.selectService.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectService.Location = new System.Drawing.Point(213, 11);
            this.selectService.Margin = new System.Windows.Forms.Padding(2);
            this.selectService.Name = "selectService";
            this.selectService.Padding = new System.Windows.Forms.Padding(2);
            this.selectService.Size = new System.Drawing.Size(200, 196);
            this.selectService.TabIndex = 1;
            this.selectService.TabStop = false;
            this.selectService.Text = "Select a Service";

            // 
            // Service Listbox
            // 
            this.serviceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceListBox.FormattingEnabled = true;
            this.serviceListBox.ItemHeight = 20;
            this.serviceListBox.Location = new System.Drawing.Point(5, 24);
            this.serviceListBox.Margin = new System.Windows.Forms.Padding(2);
            this.serviceListBox.Name = "serviceListBox";
            this.serviceListBox.Size = new System.Drawing.Size(190, 164);
            this.serviceListBox.TabIndex = 0;
            this.serviceListBox.SelectedIndexChanged += new System.EventHandler(this.ServiceListBox_SelectedIndexChanged);

            // 
            // Charged Items
            // 
            this.chargedItem.Controls.Add(this.chargedListBox);
            this.chargedItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargedItem.Location = new System.Drawing.Point(419, 11);
            this.chargedItem.Margin = new System.Windows.Forms.Padding(2);
            this.chargedItem.Name = "chargedItem";
            this.chargedItem.Padding = new System.Windows.Forms.Padding(2);
            this.chargedItem.Size = new System.Drawing.Size(200, 196);
            this.chargedItem.TabIndex = 2;
            this.chargedItem.TabStop = false;
            this.chargedItem.Text = "Charged Items";

            // 
            // Charged Items Listbox
            // 
            this.chargedListBox.Enabled = false;
            this.chargedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chargedListBox.FormattingEnabled = true;
            this.chargedListBox.ItemHeight = 20;
            this.chargedListBox.Location = new System.Drawing.Point(5, 24);
            this.chargedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.chargedListBox.Name = "chargedListBox";
            this.chargedListBox.Size = new System.Drawing.Size(190, 164);
            this.chargedListBox.TabIndex = 0;

            // 
            // Price Result
            // 
            this.priceResult.Controls.Add(this.priceListBox);
            this.priceResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceResult.Location = new System.Drawing.Point(626, 11);
            this.priceResult.Margin = new System.Windows.Forms.Padding(2);
            this.priceResult.Name = "priceResult";
            this.priceResult.Padding = new System.Windows.Forms.Padding(2);
            this.priceResult.Size = new System.Drawing.Size(117, 196);
            this.priceResult.TabIndex = 3;
            this.priceResult.TabStop = false;
            this.priceResult.Text = "Price";

            // 
            // Price Listbox
            // 
            this.priceListBox.Enabled = false;
            this.priceListBox.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceListBox.FormatString = "C2";
            this.priceListBox.FormattingEnabled = true;
            this.priceListBox.ItemHeight = 16;
            this.priceListBox.Location = new System.Drawing.Point(5, 24);
            this.priceListBox.Margin = new System.Windows.Forms.Padding(2);
            this.priceListBox.Name = "priceListBox";
            this.priceListBox.Size = new System.Drawing.Size(107, 166);
            this.priceListBox.TabIndex = 0;

            // 
            // Total Price Label
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(521, 222);
            this.totalPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(99, 20);
            this.totalPriceLabel.TabIndex = 4;
            this.totalPriceLabel.Text = "Total Price:";
            this.totalPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // Total Textbox
            //
            this.totalTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTextBox.Location = new System.Drawing.Point(631, 222);
            this.totalTextBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(107, 23);
            this.totalTextBox.TabIndex = 5;
            this.totalTextBox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // Add Service
            // 
            this.addButton.Enabled = false;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(119, 257);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(152, 32);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add Service";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);

            // 
            // Calculate Button
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(275, 257);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(152, 32);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);

            // 
            // Reset Button
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(431, 257);
            this.resetButton.Margin = new System.Windows.Forms.Padding(2);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(152, 32);
            this.resetButton.TabIndex = 8;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);

            // 
            // Exit Button
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(587, 257);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(152, 32);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);

            // 
            // Form1
            // 
            this.CancelButton = this.resetButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 300);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.selectDresser);
            this.Controls.Add(this.selectService);
            this.Controls.Add(this.chargedItem);
            this.Controls.Add(this.priceResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Perfect Cut Hair Salon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.selectDresser.ResumeLayout(false);
            this.selectService.ResumeLayout(false);
            this.chargedItem.ResumeLayout(false);
            this.priceResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}