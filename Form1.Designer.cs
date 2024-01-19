namespace OgrenciSinavDurumu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbAdSoyad = new System.Windows.Forms.TextBox();
            this.txbVizeNot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbFinalNot = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbProjeNot = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı Soyadı :";
            // 
            // txbAdSoyad
            // 
            this.txbAdSoyad.Location = new System.Drawing.Point(138, 25);
            this.txbAdSoyad.Name = "txbAdSoyad";
            this.txbAdSoyad.Size = new System.Drawing.Size(104, 20);
            this.txbAdSoyad.TabIndex = 1;
            // 
            // txbVizeNot
            // 
            this.txbVizeNot.Location = new System.Drawing.Point(138, 51);
            this.txbVizeNot.Name = "txbVizeNot";
            this.txbVizeNot.Size = new System.Drawing.Size(104, 20);
            this.txbVizeNot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(52, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vize Notu :";
            // 
            // txbFinalNot
            // 
            this.txbFinalNot.Location = new System.Drawing.Point(138, 77);
            this.txbFinalNot.Name = "txbFinalNot";
            this.txbFinalNot.Size = new System.Drawing.Size(104, 20);
            this.txbFinalNot.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Final Notu :";
            // 
            // txbProjeNot
            // 
            this.txbProjeNot.Location = new System.Drawing.Point(138, 103);
            this.txbProjeNot.Name = "txbProjeNot";
            this.txbProjeNot.Size = new System.Drawing.Size(104, 20);
            this.txbProjeNot.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proje Notu :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(79, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(26, 191);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 95);
            this.listBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 304);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbProjeNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbFinalNot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbVizeNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAdSoyad);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Öğrenci Not Hesaplayıcı";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbAdSoyad;
        private System.Windows.Forms.TextBox txbVizeNot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFinalNot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbProjeNot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

