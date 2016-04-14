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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Hero hero1;
        static void setNewStatus(Label label4, Label label3, ProgressBar progressBar4, ProgressBar progressBar3,Hero hero1)
        {
            label4.Text = "HP : " + hero1.getHp() + " / " + hero1.getMaxHp();
            label3.Text = "MP : " + hero1.getMp() + " / " + hero1.getMaxMp();
            progressBar4.Value = (int)((float)hero1.getHp() / hero1.getMaxHp() * 100);
            progressBar3.Value = (int)((float)hero1.getMp() / hero1.getMaxMp() * 100);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            hero1 = new Hero(1);
            setNewStatus(label4, label3, progressBar4, progressBar3, hero1);
            //this.Text = hero1.getHp().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Command c = new Command();
            c.ShowDialog();
            textBox2.AppendText(c.getCommand());
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Heal_Spell_List h = new Heal_Spell_List(hero1.getLevel());
            h.ShowDialog();
            textBox2.AppendText(h.getHealLevel().ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<string> s = hero1.getList();
            Use_Item u = new Use_Item(ref s);
            u.ShowDialog();
            hero1.setList(s);
        }
    }
}
