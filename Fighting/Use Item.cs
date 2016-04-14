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
    public partial class Use_Item : Form
    {
        List<string> list;
        string selectedItem;
        public Use_Item(ref List<string> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private void Use_Item_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            listBox1.DataSource = list;
        }

        public string getItem()
        {
            return selectedItem;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                selectedItem = list[listBox1.SelectedIndex];
                list.Remove(selectedItem);
                this.Close();        
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
