namespace ShippingCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonDel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.kilogramLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.resetBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 530);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 34);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(211, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rates";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(91, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipping";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel2.Controls.Add(this.comboBoxCity);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.textBoxUserInput);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(345, 153);
            this.panel2.TabIndex = 1;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "Metro Manila",
            "Cebu City",
            "Bacolod",
            "Siargao",
            "Davao"});
            this.comboBoxCity.Location = new System.Drawing.Point(16, 107);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(166, 24);
            this.comboBoxCity.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(277, 16);
            this.label16.TabIndex = 2;
            this.label16.Text = "Where would you like to deliver the package?";
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUserInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserInput.Location = new System.Drawing.Point(16, 40);
            this.textBoxUserInput.Multiline = true;
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(166, 24);
            this.textBoxUserInput.TabIndex = 1;
            this.textBoxUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUserInput_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "How many kilograms is your package?";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.label15, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label13, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label9, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(28, 185);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(316, 172);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(129, 143);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 27);
            this.label15.TabIndex = 11;
            this.label15.Text = "PHP 200.00";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 143);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 27);
            this.label14.TabIndex = 10;
            this.label14.Text = "Davao";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(129, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(184, 27);
            this.label13.TabIndex = 9;
            this.label13.Text = "PHP 230.00";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(120, 27);
            this.label12.TabIndex = 8;
            this.label12.Text = "Siargao";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(129, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(184, 28);
            this.label11.TabIndex = 7;
            this.label11.Text = "PHP 295.00";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 28);
            this.label10.TabIndex = 6;
            this.label10.Text = "Bacolod";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(129, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(184, 28);
            this.label9.TabIndex = 5;
            this.label9.Text = "PHP 300.00";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Cebu City";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Metro Manila";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "Place to Deliver";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Shipping Rates per kg";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(129, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "PHP 350.00";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDel
            // 
            this.buttonDel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonDel.Location = new System.Drawing.Point(114, 478);
            this.buttonDel.Name = "buttonDel";
            this.buttonDel.Size = new System.Drawing.Size(139, 36);
            this.buttonDel.TabIndex = 3;
            this.buttonDel.Text = "Calculate";
            this.buttonDel.UseVisualStyleBackColor = false;
            this.buttonDel.Click += new System.EventHandler(this.buttonDel_Click);
            this.buttonDel.MouseEnter += new System.EventHandler(this.buttonCal_MouseEnter);
            this.buttonDel.MouseLeave += new System.EventHandler(this.deliverButton_MouseLeave);
            this.buttonDel.MouseHover += new System.EventHandler(this.deliverButton_MouseHover);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaShell;
            this.panel3.Controls.Add(this.totalCostLabel);
            this.panel3.Controls.Add(this.cityLabel);
            this.panel3.Controls.Add(this.kilogramLabel);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(17, 363);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 103);
            this.panel3.TabIndex = 4;
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostLabel.Location = new System.Drawing.Point(110, 71);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(0, 16);
            this.totalCostLabel.TabIndex = 6;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(101, 45);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(0, 13);
            this.cityLabel.TabIndex = 5;
            // 
            // kilogramLabel
            // 
            this.kilogramLabel.AutoSize = true;
            this.kilogramLabel.Location = new System.Drawing.Point(101, 29);
            this.kilogramLabel.Name = "kilogramLabel";
            this.kilogramLabel.Size = new System.Drawing.Size(0, 13);
            this.kilogramLabel.TabIndex = 4;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(36, 71);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 16);
            this.label20.TabIndex = 3;
            this.label20.Text = "Total Cost:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(36, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 16);
            this.label19.TabIndex = 2;
            this.label19.Text = "City:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(36, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(56, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Kilogram:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(101, 16);
            this.label17.TabIndex = 0;
            this.label17.Text = "Shipping Details:";
            // 
            // resetBtn
            // 
            this.resetBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.resetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBtn.Location = new System.Drawing.Point(12, 495);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(65, 29);
            this.resetBtn.TabIndex = 5;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = false;
            this.resetBtn.Click += new System.EventHandler(this.resetButton);
            this.resetBtn.MouseEnter += new System.EventHandler(this.resetBtn_MouseEnter);
            this.resetBtn.MouseLeave += new System.EventHandler(this.resetButton_MouseLeave);
            this.resetBtn.MouseHover += new System.EventHandler(this.resetButton_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(369, 564);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonDel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shipping Cost";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonDel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label kilogramLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.Button resetBtn;
    }
}

