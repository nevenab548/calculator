namespace Kalkulator
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
            this.InputText = new System.Windows.Forms.TextBox();
            this.Result = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Zerobutton = new System.Windows.Forms.Button();
            this.Threebutton = new System.Windows.Forms.Button();
            this.Twobutton = new System.Windows.Forms.Button();
            this.Onebutton = new System.Windows.Forms.Button();
            this.Sixbutton = new System.Windows.Forms.Button();
            this.Fivebutton = new System.Windows.Forms.Button();
            this.Mulbutton = new System.Windows.Forms.Button();
            this.Ninebutton = new System.Windows.Forms.Button();
            this.Divbutton = new System.Windows.Forms.Button();
            this.Delbutton = new System.Windows.Forms.Button();
            this.CEbutton = new System.Windows.Forms.Button();
            this.Sevenbutton = new System.Windows.Forms.Button();
            this.Eightbutton = new System.Windows.Forms.Button();
            this.Fourbutton = new System.Windows.Forms.Button();
            this.Subbutton = new System.Windows.Forms.Button();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Dotbutton = new System.Windows.Forms.Button();
            this.Eqbutton = new System.Windows.Forms.Button();
            this.ModButton = new System.Windows.Forms.Button();
            this.Degbutton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InputText
            // 
            this.InputText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InputText.Location = new System.Drawing.Point(0, 0);
            this.InputText.Name = "InputText";
            this.InputText.Size = new System.Drawing.Size(286, 20);
            this.InputText.TabIndex = 0;
            this.InputText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputText_KeyPress);
            // 
            // Result
            // 
            this.Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Result.Location = new System.Drawing.Point(-3, 23);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(284, 48);
            this.Result.TabIndex = 1;
            this.Result.Text = "Unesite izraz i pritisnite enter ili =";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Threebutton, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.Twobutton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Onebutton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Sixbutton, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.Fivebutton, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Mulbutton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Ninebutton, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.CEbutton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Sevenbutton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Eightbutton, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Fourbutton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Subbutton, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.Addbutton, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.Dotbutton, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Delbutton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Divbutton, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.ModButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Zerobutton, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Degbutton, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.Eqbutton, 2, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 297);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // Zerobutton
            // 
            this.Zerobutton.Location = new System.Drawing.Point(3, 239);
            this.Zerobutton.Name = "Zerobutton";
            this.Zerobutton.Size = new System.Drawing.Size(65, 55);
            this.Zerobutton.TabIndex = 17;
            this.Zerobutton.Text = "0";
            this.Zerobutton.UseVisualStyleBackColor = true;
            this.Zerobutton.Click += new System.EventHandler(this.Zerobutton_Click);
            // 
            // Threebutton
            // 
            this.Threebutton.Location = new System.Drawing.Point(145, 180);
            this.Threebutton.Name = "Threebutton";
            this.Threebutton.Size = new System.Drawing.Size(65, 53);
            this.Threebutton.TabIndex = 14;
            this.Threebutton.Text = "3";
            this.Threebutton.UseVisualStyleBackColor = true;
            this.Threebutton.Click += new System.EventHandler(this.Threebutton_Click);
            // 
            // Twobutton
            // 
            this.Twobutton.Location = new System.Drawing.Point(74, 180);
            this.Twobutton.Name = "Twobutton";
            this.Twobutton.Size = new System.Drawing.Size(65, 53);
            this.Twobutton.TabIndex = 13;
            this.Twobutton.Text = "2";
            this.Twobutton.UseVisualStyleBackColor = true;
            this.Twobutton.Click += new System.EventHandler(this.Twobutton_Click);
            // 
            // Onebutton
            // 
            this.Onebutton.Location = new System.Drawing.Point(3, 180);
            this.Onebutton.Name = "Onebutton";
            this.Onebutton.Size = new System.Drawing.Size(65, 53);
            this.Onebutton.TabIndex = 12;
            this.Onebutton.Text = "1";
            this.Onebutton.UseVisualStyleBackColor = true;
            this.Onebutton.Click += new System.EventHandler(this.Onebutton_Click);
            // 
            // Sixbutton
            // 
            this.Sixbutton.Location = new System.Drawing.Point(145, 121);
            this.Sixbutton.Name = "Sixbutton";
            this.Sixbutton.Size = new System.Drawing.Size(65, 53);
            this.Sixbutton.TabIndex = 10;
            this.Sixbutton.Text = "6";
            this.Sixbutton.UseVisualStyleBackColor = true;
            this.Sixbutton.Click += new System.EventHandler(this.Sixbutton_Click);
            // 
            // Fivebutton
            // 
            this.Fivebutton.Location = new System.Drawing.Point(74, 121);
            this.Fivebutton.Name = "Fivebutton";
            this.Fivebutton.Size = new System.Drawing.Size(65, 53);
            this.Fivebutton.TabIndex = 9;
            this.Fivebutton.Text = "5";
            this.Fivebutton.UseVisualStyleBackColor = true;
            this.Fivebutton.Click += new System.EventHandler(this.Fivebutton_Click);
            // 
            // Mulbutton
            // 
            this.Mulbutton.Location = new System.Drawing.Point(216, 62);
            this.Mulbutton.Name = "Mulbutton";
            this.Mulbutton.Size = new System.Drawing.Size(65, 53);
            this.Mulbutton.TabIndex = 7;
            this.Mulbutton.Text = "X";
            this.Mulbutton.UseVisualStyleBackColor = true;
            this.Mulbutton.Click += new System.EventHandler(this.Mulbutton_Click);
            // 
            // Ninebutton
            // 
            this.Ninebutton.Location = new System.Drawing.Point(145, 62);
            this.Ninebutton.Name = "Ninebutton";
            this.Ninebutton.Size = new System.Drawing.Size(65, 53);
            this.Ninebutton.TabIndex = 6;
            this.Ninebutton.Text = "9";
            this.Ninebutton.UseVisualStyleBackColor = true;
            this.Ninebutton.Click += new System.EventHandler(this.Ninebutton_Click);
            // 
            // Divbutton
            // 
            this.Divbutton.Location = new System.Drawing.Point(216, 3);
            this.Divbutton.Name = "Divbutton";
            this.Divbutton.Size = new System.Drawing.Size(65, 53);
            this.Divbutton.TabIndex = 3;
            this.Divbutton.Text = "%";
            this.Divbutton.UseVisualStyleBackColor = true;
            this.Divbutton.Click += new System.EventHandler(this.Divbutton_Click);
            // 
            // Delbutton
            // 
            this.Delbutton.Location = new System.Drawing.Point(74, 3);
            this.Delbutton.Name = "Delbutton";
            this.Delbutton.Size = new System.Drawing.Size(65, 53);
            this.Delbutton.TabIndex = 2;
            this.Delbutton.Text = "DEL";
            this.Delbutton.UseVisualStyleBackColor = true;
            this.Delbutton.Click += new System.EventHandler(this.Delbutton_Click);
            // 
            // CEbutton
            // 
            this.CEbutton.Location = new System.Drawing.Point(3, 3);
            this.CEbutton.Name = "CEbutton";
            this.CEbutton.Size = new System.Drawing.Size(65, 53);
            this.CEbutton.TabIndex = 0;
            this.CEbutton.Text = "CE";
            this.CEbutton.UseVisualStyleBackColor = true;
            this.CEbutton.Click += new System.EventHandler(this.CEbutton_Click);
            // 
            // Sevenbutton
            // 
            this.Sevenbutton.Location = new System.Drawing.Point(3, 62);
            this.Sevenbutton.Name = "Sevenbutton";
            this.Sevenbutton.Size = new System.Drawing.Size(65, 53);
            this.Sevenbutton.TabIndex = 1;
            this.Sevenbutton.Text = "7";
            this.Sevenbutton.UseVisualStyleBackColor = true;
            this.Sevenbutton.Click += new System.EventHandler(this.Sevenbutton_Click);
            // 
            // Eightbutton
            // 
            this.Eightbutton.Location = new System.Drawing.Point(74, 62);
            this.Eightbutton.Name = "Eightbutton";
            this.Eightbutton.Size = new System.Drawing.Size(65, 53);
            this.Eightbutton.TabIndex = 4;
            this.Eightbutton.Text = "8";
            this.Eightbutton.UseVisualStyleBackColor = true;
            this.Eightbutton.Click += new System.EventHandler(this.Eightbutton_Click);
            // 
            // Fourbutton
            // 
            this.Fourbutton.Location = new System.Drawing.Point(3, 121);
            this.Fourbutton.Name = "Fourbutton";
            this.Fourbutton.Size = new System.Drawing.Size(65, 53);
            this.Fourbutton.TabIndex = 5;
            this.Fourbutton.Text = "4";
            this.Fourbutton.UseVisualStyleBackColor = true;
            this.Fourbutton.Click += new System.EventHandler(this.Fourbutton_Click);
            // 
            // Subbutton
            // 
            this.Subbutton.Location = new System.Drawing.Point(216, 121);
            this.Subbutton.Name = "Subbutton";
            this.Subbutton.Size = new System.Drawing.Size(65, 53);
            this.Subbutton.TabIndex = 8;
            this.Subbutton.Text = "-";
            this.Subbutton.UseVisualStyleBackColor = true;
            this.Subbutton.Click += new System.EventHandler(this.Subbutton_Click);
            // 
            // Addbutton
            // 
            this.Addbutton.Location = new System.Drawing.Point(216, 180);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(65, 53);
            this.Addbutton.TabIndex = 11;
            this.Addbutton.Text = "+";
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.Addbutton_Click);
            // 
            // Dotbutton
            // 
            this.Dotbutton.Location = new System.Drawing.Point(74, 239);
            this.Dotbutton.Name = "Dotbutton";
            this.Dotbutton.Size = new System.Drawing.Size(65, 55);
            this.Dotbutton.TabIndex = 16;
            this.Dotbutton.Text = ".";
            this.Dotbutton.UseVisualStyleBackColor = true;
            this.Dotbutton.Click += new System.EventHandler(this.Dotbutton_Click);
            // 
            // Eqbutton
            // 
            this.Eqbutton.Location = new System.Drawing.Point(145, 239);
            this.Eqbutton.Name = "Eqbutton";
            this.Eqbutton.Size = new System.Drawing.Size(65, 55);
            this.Eqbutton.TabIndex = 15;
            this.Eqbutton.Text = "=";
            this.Eqbutton.UseVisualStyleBackColor = true;
            this.Eqbutton.Click += new System.EventHandler(this.Eqbutton_Click);
            // 
            // ModButton
            // 
            this.ModButton.Location = new System.Drawing.Point(145, 3);
            this.ModButton.Name = "ModButton";
            this.ModButton.Size = new System.Drawing.Size(65, 53);
            this.ModButton.TabIndex = 18;
            this.ModButton.Text = "MOD";
            this.ModButton.UseVisualStyleBackColor = true;
            this.ModButton.Click += new System.EventHandler(this.ModButton_Click);
            // 
            // Degbutton
            // 
            this.Degbutton.Location = new System.Drawing.Point(216, 239);
            this.Degbutton.Name = "Degbutton";
            this.Degbutton.Size = new System.Drawing.Size(65, 53);
            this.Degbutton.TabIndex = 19;
            this.Degbutton.Text = "^";
            this.Degbutton.UseVisualStyleBackColor = true;
            this.Degbutton.Click += new System.EventHandler(this.Degbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 371);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.InputText);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputText;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Zerobutton;
        private System.Windows.Forms.Button Threebutton;
        private System.Windows.Forms.Button Twobutton;
        private System.Windows.Forms.Button Onebutton;
        private System.Windows.Forms.Button Sixbutton;
        private System.Windows.Forms.Button Fivebutton;
        private System.Windows.Forms.Button Mulbutton;
        private System.Windows.Forms.Button Ninebutton;
        private System.Windows.Forms.Button Divbutton;
        private System.Windows.Forms.Button Delbutton;
        private System.Windows.Forms.Button CEbutton;
        private System.Windows.Forms.Button Sevenbutton;
        private System.Windows.Forms.Button Eightbutton;
        private System.Windows.Forms.Button Fourbutton;
        private System.Windows.Forms.Button Subbutton;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Dotbutton;
        private System.Windows.Forms.Button Eqbutton;
        private System.Windows.Forms.Button ModButton;
        private System.Windows.Forms.Button Degbutton;
    }
}

