using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList;

public partial class menu : Form
{
    public menu()
    {
        InitializeComponent();
    }
    private void ToDoListBtn_Click(object sender, EventArgs e)
    {
        list frm = new();
        frm.Show();
        this.Hide();
    }
    private void GameBtn_Click(object sender, EventArgs e)
    {
        game frm = new();
        frm.Show();
        this.Hide();
    }
    private void ExitBtn_Click(object sender, EventArgs e)
    {
        DialogResult result = MessageBox.Show(
            text: "Biztos szeretne kilépni?",
            caption: "",
            buttons: MessageBoxButtons.YesNo,
            icon: MessageBoxIcon.Warning);

        if (result == DialogResult.Yes)
        {
            Application.Exit();
        }
    }
}
