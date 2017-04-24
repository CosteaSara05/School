using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace CryptAlgos
{
	public class MyMD5
	{
		// This constant is used to determine the keysize of the encryption algorithm in bits.
		// We divide this by 8 within the code below to get the equivalent number of bytes.
		private const int Keysize = 256;

		// This constant determines the number of iterations for the password bytes generation function.
		private const int DerivationIterations = 1000;

		public static string Encrypt(string plainText, string passPhrase)
		{
			// Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
			// so that the same Salt and IV values can be used when decrypting.  
			var saltStringBytes = Generate256BitsOfRandomEntropy();
			var ivStringBytes = Generate256BitsOfRandomEntropy();
			var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
			using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
			{
				var keyBytes = password.GetBytes(Keysize / 8);
				using (var symmetricKey = new RijndaelManaged())
				{
					symmetricKey.BlockSize = 256;
					symmetricKey.Mode = CipherMode.CBC;
					symmetricKey.Padding = PaddingMode.PKCS7;
					using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
					{
						using (var memoryStream = new MemoryStream())
						{
							using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
							{
								cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
								cryptoStream.FlushFinalBlock();
								// Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
								var cipherTextBytes = saltStringBytes;
								cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
								cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
								memoryStream.Close();
								cryptoStream.Close();
								return Convert.ToBase64String(cipherTextBytes);
							}
						}
					}
				}
			}
		}

		public static string Decrypt(string cipherText, string passPhrase)
		{
			// Get the complete stream of bytes that represent:
			// [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
			var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
			// Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
			var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
			// Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
			var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
			// Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
			var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

			using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
			{
				var keyBytes = password.GetBytes(Keysize / 8);
				using (var symmetricKey = new RijndaelManaged())
				{
					symmetricKey.BlockSize = 256;
					symmetricKey.Mode = CipherMode.CBC;
					symmetricKey.Padding = PaddingMode.PKCS7;
					using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
					{
						using (var memoryStream = new MemoryStream(cipherTextBytes))
						{
							using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
							{
								var plainTextBytes = new byte[cipherTextBytes.Length];
								var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
								memoryStream.Close();
								cryptoStream.Close();
								return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
							}
						}
					}
				}
			}
		}

		private static byte[] Generate256BitsOfRandomEntropy()
		{
			var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
			using (var rngCsp = new RNGCryptoServiceProvider())
			{
				// Fill the array with cryptographically secure random bytes.
				rngCsp.GetBytes(randomBytes);
			}
			return randomBytes;
		}
	}

	public class MyDES
	{
		private static byte[] _salt = Encoding.ASCII.GetBytes("ZeroCool");

		/// <span class="code-SummaryComment"><summary></span>
		/// Encrypt a string.
		/// <span class="code-SummaryComment"></summary></span>
		/// <span class="code-SummaryComment"><param name="originalString">The original string.</param></span>
		/// <span class="code-SummaryComment"><returns>The encrypted string.</returns></span>
		/// <span class="code-SummaryComment"><exception cref="ArgumentNullException">This exception will be </span>
		/// thrown when the original string is null or empty.<span class="code-SummaryComment"></exception></span>
		public static string Encrypt(string originalString)
		{
			DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream();
			CryptoStream cryptoStream = new CryptoStream(memoryStream,
				cryptoProvider.CreateEncryptor(_salt, _salt), CryptoStreamMode.Write);
			StreamWriter writer = new StreamWriter(cryptoStream);
			writer.Write(originalString);
			writer.Flush();
			cryptoStream.FlushFinalBlock();
			writer.Flush();
			return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
		}

		/// <span class="code-SummaryComment"><summary></span>
		/// Decrypt a crypted string.
		/// <span class="code-SummaryComment"></summary></span>
		/// <span class="code-SummaryComment"><param name="cryptedString">The crypted string.</param></span>
		/// <span class="code-SummaryComment"><returns>The decrypted string.</returns></span>
		/// <span class="code-SummaryComment"><exception cref="ArgumentNullException">This exception will be thrown </span>
		/// when the crypted string is null or empty.<span class="code-SummaryComment"></exception></span>
		public static string Decrypt(string cryptedString)
		{
			if (String.IsNullOrEmpty(cryptedString))
			{
				throw new ArgumentNullException
				   ("The string which needs to be decrypted can not be null.");
			}
			DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
			MemoryStream memoryStream = new MemoryStream
					(Convert.FromBase64String(cryptedString));
			CryptoStream cryptoStream = new CryptoStream(memoryStream,
				cryptoProvider.CreateDecryptor(_salt, _salt), CryptoStreamMode.Read);
			StreamReader reader = new StreamReader(cryptoStream);
			return reader.ReadToEnd();
		}
	}

	public class MyAES
	{
		private static byte[] _salt = Encoding.ASCII.GetBytes("o6806642kbM7c5");

		/// <summary>
		/// Encrypt the given string using AES.  The string can be decrypted using 
		/// DecryptStringAES().  The sharedSecret parameters must match.
		/// </summary>
		/// <param name="plainText">The text to encrypt.</param>
		/// <param name="sharedSecret">A password used to generate a key for encryption.</param>
		public static string Encrypt(string plainText, string sharedSecret)
		{
			string outStr = null;                       // Encrypted string to return
			RijndaelManaged aesAlg = null;              // RijndaelManaged object used to encrypt the data.

			try
			{
				// generate the key from the shared secret and the salt
				Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

				// Create a RijndaelManaged object
				aesAlg = new RijndaelManaged();
				aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

				// Create a decryptor to perform the stream transform.
				ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

				// Create the streams used for encryption.
				using (MemoryStream msEncrypt = new MemoryStream())
				{
					// prepend the IV
					msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
					msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
					using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
					{
						using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
						{
							//Write all data to the stream.
							swEncrypt.Write(plainText);
						}
					}
					outStr = Convert.ToBase64String(msEncrypt.ToArray());
				}
			}
			finally
			{
				// Clear the RijndaelManaged object.
				if (aesAlg != null)
					aesAlg.Clear();
			}

			// Return the encrypted bytes from the memory stream.
			return outStr;
		}

		/// <summary>
		/// Decrypt the given string.  Assumes the string was encrypted using 
		/// EncryptStringAES(), using an identical sharedSecret.
		/// </summary>
		/// <param name="cipherText">The text to decrypt.</param>
		/// <param name="sharedSecret">A password used to generate a key for decryption.</param>
		public static string Decrypt(string cipherText, string sharedSecret)
		{
			// Declare the RijndaelManaged object
			// used to decrypt the data
			RijndaelManaged aesAlg = null;

			// Declare the string used to hold
			// the decrypted text
			string plaintext = null;

			try
			{
				// generate the key from the shared secret and the salt
				Rfc2898DeriveBytes key = new Rfc2898DeriveBytes(sharedSecret, _salt);

				// Create the streams used for decryption.                
				byte[] bytes = Convert.FromBase64String(cipherText);
				using (MemoryStream msDecrypt = new MemoryStream(bytes))
				{
					// Create a RijndaelManaged object
					// with the specified key and IV.
					aesAlg = new RijndaelManaged();
					aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
					// Get the initialization vector from the encrypted stream
					aesAlg.IV = ReadByteArray(msDecrypt);
					// Create a decrytor to perform the stream transform.
					ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
					using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
					{
						using (StreamReader srDecrypt = new StreamReader(csDecrypt))

							// Read the decrypted bytes from the decrypting stream
							// and place them in a string.
							plaintext = srDecrypt.ReadToEnd();
					}
				}
			}
			finally
			{
				// Clear the RijndaelManaged object.
				if (aesAlg != null)
					aesAlg.Clear();
			}

			return plaintext;
		}

		private static byte[] ReadByteArray(Stream s)
		{
			byte[] rawLength = new byte[sizeof(int)];
			if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
			{
				MessageBox.Show("Stream did not contain properly formatted byte array");
			}

			byte[] buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
			if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
			{
				MessageBox.Show("Did not read byte array properly");
			}

			return buffer;
		}
	}
}
