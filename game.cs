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
    private string imagepath;

    public game()
    {
        InitializeComponent();
        score = DataStore.Score;
        pointsLbl.Text = score.ToString() + " points";
        imagepath = @"Properties\\resources\\";

        images = new List<Image>
        {
                Image.FromFile(imagepath + "flower01.png"),
                Image.FromFile(imagepath + "flower02.png"),
                Image.FromFile(imagepath + "flower03.png"),
                Image.FromFile(imagepath + "flower04.png"),
                Image.FromFile(imagepath + "flower05.png"),
                Image.FromFile(imagepath + "flower06.png")
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
        if (score >= 10)
        {
            currentIndex = (currentIndex + 1) % images.Count;
            pictureBox1.Image = images[currentIndex];
            MessageBox.Show(
                text: "Gratulálok sikeresen fejlesztetted a virágot");
            
            score -= 10;
            pointsLbl.Text = score.ToString() + " points";
            DataStore.Score = score;
        }
        else
        {
            MessageBox.Show(
                text: "A virág fejlesztéséhez min 10 pont kell!");
        }

    }
}
