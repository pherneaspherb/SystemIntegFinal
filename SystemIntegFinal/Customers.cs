using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SystemIntegFinal
{
    public partial class Customers : Form
    {
        private OleDbConnection Con;

        public Customers()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ecnp1\OneDrive\Documents\ProductsDatabase.accdb;";
            Con = new OleDbConnection(connectionString);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CusIdTb.Text) ||
                    string.IsNullOrWhiteSpace(CusNameTb.Text) ||
                    string.IsNullOrWhiteSpace(TelTb.Text))
                {
                    MessageBox.Show("Incomplete Information");
                    return;
                }

                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                using (OleDbCommand cmd = new OleDbCommand("INSERT INTO Customers (CusId, CusName, ContactNum) VALUES (?, ?, ?)", Con))
                {
                    cmd.Parameters.AddWithValue("?", CusIdTb.Text);
                    cmd.Parameters.AddWithValue("?", CusNameTb.Text);
                    cmd.Parameters.AddWithValue("?", TelTb.Text);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Entered Successfully");
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CusIdTb.Text) ||
                    string.IsNullOrWhiteSpace(CusNameTb.Text) ||
                    string.IsNullOrWhiteSpace(TelTb.Text))
                {
                    MessageBox.Show("Incomplete Information");
                    return;
                }

                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                using (OleDbCommand cmd = new OleDbCommand("UPDATE Customers SET CusName = ?, ContactNum = ? WHERE CusId = ?", Con))
                {
                    cmd.Parameters.AddWithValue("?", CusNameTb.Text);
                    cmd.Parameters.AddWithValue("?", TelTb.Text);
                    cmd.Parameters.AddWithValue("?", CusIdTb.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the provided ID.");
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CusIdTb.Text))
                {
                    MessageBox.Show("Please enter a Customer ID to delete.");
                    return;
                }

                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                using (OleDbCommand cmd = new OleDbCommand("DELETE FROM Customers WHERE CusId = ?", Con))
                {
                    cmd.Parameters.AddWithValue("?", CusIdTb.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Deleted Successfully");
                    }
                    else
                    {
                        MessageBox.Show("No customer found with the provided ID.");
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CusIdTb.Text = "";
            CusNameTb.Text = "";
            TelTb.Text = "";
        }

        private void dataGridView1_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                CusIdTb.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                CusNameTb.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                TelTb.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                using (OleDbDataAdapter sqlDataAdapter = new OleDbDataAdapter("SELECT COUNT(*) FROM [Order] WHERE Cus Id = ?", Con))
                {
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("?", CusIdTb.Text);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        OrderAmount.Text = dt.Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No data found for this customer");
                        OrderAmount.Text = "0";
                    }
                }

                using (OleDbDataAdapter sqlDataAdapter1 = new OleDbDataAdapter("SELECT TotalAmount FROM [Orders] WHERE CusId = ?", Con))
                {
                    sqlDataAdapter1.SelectCommand.Parameters.AddWithValue("?", CusIdTb.Text);
                    DataTable dt1 = new DataTable();
                    sqlDataAdapter1.Fill(dt1);

                    if (dt1.Rows.Count > 0)
                    {
                        OrderAmount.Text = dt1.Rows[0][0].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No data found for this customer");
                        OrderAmount.Text = "0";
                    }
                }

                using (OleDbDataAdapter sqlDataAdapter2 = new OleDbDataAdapter("SELECT TOP 1 OrderDate FROM [Orders] WHERE CusId = ? ORDER BY OrderDate DESC", Con))
                {
                    sqlDataAdapter2.SelectCommand.Parameters.AddWithValue("?", CusIdTb.Text);
                    DataTable dt2 = new DataTable();
                    sqlDataAdapter2.Fill(dt2);

                    if (dt2.Rows.Count > 0)
                    {
                        LastOrderDate.Text = dt2.Rows[0][0].ToString();
                    }
                    else
                    {
                        LastOrderDate.Text = "No Orders";
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

        private void Customers_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }

        private void CusIdTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}