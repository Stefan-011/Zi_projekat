using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_projekat
{
    public partial class EncryptForm : Form
    {
        public EncryptForm()
        {
            InitializeComponent();
            test();
        }
        public void test() //
        {
            Bifid test = new Bifid(); 
    
            // Encoding.ASCII.GetBytes(str) | File.ReadAllText(inputfile); | Encoding.UTF8.GetString(data); | data.SequenceEqual(bytesz)             
            // File.WriteAllText(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\Encoded.txt", Encoding.UTF8.GetString(t.Encrypt("Hollow world")));
            //File.WriteAllText(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\Decoded.txt", Encoding.UTF8.GetString(t.Decrypt(t.Encrypt("Hollow world"))));
        }

        public byte[] citajbitar(string filenamez)
        {
            Byte[] buffer = null;
          
            var fileName = @"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\"+filenamez;
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);

                long numBytes = new FileInfo(fileName).Length;
                buffer = br.ReadBytes((int)numBytes);

                br.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return buffer;
        }

        public void pisibitar(Byte[] buffer,string fileNamez)
        {
            var fileName = @"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\"+fileNamez;
            try
            {
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                BinaryWriter bw = new BinaryWriter(fs);

                for (int i = 0; i < buffer.Length; i++)
                    bw.Write(buffer[i]);

                bw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            
            switch (Alg_cmbox.Text)
            {
                case "RC6":
                    RC6 Crypter = new RC6();
                    Crypter.GenerateKey(Encoding.ASCII.GetBytes("aaaaccccbbbbeeee"));
                    Crypter.ReadFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\Normal.txt");
                    Crypter.EncryptFile();
                    Input_textbox.Text = Encoding.UTF8.GetString(Crypter.GetLoadedData());
                    Crypter.SaveFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\EncodedRC6.txt");
                    Output_textbox.Text = Encoding.UTF8.GetString(Crypter.GetChangedData());
                    break;
                case "Bifid":
                    Bifid BifidCrypter = new Bifid();
                    BifidCrypter.Set_key("arikspyvxnuhfcqzemgwdbtol");
                    BifidCrypter.GenerateKey();                
                    BifidCrypter.ReadFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\Normal.txt");
                    Input_textbox.Text = (BifidCrypter.GetLoadedText());
                    BifidCrypter.EncryptFile();
                    Output_textbox.Text = (BifidCrypter.GetCipherText());
                    BifidCrypter.SaveFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\EncodedBifid.txt");
                    break;
                default:
                    break;
            }
        }

        private void Decrypt_btn_Click(object sender, EventArgs e)
        {
            switch (Alg_cmbox.Text)
            {
                case "RC6":
                    RC6 RC6Crypter = new RC6();
                    RC6Crypter.GenerateKey(Encoding.ASCII.GetBytes("aaaaccccbbbbeeee"));
                    RC6Crypter.ReadFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\EncodedRC6.txt");
                    RC6Crypter.DecryptFile();
                    Input_textbox.Text = Encoding.UTF8.GetString(RC6Crypter.GetLoadedData());
                    RC6Crypter.SaveFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\NewFileRC6.txt");
                    Output_textbox.Text = Encoding.UTF8.GetString(RC6Crypter.GetChangedData());
                    break;
                case "Bifid":
                    Bifid BifidCrypter = new Bifid();
                    BifidCrypter.Set_key("arikspyvxnuhfcqzemgwdbtol");
                    BifidCrypter.GenerateKey();                
                    BifidCrypter.ReadFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\EncodedBifid.txt");
                    Input_textbox.Text = (BifidCrypter.GetLoadedText());
                    BifidCrypter.DecryptFile();
                    Output_textbox.Text = (BifidCrypter.GetCipherText());
                    BifidCrypter.SaveFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\DecodedBifid.txt");
                    break;
                default:
                    break;
            }
        }


    }
   
}


