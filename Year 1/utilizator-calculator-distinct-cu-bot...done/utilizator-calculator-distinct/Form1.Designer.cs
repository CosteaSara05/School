namespace utilizator_calculator_distinct
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxp = new System.Windows.Forms.TextBox();
            this.textBoxc = new System.Windows.Forms.TextBox();
            this.p = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.numargasit = new System.Windows.Forms.Label();
            this.textBoxTurn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumarGata = new System.Windows.Forms.TextBox();
            this.Verificare = new System.Windows.Forms.Button();
            this.numarcalculatorlabel = new System.Windows.Forms.Label();
            this.numarutilizatorlabel = new System.Windows.Forms.Label();
            this.ElapsedTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelCeas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(42, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(225, 20);
            this.textBox1.TabIndex = 10;
            // 
            // textBoxp
            // 
            this.textBoxp.Location = new System.Drawing.Point(393, 12);
            this.textBoxp.Name = "textBoxp";
            this.textBoxp.Size = new System.Drawing.Size(84, 20);
            this.textBoxp.TabIndex = 12;
            this.textBoxp.TextChanged += new System.EventHandler(this.textBoxp_TextChanged);
            // 
            // textBoxc
            // 
            this.textBoxc.Location = new System.Drawing.Point(393, 38);
            this.textBoxc.Name = "textBoxc";
            this.textBoxc.Size = new System.Drawing.Size(84, 20);
            this.textBoxc.TabIndex = 13;
            // 
            // p
            // 
            this.p.AutoSize = true;
            this.p.Location = new System.Drawing.Point(370, 15);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(17, 13);
            this.p.TabIndex = 14;
            this.p.Text = "P:";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(370, 41);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(17, 13);
            this.C.TabIndex = 15;
            this.C.Text = "C:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(393, 95);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(82, 368);
            this.listBox1.TabIndex = 17;
            // 
            // numargasit
            // 
            this.numargasit.AutoSize = true;
            this.numargasit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numargasit.ForeColor = System.Drawing.Color.Crimson;
            this.numargasit.Location = new System.Drawing.Point(12, 59);
            this.numargasit.Name = "numargasit";
            this.numargasit.Size = new System.Drawing.Size(286, 18);
            this.numargasit.TabIndex = 18;
            this.numargasit.Text = "Felicitari, botul a descoperit numarul!";
            // 
            // textBoxTurn
            // 
            this.textBoxTurn.Location = new System.Drawing.Point(393, 64);
            this.textBoxTurn.Name = "textBoxTurn";
            this.textBoxTurn.Size = new System.Drawing.Size(84, 20);
            this.textBoxTurn.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Turn:";
            // 
            // textBoxNumarGata
            // 
            this.textBoxNumarGata.Location = new System.Drawing.Point(42, 106);
            this.textBoxNumarGata.Name = "textBoxNumarGata";
            this.textBoxNumarGata.Size = new System.Drawing.Size(225, 20);
            this.textBoxNumarGata.TabIndex = 21;
            // 
            // Verificare
            // 
            this.Verificare.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Verificare.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Verificare.Location = new System.Drawing.Point(42, 132);
            this.Verificare.Name = "Verificare";
            this.Verificare.Size = new System.Drawing.Size(225, 27);
            this.Verificare.TabIndex = 22;
            this.Verificare.Text = "Verificare";
            this.Verificare.UseVisualStyleBackColor = false;
            this.Verificare.Click += new System.EventHandler(this.Verificare_Click);
            // 
            // numarcalculatorlabel
            // 
            this.numarcalculatorlabel.AutoSize = true;
            this.numarcalculatorlabel.Location = new System.Drawing.Point(4, 83);
            this.numarcalculatorlabel.Name = "numarcalculatorlabel";
            this.numarcalculatorlabel.Size = new System.Drawing.Size(25, 13);
            this.numarcalculatorlabel.TabIndex = 23;
            this.numarcalculatorlabel.Text = "NC:";
            this.numarcalculatorlabel.Visible = false;
            // 
            // numarutilizatorlabel
            // 
            this.numarutilizatorlabel.AutoSize = true;
            this.numarutilizatorlabel.Location = new System.Drawing.Point(4, 109);
            this.numarutilizatorlabel.Name = "numarutilizatorlabel";
            this.numarutilizatorlabel.Size = new System.Drawing.Size(26, 13);
            this.numarutilizatorlabel.TabIndex = 24;
            this.numarutilizatorlabel.Text = "NU:";
            this.numarutilizatorlabel.Visible = false;
            // 
            // ElapsedTimeLabel
            // 
            this.ElapsedTimeLabel.AutoSize = true;
            this.ElapsedTimeLabel.Location = new System.Drawing.Point(4, 168);
            this.ElapsedTimeLabel.Name = "ElapsedTimeLabel";
            this.ElapsedTimeLabel.Size = new System.Drawing.Size(34, 13);
            this.ElapsedTimeLabel.TabIndex = 25;
            this.ElapsedTimeLabel.Text = "Ceas:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelCeas
            // 
            this.labelCeas.AutoSize = true;
            this.labelCeas.Location = new System.Drawing.Point(44, 168);
            this.labelCeas.Name = "labelCeas";
            this.labelCeas.Size = new System.Drawing.Size(26, 13);
            this.labelCeas.TabIndex = 26;
            this.labelCeas.Text = "time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(485, 464);
            this.Controls.Add(this.labelCeas);
            this.Controls.Add(this.ElapsedTimeLabel);
            this.Controls.Add(this.numarutilizatorlabel);
            this.Controls.Add(this.numarcalculatorlabel);
            this.Controls.Add(this.Verificare);
            this.Controls.Add(this.textBoxNumarGata);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTurn);
            this.Controls.Add(this.numargasit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.C);
            this.Controls.Add(this.p);
            this.Controls.Add(this.textBoxc);
            this.Controls.Add(this.textBoxp);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxp;
        private System.Windows.Forms.TextBox textBoxc;
        private System.Windows.Forms.Label p;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label numargasit;
        private System.Windows.Forms.TextBox textBoxTurn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumarGata;
        private System.Windows.Forms.Button Verificare;
        private System.Windows.Forms.Label numarcalculatorlabel;
        private System.Windows.Forms.Label numarutilizatorlabel;
        private System.Windows.Forms.Label ElapsedTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelCeas;
    }
}

