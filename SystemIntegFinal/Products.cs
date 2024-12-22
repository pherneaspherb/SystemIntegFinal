using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.CodeDom;

namespace SystemIntegFinal
{



    public partial class form1 : Form
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ecnp1\OneDrive\Documents\ProductsDatabase.accdb;";
        private OleDbConnection Con;

        public form1()
        {
            InitializeComponent();
            Con = new OleDbConnection(connectionString); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home obj = new Home();
            obj.Show();
            this.Hide();
        }
        private void FilterByProduct()
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                string query = "SELECT * FROM Products WHERE PCategory = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("?", comboBox2.Text.Trim());

                    using (OleDbDataAdapter sda = new OleDbDataAdapter(cmd))
                    {
                        var ds = new DataSet();
                        sda.Fill(ds);
                        productDGV.DataSource = ds.Tables[0];
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

        private void GetCategory()
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                using (OleDbCommand cmd = new OleDbCommand("SELECT * FROM Products", Con))
                {
                    using (OleDbDataReader rdr = cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Columns.Add("PCategory", typeof(string)); 

                        dt.Load(rdr);

                        ProCatCb.DataSource = dt;
                        ProCatCb.DisplayMember = "PCategory"; 
                        ProCatCb.ValueMember = "PCategory";  

                        comboBox2.DataSource = dt;
                        comboBox2.DisplayMember = "PCategory"; 
                        comboBox2.ValueMember = "PCategory";   
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(ProductIdTB.Text) ||
                    string.IsNullOrWhiteSpace(ProNameTb.Text) ||
                    string.IsNullOrWhiteSpace(ProQuanTB.Text) ||
                    string.IsNullOrWhiteSpace(BrantTb.Text) ||
                    string.IsNullOrWhiteSpace(ProCatCb.Text) ||
                    string.IsNullOrWhiteSpace(DescTb.Text) ||
                    string.IsNullOrWhiteSpace(PriceTb.Text))
                {
                    MessageBox.Show("Incomplete Info");
                }
                else
                {
                    Con.Open(); 
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO Products(PId, PName, PQuantity, Brand, PCategory, Description, Price) VALUES(@PI, @PN, @PQ, @B, @PC, @D, @P)", Con);
                    cmd.Parameters.AddWithValue("@PI", ProductIdTB.Text);
                    cmd.Parameters.AddWithValue("@PN", ProNameTb.Text);
                    cmd.Parameters.AddWithValue("@PQ", ProQuanTB.Text);
                    cmd.Parameters.AddWithValue("@B", BrantTb.Text);
                    cmd.Parameters.AddWithValue("@PC", ProCatCb.Text);
                    cmd.Parameters.AddWithValue("@D", DescTb.Text);
                    cmd.Parameters.AddWithValue("@P", PriceTb.Text);
                    cmd.ExecuteNonQuery(); 
                    MessageBox.Show("Entered Successfully");
                    DisplayProducts();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void DisplayProducts()
        {
        }

        private void ProCatCb_Load(object sender, EventArgs e)
        {
            DisplayProduct();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ProductIdTB.Text) ||
                    string.IsNullOrWhiteSpace(ProNameTb.Text) ||
                    string.IsNullOrWhiteSpace(ProQuanTB.Text) ||
                    string.IsNullOrWhiteSpace(BrantTb.Text) ||
                    string.IsNullOrWhiteSpace(ProCatCb.Text) ||
                    string.IsNullOrWhiteSpace(DescTb.Text) ||
                    string.IsNullOrWhiteSpace(PriceTb.Text))
                {
                    MessageBox.Show("Incomplete Info");
                    return; 
                }

                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                OleDbCommand cmd = new OleDbCommand("UPDATE Products SET PName = ?, PQuantity = ?, Brand = ?, PCategory = ?, Description = ?, Price = ? WHERE PId = ?", Con);

            
                cmd.Parameters.Add("@PN", OleDbType.VarChar).Value = ProNameTb.Text;
                cmd.Parameters.Add("@PQ", OleDbType.Integer).Value = int.Parse(ProQuanTB.Text); 
                cmd.Parameters.Add("@PC", OleDbType.VarChar).Value = ProCatCb.Text;
                cmd.Parameters.Add("@D", OleDbType.VarChar).Value = DescTb.Text;
                cmd.Parameters.Add("@P", OleDbType.Currency).Value = decimal.Parse(PriceTb.Text); 
                cmd.Parameters.Add("@PI", OleDbType.VarChar).Value = ProductIdTB.Text; 

                
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated Successfully");
                }
                else
                {
                    MessageBox.Show("No record found with the given Product ID.");
                }

               
                DisplayProducts();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(ProductIdTB.Text))
                {
                    MessageBox.Show("Incomplete Information");
                    return; 
                }

              
                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                
                OleDbCommand cmd = new OleDbCommand("DELETE FROM Products WHERE PId = ?", Con);
                cmd.Parameters.AddWithValue("?", ProductIdTB.Text); 

             
                int rowsAffected = cmd.ExecuteNonQuery();

              
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("No product found with the given Product ID.");
                }

               
                DisplayProducts();
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

        private void button4_Click(object sender, EventArgs e)
        {

            ProductIdTB.Text = " ";
            ProNameTb.Text = " ";
            ProQuanTB.Text = " ";
            BrantTb.Text = " ";
            ProCatCb.Text = " ";
            DescTb.Text = " ";
            PriceTb.Text = " ";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            FilterByProduct();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetCategory();
            DisplayProduct();
        }

        private void productDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ProNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void productDGV_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ProductIdTB.Text = productDGV.SelectedRows[0].Cells[0].Value.ToString();
                ProNameTb.Text = productDGV.SelectedRows[0].Cells[1].Value.ToString();
                ProQuanTB.Text = productDGV.SelectedRows[0].Cells[2].Value.ToString();
                BrantTb.Text = productDGV.SelectedRows[0].Cells[3].Value.ToString();
                ProCatCb.Text = productDGV.SelectedRows[0].Cells[4].Value.ToString();
                DescTb.Text = productDGV.SelectedRows[0].Cells[5].Value.ToString();
                PriceTb.Text = productDGV.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();

            }

        }

        private void ProductIdTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
    



