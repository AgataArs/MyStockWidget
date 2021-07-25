
using System;

namespace MyStockWidget1
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
            this.btnShowMe_Click = new System.Windows.Forms.Button();
            this.symbol1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.symbol3 = new System.Windows.Forms.TextBox();
            this.symbol2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.price3 = new System.Windows.Forms.TextBox();
            this.price2 = new System.Windows.Forms.TextBox();
            this.price1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowMe_Click
            // 
            this.btnShowMe_Click.Location = new System.Drawing.Point(88, 68);
            this.btnShowMe_Click.Name = "btnShowMe_Click";
            this.btnShowMe_Click.Size = new System.Drawing.Size(64, 98);
            this.btnShowMe_Click.TabIndex = 0;
            this.btnShowMe_Click.Text = "Show me how much money I screwed up";
            this.btnShowMe_Click.UseVisualStyleBackColor = true;
            this.btnShowMe_Click.Click += new System.EventHandler(this.btnShowMe_Click_Click);
            // 
            // symbol1
            // 
            this.symbol1.HideSelection = false;
            this.symbol1.Location = new System.Drawing.Point(12, 68);
            this.symbol1.Name = "symbol1";
            this.symbol1.ReadOnly = true;
            this.symbol1.Size = new System.Drawing.Size(49, 20);
            this.symbol1.TabIndex = 1;
            this.symbol1.Text = "IBM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Symbol";
            // 
            // symbol3
            // 
            this.symbol3.Location = new System.Drawing.Point(12, 146);
            this.symbol3.Name = "symbol3";
            this.symbol3.Size = new System.Drawing.Size(49, 20);
            this.symbol3.TabIndex = 6;
            this.symbol3.Text = "AAPL";
            // 
            // symbol2
            // 
            this.symbol2.Location = new System.Drawing.Point(12, 108);
            this.symbol2.Name = "symbol2";
            this.symbol2.Size = new System.Drawing.Size(49, 20);
            this.symbol2.TabIndex = 7;
            this.symbol2.Text = "MSFT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Prices";
            // 
            // price3
            // 
            this.price3.Location = new System.Drawing.Point(175, 146);
            this.price3.Name = "price3";
            this.price3.Size = new System.Drawing.Size(49, 20);
            this.price3.TabIndex = 10;
            // 
            // price2
            // 
            this.price2.Location = new System.Drawing.Point(175, 108);
            this.price2.Name = "price2";
            this.price2.Size = new System.Drawing.Size(49, 20);
            this.price2.TabIndex = 13;
            // 
            // price1
            // 
            this.price1.AcceptsReturn = true;
            this.price1.Location = new System.Drawing.Point(175, 68);
            this.price1.Name = "price1";
            this.price1.Size = new System.Drawing.Size(49, 20);
            this.price1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(236, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 137);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 248);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.price1);
            this.Controls.Add(this.price2);
            this.Controls.Add(this.price3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.symbol2);
            this.Controls.Add(this.symbol3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.symbol1);
            this.Controls.Add(this.btnShowMe_Click);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowMe_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox symbol3;
        private System.Windows.Forms.TextBox symbol2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox price3;
        private System.Windows.Forms.TextBox price2;
        private System.Windows.Forms.TextBox price1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox symbol1;
        
    }
}

