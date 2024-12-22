using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIntegFinal
{
    public partial class Orders : Form
    {
        DataTable table;
        private OleDbConnection Con;

        private int OrderItemNumber = 0;
        private int Quantity;
        private int Total;
        private string Product;
        private int stock;
        private int Price;
        private int sum = 0;
        private int flag = 0;

        public Orders()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ecnp1\\OneDrive\\Documents\\ProductsDatabase.accdb;";
            Con = new OleDbConnection(connectionString);
        }

        private void DisplayProduct()
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                string query = "SELECT * FROM Products";

                using (OleDbDataAdapter sda = new OleDbDataAdapter(query, Con))
                {
                    var ds = new DataSet();
                    sda.Fill(ds);
                    productDGV.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void FilterByCategory()
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                string query = "SELECT * FROM Products WHERE PCategory = ?";

                using (OleDbDataAdapter sda = new OleDbDataAdapter(query, Con))
                {
                    sda.SelectCommand.Parameters.AddWithValue("?", ProCatCb.Text);
                    var ds = new DataSet();
                    sda.Fill(ds);
                    productDGV.DataSource = ds.Tables[0];

                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        MessageBox.Show("No products found for the selected category.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void GetCategory()
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                using (OleDbCommand cmd = new OleDbCommand("SELECT DISTINCT PCategory FROM Products", Con))
                {
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("PCategory", typeof(string));
                        dt.Load(rdr);
                        ProCatCb.DataSource = dt;
                        ProCatCb.DisplayMember = "PCategory";
                        ProCatCb.ValueMember = "PCategory";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                CusIdTb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                CusNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateProduct()
        {
            try
            {
                if (productDGV.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a product to update.");
                    return;
                }

                int id = Convert.ToInt32(productDGV.SelectedRows[0].Cells[0].Value);
                int stock = Convert.ToInt32(productDGV.SelectedRows[0].Cells[2].Value);
                int newQty = stock - Convert.ToInt32(QtyTb.Text);

                if (newQty < 0)
                {
                    MessageBox.Show("Operation Failed: Insufficient stock.");
                    return;
                }

                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                string query = "UPDATE Products SET PQuantity = ? WHERE PId = ?";

                using (OleDbCommand cmd = new OleDbCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("?", newQty);
                    cmd.Parameters.AddWithValue("?", id);
                    cmd.ExecuteNonQuery();
                }

                DisplayProduct();
                MessageBox.Show("Product updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void DisplayCustomers()
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                string query = "SELECT * FROM Customers";

                using (OleDbDataAdapter sda = new OleDbDataAdapter(query, Con))
                {
                    var ds = new DataSet();
                    sda.Fill(ds);
                    dataGridView1.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void dataGridView2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Product = productDGV.SelectedRows[0].Cells[1].Value.ToString();
                stock = Convert.ToInt32(productDGV.SelectedRows[0].Cells[2].Value);
                Price = Convert.ToInt32(productDGV.SelectedRows[0].Cells[6].Value);
                flag = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FilterByCategory();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(QtyTb.Text))
            {
                MessageBox.Show("Enter Quantity Of Products");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the Product");
            }
            else if (Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("Not Enough Stock Available");
            }
            else
            {
                try
                {
                    OrderItemNumber++;
                    Quantity = Convert.ToInt32(QtyTb.Text);
                    Total = Quantity * Price;
                    table.Rows.Add(OrderItemNumber, Product, Quantity, Price, Total);
                    dataGridView2.DataSource = table;
                    flag = 0;
                    sum += Total;
                    Tprice.Text = "Php" + sum;
                    UpdateProduct();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label4_Load(object sender, EventArgs e)
        {
            DisplayProduct();
            DisplayCustomers();
            GetCategory();

            table = new DataTable();
            table.Columns.Add("OrderItemNumber", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Price", typeof(int));
            table.Columns.Add("Total", typeof(int));
            dataGridView2.DataSource = table;

            dateTimePicker1.Value = DateTime.Today;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(OrderIdTb.Text) ||
                    string.IsNullOrWhiteSpace(CusIdTb.Text) ||
                    string.IsNullOrWhiteSpace(CusNameTb.Text) ||
                    string.IsNullOrWhiteSpace(Tprice.Text))
                {
                    MessageBox.Show("Fill the data correctly");
                    return;
                }

                if (!decimal.TryParse(Tprice.Text.Replace("Php", "").Trim(), out decimal totalPrice))
                {
                    MessageBox.Show("Total Price must be a valid number.");
                    return;
                }

                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                string query = "INSERT INTO [Order] (OrderId, CusId, CusName, OrderDate, TotalPrice) VALUES (?, ?, ?, ?, ?)";

                using (OleDbCommand cmd = new OleDbCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(OrderIdTb.Text));
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(CusIdTb.Text));
                    cmd.Parameters.AddWithValue("?", CusNameTb.Text);
                    cmd.Parameters.AddWithValue("?", dateTimePicker1.Value); 
                    cmd.Parameters.AddWithValue("?", totalPrice); 
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Order added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewOrderButton_Click(object sender, EventArgs e)
        {
            ViewOrder obj = new ViewOrder();
            obj.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
