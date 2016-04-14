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
    public partial class Heal_Spell_List : Form
    {
        int lv = 0, healLevel;
        public Heal_Spell_List(int level)
        {
            InitializeComponent();
            lv = level;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            healLevel = listBox1.SelectedIndex + 1;
            this.Close();
        }

        public int getHealLevel()
        {
            return healLevel;
        }
        private void Heal_Spell_List_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            if (lv > 5)
            {
                listBox1.Items.Add("Cure");
                healLevel = 1;
            }
            if (lv > 20)
            {
                listBox1.Items.Add("Cura");
                healLevel = 2;
            }
            if (lv > 55)
            {
                listBox1.Items.Add("Curaga");
                healLevel = 3;
            }
            if (lv > 70)
            {
                listBox1.Items.Add("Full-Cure");
                healLevel = 4;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
