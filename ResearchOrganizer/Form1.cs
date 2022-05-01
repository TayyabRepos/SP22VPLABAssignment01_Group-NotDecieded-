using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ResearchOrganizer 
{
    public partial class Form1 : Form 
    {
        public static Form1 instance;
        public TextBox tb1, tb2, tb3, tb4, tb5;
        public GridItemType grd;



        public static int ID;
        public static string Title = "";
        public static string Abstract = "";
        public static string URI = "";
        public static string Notes = "";
        public static string Bib_Text = "";


        public Form1()
        {
            InitializeComponent();
            instance = this;
            tb1 = textBox1;
            tb2 = textBox2;
            tb3 = textBox3;
            tb4 = textBox4;
            tb5 = textBox5;


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public void Save_Click(object sender, EventArgs e)
        {

            try
            {
                Title = textBox1.Text;
                Abstract = textBox2.Text;
                URI = textBox3.Text;
                Notes = textBox4.Text;
                Bib_Text = textBox5.Text;

                if (Title == "" || Abstract == "" || URI == "" || Notes == "" || Bib_Text == "")
                {
                    MessageBox.Show("Enter Data in Textboxs");
                }

                else
                {
                    SQLiteConnection conn = new SQLiteConnection("Data Source = MyData.db; Version=3");
                    conn.Open();
                    string query = "INSERT INTO MyData (Title, Abstract ,URI, Notes, Bib_Text) VALUES ('" + Title + "', '" + Abstract + "','" + URI + "', '" + Notes + "','" + Bib_Text + "')"; //MyData is the name of tables and values are attributes  
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    /*           SQLiteDataAdapter adobter = new SQLiteDataAdapter("SELECT * from MyData", conn);
                               DataTable dt = new DataTable();
                               adobter.Fill(dt);
                               DGV1.DataSource = dt;*/
                    conn.Close();
                }

                Form2 f2 = new Form2();
                f2.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful Attempt");
            }
            
            

        }
    }
}