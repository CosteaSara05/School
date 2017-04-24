namespace Agenda
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
            this.Nume = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Prenume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Mobil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Fix = new System.Windows.Forms.TextBox();
            this.Varsta = new System.Windows.Forms.TextBox();
            this.Afisare = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(97, 3);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(100, 20);
            this.Nume.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "Simplu";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(21, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.ValueMember = "Simplu";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(41, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nume:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Prenume:";
            // 
            // Prenume
            // 
            this.Prenume.Location = new System.Drawing.Point(97, 38);
            this.Prenume.Name = "Prenume";
            this.Prenume.Size = new System.Drawing.Size(100, 20);
            this.Prenume.TabIndex = 5;
            this.Prenume.TextChanged += new System.EventHandler(this.Prenume_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mobil:";
            // 
            // Mobil
            // 
            this.Mobil.Location = new System.Drawing.Point(97, 77);
            this.Mobil.Name = "Mobil";
            this.Mobil.Size = new System.Drawing.Size(100, 20);
            this.Mobil.TabIndex = 7;
            this.Mobil.TextChanged += new System.EventHandler(this.Mobil_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fix:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Varsta:";
            // 
            // Fix
            // 
            this.Fix.Location = new System.Drawing.Point(97, 15);
            this.Fix.Name = "Fix";
            this.Fix.Size = new System.Drawing.Size(100, 20);
            this.Fix.TabIndex = 10;
            this.Fix.TextChanged += new System.EventHandler(this.Fix_TextChanged);
            // 
            // Varsta
            // 
            this.Varsta.Location = new System.Drawing.Point(97, 3);
            this.Varsta.Name = "Varsta";
            this.Varsta.Size = new System.Drawing.Size(100, 20);
            this.Varsta.TabIndex = 11;
            this.Varsta.TextChanged += new System.EventHandler(this.Varsta_TextChanged);
            // 
            // Afisare
            // 
            this.Afisare.FormattingEnabled = true;
            this.Afisare.Location = new System.Drawing.Point(22, 69);
            this.Afisare.Name = "Afisare";
            this.Afisare.Size = new System.Drawing.Size(120, 147);
            this.Afisare.TabIndex = 12;
            this.Afisare.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Nume);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Prenume);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Mobil);
            this.panel1.Location = new System.Drawing.Point(148, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Fix);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(148, 124);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 49);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Varsta);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(148, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 36);
            this.panel3.TabIndex = 15;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(863, 448);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Afisare);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox Nume;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Prenume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Mobil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Fix;
        private System.Windows.Forms.TextBox Varsta;
        private System.Windows.Forms.ListBox Afisare;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

