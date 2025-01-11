using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ToDoListBtn_Click(object sender, EventArgs e)
        {
            Form1 frm = new();
            frm.Show();
            this.Hide();
        }
    }
}
