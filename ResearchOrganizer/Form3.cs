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
    public partial class Form3 : Form
    {
        public static Form3 instance;

        public static int ID;
        public static string Title = "";
        public static string Abstract = "";
        public static string URI = "";
        public static string Notes = "";
        public static string Bib_Text = "";

        public Form3()
        {
            InitializeComponent();
            instance = this;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            var IDvar = IDtxt.Text;
            int ID = int.Parse(IDtxt.Text);

            Title =  titletxt.Text;
            Abstract = Abstracttxt.Text;
            URI = URItxt.Text;
            Notes = Notestxt.Text;
            Bib_Text = Bibtxt.Text;

            if (ID==null ||Title == "" || Abstract == "" || URI == "" || Notes == "" || Bib_Text == "")
            {
                MessageBox.Show("Enter Data in Textboxs");
            }

            SQLiteConnection conn = new SQLiteConnection("Data Source = MyData.db; Version=3");
            conn.Open();
            string query = "UPDATE MyData set Title ='"+Title+ "', Abstract ='" + Abstract + "', URI='" + URI + "', Notes='" + Notes + "', Bib_Text='" + Bib_Text + "'  where ID ='" + ID + "'";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);
            cmd.ExecuteNonQuery();
/*            Form2.instance.Abs.Text = Abstract;
            Form2.instance.nots.Text = Notes;*/
            conn.Close();
            Form2 f2 = new Form2();
            f2.Show();
            
        }
    }
}
