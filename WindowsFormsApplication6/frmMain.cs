using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace DesktopTOTPGenerator
{
    public partial class frmMain : Form
    {

        long prethodniInterval;
        public frmMain()
        {
            InitializeComponent();
        }

      	

        private void btnGeneriraj_Click(object sender, EventArgs e)
        {
            if (txtKljuc.TextLength == 16)
            {
                timer1.Start();
            }
            else 
            {
                MessageBox.Show("Neispravno unesen tajni kljuc! Kljuc mora biti dužine 16 znakova...\n (razmaci se automatski brišu i ne utječu na generiranje TOTP-a)");
            }
        }
        // Autor metode GeneratePassword je Rick Bassham, kod je dostupan na sljedećem linku:http://www.codeproject.com/Articles/403355/Implementing-Two-Factor-Authentication-in-ASP-NET
        public static string GeneratePassword(string secret, long iterationNumber, int digits = 6)
        {
            byte[] counter = BitConverter.GetBytes(iterationNumber);

            if (BitConverter.IsLittleEndian)
                Array.Reverse(counter);

            byte[] key = Base32.FromBase32String(secret);
          
            HMACSHA1 hmac = new HMACSHA1(key, true);

            byte[] hash = hmac.ComputeHash(counter);

            int offset = hash[hash.Length - 1] & 0xf;
            
            int binary =
                ((hash[offset] & 0x7f) << 24)
                | ((hash[offset + 1] & 0xff) << 16)
                | ((hash[offset + 2] & 0xff) << 8)
                | (hash[offset + 3] & 0xff);

            int password = binary % (int)Math.Pow(10, digits); // 6 digits

            return password.ToString(new string('0', digits));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            long trenutniInterval = Timestamp();
            if (prethodniInterval != trenutniInterval)
            {
                String kljuc = txtKljuc.Text;
                txtTOTP.Text = GeneratePassword(kljuc, Timestamp());
                prethodniInterval = trenutniInterval;
            }
        }

        private long Timestamp()
        {
            long trenutnoVrijeme = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds / 30;
            return trenutnoVrijeme;
        }

        private void btnStani_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void txtKljuc_TextChanged(object sender, EventArgs e)
        {

            int pos= txtKljuc.SelectionStart;
            String base32 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ234567";
            txtKljuc.Text=txtKljuc.Text.ToUpperInvariant();
            txtKljuc.Text=txtKljuc.Text.Replace(" ", "");
            for (int i = 0; i < txtKljuc.TextLength; i++)
            {
                char[] polje = new char[txtKljuc.TextLength]; 
                polje=txtKljuc.Text.ToCharArray(0, txtKljuc.TextLength);
                if (!(base32.Contains(polje[i].ToString())))
                {
                    MessageBox.Show("Tajni kljuc sadrži samo znakove engleske abecede i brojeve od 2-7!");
                    txtKljuc.Text="";
                }
            }
            if (timer1.Enabled)
            {
                timer1.Stop();
                MessageBox.Show("Generiranje TOTP-a je zaustavljeno jer ste promjenili tajni ključ!");
            }
            txtKljuc.SelectionStart=pos;

        }
    }
}
