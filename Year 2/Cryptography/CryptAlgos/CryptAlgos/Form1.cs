using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptAlgos
{
	public partial class Form1 : Form
	{
		//criptare/decryptare a unui fisier si alegerea unui algoritm de criptare din .net
		//fisierul destinatie
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cmbSelectAlgo.Items.Add(CryptAlgorithm.AES);
			cmbSelectAlgo.Items.Add(CryptAlgorithm.DES);
			cmbSelectAlgo.Items.Add(CryptAlgorithm.MD5);
			//cmbSelectAlgo.Items.Add(CryptAlgorithm.DSA);
			//cmbSelectAlgo.Items.Add(CryptAlgorithm.RC2);
			//cmbSelectAlgo.Items.Add(CryptAlgorithm.RSA);
			//cmbSelectAlgo.Items.Add(CryptAlgorithm.TripleDES);
			cmbSelectAlgo.SelectedIndex = 0;
		}

		private void btnBrowseFile_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			tbChoosedPath.Text = openFileDialog1.FileName;
		}

		private void btnBrowseDestination_Click(object sender, EventArgs e)
		{
			folderBrowserDialog1.ShowDialog();
			tbDestinationPath.Text = folderBrowserDialog1.SelectedPath;
		}

		private void btnProcessEncryption_Click(object sender, EventArgs e)
		{
			if (Engine.ProcessStatus(tbChoosedPath.Text, tbKey.Text, tbDestinationPath.Text, cmbSelectAlgo.SelectedItem.ToString()) == ReadyForProcessStatus.Success)
			{
				Engine.ProcessEncryption(cmbSelectAlgo.SelectedItem.ToString(), tbChoosedPath.Text, tbDestinationPath.Text + "\\" + "Crypted.txt", tbKey.Text);
			}
			else
			{
				MessageBox.Show(Engine.ProcessStatus(tbChoosedPath.Text, tbKey.Text, tbDestinationPath.Text, cmbSelectAlgo.SelectedItem.ToString()).ToString());
			}
		}

		private void btnProcessDecryption_Click(object sender, EventArgs e)
		{
			if (Engine.ProcessStatus(tbChoosedPath.Text, tbKey.Text, tbDestinationPath.Text, cmbSelectAlgo.SelectedItem.ToString()) == ReadyForProcessStatus.Success)
			{
				Engine.ProcessDecryption(cmbSelectAlgo.SelectedItem.ToString(), tbChoosedPath.Text, tbDestinationPath.Text + "\\" + "Decrypted.txt", tbKey.Text);
			}
			else
			{
				MessageBox.Show(Engine.ProcessStatus(tbChoosedPath.Text, tbKey.Text, tbDestinationPath.Text, cmbSelectAlgo.SelectedItem.ToString()).ToString());
			}
		}

		private void cmbSelectAlgo_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cmbSelectAlgo.SelectedItem.ToString() == CryptAlgorithm.AES.ToString() || cmbSelectAlgo.SelectedItem.ToString() == CryptAlgorithm.MD5.ToString())
			{
				label4.Visible = true;
				tbKey.Visible = true;
				label5.Visible = true;
				Engine.showKey = true;
			}
			else
			{
				label4.Visible = false;
				tbKey.Visible = false;
				label5.Visible = false;
				Engine.showKey = false;
			}
		}
	}
}

