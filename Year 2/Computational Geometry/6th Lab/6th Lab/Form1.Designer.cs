﻿namespace _6th_Lab
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
			this.BtnAddPoints = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(12, 91);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(1068, 510);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// BtnAddPoints
			// 
			this.BtnAddPoints.Location = new System.Drawing.Point(12, 62);
			this.BtnAddPoints.Name = "BtnAddPoints";
			this.BtnAddPoints.Size = new System.Drawing.Size(75, 23);
			this.BtnAddPoints.TabIndex = 1;
			this.BtnAddPoints.Text = "Add Points";
			this.BtnAddPoints.UseVisualStyleBackColor = true;
			this.BtnAddPoints.Click += new System.EventHandler(this.BtnAddPoints_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(93, 62);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Draw Polygon";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(227, 62);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(128, 23);
			this.button2.TabIndex = 3;
			this.button2.Text = "Triangulate it!";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1092, 613);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.BtnAddPoints);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button BtnAddPoints;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}
