using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListViewExample
{
    public partial class Form1 : Form
    {
        SqlConnection db=new SqlConnection(@"data source=AZRA;initial catalog=SchoolDb;user id=sa; password=1453");
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.View = View.Details;

            listView1.FullRowSelect = true;
                listView1.Columns.Add("Id", 10);
                listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Surname", 100);
            listView1.Columns.Add("Age", 10);
            listView1.Columns.Add("Status", 50);

            string[] azraInformation = { "1", "Azra", "Yüksel", "22", "Active" };
            listView1.Items.Add(new ListViewItem(azraInformation));
            }

        int id = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            id++;

            string[] userInformation = new string[5];
            
            userInformation[0] = id.ToString();
            userInformation[1] = NameTxt.Text;
            userInformation[2] = SurnameTxt.Text;
            userInformation[3] = AgeNud.Value.ToString();
                userInformation[4] = StatusCb.SelectedItem.ToString();

            listView1.Items.Add(new ListViewItem(userInformation));
            MessageBox.Show("Kullanıcı ekleme başarılı",
                "Add User",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void GULBtn_Click(object sender, EventArgs e)
        {
            listView2.Items.Clear();
            db.Open();

            string query = "select * from Students";
            SqlCommand sqlCommand = new SqlCommand(query, db);
            //SqlDataReader reader = sqlCommand.ExecuteReader();

            //while (reader.Read())
            //{
            // string[] studentInformation = { reader["Id"].ToString(),
            // reader["Name"].ToString(),
            // reader["Surname"].ToString(),
            // reader["Age"].ToString(),
            // reader["ClassesId"].ToString(),
            // reader["Status"].ToString(),
            // };
            // listView2.Items.Add(new ListViewItem(studentInformation));
            //}

            SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);

            DataTable dt = new DataTable();
            adapter.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                string[] studentInformation = { dr["Id"].ToString(),
dr["Name"].ToString(),
dr["Surname"].ToString(),
dr["Age"].ToString(),
                    dr["ClassesId"].ToString(),
                    dr["Status"].ToString(),
};
                listView2.Items.Add(new ListViewItem(studentInformation));
            }


            db.Close();
        }
    }
}
