using System.Data;
using System.Data.SQLite;

namespace ResearchOrganizer
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public TextBox Abs, nots;

        string Title = Form1.Title;
        string Abstract = Form1.Title;
        string URI = Form1.Title;
        string Notes = Form1.Title;
        string Bib_Text = Form1.Title;
        public Form2()
        {
            InitializeComponent();
            instance = this;
            Abs = textBox1;
            nots = textBox2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Title = Form1.instance.tb1.Text;
            Abstract = Form1.instance.tb2.Text;
            URI = Form1.instance.tb3.Text;
            Notes = Form1.instance.tb4.Text;
            Bib_Text = Form1.instance.tb5.Text;

            {
                SQLiteConnection conn = new SQLiteConnection("Data Source = MyData.db; Version=3");
                conn.Open();
                /*string query = "INSERT INTO MyData (Title, Abstract ,URI, Notes, Bib_Text) VALUES ('" + Title + "', '" + Abstract + "','" + URI + "', '" + Notes + "','" + Bib_Text + "')";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.ExecuteNonQuery();*/
                SQLiteDataAdapter adobter = new SQLiteDataAdapter("SELECT  * from MyData", conn);
                DataTable dt = new DataTable();
                adobter.Fill(dt);
                DGV2.DataSource = dt; //DGTV == DataGridView  
                /*                textBox1.Text = Abstract;
                                textBox2.Text = Notes;*/
                conn.Close();
                

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DGV2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //gets a collection that contains all the rows
                DataGridViewRow row = this.DGV2.Rows[e.RowIndex];
                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[3].Value.ToString();
            }
            }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            
        }
    }
}
