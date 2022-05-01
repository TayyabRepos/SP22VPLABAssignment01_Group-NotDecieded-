namespace ResearchOrganizer
{
    partial class Form3
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
            this.Save = new System.Windows.Forms.Button();
            this.Bibtxt = new System.Windows.Forms.TextBox();
            this.Notestxt = new System.Windows.Forms.TextBox();
            this.URItxt = new System.Windows.Forms.TextBox();
            this.Abstracttxt = new System.Windows.Forms.TextBox();
            this.titletxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDtxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(303, 432);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(107, 46);
            this.Save.TabIndex = 23;
            this.Save.Text = "Save Edited Text";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Bibtxt
            // 
            this.Bibtxt.Location = new System.Drawing.Point(98, 418);
            this.Bibtxt.Multiline = true;
            this.Bibtxt.Name = "Bibtxt";
            this.Bibtxt.Size = new System.Drawing.Size(185, 64);
            this.Bibtxt.TabIndex = 22;
            // 
            // Notestxt
            // 
            this.Notestxt.Location = new System.Drawing.Point(98, 312);
            this.Notestxt.Multiline = true;
            this.Notestxt.Name = "Notestxt";
            this.Notestxt.Size = new System.Drawing.Size(312, 93);
            this.Notestxt.TabIndex = 21;
            // 
            // URItxt
            // 
            this.URItxt.Location = new System.Drawing.Point(98, 273);
            this.URItxt.Name = "URItxt";
            this.URItxt.Size = new System.Drawing.Size(312, 23);
            this.URItxt.TabIndex = 20;
            this.URItxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Abstracttxt
            // 
            this.Abstracttxt.Location = new System.Drawing.Point(98, 145);
            this.Abstracttxt.Multiline = true;
            this.Abstracttxt.Name = "Abstracttxt";
            this.Abstracttxt.Size = new System.Drawing.Size(312, 111);
            this.Abstracttxt.TabIndex = 19;
            // 
            // titletxt
            // 
            this.titletxt.Location = new System.Drawing.Point(98, 112);
            this.titletxt.Name = "titletxt";
            this.titletxt.Size = new System.Drawing.Size(312, 23);
            this.titletxt.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(32, 432);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Bib Tex";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Notes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(32, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "URI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Abstact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Research Organizer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IDtxt
            // 
            this.IDtxt.Location = new System.Drawing.Point(98, 68);
            this.IDtxt.Name = "IDtxt";
            this.IDtxt.Size = new System.Drawing.Size(312, 23);
            this.IDtxt.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(39, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "ID";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 494);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IDtxt);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Bibtxt);
            this.Controls.Add(this.Notestxt);
            this.Controls.Add(this.URItxt);
            this.Controls.Add(this.Abstracttxt);
            this.Controls.Add(this.titletxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Save;
        private TextBox Bibtxt;
        private TextBox Notestxt;
        private TextBox URItxt;
        private TextBox Abstracttxt;
        private TextBox titletxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox IDtxt;
        private Label label7;
    }
}