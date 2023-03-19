using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Text;

namespace Zadanie1
{
    public partial class Form1 : Form
    {
        //translates text to 0's and 1's
        static string ToBinaryString(Encoding encoding, string text) // used to convert asci to binarry
        {
            return string.Join("", encoding.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }

        // gui starts there

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        //button used to translate
        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBoxInput.Text;
            textBoxOutput.Text = ToBinaryString(Encoding.UTF8, userInput);
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            byte[] bytesToWrite = Encoding.UTF8.GetBytes(textBoxOutput.Text);
            File.WriteAllBytes("tmp.txt", bytesToWrite);

            MessageBox.Show($"Zapisano tekst '{textBoxOutput.Text}' do pliku '{"tmp.txt"}'");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            string fileName = "tmp.txt";
            if (!File.Exists(fileName))
            {
                MessageBox.Show($"Plik '{fileName}' nie istnieje!");
                return;
            }
            using (StreamReader reader = new StreamReader(fileName))
            {
                textBoxOutput.Text = reader.ReadToEnd();
                MessageBox.Show($"Wczytano tekst z pliku '{fileName}'");
            }
        }
    }
}