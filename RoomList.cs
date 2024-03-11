namespace WinFormsRoomsControllApp
{
    public partial class RoomList : Form
    {
        public RoomList()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                listView1.SelectedItems[0].BackColor = Color.CornflowerBlue;
                listView1.SelectedItems[0].ForeColor = Color.White;
            }

            foreach (ListViewItem item in listView1.Items)
            {
                if (!item.Selected)
                {
                    item.BackColor = Color.White;
                    item.ForeColor = Color.Black;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form newRoom = new RoomDetails();
            newRoom.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
