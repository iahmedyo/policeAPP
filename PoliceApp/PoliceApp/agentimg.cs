using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace PoliceApp
{
    public partial class agentimg : Form
    {
        clsFunc cf = new clsFunc();
        public agentimg()
        {
            InitializeComponent();
        }

        //SqlConnection conn = new SqlConnection("Data Source=EMNA-SDSI-DJ;Initial Catalog=DB_RH_POLICE;Integrated Security=True");
        ConnectionString cons = new ConnectionString();
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg";
            DialogResult res = ofd.ShowDialog();
            if(res == DialogResult.OK)
            {
                pb1.Image = Image.FromFile(ofd.FileName);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                SqlDataReader rd = null;
                string query = "INSERT INTO picagent(picture) VALUES( @picagent )";
                SqlConnection dbConn;
                dbConn = new SqlConnection(cons.DBConn());
                dbConn.Open();
                SqlCommand cmd = new SqlCommand(query, dbConn);
                MemoryStream stream = new MemoryStream();
                pb1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                cmd.Parameters.AddWithValue("@picagent", pic);
                MessageBox.Show("yes");
                int i = 0;  
                i= cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("save" + i);
                }
                    
                

              
               // rd = cmd.ExecuteReader();
               // if (rd.Read())
               // {
                  //  frmMainMenu fr1 = new frmMainMenu();
                  //  this.Hide();
                   // fr1.Show();
                   // st1 = UserID.Text;
                   // st2 = "connexion à l application";
                   // cf.LogFunc(st1, System.DateTime.Now, st2);
               // }
            //conn.Open();
           // int i = 0;
            //SqlCommand cmd = new SqlCommand("INSERT INTO agentpic(picture) VALUES( @picture )");
            // stream = new MemoryStream();
            //pb1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] pic = stream.ToArray();
            //cmd.Parameters.AddWithValue("@agentPic", pic);*/
            
        }

        
        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlDataReader rd = null;
            
            //string query = "INSERT INTO Table1 VALUES( '"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"' )";
            SqlConnection dbConn;
            dbConn = new SqlConnection(cons.DBConn());
            dbConn.Open();
            SqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO Table3 VALUES( '" + textBox1.Text + "','" + textBox2.Text + "','" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '"+dateTimePicker1.Value.ToString()+"')";
            //SqlCommand cmd = new SqlCommand(query, dbConn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("succedd");
          
        }

        private void agentimg_Load(object sender, EventArgs e)
        {
            display_data();
        }

        public void display_data()
        {
            SqlDataReader rd = null;

            //string query = "INSERT INTO Table1 VALUES( '"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"' )";
            SqlConnection dbConn;
            dbConn = new SqlConnection(cons.DBConn());
            dbConn.Open();
            SqlCommand cmd = dbConn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table3";
            //SqlCommand cmd = new SqlCommand(query, dbConn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("succedd");

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
