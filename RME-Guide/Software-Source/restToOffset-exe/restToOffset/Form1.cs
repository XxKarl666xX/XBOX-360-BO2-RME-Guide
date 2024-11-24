using System;
using System.Windows.Forms;

namespace restToOffset
{
    public partial class Form1 : Form
    {
        // Define the starting address from the RME exploit
        private const uint RMEstartAddress = 2203392528;

        public Form1()
        {
            InitializeComponent();
            // Add KeyPress event handler for textBox1
            textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
        }

        // Function to convert hex to decimal
        private uint HexToDecimal(string hexStr)
        {
            return Convert.ToUInt32(hexStr, 16);
        }

        // Function to calculate the difference and convert to hex
        private string CalculateDifferenceAndConvert(string hexStr)
        {
            uint restToOffset = HexToDecimal(hexStr);
            uint difference = restToOffset - RMEstartAddress;
            return difference.ToString("X");
        }

        // Event handler for KeyPress event
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Prevent the beep sound on Enter key press
                string userInput = textBox1.Text;
                string result = CalculateDifferenceAndConvert(userInput);
                textBox2.Text = $"restToOffset = 0x{result.ToUpper()}";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This event handler can be left empty or used for other purposes
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // This event handler can be left empty or used for other purposes
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}