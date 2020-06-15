namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SerchBox = new System.Windows.Forms.TextBox();
            this.SerchLabel = new System.Windows.Forms.Label();
            this.InflationTextBox = new System.Windows.Forms.TextBox();
            this.TradeBalInput = new System.Windows.Forms.TextBox();
            this.HDIInput = new System.Windows.Forms.TextBox();
            this.NameOfCountry = new System.Windows.Forms.Label();
            this.GDPInput = new System.Windows.Forms.Label();
            this.InflationInput = new System.Windows.Forms.Label();
            this.TradeBalanace = new System.Windows.Forms.Label();
            this.HDIIndex = new System.Windows.Forms.Label();
            this.TradePartnerDropDown = new System.Windows.Forms.ComboBox();
            this.TradePartnerInput = new System.Windows.Forms.Label();
            this.GDPBoxInput = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.ListOfAll = new System.Windows.Forms.ListBox();
            this.editButton = new System.Windows.Forms.Button();
            this.tradePLabel = new System.Windows.Forms.Label();
            this.treeHeight = new System.Windows.Forms.TextBox();
            this.DisplayMainTradeP = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gotoButton = new System.Windows.Forms.Button();
            this.deletetradePartner = new System.Windows.Forms.Button();
            this.countrysNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.countryInfoBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HeightestPotential = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LookUpViaTrade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SerchBox
            // 
            this.SerchBox.Location = new System.Drawing.Point(268, 22);
            this.SerchBox.Name = "SerchBox";
            this.SerchBox.Size = new System.Drawing.Size(182, 20);
            this.SerchBox.TabIndex = 7;
            this.SerchBox.TextChanged += new System.EventHandler(this.SerchBox_TextChanged);
            // 
            // SerchLabel
            // 
            this.SerchLabel.AutoSize = true;
            this.SerchLabel.Location = new System.Drawing.Point(265, 6);
            this.SerchLabel.Name = "SerchLabel";
            this.SerchLabel.Size = new System.Drawing.Size(101, 13);
            this.SerchLabel.TabIndex = 10;
            this.SerchLabel.Text = "search for a country";
            // 
            // InflationTextBox
            // 
            this.InflationTextBox.Location = new System.Drawing.Point(210, 534);
            this.InflationTextBox.Name = "InflationTextBox";
            this.InflationTextBox.Size = new System.Drawing.Size(112, 20);
            this.InflationTextBox.TabIndex = 14;
            this.InflationTextBox.TextChanged += new System.EventHandler(this.InflationTextBox_TextChanged);
            // 
            // TradeBalInput
            // 
            this.TradeBalInput.Location = new System.Drawing.Point(210, 583);
            this.TradeBalInput.Name = "TradeBalInput";
            this.TradeBalInput.Size = new System.Drawing.Size(112, 20);
            this.TradeBalInput.TabIndex = 15;
            this.TradeBalInput.TextChanged += new System.EventHandler(this.TradeBalInput_TextChanged);
            // 
            // HDIInput
            // 
            this.HDIInput.Location = new System.Drawing.Point(338, 439);
            this.HDIInput.Name = "HDIInput";
            this.HDIInput.Size = new System.Drawing.Size(112, 20);
            this.HDIInput.TabIndex = 16;
            this.HDIInput.TextChanged += new System.EventHandler(this.HDIInput_TextChanged);
            // 
            // NameOfCountry
            // 
            this.NameOfCountry.AutoSize = true;
            this.NameOfCountry.Location = new System.Drawing.Point(207, 423);
            this.NameOfCountry.Name = "NameOfCountry";
            this.NameOfCountry.Size = new System.Drawing.Size(35, 13);
            this.NameOfCountry.TabIndex = 18;
            this.NameOfCountry.Text = "Name";
            // 
            // GDPInput
            // 
            this.GDPInput.AutoSize = true;
            this.GDPInput.Location = new System.Drawing.Point(207, 467);
            this.GDPInput.Name = "GDPInput";
            this.GDPInput.Size = new System.Drawing.Size(30, 13);
            this.GDPInput.TabIndex = 19;
            this.GDPInput.Text = "GDP";
            // 
            // InflationInput
            // 
            this.InflationInput.AutoSize = true;
            this.InflationInput.Location = new System.Drawing.Point(207, 518);
            this.InflationInput.Name = "InflationInput";
            this.InflationInput.Size = new System.Drawing.Size(44, 13);
            this.InflationInput.TabIndex = 20;
            this.InflationInput.Text = "Inflation";
            // 
            // TradeBalanace
            // 
            this.TradeBalanace.AutoSize = true;
            this.TradeBalanace.Location = new System.Drawing.Point(205, 567);
            this.TradeBalanace.Name = "TradeBalanace";
            this.TradeBalanace.Size = new System.Drawing.Size(74, 13);
            this.TradeBalanace.TabIndex = 21;
            this.TradeBalanace.Text = "TradeBalance";
            // 
            // HDIIndex
            // 
            this.HDIIndex.AutoSize = true;
            this.HDIIndex.Location = new System.Drawing.Point(335, 423);
            this.HDIIndex.Name = "HDIIndex";
            this.HDIIndex.Size = new System.Drawing.Size(52, 13);
            this.HDIIndex.TabIndex = 22;
            this.HDIIndex.Text = "HDIIndex";
            // 
            // TradePartnerDropDown
            // 
            this.TradePartnerDropDown.FormattingEnabled = true;
            this.TradePartnerDropDown.Location = new System.Drawing.Point(338, 483);
            this.TradePartnerDropDown.Name = "TradePartnerDropDown";
            this.TradePartnerDropDown.Size = new System.Drawing.Size(147, 21);
            this.TradePartnerDropDown.TabIndex = 23;
            this.TradePartnerDropDown.SelectedIndexChanged += new System.EventHandler(this.TradePartnerDropDown_SelectedIndexChanged);
            // 
            // TradePartnerInput
            // 
            this.TradePartnerInput.AutoSize = true;
            this.TradePartnerInput.Location = new System.Drawing.Point(329, 467);
            this.TradePartnerInput.Name = "TradePartnerInput";
            this.TradePartnerInput.Size = new System.Drawing.Size(72, 13);
            this.TradePartnerInput.TabIndex = 24;
            this.TradePartnerInput.Text = "Trade Partner";
            // 
            // GDPBoxInput
            // 
            this.GDPBoxInput.Location = new System.Drawing.Point(210, 483);
            this.GDPBoxInput.Name = "GDPBoxInput";
            this.GDPBoxInput.Size = new System.Drawing.Size(112, 20);
            this.GDPBoxInput.TabIndex = 25;
            this.GDPBoxInput.TextChanged += new System.EventHandler(this.GDPBoxInput_TextChanged);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(338, 518);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(99, 54);
            this.AddButton.TabIndex = 26;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(334, 579);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(103, 24);
            this.deleteButton.TabIndex = 27;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(208, 439);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(112, 20);
            this.NametextBox.TabIndex = 29;
            this.NametextBox.TextChanged += new System.EventHandler(this.NametextBox_TextChanged);
            // 
            // ListOfAll
            // 
            this.ListOfAll.FormattingEnabled = true;
            this.ListOfAll.Location = new System.Drawing.Point(11, 17);
            this.ListOfAll.Name = "ListOfAll";
            this.ListOfAll.Size = new System.Drawing.Size(180, 329);
            this.ListOfAll.TabIndex = 31;
            this.ListOfAll.SelectedIndexChanged += new System.EventHandler(this.ListOfAll_SelectedIndexChanged);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(443, 520);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(99, 55);
            this.editButton.TabIndex = 32;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // tradePLabel
            // 
            this.tradePLabel.AutoSize = true;
            this.tradePLabel.Location = new System.Drawing.Point(12, 349);
            this.tradePLabel.Name = "tradePLabel";
            this.tradePLabel.Size = new System.Drawing.Size(102, 13);
            this.tradePLabel.TabIndex = 34;
            this.tradePLabel.Text = "Main trade Partners ";
            // 
            // treeHeight
            // 
            this.treeHeight.Location = new System.Drawing.Point(251, 333);
            this.treeHeight.Name = "treeHeight";
            this.treeHeight.Size = new System.Drawing.Size(28, 20);
            this.treeHeight.TabIndex = 36;
            this.treeHeight.TextChanged += new System.EventHandler(this.treeHeight_TextChanged);
            // 
            // DisplayMainTradeP
            // 
            this.DisplayMainTradeP.FormattingEnabled = true;
            this.DisplayMainTradeP.Location = new System.Drawing.Point(12, 364);
            this.DisplayMainTradeP.Name = "DisplayMainTradeP";
            this.DisplayMainTradeP.Size = new System.Drawing.Size(179, 264);
            this.DisplayMainTradeP.TabIndex = 37;
            this.DisplayMainTradeP.SelectedIndexChanged += new System.EventHandler(this.DisplayMainTradeP_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Tree Height";
            // 
            // gotoButton
            // 
            this.gotoButton.Location = new System.Drawing.Point(443, 580);
            this.gotoButton.Name = "gotoButton";
            this.gotoButton.Size = new System.Drawing.Size(99, 23);
            this.gotoButton.TabIndex = 39;
            this.gotoButton.Text = "Goto";
            this.gotoButton.UseVisualStyleBackColor = true;
            this.gotoButton.Click += new System.EventHandler(this.gotoButton_Click);
            // 
            // deletetradePartner
            // 
            this.deletetradePartner.Location = new System.Drawing.Point(332, 610);
            this.deletetradePartner.Name = "deletetradePartner";
            this.deletetradePartner.Size = new System.Drawing.Size(208, 23);
            this.deletetradePartner.TabIndex = 40;
            this.deletetradePartner.Text = "remove Trade Partner";
            this.deletetradePartner.UseVisualStyleBackColor = true;
            this.deletetradePartner.Click += new System.EventHandler(this.deletetradePartner_Click);
            // 
            // countrysNumber
            // 
            this.countrysNumber.Location = new System.Drawing.Point(251, 390);
            this.countrysNumber.Name = "countrysNumber";
            this.countrysNumber.Size = new System.Drawing.Size(28, 20);
            this.countrysNumber.TabIndex = 41;
            this.countrysNumber.TextChanged += new System.EventHandler(this.countrysNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Number of countrys";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // countryInfoBox
            // 
            this.countryInfoBox.Location = new System.Drawing.Point(251, 87);
            this.countryInfoBox.Multiline = true;
            this.countryInfoBox.Name = "countryInfoBox";
            this.countryInfoBox.Size = new System.Drawing.Size(220, 225);
            this.countryInfoBox.TabIndex = 43;
            this.countryInfoBox.TextChanged += new System.EventHandler(this.countryInfoBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // HeightestPotential
            // 
            this.HeightestPotential.Location = new System.Drawing.Point(371, 361);
            this.HeightestPotential.Name = "HeightestPotential";
            this.HeightestPotential.Size = new System.Drawing.Size(100, 20);
            this.HeightestPotential.TabIndex = 46;
            this.HeightestPotential.TextChanged += new System.EventHandler(this.HeightestPotential_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Highest Potential";
            // 
            // LookUpViaTrade
            // 
            this.LookUpViaTrade.Location = new System.Drawing.Point(268, 61);
            this.LookUpViaTrade.Name = "LookUpViaTrade";
            this.LookUpViaTrade.Size = new System.Drawing.Size(182, 20);
            this.LookUpViaTrade.TabIndex = 48;
            this.LookUpViaTrade.TextChanged += new System.EventHandler(this.LookUpViaTrade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 49;
            this.label4.Text = "search via trade partners";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 645);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LookUpViaTrade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeightestPotential);
            this.Controls.Add(this.countryInfoBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.countrysNumber);
            this.Controls.Add(this.deletetradePartner);
            this.Controls.Add(this.gotoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayMainTradeP);
            this.Controls.Add(this.treeHeight);
            this.Controls.Add(this.tradePLabel);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.ListOfAll);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.GDPBoxInput);
            this.Controls.Add(this.TradePartnerInput);
            this.Controls.Add(this.TradePartnerDropDown);
            this.Controls.Add(this.HDIIndex);
            this.Controls.Add(this.TradeBalanace);
            this.Controls.Add(this.InflationInput);
            this.Controls.Add(this.GDPInput);
            this.Controls.Add(this.NameOfCountry);
            this.Controls.Add(this.HDIInput);
            this.Controls.Add(this.TradeBalInput);
            this.Controls.Add(this.InflationTextBox);
            this.Controls.Add(this.SerchLabel);
            this.Controls.Add(this.SerchBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SerchBox;
        private System.Windows.Forms.Label SerchLabel;
        private System.Windows.Forms.TextBox InflationTextBox;
        private System.Windows.Forms.TextBox TradeBalInput;
        private System.Windows.Forms.TextBox HDIInput;
        private System.Windows.Forms.Label NameOfCountry;
        private System.Windows.Forms.Label GDPInput;
        private System.Windows.Forms.Label InflationInput;
        private System.Windows.Forms.Label TradeBalanace;
        private System.Windows.Forms.Label HDIIndex;
        private System.Windows.Forms.ComboBox TradePartnerDropDown;
        private System.Windows.Forms.Label TradePartnerInput;
        private System.Windows.Forms.TextBox GDPBoxInput;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.ListBox ListOfAll;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label tradePLabel;
        private System.Windows.Forms.TextBox treeHeight;
        private System.Windows.Forms.ListBox DisplayMainTradeP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gotoButton;
        private System.Windows.Forms.Button deletetradePartner;
        private System.Windows.Forms.TextBox countrysNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox countryInfoBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox HeightestPotential;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LookUpViaTrade;
        private System.Windows.Forms.Label label4;
    }
}

