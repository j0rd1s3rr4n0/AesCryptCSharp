namespace AesCryptCSharp
{
    public partial class Form1 : Form
    {
        const string salt = "🎃🎃🧛🏻🧛🏻‍♂️🧛🏻‍♀️🦇🧄🧟🧟‍♂️🧟‍♀️🧌🕷️🕸️";
        public Form1()
        {
            InitializeComponent();
        }

        private void Label_text_Click(object sender, EventArgs e) { }
        private void encrypt_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            TB_result.Text = aes.Encrypt(TB_txt.Text,TB_passphrase.Text, salt);
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            TB_result.Text = aes.Decrypt(TB_txt.Text, TB_passphrase.Text, salt);
        }
        private void CloseApp_Click(object sender, EventArgs e){this.closeAppNow();}
        private void label1_Click(object sender, EventArgs e){this.closeAppNow();}
        private void closeAppNow()
        {/* In a console application:*//*Environment.Exit(0);*//*In a WPF application:*/
         Close();
        }

        private void btn_read_txt_Click(object sender, EventArgs e)
        {
            TB_txt.Text = ReadFile();
        }

        private void SwitchText_Click(object sender, EventArgs e)
        {
            string text = TB_txt.Text;
            TB_txt.Text = TB_result.Text;
            TB_result.Text = text;
        }


        public static string ReadFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            try { 
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "C:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        var fileStream = openFileDialog.OpenFile();
                        try { 
                            using (StreamReader reader = new StreamReader(fileStream))
                            {
                                fileContent = reader.ReadToEnd();
                            }
                        }
                        catch { }
                    }
                }
            }
            catch { }
            return fileContent.ToString();
        }

        private void btn_read_result_Click(object sender, EventArgs e)
        {
            TB_result.Text = ReadFile();
        }
    }
}