
namespace PersonalManager
{
    public enum StatusType
    {
        Work,
        Dismissed,
        OnVacation,

    }

    public partial class Form1 : Form
    {
        private List<Person> _persons = new List<Person>()
        {
            new Person("Christopher", "Adam", "Bumstead", "Gym", "Bodybuilder", addmissionDate: new DateTime(2012, 12, 05)),
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }


        /// <summary>
        /// Form Method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            _mainListView.Items.Clear();

            ListViewItem listViewItem;

            foreach (Person person in _persons)
            {
                listViewItem = new ListViewItem(person.Name);
                listViewItem.SubItems.Add(person.LastName);
                listViewItem.SubItems.Add(person.FatherName);
                listViewItem.SubItems.Add(person.Department);
                listViewItem.SubItems.Add(person.Position);
                listViewItem.SubItems.Add(person.AddmissionDate.ToString());
                listViewItem.SubItems.Add(person.Status.ToString());

                _mainListView.Items.Add(listViewItem);
            }

        }

        /// <summary>
        /// Dismiss/Fire button 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dismissBtn_Click(object sender, EventArgs e)
        {
            _mainListView.FocusedItem.SubItems[6].Text = StatusType.Dismissed.ToString();
            UpdateTextBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


     
        private void ListView_SelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
 
            UpdateTextBox();

        }

        private void UpdateTextBox()
        {
            ListViewItem selectedItem = _mainListView.FocusedItem;
            _userNameInput.Text = selectedItem.SubItems[0].Text;
            _userLastNameInput.Text = selectedItem.SubItems[1].Text;
            _userFatherNameInput.Text = selectedItem.SubItems[2].Text;
            _userDepartmentInput.Text = selectedItem.SubItems[3].Text;
            _userJobInput.Text = selectedItem.SubItems[4].Text;
            _userTimeStampInput.Text = selectedItem.SubItems[5].Text;
            _statusLabel.Text = selectedItem.SubItems[6].Text;
        }
    }

}