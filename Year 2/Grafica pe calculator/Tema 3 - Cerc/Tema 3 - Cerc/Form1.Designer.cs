namespace Tema_3___Cerc
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
			this.btnRandomRadius = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tbRadius = new System.Windows.Forms.TextBox();
			this.tbX = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tbY = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRandomRadius
			// 
			this.btnRandomRadius.Location = new System.Drawing.Point(280, 12);
			this.btnRandomRadius.Name = "btnRandomRadius";
			this.btnRandomRadius.Size = new System.Drawing.Size(101, 59);
			this.btnRandomRadius.TabIndex = 0;
			this.btnRandomRadius.Text = "Random Radius";
			this.btnRandomRadius.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 77);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(671, 375);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(387, 12);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(101, 59);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(494, 12);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(101, 59);
			this.button3.TabIndex = 3;
			this.button3.Text = "Draw";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Radius:";
			// 
			// tbRadius
			// 
			this.tbRadius.Location = new System.Drawing.Point(62, 11);
			this.tbRadius.Name = "tbRadius";
			this.tbRadius.Size = new System.Drawing.Size(100, 20);
			this.tbRadius.TabIndex = 8;
			this.tbRadius.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tbX
			// 
			this.tbX.Location = new System.Drawing.Point(62, 31);
			this.tbX.Name = "tbX";
			this.tbX.Size = new System.Drawing.Size(100, 20);
			this.tbX.TabIndex = 10;
			this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "X:";
			// 
			// tbY
			// 
			this.tbY.Location = new System.Drawing.Point(62, 51);
			this.tbY.Name = "tbY";
			this.tbY.Size = new System.Drawing.Size(100, 20);
			this.tbY.TabIndex = 12;
			this.tbY.TextChanged += new System.EventHandler(this.tbY_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Y:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(695, 464);
			this.Controls.Add(this.tbY);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.tbX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbRadius);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnRandomRadius);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRandomRadius;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbRadius;
		private System.Windows.Forms.TextBox tbX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tbY;
		private System.Windows.Forms.Label label3;
	}
}

