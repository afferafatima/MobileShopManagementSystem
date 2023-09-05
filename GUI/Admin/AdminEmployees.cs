using MSMSGUI.BL;
using MSMSGUI.DL;
using pdfExplorer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MSMSGUI.GUI.Panels
{
    public partial class AdminEmployees : UserControl
    {
        private int employeeidx;
        private Employee Employee=new Employee();
        private List<Employee> Employees=EmployeeDL.Employees;
        public AdminEmployees()
        {
            InitializeComponent();
            timer.Enabled = true;
            btnCancel.Enabled = true;
            InitializeDataTable();
            dataBinding();
        }
        private void AddEmployees_Load(object sender, EventArgs e)
        {
        }
        private void Username_txtChanged(object sender, EventArgs e)
        {
            if (!Validations.IsValidUsername(txtUsername.Text))
            {
                errorProvider.SetError(txtUsername, "Enter Valid Username");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void Password_txtChanged(object sender, EventArgs e)
        {
            if (!Validations.IsValidPassword(txtPassword.Text))
            {
                errorProvider.SetError(txtPassword, "Enter Valid Password");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            employeeidx = EmployeeDL.EmployeeExists(txtUsername.Text, txtPassword.Text);
            if (employeeidx != -1)
            {
                Employee = EmployeeDL.GetEmployee(employeeidx);

                txtPhoneNumber.Text = Employee.PhoneNumber;
                txtAttendance.Text = Employee.Attendance1.ToString();
                txtOneDaySalary.Text = Employee.OneDaySalary1.ToString();
                txtTotalSalary.Text = (Employee.Attendance1 * Employee.OneDaySalary1).ToString();
                checkboxVoucher.Checked = Employee.Voucher1;
                EnableButtons(false, true, true, true, true, true);
            }
            else if (employeeidx == -1)
            {
                //all inputs are valid and not existing employee
                if (validInputs())
                {
                    EnableButtons(true, false, false, true, true, true);
                }
                else
                {
                    EnableButtons(false, false, false, true, true, true);
                }
            }
        }
        private void Phonenumber_txtChanged(object sender, EventArgs e)
        {
            if (!Validations.IsValidPhoneNumber(txtPhoneNumber.Text))
            {
                errorProvider.SetError(txtPhoneNumber, "Enter Valid PhoneNumber");
            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void Attendance_txtChanged(object sender, EventArgs e)
        {
            if (!Validations.isValidNumber(txtAttendance.Text))
            {
                errorProvider.SetError(txtAttendance, "Enter Valid Integer Value");

            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void oneDaySalary_txtChanged(object sender, EventArgs e)
        {
            if (!Validations.isValidNumber(txtOneDaySalary.Text))
            {
                errorProvider.SetError(txtOneDaySalary, "It can only consist of Numeric Values");

            }
            else
            {
                errorProvider.Clear();
            }
        }
        private void txtTotalSalary_TextChanged(object sender, EventArgs e)
        {
            if (Validations.isValidNumber(txtAttendance.Text) && Validations.isValidNumber(txtOneDaySalary.Text))
            {
                txtTotalSalary.Text = (int.Parse(txtAttendance.Text) * double.Parse(txtOneDaySalary.Text)).ToString();
            }
        }
        private void EnableButtons(bool add, bool edit, bool delete, bool print, bool save, bool update)
        {
            btnAdd.Enabled = add;
            btnDelete.Enabled = delete;
            btnEdit.Enabled = edit;
            btnSave.Enabled = save;
            btnPrint.Enabled = print;
            btnUpdate.Enabled = update;
        }
        private void VisibleButtons(bool add, bool edit, bool delete, bool print, bool save, bool cancel, bool update)
        {
            btnAdd.Visible = add;
            btnDelete.Visible = delete;
            btnEdit.Visible = edit;
            btnSave.Visible = save;
            btnPrint.Visible = print;
            btnCancel.Visible = cancel;
            btnUpdate.Visible = update;
        }
        private void TextBoxClear()
        {
            txtAttendance.Text = null;
            txtOneDaySalary.Text = null;
            txtPassword.Text = null;
            txtPhoneNumber.Text = null;
            txtTotalSalary.Text = null;
            txtUsername.Text = null;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee(txtUsername.Text, txtPassword.Text, txtPhoneNumber.Text, int.Parse(txtAttendance.Text), double.Parse(txtOneDaySalary.Text), checkboxVoucher.Checked);
            Employee = employee;
            EmployeeDL.addEmployee(employee);
            MessageBox.Show("Employee Added Successfully\nPress Save Button to Save your Changed Information");
            dataBinding();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<Employee> list = EmployeeDL.Employees;
            foreach(Employee employee in list)
            {
                MessageBox.Show(employee.toString());
            }
            EmployeeDL.writeData();

            MessageBox.Show("You Saved your data Successfully");
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            VisibleButtons(false, false, false, false, false, true, true);
            btnCancel.Enabled = true;
            timer.Enabled = false;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            VisibleButtons(true, true, true, true, true, false, false);
            EnableButtons(false, false, false, true, true, true);
            TextBoxClear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            EmployeeDL.removeEmployee(employeeidx);
            MessageBox.Show("Employee Removed Succesfully\nPress Save Button to save your changes");
            TextBoxClear();
            dataBinding();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (validInputs())
            {
                Employee employee = new Employee(txtUsername.Text, txtPassword.Text, txtPhoneNumber.Text, int.Parse(txtAttendance.Text), double.Parse(txtOneDaySalary.Text), checkboxVoucher.Checked);
                EmployeeDL.updateEmployeeInfo(employeeidx, employee);
                MessageBox.Show("Update Successfully");
                VisibleButtons(true, true, true, true, true, false, false);
                TextBoxClear();
                dataBinding();
            }
            timer.Enabled = true;
        }
        private bool validInputs()
        {
            if (Validations.IsValidUsername(txtUsername.Text) && Validations.IsValidPassword(txtPassword.Text) && Validations.IsValidPhoneNumber(txtPhoneNumber.Text) && Validations.isValidNumber(txtAttendance.Text) && Validations.isValidNumber(txtOneDaySalary.Text))
            {
                return true;
            }
            return false;
        }
        private void txtTotalSalary_Click(object sender, EventArgs e)
        {
            if (Validations.isValidNumber(txtAttendance.Text) && Validations.isValidNumber(txtOneDaySalary.Text))
            {
                txtTotalSalary.Text = (int.Parse(txtAttendance.Text) * double.Parse(txtOneDaySalary.Text)).ToString();
            }
        }
        private void dataBinding()
        {
            DataTable.DataSource = null;
            DataTable.Rows.Clear();
            foreach (var o in EmployeeDL.Employees)
            {
                double Salary = o.Attendance1 * o.OneDaySalary1;
                DataTable.Rows.Add(o.Name1, o.Password1, o.PhoneNumber, o.Attendance1, o.OneDaySalary1, Salary, o.Voucher1);
            }
            DataTable.Refresh();
        }
        private void InitializeDataTable()
        {
            // Column headers for the DataTable
            string[] columnHeaders = { "Name", "Password","PhoneNumber", "Attendance", "OneDaySalary", "Salary", "Voucher" };
            // Add columns using a loop

            foreach (var columnHeader in columnHeaders)
            {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.HeaderText = columnHeader;
                DataTable.Columns.Add(col);
            }
        }
      
        private void fillTextBox()
        {
            txtUsername.Text = Employee.Name1;
            txtPassword.Text = Employee.Password1;
            txtPhoneNumber.Text = Employee.PhoneNumber;
            txtOneDaySalary.Text = Employee.OneDaySalary1.ToString();
            txtAttendance.Text = Employee.Attendance1.ToString();
            txtTotalSalary.Text = (Employee.OneDaySalary1 * Employee.Attendance1).ToString();
        }
       

        private void DataTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            employeeidx = DataTable.CurrentRow.Index;
            Employee=EmployeeDL.GetEmployee(employeeidx);
            fillTextBox();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            PdfGenerator pdf = new PdfGenerator();
            pdf.GeneratePdfReport(Employees);
        }
    }
}
