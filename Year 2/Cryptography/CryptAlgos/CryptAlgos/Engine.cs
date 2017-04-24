using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;

namespace CryptAlgos
{
	public enum ReadyForProcessStatus
	{
		NoChoosedPathSelected = 0,
		NoDestinationPathSelected = 1,
		NoEncryptionAlgorithmSelected = 2,
		Success = 3,
		NoSecretKey = 4,
		AnotherFileWithTheSameNameExists = 5
	}

	public enum CryptAlgorithm
	{
		AES = 0,
		DES = 1,
		MD5 = 2,
		DSA = 3,
		RC2 = 4,
		RSA = 5,
		TripleDES = 6
	}

	class Engine
	{
		public static string content = "";
		public static bool showKey = false;

		public static ReadyForProcessStatus ProcessStatus(string choosedPath, string key, string destinationPath, string algo)
		{
			if (choosedPath == "")
			{
				return ReadyForProcessStatus.NoChoosedPathSelected;
			}
			else if (destinationPath == "")
			{
				return ReadyForProcessStatus.NoDestinationPathSelected;
			}
			else if (algo == "")
			{
				return ReadyForProcessStatus.NoEncryptionAlgorithmSelected;
			}
			else if ((key == "") && (showKey))
			{
				return ReadyForProcessStatus.NoSecretKey;
			}
			else
			{
				return ReadyForProcessStatus.Success;
			}
		}

		public static void ProcessEncryption(string algo, string choosedPath, string destinationPath, string key)
		{
			content = FileToString(choosedPath);
			string changedContent = "", message = "Success Crypted";
			if (algo == CryptAlgorithm.AES.ToString())
			{
				changedContent = MyAES.Encrypt(content, key);
			}
			else if (algo == CryptAlgorithm.DES.ToString())
			{
				changedContent = MyDES.Encrypt(content);
			}
			else if (algo == CryptAlgorithm.MD5.ToString())
			{
				changedContent = MyMD5.Encrypt(content, key);
			}
			StringToFile(changedContent, destinationPath, message);
		}

		public static void ProcessDecryption(string algo, string choosedPath, string destinationPath, string key)
		{
			content = FileToString(choosedPath);
			string changedContent = "", message = "Success Decrypted";
			if (algo == CryptAlgorithm.AES.ToString())
			{
				changedContent = MyAES.Decrypt(content, key);
			}
			else if (algo == CryptAlgorithm.DES.ToString())
			{
				changedContent = MyDES.Decrypt(content);
			}
			else if (algo == CryptAlgorithm.MD5.ToString())
			{
				changedContent = MyMD5.Decrypt(content, key);
			}
			StringToFile(changedContent, destinationPath, message);
		}

		public static string FileToString(string path)
		{
			return content = File.ReadAllText(path);
		}

		public static void StringToFile(string contentHere, string path, string message)
		{
			if (!File.Exists(path))
			{
				File.WriteAllText(path, contentHere);
				MessageBox.Show(message);
			}
			else
			{
				MessageBox.Show(ReadyForProcessStatus.AnotherFileWithTheSameNameExists.ToString());
			}
		}
	}
}
