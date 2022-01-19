
namespace Projekt.View
{
    partial class LoanForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelDate2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button = new System.Windows.Forms.Button();
            this.labelLoaner = new System.Windows.Forms.Label();
            this.labelBook = new System.Windows.Forms.Label();
            this.labelDate1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "ID czytelnika:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 82);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(106, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelDate2
            // 
            this.labelDate2.AutoSize = true;
            this.labelDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDate2.ForeColor = System.Drawing.Color.Blue;
            this.labelDate2.Location = new System.Drawing.Point(150, 205);
            this.labelDate2.Name = "labelDate2";
            this.labelDate2.Size = new System.Drawing.Size(16, 13);
            this.labelDate2.TabIndex = 42;
            this.labelDate2.Text = "...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID książki:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 56);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(106, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "W celu wypożyczenia proszę o podanie:";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(148, 269);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(81, 23);
            this.button.TabIndex = 3;
            this.button.Text = "Zatwierdź";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // labelLoaner
            // 
            this.labelLoaner.AutoSize = true;
            this.labelLoaner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLoaner.ForeColor = System.Drawing.Color.Blue;
            this.labelLoaner.Location = new System.Drawing.Point(151, 123);
            this.labelLoaner.Name = "labelLoaner";
            this.labelLoaner.Size = new System.Drawing.Size(16, 13);
            this.labelLoaner.TabIndex = 47;
            this.labelLoaner.Text = "...";
            // 
            // labelBook
            // 
            this.labelBook.AutoSize = true;
            this.labelBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBook.ForeColor = System.Drawing.Color.Blue;
            this.labelBook.Location = new System.Drawing.Point(151, 152);
            this.labelBook.Name = "labelBook";
            this.labelBook.Size = new System.Drawing.Size(16, 13);
            this.labelBook.TabIndex = 48;
            this.labelBook.Text = "...";
            // 
            // labelDate1
            // 
            this.labelDate1.AutoSize = true;
            this.labelDate1.Location = new System.Drawing.Point(151, 178);
            this.labelDate1.Name = "labelDate1";
            this.labelDate1.Size = new System.Drawing.Size(16, 13);
            this.labelDate1.TabIndex = 49;
            this.labelDate1.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Data wypozyczenia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Data zwrotu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tytuł książki:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Wypożyczający:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(254, 13);
            this.label7.TabIndex = 54;
            this.label7.Text = "Jeżeli dane się zgadzają, proszę kliknąć  \'Zatwierdź\'.";
            // 
            // LoanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 313);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelDate1);
            this.Controls.Add(this.labelBook);
            this.Controls.Add(this.labelLoaner);
            this.Controls.Add(this.button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelDate2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.MaximizeBox = false;
            this.Name = "LoanForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wypożyczanie";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelDate2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label labelLoaner;
        private System.Windows.Forms.Label labelBook;
        private System.Windows.Forms.Label labelDate1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}