namespace Tema_2___Draw_Forms
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRandomCoords = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnDraw = new System.Windows.Forms.Button();
			this.lblX0 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblX1 = new System.Windows.Forms.Label();
			this.lblY1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbX0 = new System.Windows.Forms.TextBox();
			this.tbY0 = new System.Windows.Forms.TextBox();
			this.tbX1 = new System.Windows.Forms.TextBox();
			this.tbY1 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRandomCoords
			// 
			this.btnRandomCoords.Location = new System.Drawing.Point(354, 13);
			this.btnRandomCoords.Name = "btnRandomCoords";
			this.btnRandomCoords.Size = new System.Drawing.Size(124, 57);
			this.btnRandomCoords.TabIndex = 0;
			this.btnRandomCoords.Text = "Random Coords";
			this.btnRandomCoords.UseVisualStyleBackColor = true;
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(484, 12);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(124, 57);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnDraw
			// 
			this.btnDraw.Location = new System.Drawing.Point(614, 12);
			this.btnDraw.Name = "btnDraw";
			this.btnDraw.Size = new System.Drawing.Size(124, 57);
			this.btnDraw.TabIndex = 2;
			this.btnDraw.Text = "Draw";
			this.btnDraw.UseVisualStyleBackColor = true;
			// 
			// lblX0
			// 
			this.lblX0.AutoSize = true;
			this.lblX0.Location = new System.Drawing.Point(24, 12);
			this.lblX0.Name = "lblX0";
			this.lblX0.Size = new System.Drawing.Size(23, 13);
			this.lblX0.TabIndex = 3;
			this.lblX0.Text = "X0:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(24, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(23, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Y0:";
			// 
			// lblX1
			// 
			this.lblX1.AutoSize = true;
			this.lblX1.Location = new System.Drawing.Point(172, 12);
			this.lblX1.Name = "lblX1";
			this.lblX1.Size = new System.Drawing.Size(23, 13);
			this.lblX1.TabIndex = 5;
			this.lblX1.Text = "X1:";
			// 
			// lblY1
			// 
			this.lblY1.AutoSize = true;
			this.lblY1.Location = new System.Drawing.Point(172, 44);
			this.lblY1.Name = "lblY1";
			this.lblY1.Size = new System.Drawing.Size(23, 13);
			this.lblY1.TabIndex = 6;
			this.lblY1.Text = "Y1:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 76);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(839, 425);
			this.pictureBox1.TabIndex = 7;
			this.pictureBox1.TabStop = false;
			// 
			// tbX0
			// 
			this.tbX0.Location = new System.Drawing.Point(53, 9);
			this.tbX0.Name = "tbX0";
			this.tbX0.Size = new System.Drawing.Size(100, 20);
			this.tbX0.TabIndex = 8;
			// 
			// tbY0
			// 
			this.tbY0.Location = new System.Drawing.Point(53, 41);
			this.tbY0.Name = "tbY0";
			this.tbY0.Size = new System.Drawing.Size(100, 20);
			this.tbY0.TabIndex = 9;
			// 
			// tbX1
			// 
			this.tbX1.Location = new System.Drawing.Point(201, 9);
			this.tbX1.Name = "tbX1";
			this.tbX1.Size = new System.Drawing.Size(100, 20);
			this.tbX1.TabIndex = 10;
			// 
			// tbY1
			// 
			this.tbY1.Location = new System.Drawing.Point(201, 41);
			this.tbY1.Name = "tbY1";
			this.tbY1.Size = new System.Drawing.Size(100, 20);
			this.tbY1.TabIndex = 11;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(863, 513);
			this.Controls.Add(this.tbY1);
			this.Controls.Add(this.tbX1);
			this.Controls.Add(this.tbY0);
			this.Controls.Add(this.tbX0);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblY1);
			this.Controls.Add(this.lblX1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lblX0);
			this.Controls.Add(this.btnDraw);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnRandomCoords);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRandomCoords;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnDraw;
		private System.Windows.Forms.Label lblX0;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lblX1;
		private System.Windows.Forms.Label lblY1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox tbX0;
		private System.Windows.Forms.TextBox tbY0;
		private System.Windows.Forms.TextBox tbX1;
		private System.Windows.Forms.TextBox tbY1;
	}
}

