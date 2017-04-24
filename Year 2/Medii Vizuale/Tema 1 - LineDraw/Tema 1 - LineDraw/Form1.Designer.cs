namespace Tema_1___LineDraw
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnDraw = new System.Windows.Forms.Button();
			this.lblx = new System.Windows.Forms.Label();
			this.lbly = new System.Windows.Forms.Label();
			this.tbX1 = new System.Windows.Forms.TextBox();
			this.tbY1 = new System.Windows.Forms.TextBox();
			this.tbY2 = new System.Windows.Forms.TextBox();
			this.tbX2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRandomCoords = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(13, 68);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(675, 424);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// btnDraw
			// 
			this.btnDraw.Location = new System.Drawing.Point(274, 12);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(118, 51);
			this.btnDraw.TabIndex = 1;
			this.btnDraw.Text = "Draw";
			this.btnDraw.UseVisualStyleBackColor = true;
			this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
			// 
			// lblx
			// 
			this.lblx.AutoSize = true;
			this.lblx.Location = new System.Drawing.Point(16, 15);
			this.lblx.Name = "lblx";
			this.lblx.Size = new System.Drawing.Size(17, 13);
			this.lblx.TabIndex = 2;
			this.lblx.Text = "X:";
			// 
			// lbly
			// 
			this.lbly.AutoSize = true;
			this.lbly.Location = new System.Drawing.Point(145, 15);
			this.lbly.Name = "lbly";
			this.lbly.Size = new System.Drawing.Size(17, 13);
			this.lbly.TabIndex = 3;
			this.lbly.Text = "Y:";
			// 
			// tbX1
			// 
			this.tbX1.Location = new System.Drawing.Point(39, 12);
			this.tbX1.Name = "tbX1";
			this.tbX1.Size = new System.Drawing.Size(100, 20);
			this.tbX1.TabIndex = 4;
			this.tbX1.TextChanged += new System.EventHandler(this.tbX1_TextChanged);
			// 
			// tbY1
			// 
			this.tbY1.Location = new System.Drawing.Point(168, 12);
			this.tbY1.Name = "tbY1";
			this.tbY1.Size = new System.Drawing.Size(100, 20);
			this.tbY1.TabIndex = 5;
			this.tbY1.TextChanged += new System.EventHandler(this.tbY1_TextChanged);
			// 
			// tbY2
			// 
			this.tbY2.Location = new System.Drawing.Point(168, 42);
			this.tbY2.Name = "tbY2";
			this.tbY2.Size = new System.Drawing.Size(100, 20);
			this.tbY2.TabIndex = 9;
			this.tbY2.TextChanged += new System.EventHandler(this.tbY2_TextChanged);
			// 
			// tbX2
			// 
			this.tbX2.Location = new System.Drawing.Point(39, 42);
			this.tbX2.Name = "tbX2";
			this.tbX2.Size = new System.Drawing.Size(100, 20);
			this.tbX2.TabIndex = 8;
			this.tbX2.TextChanged += new System.EventHandler(this.tbX2_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(145, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Y:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "X:";
			// 
			// btnRandomCoords
			// 
			this.btnRandomCoords.Location = new System.Drawing.Point(398, 11);
			this.btnRandomCoords.Name = "btnRandomCoords";
			this.btnRandomCoords.Size = new System.Drawing.Size(118, 51);
			this.btnRandomCoords.TabIndex = 10;
			this.btnRandomCoords.Text = "Random Coords";
			this.btnRandomCoords.UseVisualStyleBackColor = true;
			this.btnRandomCoords.Click += new System.EventHandler(this.btnRandomCoords_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(522, 11);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(118, 51);
			this.btnClear.TabIndex = 11;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 504);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnRandomCoords);
			this.Controls.Add(this.tbY2);
			this.Controls.Add(this.tbX2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tbY1);
			this.Controls.Add(this.tbX1);
			this.Controls.Add(this.lbly);
			this.Controls.Add(this.lblx);
			this.Controls.Add(this.btnDraw);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnDraw;
		private System.Windows.Forms.Label lblx;
		private System.Windows.Forms.Label lbly;
		private System.Windows.Forms.TextBox tbX1;
		private System.Windows.Forms.TextBox tbY1;
		private System.Windows.Forms.TextBox tbY2;
		private System.Windows.Forms.TextBox tbX2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRandomCoords;
		private System.Windows.Forms.Button btnClear;
	}
}

