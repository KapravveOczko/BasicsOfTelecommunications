using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Text;

namespace Zadanie1
{
    public partial class Form1 : Form
    {



        static string ToBinaryString(Encoding encoding, string text) // used to convert asci to binarry
        {
            return string.Join("", encoding.GetBytes(text).Select(n => Convert.ToString(n, 2).PadLeft(8, '0')));
        }

        static void ToBinaryArray(string text)
        {

            //tmp
            //byte[]
            //tmp

            for (int c = 0; c!=text.Length; c++)
            {

            }
        }


        // gui starts there

        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBoxInput.Text;
            textBoxOutput.Text = ToBinaryString(Encoding.UTF8, userInput);
        }
    }
}