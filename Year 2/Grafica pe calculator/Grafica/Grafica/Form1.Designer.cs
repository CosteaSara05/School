﻿namespace Grafica
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.tbNewY = new System.Windows.Forms.TextBox();
			this.tbNewX = new System.Windows.Forms.TextBox();
			this.btnGenTri = new System.Windows.Forms.Button();
			this.btnGenPat = new System.Windows.Forms.Button();
			this.btnGenDre = new System.Windows.Forms.Button();
			this.btnGenTranslatie = new System.Windows.Forms.Button();
			this.btnGenScalar = new System.Windows.Forms.Button();
			this.tbDrawX = new System.Windows.Forms.TextBox();
			this.tbDrawY = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.AvInfoPanel = new System.Windows.Forms.Panel();
			this.tbScalarea = new System.Windows.Forms.TextBox();
			this.tbTranslatia = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnInfo = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnScalar = new System.Windows.Forms.Button();
			this.btnTrans = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.AvInfoPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBox
			// 
			this.pictureBox.Location = new System.Drawing.Point(0, 75);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(838, 407);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// tbNewY
			// 
			this.tbNewY.Location = new System.Drawing.Point(136, 38);
			this.tbNewY.Name = "tbNewY";
			this.tbNewY.Size = new System.Drawing.Size(72, 20);
			this.tbNewY.TabIndex = 6;
			this.toolTip.SetToolTip(this.tbNewY, "Coordonata de mutare");
			// 
			// tbNewX
			// 
			this.tbNewX.Location = new System.Drawing.Point(31, 38);
			this.tbNewX.Name = "tbNewX";
			this.tbNewX.Size = new System.Drawing.Size(72, 20);
			this.tbNewX.TabIndex = 5;
			this.toolTip.SetToolTip(this.tbNewX, "Coordonata de mutare");
			// 
			// btnGenTri
			// 
			this.btnGenTri.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnGenTri.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnGenTri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGenTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenTri.ForeColor = System.Drawing.Color.Black;
			this.btnGenTri.Location = new System.Drawing.Point(286, 12);
			this.btnGenTri.Name = "btnGenTri";
			this.btnGenTri.Size = new System.Drawing.Size(65, 53);
			this.btnGenTri.TabIndex = 16;
			this.btnGenTri.Text = "Triunghi";
			this.toolTip.SetToolTip(this.btnGenTri, "Generare Triunghi");
			this.btnGenTri.UseVisualStyleBackColor = false;
			this.btnGenTri.Click += new System.EventHandler(this.btnGenTri_Click);
			// 
			// btnGenPat
			// 
			this.btnGenPat.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnGenPat.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnGenPat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGenPat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenPat.ForeColor = System.Drawing.Color.Black;
			this.btnGenPat.Location = new System.Drawing.Point(351, 12);
			this.btnGenPat.Name = "btnGenPat";
			this.btnGenPat.Size = new System.Drawing.Size(50, 53);
			this.btnGenPat.TabIndex = 17;
			this.btnGenPat.Text = "Patrat";
			this.toolTip.SetToolTip(this.btnGenPat, "Generare Patrat");
			this.btnGenPat.UseVisualStyleBackColor = false;
			this.btnGenPat.Click += new System.EventHandler(this.btnGenPat_Click);
			// 
			// btnGenDre
			// 
			this.btnGenDre.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.btnGenDre.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnGenDre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGenDre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenDre.ForeColor = System.Drawing.Color.Black;
			this.btnGenDre.Location = new System.Drawing.Point(401, 12);
			this.btnGenDre.Name = "btnGenDre";
			this.btnGenDre.Size = new System.Drawing.Size(77, 53);
			this.btnGenDre.TabIndex = 18;
			this.btnGenDre.Text = "Dreptunghi";
			this.toolTip.SetToolTip(this.btnGenDre, "Generare Dreptunghi");
			this.btnGenDre.UseVisualStyleBackColor = false;
			this.btnGenDre.Click += new System.EventHandler(this.btnGenDre_Click);
			// 
			// btnGenTranslatie
			// 
			this.btnGenTranslatie.BackColor = System.Drawing.Color.DarkCyan;
			this.btnGenTranslatie.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnGenTranslatie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGenTranslatie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenTranslatie.ForeColor = System.Drawing.Color.Black;
			this.btnGenTranslatie.Location = new System.Drawing.Point(501, 5);
			this.btnGenTranslatie.Name = "btnGenTranslatie";
			this.btnGenTranslatie.Size = new System.Drawing.Size(236, 29);
			this.btnGenTranslatie.TabIndex = 19;
			this.btnGenTranslatie.Text = "Generare Translatie";
			this.toolTip.SetToolTip(this.btnGenTranslatie, "Translatarea formei");
			this.btnGenTranslatie.UseVisualStyleBackColor = false;
			this.btnGenTranslatie.Visible = false;
			this.btnGenTranslatie.Click += new System.EventHandler(this.btnGenTranslatie_Click);
			// 
			// btnGenScalar
			// 
			this.btnGenScalar.BackColor = System.Drawing.Color.DarkCyan;
			this.btnGenScalar.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnGenScalar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnGenScalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGenScalar.ForeColor = System.Drawing.Color.Black;
			this.btnGenScalar.Location = new System.Drawing.Point(501, 36);
			this.btnGenScalar.Name = "btnGenScalar";
			this.btnGenScalar.Size = new System.Drawing.Size(236, 29);
			this.btnGenScalar.TabIndex = 21;
			this.btnGenScalar.Text = "Generare Scalar";
			this.toolTip.SetToolTip(this.btnGenScalar, "Translatarea formei");
			this.btnGenScalar.UseVisualStyleBackColor = false;
			this.btnGenScalar.Visible = false;
			this.btnGenScalar.Click += new System.EventHandler(this.btnScalar_Click);
			// 
			// tbDrawX
			// 
			this.tbDrawX.Location = new System.Drawing.Point(31, 12);
			this.tbDrawX.Name = "tbDrawX";
			this.tbDrawX.Size = new System.Drawing.Size(72, 20);
			this.tbDrawX.TabIndex = 1;
			// 
			// tbDrawY
			// 
			this.tbDrawY.Location = new System.Drawing.Point(136, 12);
			this.tbDrawY.Name = "tbDrawY";
			this.tbDrawY.Size = new System.Drawing.Size(72, 20);
			this.tbDrawY.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "X:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(113, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(17, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Y:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(113, 41);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(17, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Y:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 41);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(17, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "X:";
			// 
			// AvInfoPanel
			// 
			this.AvInfoPanel.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
			this.AvInfoPanel.BackColor = System.Drawing.Color.Red;
			this.AvInfoPanel.Controls.Add(this.tbScalarea);
			this.AvInfoPanel.Controls.Add(this.tbTranslatia);
			this.AvInfoPanel.Controls.Add(this.btnClose);
			this.AvInfoPanel.Location = new System.Drawing.Point(0, 165);
			this.AvInfoPanel.Name = "AvInfoPanel";
			this.AvInfoPanel.Size = new System.Drawing.Size(838, 138);
			this.AvInfoPanel.TabIndex = 12;
			this.AvInfoPanel.Visible = false;
			// 
			// tbScalarea
			// 
			this.tbScalarea.BackColor = System.Drawing.Color.Red;
			this.tbScalarea.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbScalarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbScalarea.ForeColor = System.Drawing.SystemColors.Window;
			this.tbScalarea.Location = new System.Drawing.Point(3, 58);
			this.tbScalarea.Multiline = true;
			this.tbScalarea.Name = "tbScalarea";
			this.tbScalarea.ReadOnly = true;
			this.tbScalarea.Size = new System.Drawing.Size(832, 49);
			this.tbScalarea.TabIndex = 6;
			this.tbScalarea.Text = resources.GetString("tbScalarea.Text");
			this.tbScalarea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbTranslatia
			// 
			this.tbTranslatia.BackColor = System.Drawing.Color.Red;
			this.tbTranslatia.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbTranslatia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTranslatia.ForeColor = System.Drawing.SystemColors.Window;
			this.tbTranslatia.Location = new System.Drawing.Point(3, 3);
			this.tbTranslatia.Multiline = true;
			this.tbTranslatia.Name = "tbTranslatia";
			this.tbTranslatia.ReadOnly = true;
			this.tbTranslatia.Size = new System.Drawing.Size(832, 49);
			this.tbTranslatia.TabIndex = 5;
			this.tbTranslatia.Text = resources.GetString("tbTranslatia.Text");
			this.tbTranslatia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.Gold;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.Crimson;
			this.btnClose.Location = new System.Drawing.Point(760, 112);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnInfo
			// 
			this.btnInfo.BackColor = System.Drawing.Color.Gray;
			this.btnInfo.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnInfo.ForeColor = System.Drawing.Color.Black;
			this.btnInfo.Location = new System.Drawing.Point(214, 12);
			this.btnInfo.Name = "btnInfo";
			this.btnInfo.Size = new System.Drawing.Size(58, 53);
			this.btnInfo.TabIndex = 13;
			this.btnInfo.Text = "Info";
			this.btnInfo.UseVisualStyleBackColor = false;
			this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
			// 
			// btnClear
			// 
			this.btnClear.BackColor = System.Drawing.Color.Red;
			this.btnClear.Cursor = System.Windows.Forms.Cursors.Default;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClear.ForeColor = System.Drawing.Color.Black;
			this.btnClear.Location = new System.Drawing.Point(752, 5);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 64);
			this.btnClear.TabIndex = 15;
			this.btnClear.Text = "Sterge";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnScalar
			// 
			this.btnScalar.BackColor = System.Drawing.Color.Yellow;
			this.btnScalar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnScalar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnScalar.Location = new System.Drawing.Point(501, 36);
			this.btnScalar.Name = "btnScalar";
			this.btnScalar.Size = new System.Drawing.Size(236, 29);
			this.btnScalar.TabIndex = 22;
			this.btnScalar.Text = "Scalare";
			this.btnScalar.UseVisualStyleBackColor = false;
			this.btnScalar.Click += new System.EventHandler(this.Scalar_Click);
			// 
			// btnTrans
			// 
			this.btnTrans.BackColor = System.Drawing.Color.Yellow;
			this.btnTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnTrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrans.Location = new System.Drawing.Point(501, 5);
			this.btnTrans.Name = "btnTrans";
			this.btnTrans.Size = new System.Drawing.Size(236, 29);
			this.btnTrans.TabIndex = 23;
			this.btnTrans.Text = "Translatie";
			this.btnTrans.UseVisualStyleBackColor = false;
			this.btnTrans.Click += new System.EventHandler(this.Trans_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 480);
			this.Controls.Add(this.btnTrans);
			this.Controls.Add(this.btnScalar);
			this.Controls.Add(this.btnGenScalar);
			this.Controls.Add(this.btnGenTranslatie);
			this.Controls.Add(this.btnGenDre);
			this.Controls.Add(this.btnGenPat);
			this.Controls.Add(this.btnGenTri);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnInfo);
			this.Controls.Add(this.AvInfoPanel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbNewY);
			this.Controls.Add(this.tbNewX);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDrawY);
			this.Controls.Add(this.tbDrawX);
			this.Controls.Add(this.pictureBox);
			this.Name = "Form1";
			this.Text = "Transformari geometrice scalare si de translatie";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.AvInfoPanel.ResumeLayout(false);
			this.AvInfoPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

	}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox;
	private System.Windows.Forms.ToolTip toolTip;
	private System.Windows.Forms.TextBox tbDrawX;
	private System.Windows.Forms.TextBox tbDrawY;
	private System.Windows.Forms.Label label1;
	private System.Windows.Forms.Label label2;
	private System.Windows.Forms.Label label3;
	private System.Windows.Forms.Label label4;
	private System.Windows.Forms.TextBox tbNewY;
	private System.Windows.Forms.TextBox tbNewX;
	private System.Windows.Forms.Panel AvInfoPanel;
	private System.Windows.Forms.TextBox tbScalarea;
	private System.Windows.Forms.TextBox tbTranslatia;
	private System.Windows.Forms.Button btnClose;
	private System.Windows.Forms.Button btnInfo;
	private System.Windows.Forms.Button btnClear;
	private System.Windows.Forms.Button btnGenTri;
	private System.Windows.Forms.Button btnGenPat;
	private System.Windows.Forms.Button btnGenDre;
	private System.Windows.Forms.Button btnGenTranslatie;
	private System.Windows.Forms.Button btnGenScalar;
		private System.Windows.Forms.Button btnScalar;
		private System.Windows.Forms.Button btnTrans;
	}
}

