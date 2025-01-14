namespace ToDoList
{
    public partial class list : Form
    {
        public list()
        {
            InitializeComponent();
            points.Text = DataStore.Score + " points";  
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string todo = textBoxTodo.Text.Trim();
            if (!string.IsNullOrEmpty(todo))
            {
                checkedListBoxTodos.Items.Add(todo);
                textBoxTodo.Clear();
            }
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBoxTodos.CheckedItems.Count - 1; i >= 0; i--)
            {
                checkedListBoxTodos.Items.Remove(checkedListBoxTodos.CheckedItems[i]);
                DataStore.Score += 10; 
            }
            points.Text = DataStore.Score.ToString() + " points";
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("todos.txt"))
            {
                // Ment�s: Pontsz�m
                writer.WriteLine(DataStore.Score);

                // Ment�s: Feladatok
                foreach (var item in checkedListBoxTodos.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Feladatok �s pontok elmentve!");
        }
        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("todos.txt"))
            {
                using (StreamReader reader = new StreamReader("todos.txt"))
                {
                    // Bet�lt�s: Pontsz�m
                    if (int.TryParse(reader.ReadLine(), out int loadedScore))
                    {
                        DataStore.Score = loadedScore;
                        points.Text = DataStore.Score + " points";
                    }

                    // Bet�lt�s: Feladatok
                    checkedListBoxTodos.Items.Clear();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        checkedListBoxTodos.Items.Add(line);
                    }
                }
                MessageBox.Show("Feladatok �s pontok bet�ltve!");
            }
            else
            {
                MessageBox.Show("Nincs elmentett adat.");
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            menu frm = new();
            frm.Show();
            this.Hide();
        }
    }
}
