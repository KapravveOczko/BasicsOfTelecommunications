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
    }
}