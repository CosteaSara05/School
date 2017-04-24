namespace CryptAlgos
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
			this.btnBrowseFile = new System.Windows.Forms.Button();
			this.btnBrowseDestination = new System.Windows.Forms.Button();
			this.btnProcessEncryption = new System.Windows.Forms.Button();
			this.btnProcessDecryption = new System.Windows.Forms.Button();
			this.tbChoosedPath = new System.Windows.Forms.TextBox();
			this.tbDestinationPath = new System.Windows.Forms.TextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.cmbSelectAlgo = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbKey = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnBrowseFile
			// 
			this.btnBrowseFile.Location = new System.Drawing.Point(524, 47);
			this.btnBrowseFile.Name = "btnBrowseFile";
			this.btnBrowseFile.Size = new System.Drawing.Size(75, 20);
			this.btnBrowseFile.TabIndex = 0;
			this.btnBrowseFile.Text = "Browse...";
			this.btnBrowseFile.UseVisualStyleBackColor = true;
			this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
			// 
			// btnBrowseDestination
			// 
			this.btnBrowseDestination.Location = new System.Drawing.Point(524, 124);
			this.btnBrowseDestination.Name = "btnBrowseDestination";
			this.btnBrowseDestination.Size = new System.Drawing.Size(75, 20);
			this.btnBrowseDestination.TabIndex = 1;
			this.btnBrowseDestination.Text = "Browse...";
			this.btnBrowseDestination.UseVisualStyleBackColor = true;
			this.btnBrowseDestination.Click += new System.EventHandler(this.btnBrowseDestination_Click);
			// 
			// btnProcessEncryption
			// 
			this.btnProcessEncryption.Location = new System.Drawing.Point(173, 150);
			this.btnProcessEncryption.Name = "btnProcessEncryption";
			this.btnProcessEncryption.Size = new System.Drawing.Size(75, 23);
			this.btnProcessEncryption.TabIndex = 2;
			this.btnProcessEncryption.Text = "Encryption";
			this.btnProcessEncryption.UseVisualStyleBackColor = true;
			this.btnProcessEncryption.Click += new System.EventHandler(this.btnProcessEncryption_Click);
			// 
			// btnProcessDecryption
			// 
			this.btnProcessDecryption.Location = new System.Drawing.Point(314, 150);
			this.btnProcessDecryption.Name = "btnProcessDecryption";
			this.btnProcessDecryption.Size = new System.Drawing.Size(75, 23);
			this.btnProcessDecryption.TabIndex = 3;
			this.btnProcessDecryption.Text = "Decryption";
			this.btnProcessDecryption.UseVisualStyleBackColor = true;
			this.btnProcessDecryption.Click += new System.EventHandler(this.btnProcessDecryption_Click);
			// 
			// tbChoosedPath
			// 
			this.tbChoosedPath.Location = new System.Drawing.Point(118, 47);
			this.tbChoosedPath.Name = "tbChoosedPath";
			this.tbChoosedPath.ReadOnly = true;
			this.tbChoosedPath.Size = new System.Drawing.Size(400, 20);
			this.tbChoosedPath.TabIndex = 4;
			// 
			// tbDestinationPath
			// 
			this.tbDestinationPath.Location = new System.Drawing.Point(118, 124);
			this.tbDestinationPath.Name = "tbDestinationPath";
			this.tbDestinationPath.ReadOnly = true;
			this.tbDestinationPath.Size = new System.Drawing.Size(400, 20);
			this.tbDestinationPath.TabIndex = 5;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// cmbSelectAlgo
			// 
			this.cmbSelectAlgo.FormattingEnabled = true;
			this.cmbSelectAlgo.Location = new System.Drawing.Point(118, 73);
			this.cmbSelectAlgo.Name = "cmbSelectAlgo";
			this.cmbSelectAlgo.Size = new System.Drawing.Size(121, 21);
			this.cmbSelectAlgo.TabIndex = 6;
			this.cmbSelectAlgo.SelectedIndexChanged += new System.EventHandler(this.cmbSelectAlgo_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(56, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Select File";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(21, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Destionation Path";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(62, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 13);
			this.label3.TabIndex = 9;
			this.label3.Text = "Algorithm";
			// 
			// tbKey
			// 
			this.tbKey.Location = new System.Drawing.Point(118, 100);
			this.tbKey.Name = "tbKey";
			this.tbKey.Size = new System.Drawing.Size(121, 20);
			this.tbKey.TabIndex = 10;
			this.tbKey.Visible = false;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(53, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(59, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Secret Key";
			this.label4.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(245, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "*Don\'t forget this!";
			this.label5.Visible = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(628, 181);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbKey);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cmbSelectAlgo);
			this.Controls.Add(this.tbDestinationPath);
			this.Controls.Add(this.tbChoosedPath);
			this.Controls.Add(this.btnProcessDecryption);
			this.Controls.Add(this.btnProcessEncryption);
			this.Controls.Add(this.btnBrowseDestination);
			this.Controls.Add(this.btnBrowseFile);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBrowseFile;
		private System.Windows.Forms.Button btnBrowseDestination;
		private System.Windows.Forms.Button btnProcessEncryption;
		private System.Windows.Forms.Button btnProcessDecryption;
		private System.Windows.Forms.TextBox tbChoosedPath;
		private System.Windows.Forms.TextBox tbDestinationPath;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.ComboBox cmbSelectAlgo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbKey;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

