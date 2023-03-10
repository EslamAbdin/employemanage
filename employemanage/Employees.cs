using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employemanage
{
    public partial class Employees : Form
    {
        Functions Con;
        public Employees()
        {
           InitializeComponent();
           Con = new Functions();
           ShowEmp();
           GetDepartments();
        }
        private void ShowEmp()
        {
            try
            {
               string Query = "Select * from EmpoyeeTb1";
               EmployeeList.DataSource = Con.GetData(Query);
            }
            catch
            {
                throw;
            }
        }
        private void GetDepartments()
        {
           string Query = "Select * from DepartmentTb1";
           DepCb.DisplayMember = Con.GetData(Query).Columns["Depname"].ToString();
           DepCb.ValueMember = Con.GetData(Query).Columns["Depid"].ToString();
           DepCb.DataSource = Con.GetData(Query);
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emploees_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DepList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("missing date!!!!");
                }
                else
                {
                   string Name = EmpNameTb.Text;
                   string Gender = GenCb.SelectedItem.ToString();
                   int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                   string DOB = DOBTb.Value.ToString();
                   string JDate = JDateTb.Value.ToString();
                   int Salary = Convert.ToInt32(DailySalTb.Text);
                   string Query = "insert into EmpoyeeTb1 values('{0}','{1}',{2},'{3}','{4}',{5})";
                   Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary);
                   Con.SetData(Query);
                   ShowEmp();
                   MessageBox.Show("Emoloyee Updated!!!");
                   EmpNameTb.Text = "";
                   DailySalTb.Text = "";
                   GenCb.SelectedIndex = -1;
                   DepCb.SelectedIndex = -1;
                }
            }
                catch(Exception Ex) {
                MessageBox.Show(Ex.Message);
            }
        }

         private void DeleteBtn_Click(object sender, EventArgs e)
        {
             try
            {
                if (key == 0)
                {
                     MessageBox.Show("missing data!!!");
                }
                else
                {
                     string Name = EmpNameTb.Text;
                     string Gender = GenCb.SelectedItem.ToString();
                     int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                     string DOB = DOBTb.Value.ToString();
                      string JDate = JDateTb.Value.ToString();
                     int Salary = Convert.ToInt32(DailySalTb.Text);
                     string Query = "Delete from EmpoyeeTb1 where Empid= {0}";
                     Query = string.Format(Query, key);
                     Con.SetData(Query);
                    ShowEmp();
                     MessageBox.Show("Emoloyee Deleted!!!");
                     EmpNameTb.Text = "";
                     DailySalTb.Text = "";
                     GenCb.SelectedIndex = -1;
                     DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (EmpNameTb.Text == "" || GenCb.SelectedIndex == -1 || DepCb.SelectedIndex == -1 || DailySalTb.Text == "")
                {
                    MessageBox.Show("missing data!!!");
                }
                else
                {
                    string Name = EmpNameTb.Text;
                    string Gender = GenCb.SelectedItem.ToString();
                    int Dep = Convert.ToInt32(DepCb.SelectedValue.ToString());
                    string DOB = DOBTb.Value.Date.ToString();
                    string JDate = JDateTb.Value.Date.ToString();
                    int Salary = Convert.ToInt32(DailySalTb.Text);
                    string Query = "Update EmpoyeeTb1 set EmpName = '{0}',EmpGen='{1}',EmpDep={2},EmpDOB='{3}',Empjdate='{4}',EmpSal={5} where Empid= {6}";
                    Query = string.Format(Query, Name, Gender, Dep, DOB, JDate, Salary, key);
                    Con.SetData(Query);
                    ShowEmp();
                    MessageBox.Show("Emoloyee Updated!!!");
                    EmpNameTb.Text = "";
                    DailySalTb.Text = "";
                    GenCb.SelectedIndex = -1;
                    DepCb.SelectedIndex = -1;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }
        int key = 0;
         private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             EmpNameTb.Text = EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
             GenCb.Text = EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
             DepCb.SelectedValue = EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
             DOBTb.Text = EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
             JDateTb.Text = EmployeeList.SelectedRows[0].Cells[5].Value.ToString();
             DailySalTb.Text = EmployeeList.SelectedRows[0].Cells[6].Value.ToString();
             if (EmpNameTb.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

         private void pictureBox3_Click(object sender, EventArgs e)
        {
             Departments obj = new Departments();
             obj.Show();
             this.Hide();
        }

         private void pictureBox4_Click(object sender, EventArgs e)
        {
             Login obj = new Login();
             obj.Show();
             this.Hide();
        }
    }
}
