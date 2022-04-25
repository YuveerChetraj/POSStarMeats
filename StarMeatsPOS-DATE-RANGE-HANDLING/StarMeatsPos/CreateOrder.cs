using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Net.Mail;

namespace StarMeatsPos
{
    public partial class CreateOrder : Form
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.starMeatsDataSet);

        }

        private void ProcessOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'group3DataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.group3DataSet.Customer);
            // TODO: This line of code loads data into the 'group3DataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.group3DataSet.Employee);
            // TODO: This line of code loads data into the 'group3DataSet.Order' table. You can move, or remove it, as needed.
            this.orderTableAdapter1.Fill(this.group3DataSet.Order);
            // TODO: This line of code loads data into the 'group3DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter1.Fill(this.group3DataSet.Product);
            // TODO: This line of code loads data into the 'starMeatsDataSet.Product' table. You can move, or remove it, as needed.
            //this.productTableAdapter.Fill(this.starMeatsDataSet.Product);
            DataRowView current = (DataRowView)this.productBindingSource1.Current;
            //current["CustomerID"] = Guid.NewGuid();
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(buttonFirst, "Takes you to the top for the grid");
            toolTip.SetToolTip(buttonPrevious, "Takes you one up on the grid");
            toolTip.SetToolTip(buttonNext, "Takes you one down on the grid");
            toolTip.SetToolTip(buttonLast, "Takes you to the bottom on the grid");
            toolTip.SetToolTip(btnSearch, "Search for a product");
            toolTip.SetToolTip(buttonAdd, "Add a product to order");
            toolTip.SetToolTip(buttonRemoveFromSale, "Remove product from order");
            toolTip.SetToolTip(buttonProcessSale, "Add Order");
            toolTip.SetToolTip(textBoxID, "Contains the Product's ID");
            toolTip.SetToolTip(textBoxName, "Contains the Product's Name");
            toolTip.SetToolTip(textBoxPrice, "Contains the Product's Price");
            toolTip.SetToolTip(textBoxQuantity, "Contains the Product's Quantity to order");
            toolTip.SetToolTip(dateTimePickerEndDate, "Contains the order end date");
            toolTip.SetToolTip(textBox1, "Contains the Customer's ID  who is making the order");
            toolTip.SetToolTip(textBox2, "Contains the Employee's ID who will prepare the order");
        }
        private decimal total = 0;
        private ArrayList prodId = new ArrayList();
        private ArrayList prodName = new ArrayList();
        private ArrayList prodCost = new ArrayList();
        private ArrayList prodQuaninty = new ArrayList();
        private ArrayList prodCat = new ArrayList();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            String test;
            bool validQNumber = true;
            test = textBoxQuantity.Text;
            if (String.IsNullOrEmpty(test) )
            {
                validQNumber = false;
            }
            for (int i = 0; i < test.Length; i++)
            {
                if (!char.IsDigit(test[i]))
                {
                    validQNumber = false;
                }
            }
            if (!validQNumber)
            {
                MessageBox.Show("Invalidate Qanitity");
                textBoxQuantity.Clear();
            }
            //
            if (validQNumber) {
                Boolean enoughQ;
                DataRowView current = (DataRowView)this.productBindingSource1.Current;
                if (current["Prod_Category"].Equals("Butchery Meat"))
                {
                    enoughQ = Convert.ToDouble(current["Prod_Quantity_Available_kg"]) >= Convert.ToDouble(textBoxQuantity.Text);
                }
                else
                {
                    enoughQ = Convert.ToInt32(current["Prod_Quantity_Available_unit"]) >= Convert.ToInt32(textBoxQuantity.Text);
                }
                if (enoughQ)
                {
                    total += Convert.ToInt32(textBoxQuantity.Text) * Convert.ToDecimal(textBoxPrice.Text);
                    prodId.Add(textBoxID.Text);
                    prodName.Add(textBoxName.Text);
                    prodCost.Add(textBoxPrice.Text);
                    prodQuaninty.Add(textBoxQuantity.Text);
                    prodCat.Add(current["Prod_Category"]);
                    richTextBox1.Clear();
                    for (int i = 0; i < prodId.Count; i++)
                    {
                        richTextBox1.AppendText("\n\r Item No: " + Convert.ToString(i + 1) + "\n\r Product ID: " + prodId[i] + "\n\r Product Name: " + prodName[i] + "\n\r Product Price: R" + prodCost[i] + "\n\r Product Quantity: " + prodQuaninty[i] + "\n\r **********************");
                    }
                    richTextBox1.AppendText("\n\r Total Cost: R" + Convert.ToString(total));
                }
                else
                {
                    MessageBox.Show("Not enough quantity");
                }
            }
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            this.productBindingSource1.MoveFirst();
            DataRowView current = (DataRowView)this.productBindingSource1.Current;
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.productBindingSource1.MovePrevious();
            DataRowView current = (DataRowView)this.productBindingSource1.Current;
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.productBindingSource1.MoveNext();
            DataRowView current = (DataRowView)this.productBindingSource1.Current;
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            this.productBindingSource1.MoveLast();
            DataRowView current = (DataRowView)this.productBindingSource1.Current;
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataRowView current = (DataRowView)this.productBindingSource1.Current;
            double cost = 0;
            if (current["Prod_Price_per_kg"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
            if (current["Prod_Price_per_unit"] != null)
            {
                try
                {
                    cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    textBoxPrice.Text = cost.ToString();
                }
                catch (Exception)
                {
                    //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                    //textBoxPrice.Text = cost.ToString();
                }
            }
        }

        private void buttonRemoveFromSale_Click(object sender, EventArgs e)
        {
            string stringItemNo = Interaction.InputBox("Enter Item No ");
            Boolean found = false;
            for (int i = 0; i < prodId.Count; i++)
            {
                if (stringItemNo.Equals(Convert.ToString(i+1)))
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                int itemNo = Convert.ToInt32(stringItemNo);
                total -= Convert.ToDecimal(prodCost[itemNo - 1]) * Convert.ToInt32(prodQuaninty[itemNo - 1]);
                prodId.RemoveAt(itemNo - 1);
                prodName.RemoveAt(itemNo - 1);
                prodQuaninty.RemoveAt(itemNo - 1);
                prodCost.RemoveAt(itemNo - 1);
                richTextBox1.Clear();
                for (int i = 0; i < prodId.Count; i++)
                {
                    richTextBox1.AppendText("\n\r Item No: " + Convert.ToString(i + 1) + "\n\r Product ID: " + prodId[i] + "\n\r Product Name: " + prodName[i] + "\n\r Product Price:R" + prodCost[i] + "\n\r Product Quantity: " + prodQuaninty[i] + "\n\r **********************");
                }
                richTextBox1.AppendText("\n\r Total Cost: " + Convert.ToString(total));
                MessageBox.Show("Item is Removed");
            }
            else { MessageBox.Show("Item No Not found"); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            double cost = 0;
            String prodId = textBoxID.Text;
            productBindingSource1.MoveFirst();
            Boolean found = false;
            foreach (DataRow row in group3DataSet.Product.Rows)
            {
                DataRowView current = (DataRowView)this.productBindingSource1.Current;
                
                if (Convert.ToString(current["Prod_Id"]).Equals(prodId))
                {
                    found = true;
                    MessageBox.Show("Found");
                    if (current["Prod_Price_per_kg"] != null)
                    {
                        try
                        {
                            cost = Convert.ToDouble(current["Prod_Price_per_kg"]);
                            textBoxPrice.Text = cost.ToString();
                        }
                        catch (Exception)
                        {
                            //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                            //textBoxPrice.Text = cost.ToString();
                        }
                    }
                    if (current["Prod_Price_per_unit"] != null)
                    {
                        try
                        {
                            cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                            textBoxPrice.Text = cost.ToString();
                        }
                        catch (Exception)
                        {
                            //cost = Convert.ToDouble(current["Prod_Price_per_unit"]);
                            //textBoxPrice.Text = cost.ToString();
                        }
                    }
                    break;
                }
                else
                {
                    productBindingSource1.MoveNext();
                }
            }
            if (!found)
            {
                MessageBox.Show("Product ID not found");
            }
        }

        private void buttonProcessSale_Click(object sender, EventArgs e)
        {
            bool validateIds = true;
            // test customer id
            this.customerBindingSource.MoveFirst();
            Boolean found = false;
            foreach (DataRow row in group3DataSet.Customer.Rows)
            {
                DataRowView currentCust = (DataRowView)this.customerBindingSource.Current;
                if (Convert.ToString(currentCust["Customer_Id"]).Equals(textBox1.Text))
                {
                    found = true;
                    break;
                }
                else
                {
                    customerBindingSource.MoveNext();
                }
            }
            if (!found)
            {
                validateIds = false;
                MessageBox.Show("Customer ID not found");
            }
            // test Emplyee Id
            this.employeeBindingSource.MoveFirst();
            found = false;
            foreach (DataRow row in group3DataSet.Employee.Rows)
            {
                DataRowView currentEmployee = (DataRowView)this.employeeBindingSource.Current;
                if (Convert.ToString(currentEmployee["Employee_Id"]).Equals(textBox2.Text))
                {
                    found = true;
                    break;
                }
                else
                {
                    employeeBindingSource.MoveNext();
                }
            }
            if (!found)
            {
                validateIds = false;
                MessageBox.Show("Employee ID not found");
            }
            //
            if (validateIds) {
                orderTableAdapter1.Insert(Convert.ToInt32(textBox1.Text), DateTime.Now, dateTimePickerEndDate.Value, DateTime.Now, Convert.ToInt32(textBox2.Text),
                    total, false, true, false);
                this.orderTableAdapter1.Fill(this.group3DataSet.Order);
                orderBindingSource.MoveLast();
                DataRowView current = (DataRowView)this.orderBindingSource.Current;
                int OrderNo = Convert.ToInt32(current["Order_Id"]);
                for (int i = 0; i < prodId.Count; i++)
                {
                    orderProductTableAdapter1.Insert(OrderNo, Convert.ToInt32(prodId[i]), Convert.ToInt32(prodQuaninty[i]), Convert.ToDecimal(prodCost[i]));   
                }
                this.orderTableAdapter1.Fill(this.group3DataSet.Order);
                this.productTableAdapter1.Fill(this.group3DataSet.Product);
                MessageBox.Show("Order is processed");
                prodId.Clear();
                prodName.Clear();
                prodCost.Clear();
                prodCat.Clear();
                richTextBox1.Clear();
                total = 0;

                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress("AsheelDatharam3@gmail.com");
                    mail.To.Add("asheel.dathz@gmail.com"); // replace with your email adress to test
                    mail.Subject = "Star Meats Order Confirmation";
                    mail.Body = "Order confirmed\nOrder number: " + group3DataSet.Order.Rows[group3DataSet.Order.Rows.Count-1].ItemArray[0] + "\n Order Total: " + String.Format("{0:C}", Convert.ToDecimal(group3DataSet.Order.Rows[group3DataSet.Order.Rows.Count - 1].ItemArray[6])); ;
                    
                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential("AsheelDatharam3@gmail.com", "AsheelDatharam123");
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("Email confirmation sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was a problem sending the email confirmation, confirmation not sent");
                }
            }
        }
    }
}
