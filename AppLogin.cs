using System.Data.SQLite;


namespace WinFormsRoomsControllApp
{
    public partial class AppLogin : Form
    {
        public AppLogin()
        {
            InitializeComponent();
            string dbPath = "usersDB2.db";
            SQLiteDatabase db = new SQLiteDatabase(dbPath);

            string query = $"CREATE Table if not EXISTS UsersLogin (ID INTEGER PRIMERY KEY, User TEXT, Passw TEXT, Rolle TEXT)";
            db.ExecuteNonQuery(query);
            System.Console.WriteLine("Datenbank erstellt");

            string Inserquery = $"INSERT INTO UsersLogin (User,Passw,Rolle) VALUES ('Steffen', '12345', 'admin')";
            db.ExecuteNonQuery(Inserquery);
            System.Console.WriteLine("Insert User und Passoword");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void userName_TextChanged(object sender, EventArgs e)
        {

        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void logoBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form showList = new RoomList();
            showList.Show();
        }
    }

    public class SQLiteDatabase
    {
        private string dbconnection;

        public SQLiteDatabase(string dbPath)
        {
            dbconnection = $"Data Source={dbPath};Version=3";
        }

        public void ExecuteNonQuery(string query)
        {
            using (SQLiteConnection connection = new SQLiteConnection(dbconnection))
            {

                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }

            }
        }
    }
}
