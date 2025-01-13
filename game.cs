using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList;

public partial class game : Form
{
    private int score;
    private List<Image> images;
    private int currentIndex;

    public game()
    {
        InitializeComponent();
        score = DataStore.Score;
        pointsLbl.Text = score.ToString() + " points";

        images = new List<Image>
        {
                Image.FromFile("D:\\ToDoList\\Properties\\resources\\flower01.png"),
                Image.FromFile("D:\\ToDoList\\Properties\\resources\\flower02.png"),
                Image.FromFile("D:\\ToDoList\\Properties\\resources\\flower03.png"),
                Image.FromFile("D:\\ToDoList\\Properties\\resources\\flower04.png"),
                Image.FromFile("D:\\ToDoList\\Properties\\resources\\flower05.png"),
                Image.FromFile("D:\\ToDoList\\Properties\\resources\\flower06.png")
        };

        currentIndex = 0;
        pictureBox1.Image = images[currentIndex]; 
    }

    private void ExitBtn_Click(object sender, EventArgs e)
    {
        menu frm = new();
        frm.Show();
        this.Hide();
    }

    private void UpgradeBtn_Click(object sender, EventArgs e)
    {
        if (score > 50)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            pictureBox1.Image = images[currentIndex];
            MessageBox.Show(
                text: "Gratulálok sikeresen fejlesztetted a virágot");
            
            score -= 50;
            pointsLbl.Text = score.ToString() + " points";
            DataStore.Score = score;
        }
        else
        {
            MessageBox.Show(
                text: "A virág fejlesztéséhez min 50 pont kell!");
        }

    }
}
