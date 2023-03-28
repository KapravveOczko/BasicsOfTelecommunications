using System.Drawing.Imaging;
using System.Text;
using Zadani1Podejscie2;

namespace Zadanie1Podejscie2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static void SaveStringToFile(string filePath, string stringToSave)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(stringToSave);
            }
        }
        static string toBits(Encoding encoding, string text) // used to convert asci to binarry
        {
            return string.Join("", encoding.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }
        private void buttonTranslate_Click(object sender, EventArgs e)
        {
            textBoxTranslate.Text = toBits(Encoding.UTF8, textBoxInput.Text);
        }

        private void button4Parrity_Click(object sender, EventArgs e)
        {
            textBoxTranslate.Text = Utils.Encode(textBoxInput.Text, SingleCorrection.numberOfHMatrixColumns, SingleCorrection.hMatrix);
        }

        private void button8Parrity_Click(object sender, EventArgs e)
        {
            textBoxTranslate.Text = Utils.Encode(textBoxInput.Text, DoubleCorrection.numberOfHMatrixColumns, DoubleCorrection.hMatrix);
        }

        private void button4Decode_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = Utils.DecodeBinaryToString(SingleCorrection.DecodeToBinary(textBoxTranslate.Text));
        }

        private void button8Decode_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = Utils.DecodeBinaryToString(DoubleCorrection.Decode(textBoxTranslate.Text));
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = Utils.DecodeBinaryToString(textBoxTranslate.Text);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                string textToSave = textBoxTranslate.Text;

                try
                {
                    using (StreamWriter writer = new StreamWriter(fileName))
                    {
                        writer.Write(textToSave);
                    }

                    MessageBox.Show("File saved successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;

                try
                {
                    using (StreamReader reader = new StreamReader(fileName))
                    {
                        textBoxTranslate.Text = reader.ReadToEnd();
                    }

                    MessageBox.Show("File loaded successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading file: " + ex.Message);
                }
            }
        }
    }
}