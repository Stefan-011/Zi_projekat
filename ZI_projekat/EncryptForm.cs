using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZI_projekat
{
    public partial class EncryptForm : Form
    {
       private string 
            LoadedFilePath,
            LoadedFileName,
            PathToSave;


        public EncryptForm()
        {
            InitializeComponent();
            test();
        }
        public void test() //
        {
            Knapsack test = new Knapsack();
            test.GenerateKeys(1, 5);
            // int [] t = test.Encrypt("11101 00100 11100");
         /*   test.ReadFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\NormalBinary.txt");
            test.EncryptFile();
            test.SaveFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\EncodedKnapsack.txt");*/

            test.ReadFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\EncodedKnapsack.txt");
            test.DecryptFile();
            test.SaveFile(@"C:\Users\Stefan\Desktop\Projekti\ZI projekat\ZI_projekat\Fajlovi\DecodedKnapsack.txt");
            /*  foreach (var item in t)
              {
                  Console.WriteLine(item);
              }*/

            test.Decrypt("193 76 169");

       

            



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
                    Crypter.ReadFile(LoadedFilePath);
                    Crypter.EncryptFile();                   
                    Crypter.SaveFile(@""+PathToSave+"EncodedRC6.txt");

                    Input_textbox.Text = Encoding.UTF8.GetString(Crypter.GetLoadedData());
                    Output_textbox.Text = Encoding.UTF8.GetString(Crypter.GetChangedData());
                    break;
                case "Bifid":
                    Bifid BifidCrypter = new Bifid();
                    BifidCrypter.Set_key("arikspyvxnuhfcqzemgwdbtol");
                    BifidCrypter.GenerateKey();                
                    BifidCrypter.ReadFile(LoadedFilePath);
                    BifidCrypter.EncryptFile();
                    BifidCrypter.SaveFile(@"" + PathToSave + "EncodedBifid.txt");

                    Input_textbox.Text = (BifidCrypter.GetLoadedText());                 
                    Output_textbox.Text = (BifidCrypter.GetCipherText());
                 
                    break;
                case "Knapsack":
                    Knapsack KnapsackCrypter = new Knapsack();
                    KnapsackCrypter.GenerateKeys(1, 5);
                    KnapsackCrypter.ReadFile(LoadedFilePath);
                    KnapsackCrypter.EncryptFile();
                    KnapsackCrypter.SaveFile(@"" + PathToSave + "EncodedKnapsack.txt");
                    Input_textbox.Text = Encoding.UTF8.GetString(KnapsackCrypter.GetReadBinary());
                    string output = "";
                    foreach (var item in KnapsackCrypter.GetCipherInt())
                    {
                        output += item+" ";
                    }
                    Output_textbox.Text = output;
                    break;
                case "Bitmap (+PC6)":
                    RC6 BitmapCrypter = new RC6();
                    BitmapCrypter.GenerateKey(Encoding.ASCII.GetBytes("aaaaccccbbbbeeee"));
                    BitmapCrypter.ReadBitmap(LoadedFilePath);
                    BitmapCrypter.EcryptAndSaveBitmap(@"" + PathToSave + "SuspiciousBitmap.bmp");

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
                    RC6Crypter.ReadFile(LoadedFilePath);
                    RC6Crypter.DecryptFile();
                    RC6Crypter.SaveFile(@"" + PathToSave + "DecodedRC6.txt");

                    Input_textbox.Text = Encoding.UTF8.GetString(RC6Crypter.GetLoadedData());                   
                    Output_textbox.Text = Encoding.UTF8.GetString(RC6Crypter.GetChangedData());

                    break;
                case "Bifid":
                    Bifid BifidCrypter = new Bifid();
                    BifidCrypter.Set_key("arikspyvxnuhfcqzemgwdbtol");
                    BifidCrypter.GenerateKey();                
                    BifidCrypter.ReadFile(LoadedFilePath);                  
                    BifidCrypter.DecryptFile();
                    BifidCrypter.SaveFile(@"" + PathToSave + "DecodedBifid.txt");

                    Input_textbox.Text = (BifidCrypter.GetLoadedText());
                    Output_textbox.Text = (BifidCrypter.GetCipherText());
                    
                    break;
                case "Knapsack":
                    Knapsack KnapsackCrypter = new Knapsack();
                    KnapsackCrypter.GenerateKeys(1, 5);
                    KnapsackCrypter.ReadFile(LoadedFilePath);
                    KnapsackCrypter.DecryptFile();
                    KnapsackCrypter.SaveFile(@"" + PathToSave + "DecodedKnapsack.txt");

                    Input_textbox.Text = (KnapsackCrypter.GetReadText());
                    string output= "";
                    foreach (var item in KnapsackCrypter.GetCipherText())
                    {
                        output += item;
                    }
                    Output_textbox.Text = output;
                    break;
                case "Bitmap (+PC6)":
                    RC6 BitmapCrypter = new RC6();
                    BitmapCrypter.GenerateKey(Encoding.ASCII.GetBytes("aaaaccccbbbbeeee"));
                    BitmapCrypter.ReadBitmap(LoadedFilePath);
                    BitmapCrypter.DecryptAndSaveBitmap(@"" + PathToSave + "NewBitmap.bmp");
                    break;
                default:
                    break;
            }
        }

       

        private void open_file_btn_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            LoadedFilePath = openFileDialog.FileName;
            string[] list = LoadedFilePath.Split('\\');
            LoadedFileName = list[list.Length - 1];
            list[list.Length - 1] = "";
            label_loaded_file.Text = LoadedFileName;

            PathToSave  = "";
            foreach (var item in list)
            {
                if(item != "")
                PathToSave += item+"\\";
            }

            Console.WriteLine(LoadedFileName);
            Console.WriteLine(LoadedFilePath);
            Console.WriteLine(PathToSave);
        }
    }
   
}


