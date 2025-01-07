namespace ToDoList
{
    public partial class Form1 : Form
    {
        private int score = 0;
        public Form1()
        {
            InitializeComponent();
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
                score += 10; 
            }
            points.Text = score.ToString() + " pont";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("todos.txt"))
            {
                foreach (var item in checkedListBoxTodos.Items)
                {
                    writer.WriteLine(item.ToString());
                }
            }
            MessageBox.Show("Feladatok elmentve!");
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists("todos.txt"))
            {
                checkedListBoxTodos.Items.Clear();
                using (StreamReader reader = new StreamReader("todos.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        checkedListBoxTodos.Items.Add(line);
                    }
                }
            }
        }
    }
}
