using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace SQLAPP
{
    public partial class Form1 : Form
    {   //Connection string to the database within local MySQL Server
        //Plan on adding the ability to connect via GUI instead of current implementation
        readonly string ConStr = "server=127.0.0.1;user id=root;database=infodb;pwd=kode1234";

        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //Unsecure
            //string querySelect = "Select * from infodb.movies where Title = " + uInput + ";";

            string querySelect = "SELECT * FROM infodb.movies WHERE Title = @uInput";
            MySqlConnection connect = new MySqlConnection(ConStr);


            MySqlCommand command = new MySqlCommand(querySelect, connect);

            //Parameters for "querySelect"
            command.Parameters.AddWithValue("@uInput", boxTitle.Text);

            connect.Open();

            command.ExecuteNonQuery();

            //Initializes the search engine and tells it where to get data from and where to put it
            MySqlDataReader dataReader = command.ExecuteReader();

            if (string.IsNullOrWhiteSpace(boxTitle.Text))
            {
                MessageBox.Show("Please enter the title of the movie you wish to search for");
            }
            else if (dataReader.Read())
            {
                boxYear.Text = dataReader.GetString("Year");
                boxDirector.Text = dataReader.GetString("Director");
                boxRating.Text = dataReader.GetString("Rating");
            }
            else
            {
                MessageBox.Show("Movie info not found!");
            }

            labHeading.Focus();
            connect.Close();
            dataReader.Close();
            dataReader.Dispose();

            //Used to Extract entire columns of data N/A for the program currently
            /*while (dataReader.Read())
            {
                Output = Output + dataReader.GetValue(0) + " - " + dataReader.GetValue(1) + "\n";
            }

            MessageBox.Show(Output);

            dataReader.Close();
            command.Dispose();
            connect.Close();*/

            //Old method used to establish and verify a connection
            /*if (connect.State == ConnectionState.Open)
            {
                MessageBox.Show("Connection Open");

                connect.Close();
            }*/
        }

        private void ButtonIn_Click(object sender, EventArgs e)
        {   //Query for the database.
            string queryInsert = "INSERT INTO infodb.movies (Title ,Year ,Director ,Rating) VALUES (@TitleIN,@YearIN, @DirectorIN, @RatingIN)";

            MySqlConnection connect = new MySqlConnection(ConStr);
            using (MySqlCommand command = new MySqlCommand(queryInsert, connect))
            {

                //Parameters for "queryInsert"
                command.Parameters.AddWithValue("@TitleIN", boxTitle.Text);
                command.Parameters.AddWithValue("@YearIN", boxYear.Text);
                command.Parameters.AddWithValue("@DirectorIN", boxDirector.Text);
                command.Parameters.AddWithValue("@RatingIN", boxRating.Text);

                try
                {
                    //Attempts to open a connection and execute "queryInsert"
                    if (string.IsNullOrWhiteSpace(boxTitle.Text))
                    {
                        MessageBox.Show("Please enter a valid title");
                    }
                    if (string.IsNullOrWhiteSpace(boxYear.Text))
                    {
                        MessageBox.Show("Please enter the year in which the movie was released");
                    }
                    if (string.IsNullOrWhiteSpace(boxDirector.Text))
                    {
                        MessageBox.Show("Please enter the director of the movie");
                    }
                    if (string.IsNullOrWhiteSpace(boxRating.Text))
                    {
                        MessageBox.Show("Please enter the IMDb rating of the movie");
                    }

                    connect.Open();
                    command.ExecuteNonQuery();
                    connect.Close();
                    MessageBox.Show("Data has been inserted!");
                }
                //look into throwing a custom exception for dupechecking in the future but for now im just using Mysqlexception
                catch (MySqlException mse)
                {
                    MessageBox.Show("Duplicate found!", mse.Message);
                }
                finally
                {
                    command.Dispose();
                    labHeading.Focus();
                }
            }
        }

        private void ButtonCL_Click(object sender, EventArgs e)
        {
            boxTitle.Text = "";
            boxYear.Text = "";
            boxDirector.Text = "";
            boxRating.Text = "";
            labHeading.Focus();
        }
    }
}
