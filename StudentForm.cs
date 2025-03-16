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
using System.Collections;

namespace Vector_International
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MSI\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
        string connectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True";

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void label15_Click(object sender, EventArgs e)
        {
        }
        //input data//
        private void label2_Click(object sender, EventArgs e)//logout//
        {
            DialogResult dialogResult = MessageBox.Show("Are you really want to logout?", "Log out!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();

            }
            else
            {

            }


        }
        private void label19_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you really want to exit?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you really want to clear all the data?", "Clear Data!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (dialogResult == DialogResult.Yes)
            {
                Fnametxt.Clear();
                Lnametxt.Clear();
                malebutton.Checked = false;
                femalebutton.Checked = false;
                addresstxt.Clear();
                emailtxt.Clear();
                Mobilephonetxt.Clear();
                Homephonetxt.Clear();
                parenttxt.Clear();
                Nictxt.Clear();
                Contactnumtxt.Clear();
            }
            else
            {

            }
        }

        private void malebutton_CheckedChanged(object sender, EventArgs e)
        {
            femalebutton.Checked = false;
        }

        private void femalebutton_CheckedChanged(object sender, EventArgs e)
        {
            malebutton.Checked = false;
        }

        private void registerbtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Taking the inputs
                string fname = Fnametxt.Text;
                string lname = Lnametxt.Text;
                string gender = malebutton.Checked ? "Male" : "Female";
                string dob = dobPicker.Value.ToString("yyyy-MM-dd"); // Format the date correctly
                string address = addresstxt.Text;
                string email = emailtxt.Text;
                string mphone = Mobilephonetxt.Text;
                string hphone = Homephonetxt.Text;
                string pname = parenttxt.Text;
                string Nic = Nictxt.Text;
                string Cnum = Contactnumtxt.Text;

                // SQL insert data
                string query_insert = "INSERT INTO Student VALUES(@fname, @lname, @dob, @gender, @address, @email, @mphone, @hphone, @pname, @Nic, @Cnum); SELECT SCOPE_IDENTITY();";
                SqlCommand cmnd = new SqlCommand(query_insert, con);

                // Add parameters
                cmnd.Parameters.AddWithValue("@fname", fname);
                cmnd.Parameters.AddWithValue("@lname", lname);
                cmnd.Parameters.AddWithValue("@dob", dob);
                cmnd.Parameters.AddWithValue("@gender", gender);
                cmnd.Parameters.AddWithValue("@address", address);
                cmnd.Parameters.AddWithValue("@email", email);
                cmnd.Parameters.AddWithValue("@mphone", mphone);
                cmnd.Parameters.AddWithValue("@hphone", hphone);
                cmnd.Parameters.AddWithValue("@pname", pname);
                cmnd.Parameters.AddWithValue("@Nic", Nic);
                cmnd.Parameters.AddWithValue("@Cnum", Cnum);

                con.Open();
                // Execute the command and get the last inserted ID
                int insertedID = Convert.ToInt32(cmnd.ExecuteScalar());
                con.Close();

                MessageBox.Show("Record added Successfully!\nStudent Name: " + fname + " " + lname + "\nRegistration number: " + insertedID, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dobPicker_ValueChanged(object sender, EventArgs e)
        {
            dobPicker.CustomFormat = "dd/MM/yyyy";
        }

        private void dobPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                dobPicker.CustomFormat = " ";

            }
        }
        private void LoadDataIntoDropdown()
        {
            string query = "SELECT id FROM Student"; // Assuming RegNo is the registration number column
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    comboBox1.DataSource = table;
                    comboBox1.DisplayMember = "id"; // DisplayMember should be the name of the column you want to display
                    comboBox1.ValueMember = "id"; // ValueMember should be the name of the column whose value you want to retrieve
                }
            }
        }
        private void updatebtn_Click(object sender, EventArgs e)
        {
            string gender;
            if (malebutton.Checked)
            {
                gender = "Male";

            }
            else
            {
                gender = "Female";
            }
            try
            {
                int selected_id = int.Parse(comboBox1.Text);
                string updatesql = "UPDATE Student SET firstname=@FirstName, lastname=@LastName, dateOfBirth=@DateOfBirth, gender=@Gender, address=@Address, email=@Email, mobilephone=@MobilePhone, homephone=@HomePhone, parentname=@ParentName, nic=@NIC, contactno=@ContactNo WHERE id=@ID";
                SqlCommand command = new SqlCommand(updatesql, con);


                //Add Parameters to command//
                command.Parameters.AddWithValue("@FirstName", Fnametxt.Text);
                command.Parameters.AddWithValue("@LastName", Lnametxt.Text);
                command.Parameters.AddWithValue("@DateOfBirth", dobPicker.Value);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@Address", addresstxt.Text);
                command.Parameters.AddWithValue("@Email", emailtxt.Text);
                command.Parameters.AddWithValue("@MobilePhone", Mobilephonetxt.Text);
                command.Parameters.AddWithValue("@HomePhone", Homephonetxt.Text);
                command.Parameters.AddWithValue("@ParentName", parenttxt.Text);
                command.Parameters.AddWithValue("@NIC", Nictxt.Text);
                command.Parameters.AddWithValue("@ContactNo", Contactnumtxt.Text);
                command.Parameters.AddWithValue("@ID", selected_id);
                
                con.Open();
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show(rowsAffected + " row(s) updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error occurred while updating!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                try
                {
                    string selectedRegNo = comboBox1.Text;
                    string query = "SELECT * FROM Student WHERE id = @id";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@id", selectedRegNo);
                        connection.Open(); // Open the connection

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count > 0)
                        {
                            // Assuming txtField1, txtField2, etc. are TextBox controls for other fields in your form
                            Fnametxt.Text = table.Rows[0]["id"].ToString(); // Populate other fields similarly
                           
                            // Populate other fields as needed
                        }
                        else
                        {
                            // Clear fields if no record found
                            Fnametxt.Text = "";
                       
                            // Clear other fields similarly
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error occurred while fetching data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                string deletesql = "DELETE FROM Student WHERE id=@ID";
                SqlCommand delete = new SqlCommand(deletesql, con);
                delete.Parameters.AddWithValue("@ID", comboBox1.Text);

                con.Open();
                int rowsAffected = delete.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Item successfully deleted", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Record not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
