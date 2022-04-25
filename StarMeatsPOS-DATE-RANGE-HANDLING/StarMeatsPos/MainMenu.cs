using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarMeatsPos
{
    public partial class StarMeats : Form
    {
        public StarMeats()
        {
            InitializeComponent();
            customizeDesign();

            iconButtonSales.Enabled = false;
            iconButtonOrders.Enabled = false;
            iconButtonProducts.Enabled = false;
            iconButtonStaff.Enabled = false;
            iconButtonCustomers.Enabled = false;
            iconButtonReports.Enabled = false;

        }
        public StarMeats(string emp_type)
        {
            InitializeComponent();
            customizeDesign();

            string emp_t = emp_type;

            if (emp_t == "Manager")
            {
                iconButtonSales.Enabled = true;
                iconButtonOrders.Enabled = true;
                iconButtonProducts.Enabled = true;
                iconButtonStaff.Enabled = true;
                iconButtonCustomers.Enabled = true;
                iconButtonReports.Enabled = true;
            }

            if (emp_t == "Cashier")
            {
                iconButtonSales.Enabled = true;
                btnProcessOrder.Enabled = true;
                iconButtonOrders.Enabled = false;
                iconButtonProducts.Enabled = true;
                buttonManageProducts.Enabled = false;
                iconButtonStaff.Enabled = true;
                button1.Enabled = false;
                iconButtonCustomers.Enabled = false;
                iconButtonReports.Enabled = false;
                btnViewSales.Enabled = false;
            }

            if (emp_t == "Butcher")
            {
                iconButtonSales.Enabled = false;
                iconButtonOrders.Enabled = true;
                buttonProcessOrders.Enabled = false;
                //buttonManageOrder.Enabled = false;
                iconButtonProducts.Enabled = true;
                buttonManageProducts.Enabled = false;
                iconButtonStaff.Enabled = true;
                button1.Enabled = false;
                iconButtonCustomers.Enabled = false;
                iconButtonReports.Enabled = false;
            }

        }
        public void setText(string s) {
            this.Text = s;
        }
        public void customizeDesign()
        {
            panelCustomers.Visible = false;
            panelProducts.Visible = false;
            panelSales.Visible = false;
            panelReports.Visible = false;
            panelStaff.Visible = false;
            panelOrders.Visible = false;
        }

        private void hideSubMenu()
        {
            if (panelCustomers.Visible == true)
            {
                panelCustomers.Visible = false;
            }
            if (panelProducts.Visible == true)
            {
                panelProducts.Visible = false;
            }
            if (panelSales.Visible == true)
            {
                panelSales.Visible = false;
            }
            if (panelOrders.Visible == true)
            {
                panelOrders.Visible = false;
            }
            if (panelReports.Visible == true)
            {
                panelReports.Visible = false;
            }
            if (panelStaff.Visible == true)
            {
                panelStaff.Visible = false;
            }

        }

        private void showSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                hideSubMenu();
                SubMenu.Visible = true;
            }
            else
            {
                SubMenu.Visible = false;
            }
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            setText("Process Order");
            openChildForm(new ProcessOrder());

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonReports_Click(object sender, EventArgs e)
        {
            showSubMenu(panelReports);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelCustomers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonSales_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSales);
        }

        private void iconButtonOrders_Click(object sender, EventArgs e)
        {
            showSubMenu(panelOrders);
        }

        private void iconButtonProducts_Click(object sender, EventArgs e)
        {
            showSubMenu(panelProducts);
        }

        private void iconButtonStaff_Click(object sender, EventArgs e)
        {
            showSubMenu(panelStaff);
        }

        private void iconButtonCustomers_Click(object sender, EventArgs e)
        {
            showSubMenu(panelCustomers);
        }

        private void buttonManageProducts_Click(object sender, EventArgs e)
        {
            setText("Manage Products");
            hideSubMenu();
            openChildForm(new Products());
        }

        private void buttonViewProducts_Click(object sender, EventArgs e)
        {
            setText("View Products");
            hideSubMenu();
            Products p = new Products();
            p.hidecomponents();
            openChildForm(p);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            setText("Manage Staff");
            hideSubMenu();
            openChildForm(new Staff());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            setText("View my details ");
            hideSubMenu();
            openChildForm(new Staff());
        }

        private void buttonSalesReports_Click(object sender, EventArgs e)
        {
            setText("Sales Reports"); 
            hideSubMenu();
            openChildForm(new SalesReporting());
        }

        private void buttonOrdersReports_Click(object sender, EventArgs e)
        {
            setText("Orders Reports");
            hideSubMenu();
            openChildForm(new OrdersReporting());
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btnManageSales_Click(object sender, EventArgs e)
        {
            setText("Process Sale"); 
            openChildForm(new ProcessSale());

        }

        private void buttonManageOrders_Click(object sender, EventArgs e)
        {
            setText("Create Order");
            hideSubMenu();
            openChildForm(new CreateOrder());
        }

        
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void iconButtonAccessControl_Click(object sender, EventArgs e)
        {
            labelUsername.Text = " ";
            Role.Text = " ";
            setText("Login");
            openChildForm(new Login());

            iconButtonSales.Enabled = false;
            iconButtonOrders.Enabled = false;
            iconButtonProducts.Enabled = false;
            iconButtonStaff.Enabled = false;
            iconButtonCustomers.Enabled = false;
            iconButtonReports.Enabled = false;

        }

        private void buttonManageCustomers_Click(object sender, EventArgs e)
        {
            setText("Manage Customers");
            Customers customer = new Customers();
            customer.hideGroupbox();
            openChildForm(customer);
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonViewCustomers_Click(object sender, EventArgs e)
        {
            setText("View Customers");
            Customers customer = new Customers();
            customer.hideGroupbox();
            customer.disabletextboxes();
            openChildForm(customer);

        }

        private void buttonViewOrders_Click(object sender, EventArgs e)
        {
            setText("View Orders");
            hideSubMenu();
            openChildForm(new ViewOrders());
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            setText("Add a new customer");
            hideSubMenu();
            openChildForm(new Customers());
        }

        private void StarMeats_Load(object sender, EventArgs e)
        {
            if (Login.isManager == true) {
                button4.Enabled = false;
            }


        }
        private void button2_Click(object sender, EventArgs e)
        {
            setText("View Sales");
            openChildForm(new ViewSales());
        }
        public void loadUser(string userName, string userRole)
        {
            pictureBox1.Hide();
            labelUsername.Visible = true;
            Role.Visible = true;
            //labelUsername.Text = " ";
            labelUsername.Text = "User name: " + userName;
            //Role.Text = " ";
            Role.Text = "Role: " + userRole;

        }
    }
}
