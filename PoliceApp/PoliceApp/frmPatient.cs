using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace PoliceApp
{
    public partial class frmPatient : Form
    {
        ConnectionString cs = new ConnectionString();
        CommonClasses cc = new CommonClasses();
        clsFunc cf = new clsFunc();
        string st1;
        string st2;
        string gender;
        public frmPatient()
        {
            InitializeComponent();
        }

        public void Reset()
        {

            textnomagent1.Text = "";

            txtMatricule.Text = "";
            rbMale.Checked = false;
            rbFemale.Checked = false;
           // dtpDOB.Text = System.DateTime.Today.ToString();
           
            textnomagent1.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            auto();
        }


        private void delete_records()
        {

            try
            {
                int RowsAffected = 0;
                cc.con = new SqlConnection(cs.DBConn());
                cc.con.Open();
                string ct = "delete from Patient where P_ID=@d1";
                cc.cmd = new SqlCommand(ct);
                cc.cmd.Connection = cc.con;
              
                RowsAffected = cc.cmd.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    st2 = "deleted the Patient '" + textnomagent1.Text + "' having Patient id '" + txtMatricule.Text + "'";
                    cf.LogFunc(st1, System.DateTime.Now, st2);
                    MessageBox.Show("Successfully deleted", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("No Record found", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                if (cc.con.State == ConnectionState.Open)
                {
                    cc.con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void auto()
        {
            try
            {
                int Num = 0;
                cc.con = new SqlConnection(cs.DBConn());
                cc.con.Open();
                string sql = "SELECT MAX(P_ID+1) FROM Patient";
                cc.cmd = new SqlCommand(sql);
                cc.cmd.Connection = cc.con;
                if (Convert.IsDBNull(cc.cmd.ExecuteScalar()))
                {
                    Num = 1;
                 
                    txtMatricule.Text = "P-" + Convert.ToString(Num);
                }
                else
                {
                    Num = (int)(cc.cmd.ExecuteScalar());
                   
                    txtMatricule.Text = "P-" + Convert.ToString(Num);
                }
                cc.cmd.Dispose();
                cc.con.Close();
                cc.con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }




        private void btnUpdate_Click(object sender, EventArgs e)
        {
            /*  try
              {
                  if (txtPatientName.Text == "")
                  {
                      MessageBox.Show("Please enter patient name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtPatientName.Focus();
                      return;
                  }
                  if (rbMale.Checked == false && rbFemale.Checked == false)
                  {
                      MessageBox.Show("Please select gender", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      return;
                  }
                  if (txtInsuranceCompany.Text == "")
                  {
                      MessageBox.Show("Please enter insurance company", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtInsuranceCompany.Focus();
                      return;
                  }
                  if (txtAddress.Text == "")
                  {
                      MessageBox.Show("Please enter address", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtAddress.Focus();
                      return;
                  }
                  if (txtBillingContactPerson.Text == "")
                  {
                      MessageBox.Show("Please enter billing contact person", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtBillingContactPerson.Focus();
                      return;
                  }
                  if (txtTelephoneNo.Text == "")
                  {
                      MessageBox.Show("Please enter telephone no.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      txtTelephoneNo.Focus();
                      return;
                  }
                  if (rbMale.Checked == true)
                  {
                      gender = rbMale.Text;
                  }
                  if (rbFemale.Checked == true)
                  {
                      gender = rbFemale.Text;
                  }
                  cc.con = new SqlConnection(cs.DBConn());
                  cc.con.Open();
                  string cb = "Update Patient set PatientID=@d2,Name=@d3,Address=@d4,BillingContactPerson=@d5,TelephoneNo=@d6,Email=@d7,InsuranceCompany=@d8,Gender='" + gender + "',DOB=@d10,ContactNo=@d9 where P_ID=@d1";
                  cc.cmd = new SqlCommand(cb); 
                  cc.cmd.Connection = cc.con;
                  cc.cmd.Parameters.AddWithValue("@d1", txtID.Text);
                  cc.cmd.Parameters.AddWithValue("@d2", txtPatientID.Text);
                  cc.cmd.Parameters.AddWithValue("@d3", txtPatientName.Text);
                  cc.cmd.Parameters.AddWithValue("@d4", txtAddress.Text);
                  cc.cmd.Parameters.AddWithValue("@d5", txtBillingContactPerson.Text);
                  cc.cmd.Parameters.AddWithValue("@d6", txtTelephoneNo.Text);
                  cc.cmd.Parameters.AddWithValue("@d7", txtEmailID.Text);
                  cc.cmd.Parameters.AddWithValue("@d8", txtInsuranceCompany.Text);
                  cc.cmd.Parameters.AddWithValue("@d9", txtContactNo.Text);
                  cc.cmd.Parameters.AddWithValue("@d10", dtpDOB.Text);
                  cc.cmd.ExecuteReader();
                  cc.con.Close();
                  st1 = lblUser.Text;
                  st2 = "updated the Patient '" + txtPatientName.Text + "' having Patient id '" + txtPatientID.Text + "'";
                  cf.LogFunc(st1, System.DateTime.Now, st2);
                btnUpdate.Enabled = false;
                MessageBox.Show("Successfully updated", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            Reset();
        }



        private void txtEmailID_Validating(object sender, CancelEventArgs e)
        {
            /* System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
             if (txtEmailID.Text.Length > 0)
             {
                 if (!rEMail.IsMatch(txtEmailID.Text))
                 {
                     MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     txtEmailID.SelectAll();
                     e.Cancel = true;
                 }
             }*/
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                delete_records();
            }
        }


        private void btnGetData_Click(object sender, EventArgs e)
        {
            /* this.Hide();
             frmPatientRecord frm = new frmPatientRecord();
             frm.Reset();
             frm.lblOperation.Text = "Patient Master";
             frm.lblUser.Text = lblUser.Text;
             frm.Show();*/
        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
                groupBox2.Controls.Add(label);
                groupBox2.Controls.Add(label1);
                groupBox2.Controls.Add(label2);
                groupBox2.Controls.Add(textBox1);
                groupBox2.Controls.Add(textBox);
                groupBox2.Controls.Add(d);
            }

        }
        public void nomEpouse2()
        {
            var n = 3;

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
                groupBox2.Controls.Add(label);
                groupBox2.Controls.Add(label1);
                groupBox2.Controls.Add(textBox);
                groupBox2.Controls.Add(label2);
                groupBox2.Controls.Add(textBox1);
                groupBox2.Controls.Add(d);
            }

        }
        public void nomEpouse3()
        {
            var n = 4;

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
                groupBox2.Controls.Add(label);
                groupBox2.Controls.Add(label1);
                groupBox2.Controls.Add(textBox);
                groupBox2.Controls.Add(label2);
                groupBox2.Controls.Add(textBox1);
                groupBox2.Controls.Add(d);
            }

        }
        public void nomEpouse4()
        {
            var n = 5;

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
                groupBox2.Controls.Add(label);
                groupBox2.Controls.Add(label1);
                groupBox2.Controls.Add(textBox);
                groupBox2.Controls.Add(label2);
                groupBox2.Controls.Add(textBox1);
                groupBox2.Controls.Add(d);
            }

        }
        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void textBox10_Enter(object sender, EventArgs e)
        {

        }

        private void textBox10_Click(object sender, EventArgs e)
        {


        }

        private void textBox10_Validating(object sender, CancelEventArgs e)
        {
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
             if (textBox11.Text != "")
            {
                int n = Convert.ToInt32(textBox11.Text);
                if (n == 1)
                {
                    nomEpouse1();
                    nomEnfant();
                }
                else if (n == 2)
                {
                    nomEpouse2();
                }
                else if (n == 3) 
                nomEpouse3();
                else if (n==4)
                nomEpouse4();
            }
            
               
           

        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox11_Validating(object sender, CancelEventArgs e)
        {
         
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            tabControl1.Controls.Remove(tabPage4);
            tabControl1.Controls.Remove(tabPage2);
            tabControl1.Controls.Remove(tabPage3); 
            tabControl1.Controls.Remove(tabPage5);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
         
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage5);
            TabPage t = tabControl1.TabPages[1];
            tabControl1.SelectedTab = t;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("dedans");
                   
            try
            {
                if (txtMatricule.Text == "")
                {
                    MessageBox.Show("Please enter numero matricule", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMatricule.Focus();
                    return;
                }
                if (textnomagent1.Text == "")
                {
                    MessageBox.Show("Please enter nom prenom agent", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtMatricule.Focus();
                    return;
                }

               /* if (txtnommere1.Text == "" && textnomagent2.Text == "" && textnomagent3.Text == "")
                {
                    MessageBox.Show("Please enter nom prenom de la mere", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //txtMatricule.Focus();
                    return;
                }*/

                if (rbMale.Checked == false && rbFemale.Checked == false)
                {
                    MessageBox.Show("Please select gender", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (rbMale.Checked == true)
                {
                    gender = rbMale.Text;
                }
                if (rbFemale.Checked == true)
                {
                    gender = rbFemale.Text;
                }


                cc.con = new SqlConnection(cs.DBConn());
                cc.con.Open();
                string cb = "insert into agent(Nummatricule,Nompolicier,Nommere,sexe ) VALUES (@d1,@d2,@d3)";
                cc.cmd = new SqlCommand(cb);
                cc.cmd.Connection = cc.con;
                cc.cmd.Parameters.AddWithValue("@d1", txtMatricule.Text);
                cc.cmd.Parameters.AddWithValue("@d2", textnomagent1.Text);
               // cc.cmd.Parameters.AddWithValue("@d3", txtnommere1.Text);
                cc.cmd.ExecuteReader();
                cc.con.Close();
               // st1 = lblUser.Text;
                //st2 = "added the new Patient '" + textnomagent1.Text + "' having Patient id '" + txtMatricule.Text + "'";
                //cf.LogFunc(st1, System.DateTime.Now, st2);
                //btnSave.Enabled = false;
                MessageBox.Show("Successfully saved", "Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void nomEnfant()
        {
            var n = 16;

            //int m = Convert.ToInt32(textBox11.Text);


            for (int i = 1; i < n; i++)
            {
                //Create label
                Label label = new Label();
                label.Text = String.Format("Nom enfant{0}:", i);
                Label label1 = new Label();
                label1.Text = String.Format("Date de naissance{0}:", i);
                Label label2 = new Label();
              //  label2.Text = String.Format("Nbr Enfant:", i);
                //Position label on screen
                label.Left = 03;
                label.Top = (i + 1) * 60;
                label1.Left = 220;
                label1.Top = (i + 1) * 60;
                label2.Left = 442;
                label2.Top = (i + 1) * 60;
                //Create textbox
                TextBox textBox = new TextBox();
                TextBox textBox1 = new TextBox();
                DateTimePicker d = new DateTimePicker();
                //Position textbox on screen
                textBox.Left = 200;
                textBox.Top = (i + 1) * 60;
                textBox1.Left = 542;
                textBox1.Top = (i + 1) * 60;
                textBox1.Size = new System.Drawing.Size(58, 24);
                d.Location = new System.Drawing.Point(320, 74); ;
                d.Format = System.Windows.Forms.DateTimePickerFormat.Short;
                d.Size = new System.Drawing.Size(120, 24);
                d.Top = (i + 1) * 40;
                //Add controls to form
                groupBox2.Controls.Add(label);
                groupBox2.Controls.Add(label1);
                groupBox2.Controls.Add(label2);
                groupBox2.Controls.Add(textBox1);
                groupBox2.Controls.Add(textBox);
                groupBox2.Controls.Add(d);
            }

        }

        private void txtPatientID_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void combolieu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
        
        private void button9_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[2];
            tabControl1.SelectedTab = t;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[3];
            tabControl1.SelectedTab = t; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[4];
            tabControl1.SelectedTab = t; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[2];
            tabControl1.SelectedTab = t; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[1];
            tabControl1.SelectedTab = t;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TabPage t = tabControl1.TabPages[3];
            tabControl1.SelectedTab = t;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
    }
}

    
