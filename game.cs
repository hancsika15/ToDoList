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

public partial class game : Form
{
    private int score;
    public game()
    {
        InitializeComponent();
        score = DataStore.Score;
        pointsLbl.Text = score.ToString() + " points";
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        menu frm = new();
        frm.Show();
        this.Hide();
    }
}
