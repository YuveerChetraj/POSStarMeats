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



namespace StarMeatsPos
{
    public partial class Login : Form
    {
        public static int empID;
        public static string fName, lName;
        public static Boolean isManager = false;
        public Login()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

       

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string pass = textBoxPassword.Text.Trim();
            string name = textBoxUserName.Text;
            string emp_r = "";

            if (name == "DeenaMurugan")
            {
                if (pass == "DM123456")
                {
                    String underStockLevel = "Product under restock level :\r\n";
                    this.productBindingSource.MoveFirst();
                    //
                    foreach (DataRow row in group3DataSet.Product.Rows)
                    {
                        DataRowView current = (DataRowView)this.productBindingSource.Current;
                        if (current["Prod_Category"].Equals("Butchery Meat") && (Convert.ToInt32(current["Prod_Id"]) != 31) || (Convert.ToInt32(current["Prod_Id"]) == 50))
                        {
                            if (Convert.ToDouble(current["Prod_Quantity_Available_kg"]) <= Convert.ToInt32(current["Reorder_level"]))
                            {
                                underStockLevel += current["Prod_Description"] + "\r\n";
                            }
                        }
                        else
                        {
                            if (Convert.ToDouble(current["Prod_Quantity_Available_unit"]) <= Convert.ToInt32(current["Reorder_level"]))
                            {
                                underStockLevel += current["Prod_Description"] + "\r\n";
                            }
                        }
                        productBindingSource.MoveNext();
                    }
                    StarMeats.ActiveForm.Hide();
                    StarMeats sM = new StarMeats("Manager");
                    isManager = true;
                    sM.Show();
                    MessageBox.Show(underStockLevel);
                    sM.loadUser("Deena Murugan", "Manager");
                }

            }
            else
            {
                int numPos = 0;
                int namelen = name.Length;
                for (int i = 0; i < namelen; i++)
                {
                    if (((int)(name[i])) < 58)
                    {
                        numPos = i;
                    }
                }

                if (numPos == 0)//new
                {
                    MessageBox.Show("invalid login");
                    //textBoxUserName.Text = "UserName";
                    //textBoxUserName.Text = "Password";
                }
                else
                {
                    int numPos2 = numPos - 1;
                    empID = ((int)Char.GetNumericValue(name[numPos2])) * 10 + (int)Char.GetNumericValue(name[numPos]);

                    lName = name.Substring(numPos + 1);
                    fName = name.Substring(0, (numPos2));

                    SqlConnection sqlcon = new SqlConnection(@"Data Source=146.230.177.46\ist3;Initial Catalog=group3;User ID=group3;Password=r732k");
                    string q1 = "select * from Employee Where Employee_Id ='" + empID + "' and Employee_Name='" + fName + "'and Employee_Surname='" + lName + "' and Employee_Password ='" + pass + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(q1, sqlcon);
                    DataTable dtbl = new DataTable();
                    sda.Fill(dtbl);
                    if (dtbl.Rows.Count == 1)
                    {

                        string q2 = "select Employee_Role from Employee Where Employee_Id ='" + empID + "'";
                        SqlCommand cmd1 = new SqlCommand(q2, sqlcon);

                        SqlDataReader emp_role = null;
                        sqlcon.Open();
                        emp_role = cmd1.ExecuteReader();

                        while (emp_role.Read())
                        {
                            emp_r = emp_role["Employee_Role"].ToString();
                        }

                        sqlcon.Close();
                        isManager = false;
                        StarMeats.ActiveForm.Hide();
                        StarMeats s = new StarMeats(emp_r);
                        s.Show();
                        employeeTableAdapter1.FillEmployee(group3DataSet.Employee, Login.empID);
                        s.loadUser(group3DataSet.Employee.Rows[0].ItemArray[1].ToString() + " " + group3DataSet.Employee.Rows[0].ItemArray[2].ToString(), group3DataSet.Employee.Rows[0].ItemArray[5].ToString());
                    }
                    else
                        MessageBox.Show("invalid login");
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public static int EmployeeID
        {
            get
            {
                return empID;
            }
        }

        private void textBoxPassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = "";
        }

        private void textBoxUserName_Click(object sender, EventArgs e)
        {
            textBoxUserName.Text = "";
        }

        private void Login_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group3DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.group3DataSet.Product);

        }

        public static string EmpName
        {
            get
            {
                return fName + " " + lName;
            }
        }
    }
}