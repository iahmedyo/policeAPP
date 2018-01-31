using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace PoliceApp
{
    public partial class frmpolicier : Form
    {
        clsFunc cf = new clsFunc();
        string gender;
        public frmpolicier()
        {
            InitializeComponent();
        }
        ConnectionString cons = new ConnectionString();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void textBox15_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void frmpolicier_Load(object sender, EventArgs e)
        {
            //tabControl1.Controls.Remove(tabPage4);
            //tabControl1.Controls.Remove(tabPage2);
            //tabControl1.Controls.Remove(tabPage3);
            //tabControl1.Controls.Remove(tabPage5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[2];
            tabControl1.SelectedTab = t;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[3];
            tabControl1.SelectedTab = t;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[4];
            tabControl1.SelectedTab = t;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[1];
            tabControl1.SelectedTab = t;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[2];
            tabControl1.SelectedTab = t;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[3];
            tabControl1.SelectedTab = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // tabControl1.Controls.Add(tabPage2);
            //tabControl1.Controls.Add(tabPage3);
            //tabControl1.Controls.Add(tabPage4);
            //tabControl1.Controls.Add(tabPage5);
            //TabPage t = tabControl1.TabPages[1];
            //tabControl1.SelectedTab = t;
            //panel4.Hide();
            TabPage t = tabControl1.TabPages[1];
            tabControl1.SelectedTab = t;
            this.textmatri.Text = "";
            this.textnom.Text = "";
            this.textprenom.Text = "";
            this.texttel.Text = "";
            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
            this.comboBox3.SelectedIndex = -1;
            this.textpere.Text = "";
            this.textmere.Text = "";
            this.comboBox4.SelectedIndex = -1;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void statuscombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (statuscombo.SelectedItem.ToString() == "Marier")
                panel4.Show();
            //MessageBox.Show(statuscombo.SelectedItem.ToString());

        }
        public void nomEpouse1()
        {
            var n = 2;

            //int m = Convert.ToInt32(textBox11.Text);


            for (int i = 1; i < n; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("Nom epouse{0}:", i);
                Label label1 = new Label();
                label1.Text = String.Format("Date mariage{0}:", i);
                Label label2 = new Label();
                label2.Text = String.Format("Nbr Enfant:", i);
                //Position label on screen
                label.Left = 01;
                label.Top = (i + 1) * 40;
                label1.Left = 220;
                label1.Top = (i + 1) * 40;
                label2.Left = 442;
                label2.Top = (i + 1) * 40;
                //Create textbox
                TextBox textBox = new TextBox();
                TextBox textBox1 = new TextBox();
                DateTimePicker d = new DateTimePicker();
                //Position textbox on screen
                textBox.Left = 105;
                textBox.Top = (i + 1) * 40;
                textBox1.Left = 542;
                textBox1.Top = (i + 1) * 40;
                textBox1.Size = new System.Drawing.Size(58, 24);
                d.Location = new System.Drawing.Point(320, 74); ;
                d.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                d.Size = new System.Drawing.Size(120, 24);
                d.Top = (i + 1) * 40;
                //Add controls to form

                tabPage4.Controls.Add(label);
                tabPage4.Controls.Add(label);
                tabPage4.Controls.Add(label1);
                tabPage4.Controls.Add(label2);
                tabPage4.Controls.Add(textBox1);
                tabPage4.Controls.Add(textBox);
                tabPage4.Controls.Add(d);
            }

        }
        //int n;
        private void nbrepousebox_TextChanged_1(object sender, EventArgs e)
        {
            if (nbrepousebox.Text != "")
            {
                int n = Convert.ToInt32(nbrepousebox.Text);
                if (n == 1)
                {
                    nomEpouse1();
                    //nomEnfant();
                }
                //else if (n == 2)
                //{
                    //nomEpouse2();
                //}
                //else if (n == 3)
                    //nomEpouse3();
                //else if (n == 4)
                    //nomEpouse4();
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void importimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg|*.jpg";
            DialogResult res = ofd.ShowDialog();
            if (res == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(ofd.FileName);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (textmatri.Text == "")
                {
                    MessageBox.Show("SVP veuillez saisir le numero du matricule", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textmatri.Focus();
                    return;
                }
                if (textnom.Text == "")
                {
                    MessageBox.Show("SVP veuillez saisir le nom", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textmatri.Focus();
                    return;
                }
                if (textprenom.Text  == "")
                {
                    MessageBox.Show("SVP veuillez saisir le prenom", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textmatri.Focus();
                    return;
                }
                
                if (radioButton1.Checked == true)
                {
                    gender = radioButton1.Text;
                }
                if (radioButton2.Checked == true)
                {
                    gender = radioButton2.Text;
                }
                SqlDataReader rd = null;

                //string query = "INSERT INTO Table1 VALUES( '"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+"' )";
                SqlConnection dbConn;
                dbConn = new SqlConnection(cons.DBConn());
                dbConn.Open();
                SqlCommand cmd = dbConn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                /* cmd.CommandText = "INSERT INTO infoagent VALUES('" + textmatri.Text + "','"
                                                                     + textnom.Text + "','"
                                                                     + gender.ToString() + "','"
                                                                     + dateTimePicker1.Value.ToString() + "', '"
                                                                     + comboBox1.Text + "', '"
                                                                     + comboBox2.Text + "', '"
                                                                     + comboBox3.Text + "', '"
                                                                     + texttel.Text + "', '"
                                                                     + textpere.Text + "', '"
                                                                     + textmere.Text + "', '"
                                                                     + comboBox4.Text+"', image)";*/
                cmd.CommandText = "INSERT INTO profagent VALUES (@d1,@d2,@d3,@d4,@d5,@d6,@d7,@d8,@d9,@d10,@d11,@d12,@d13)";

                //SqlCommand cmd = new SqlCommand(query, dbConn);
                MemoryStream stream = new MemoryStream();
                pictureBox3.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                cmd.Parameters.AddWithValue("@d1", textmatri.Text);
                cmd.Parameters.AddWithValue("@d2", textnom.Text);
                cmd.Parameters.AddWithValue("@d3", textprenom.Text);
                cmd.Parameters.AddWithValue("@d4", gender.ToString());
                cmd.Parameters.AddWithValue("@d5", texttel.Text);
                cmd.Parameters.AddWithValue("@d6", dateTimePicker1.Value.ToString());
                cmd.Parameters.AddWithValue("@d7", comboBox1.Text);
                cmd.Parameters.AddWithValue("@d8", comboBox2.Text);
                cmd.Parameters.AddWithValue("@d9", comboBox3.Text);
                cmd.Parameters.AddWithValue("@d10", textpere.Text);
                cmd.Parameters.AddWithValue("@d11", textmere.Text);
                cmd.Parameters.AddWithValue("@d12", comboBox4.Text);
                cmd.Parameters.AddWithValue("@d13", pic);

                MessageBox.Show(textmatri.Text);
                MessageBox.Show(textnom.Text);
                MessageBox.Show(textprenom.Text);
                MessageBox.Show(gender.ToString());
                MessageBox.Show(texttel.Text);
                MessageBox.Show(dateTimePicker1.Value.ToString());
                MessageBox.Show(comboBox1.Text);
                MessageBox.Show(comboBox2.Text);
                MessageBox.Show(comboBox3.Text);
                MessageBox.Show(textpere.Text);
                MessageBox.Show(textmere.Text);
                MessageBox.Show(comboBox4.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("succedd");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
          // display_data();
            SqlDataReader rd = null;
           SqlConnection dbConn;
           dbConn = new SqlConnection(cons.DBConn());
           dbConn.Open();
           SqlCommand cmd = dbConn.CreateCommand();
           cmd.CommandType = CommandType.Text;
           cmd.CommandText = "select * from profagent where matriculeID = '" + textBox1.Text.ToString() + "'";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            //dataGridView1.DataSource = dt;
            //MessageBox.Show("succedd");

            dataGridView1.Rows.Clear();
            foreach (DataRow dr in dt.Rows)
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
                dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
                dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
                dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
                dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
                dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
                dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
                dataGridView1.Rows[n].Cells[7].Value = dr[7].ToString();
                dataGridView1.Rows[n].Cells[8].Value = dr[8].ToString();
                dataGridView1.Rows[n].Cells[9].Value = dr[9].ToString();
                dataGridView1.Rows[n].Cells[10].Value = dr[10].ToString();
                dataGridView1.Rows[n].Cells[11].Value = dr[11].ToString();
               

            }

        }
       

        

     

        //CellContentClick
       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //textmatri.Text = dataGridView1.Rows[1].Cells[0].Value.ToString();
            //textnom.Text      = dataGridView1.SelectedRows[1].Cells[1].Value.ToString();
            //textprenom.Text   = dataGridView1.SelectedRows[2].Cells[2].Value.ToString();
            //texttel.Text      = dataGridView1.SelectedRows[3].Cells[3].Value.ToString();

        }

       private void textBox1_TextChanged(object sender, EventArgs e)
       {
           

       }

       private void button5_Click(object sender, EventArgs e)
       {
           SqlDataReader rd = null;
           SqlConnection dbConn;
           dbConn = new SqlConnection(cons.DBConn());
           dbConn.Open();
           SqlCommand cmd = dbConn.CreateCommand();
           cmd.CommandType = CommandType.Text;
           string matricule = textBox1.Text.ToString();
           cmd.CommandText = "delete from profagent where matriculeID='" + matricule + "'";
           cmd.ExecuteNonQuery();
           DataTable dt = new DataTable();
           SqlDataAdapter da = new SqlDataAdapter(cmd);
           da.Fill(dt);
           

       }


        

    }
}
