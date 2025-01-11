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
            points.Text = DataStore.Score.ToString() + " pont";
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            menu frm = new();
            frm.Show();
            this.Hide();
        }
    }
}
