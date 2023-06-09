using System.Text;
using Zadanie1;

namespace Zadanie1
{
    public partial class Form1 : Form
    {


        private Bitmap MyImage;
        public void showMyImage(String fileToDisplay, int xSize, int ySize)
        {
            // Sets up an image object to be displayed.
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            // Stretches the image to fit the pictureBox.
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox1.ClientSize = new Size(xSize, ySize);
            pictureBox1.Image = (Image)MyImage;
        }

        //translates text to 0's and 1's
        static string toBits(Encoding encoding, string text) // used to convert asci to binarry
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
            textBoxTranslated.Text = toBits(Encoding.UTF8, userInput);
        }

        //button used to save to file
        // file localizaction: */Zadani1/bin/Debug/net6.0-windows/
        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            byte[] bytesToWrite = Encoding.UTF8.GetBytes(textBoxTranslated.Text);
            File.WriteAllBytes("tmp.txt", bytesToWrite);

            MessageBox.Show($"Zapisano tekst '{textBoxTranslated.Text}' do pliku '{"tmp.txt"}'");
        }

        //button used to load from file
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
                textBoxTranslated.Text = reader.ReadToEnd();
                MessageBox.Show($"Wczytano tekst z pliku '{fileName}'");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            showMyImage("img.jpg", 312, 380);
        }

        private void buttonTranslateToOne_Click(object sender, EventArgs e)
        {
            OneCorrection oneCorrection = new OneCorrection();
            textBoxTranslated.Text = oneCorrection.encodeText(textBoxInput.Text);
            //int[] tmp = { 1, 0,0,1,1,1,1,0 };
            //textBoxOutput.Text = oneCorrection.encodeWord(tmp);
        }
    }
}