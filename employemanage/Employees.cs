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
            ShowDepartments();
        }
        private void ShowDepartments()
        {
            string Query = "Select * from DepartmentTb1";
            Deplist.DataSource = Con.GetData(Query);
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
        int key = 0;
        private void DepList_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
           
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
         
         
        }

        private void EmployeeList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
