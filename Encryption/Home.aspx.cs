using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Encryption
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void PlainText_TextChanged(object sender, EventArgs e)
        //{
        //    //PlainText.Text = "P<INDJACOB<<AJITH<<<<<<<<<<<<<<<<<<<<<<<<<<<J1234567<5IND8208020M2103134<<<<<<<<<6";
        //    if (CyberTextKey.Text == null) throw new ArgumentNullException("CyberTextKey null");
        //    if (PlainText.Text == null || PlainText.Text.Length <= 0) throw new ArgumentNullException("plainText");
        //    byte[] array;
        //    using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
        //    {
        //        rijndaelManaged.Mode = CipherMode.CBC;
        //        rijndaelManaged.Padding = PaddingMode.PKCS7;
        //        rijndaelManaged.FeedbackSize = 128;
        //        rijndaelManaged.Key = Encoding.UTF8.GetBytes(CyberTextKey.Text);
        //        rijndaelManaged.IV = Encoding.UTF8.GetBytes(CyberTextKey.Text);
        //        ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
        //        using (MemoryStream memoryStream = new MemoryStream())
        //        {
        //            using (CryptoStream cryptoStream = new CryptoStream((Stream)memoryStream, encryptor, CryptoStreamMode.Write))
        //            {
        //                using (StreamWriter streamWriter = new StreamWriter((Stream)cryptoStream)) streamWriter.Write(PlainText.Text);
        //                array = memoryStream.ToArray();
        //            }
        //        }
        //    }
        //    lblencrpttext.Text = Convert.ToBase64String(array);
        //}
        /// <summary>
        /// Checks if a string is base64 encoded
        /// </summary>
        /// <param name="base64String" />The base64 encoded string
        /// <returns>Base64 encoded stringt</returns>
        public static bool IsBase64String(string base64String)
        {
            base64String = base64String.Trim();
            return (base64String.Length % 4 == 0) && Regex.IsMatch(base64String, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None);
        }
        //protected void EncryptedText_TextChanged(object sender, EventArgs e)
        //{
        //    if (CyberTextKey.Text == null) throw new ArgumentNullException("CyberTextKey null");
        //    byte[] tokenbyte = IsBase64String(EncryptedText.Text) ? Convert.FromBase64String(EncryptedText.Text) : Convert.FromBase64String(string.Empty);
        //    string decodedtoken = Encoding.UTF8.GetString(tokenbyte);
        //    byte[] CypherText = Convert.FromBase64String(decodedtoken.ToString());
        //    var keybytes = Encoding.UTF8.GetBytes(CyberTextKey.Text);
        //    var iv = Encoding.UTF8.GetBytes(CyberTextKey.Text);
        //    // Declare the string used to hold
        //    // the decrypted text.
        //    string plaintext = string.Empty;
        //    //CryptoStream csDecrypt = null;
        //    //MemoryStream msDecrypt = null;
        //    //RijndaelManaged rijAlg = null;
        //    try
        //    {
        //        // Create an RijndaelManaged object
        //        // with the specified key and IV.
        //        RijndaelManaged rijAlg = new RijndaelManaged
        //        {
        //            Mode = CipherMode.CBC,
        //            Padding = PaddingMode.PKCS7,
        //            FeedbackSize = 128,

        //            Key = keybytes,
        //            IV = iv
        //        };
        //        // Create a decrytor to perform the stream transform.
        //        ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
        //        // Create the streams used for decryption.
        //        MemoryStream msDecrypt = new MemoryStream(CypherText);
        //        CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
        //        StreamReader srDecrypt = new StreamReader(csDecrypt);

        //        // Read the decrypted bytes from the decrypting stream
        //        // and place them in a string.
        //        plaintext = srDecrypt.ReadToEnd();
        //        srDecrypt.Dispose();
        //        csDecrypt.Dispose();
        //        msDecrypt.Dispose();
        //        rijAlg.Dispose();
        //        lblpalaintext.Text = plaintext;
        //    }
        //    catch (Exception ex) when (ex is IOException || ex is FileNotFoundException || ex is ArgumentException || ex is NullReferenceException)
        //    {
        //        lblpalaintext.Text = ex.Message;
        //    }
        //}

        protected void btnCompute_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Number1.Text);
            int b = Convert.ToInt32(Number2.Text);
            var sum = a + b;
            MessageBox.Show((sum.ToString()));
        }
    }
}