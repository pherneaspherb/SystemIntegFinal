using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace SystemIntegFinal
{
    public partial class ViewOrder : Form
    {
        private OleDbConnection Con;
        private string orderDetails; // Store the order details for printing
        private PrintDocument printDocument1;

        public ViewOrder()
        {
            InitializeComponent();
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\ecnp1\\OneDrive\\Documents\\ProductsDatabase.accdb;";
            Con = new OleDbConnection(connectionString);
            LoadOrders();

            // Initialize the PrintDocument object and set up the PrintPage event handler
            printDocument1 = new PrintDocument();
            this.printDocument1.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
        }

        private void LoadOrders()
        {
            try
            {
                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                string query = "SELECT * FROM [Order]";

                using (OleDbDataAdapter sda = new OleDbDataAdapter(query, Con))
                {
                    var ds = new DataSet();
                    sda.Fill(ds);
                    ViewOrderDGV.DataSource = ds.Tables[0];
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

        private void ViewOrderDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show($"You clicked on cell at row {e.RowIndex}, column {e.ColumnIndex}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Orders obj = new Orders();
            obj.Show();
            this.Hide();
        }

        private void PrintOrder_Click(object sender, EventArgs e)
        {
            if (ViewOrderDGV.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(ViewOrderDGV.SelectedRows[0].Cells[0].Value); 


                orderDetails = GetOrderDetails(orderId);

                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument1;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument1.Print();
                }
            }
            else
            {
                MessageBox.Show("Please select an order to print.");
            }
        }

        private string GetOrderDetails(int orderId)
        {
            string details = "";
            try
            {
                if (Con.State != ConnectionState.Open)
                {
                    Con.Open();
                }

                string query = "SELECT * FROM [Order] WHERE OrderID = ?";
                using (OleDbCommand cmd = new OleDbCommand(query, Con))
                {
                    cmd.Parameters.AddWithValue("?", orderId);
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        details += $"Order ID: {reader["OrderID"]}\n";
                        details += $"Customer: {reader["CusName"]}\n";
                        details += $"Date: {reader["OrderDate"]}\n";
                        details += $"Total Amount: {reader["TotalPrice"]}\n";
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
            return details;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 12);
            Font totalFont = new Font("Arial", 12, FontStyle.Bold);

            float yPos = 10;
            float lineHeight = regularFont.GetHeight(e.Graphics);
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;
            float pageWidth = e.MarginBounds.Width;

            string receiptTitle = "Receipt";
            SizeF titleSize = e.Graphics.MeasureString(receiptTitle, titleFont);
            float titleX = (pageWidth - titleSize.Width) / 2;
            e.Graphics.DrawString(receiptTitle, titleFont, Brushes.Black, titleX, yPos);

            yPos += lineHeight * 2; 

            e.Graphics.DrawString($"Order ID: {orderDetails.Split('\n')[0].Split(':')[1]}", headerFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            e.Graphics.DrawString($"Customer: {orderDetails.Split('\n')[1].Split(':')[1]}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;
            e.Graphics.DrawString($"Date: {orderDetails.Split('\n')[2].Split(':')[1]}", regularFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight;

            yPos += 10;
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);

            yPos += 20; // Space after the line
            string totalAmountText = $"Total Amount: {orderDetails.Split('\n')[3].Split(':')[1]}";
            SizeF totalSize = e.Graphics.MeasureString(totalAmountText, totalFont);
            float totalX = pageWidth - totalSize.Width - 10;
            e.Graphics.DrawString(totalAmountText, totalFont, Brushes.Black, totalX, yPos);

            yPos += lineHeight + 20;
            string footerText = "Thank you for your purchase!";
            SizeF footerSize = e.Graphics.MeasureString(footerText, regularFont);
            float footerX = (pageWidth - footerSize.Width) / 2;
            e.Graphics.DrawString(footerText, regularFont, Brushes.Black, footerX, yPos);

            e.Graphics.DrawRectangle(Pens.Black, leftMargin - 5, topMargin - 5, pageWidth + 10, yPos + 30);

            e.HasMorePages = false;
        }

    }
}
