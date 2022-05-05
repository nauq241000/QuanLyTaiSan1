using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace MaHoaGiaiMaConnectionString
{
    public partial class frmMaHoaGiaiMa : Form
    {
        public frmMaHoaGiaiMa()
        {
            InitializeComponent();
        }

        private static string Encrypt(string text, string key)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        private static string Decrypt(string cipher, string key)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }

        private void btnMaHoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(txtMaHoaBanRo)) || string.IsNullOrWhiteSpace(Convert.ToString(txtMaHoaKhoa)))
            {
                MessageBox.Show("Bạn phải nhập dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtMaHoaBanMa.Text = Encrypt(txtMaHoaBanRo.Text, txtMaHoaKhoa.Text);
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Convert.ToString(txtMaHoaBanRo)) || string.IsNullOrWhiteSpace(Convert.ToString(txtMaHoaKhoa)))
            {
                MessageBox.Show("Bạn phải nhập dữ liệu", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txtGiaiMaBanRo.Text = Decrypt(txtGiaiMaBanMa.Text, txtGiaiMaKhoa.Text);
            }
        }
    }
}
