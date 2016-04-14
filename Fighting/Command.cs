using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fighting
{
    public partial class Command : Form
    {
        string s = "";
        public Command()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, KeyEventArgs e)
        {
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'w' || e.KeyChar == 'a' || e.KeyChar == 's' || e.KeyChar == 'd')
            {
                e.KeyChar = Char.ToUpper(e.KeyChar);
            }
            else if(e.KeyChar != 8)
            {
                e.KeyChar = (char)0;
            }
        }

        public string getCommand()
        {
            return s;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s = textBox1.Text;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Command_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        
        
    }
}
