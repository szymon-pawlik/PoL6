namespace ConsoleApp1
{
    partial class CentrumPowiadimien
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.MojePoleTextoweDlaPogotowia = new System.Windows.Forms.TextBox();
            this.MojePoleTextoweDlaStrazy = new System.Windows.Forms.TextBox();
            this.MojePoleTextoweDlaPolicji = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 70);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 52);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "wyslij";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.send);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add_pol);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 215);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "-";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.del_pol);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(615, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.del_str);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(615, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.add_str);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(358, 215);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.del_pog);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(358, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 6;
            this.button7.Text = "+";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.add_pog);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 254);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Policja";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(600, 254);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            this.textBox3.Text = "Straz";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(346, 254);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 11;
            this.textBox4.Text = "Pogotowie";
            // 
            // MojePoleTextoweDlaPogotowia
            // 
            this.MojePoleTextoweDlaPogotowia.Location = new System.Drawing.Point(308, 292);
            this.MojePoleTextoweDlaPogotowia.Multiline = true;
            this.MojePoleTextoweDlaPogotowia.Name = "MojePoleTextoweDlaPogotowia";
            this.MojePoleTextoweDlaPogotowia.Size = new System.Drawing.Size(201, 146);
            this.MojePoleTextoweDlaPogotowia.TabIndex = 14;
            this.MojePoleTextoweDlaPogotowia.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // MojePoleTextoweDlaStrazy
            // 
            this.MojePoleTextoweDlaStrazy.Location = new System.Drawing.Point(562, 292);
            this.MojePoleTextoweDlaStrazy.Multiline = true;
            this.MojePoleTextoweDlaStrazy.Name = "MojePoleTextoweDlaStrazy";
            this.MojePoleTextoweDlaStrazy.Size = new System.Drawing.Size(201, 134);
            this.MojePoleTextoweDlaStrazy.TabIndex = 13;
            this.MojePoleTextoweDlaStrazy.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // MojePoleTextoweDlaPolicji
            // 
            this.MojePoleTextoweDlaPolicji.Location = new System.Drawing.Point(40, 292);
            this.MojePoleTextoweDlaPolicji.Multiline = true;
            this.MojePoleTextoweDlaPolicji.Name = "MojePoleTextoweDlaPolicji";
            this.MojePoleTextoweDlaPolicji.Size = new System.Drawing.Size(201, 146);
            this.MojePoleTextoweDlaPolicji.TabIndex = 12;
            this.MojePoleTextoweDlaPolicji.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(289, 113);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 15;
            this.button8.Text = "usun";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.usun);
            // 
            // CentrumPowiadimien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.MojePoleTextoweDlaPogotowia);
            this.Controls.Add(this.MojePoleTextoweDlaStrazy);
            this.Controls.Add(this.MojePoleTextoweDlaPolicji);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "CentrumPowiadimien";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox MojePoleTextoweDlaPogotowia;
        private System.Windows.Forms.TextBox MojePoleTextoweDlaStrazy;
        private System.Windows.Forms.TextBox MojePoleTextoweDlaPolicji;
        private System.Windows.Forms.Button button8;
    }
}