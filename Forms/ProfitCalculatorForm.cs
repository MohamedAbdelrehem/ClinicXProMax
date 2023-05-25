using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;


namespace Clinic_Mang_Sys.Forms
{

    public partial class ProfitCalculatorForm : Form
    {
        private DataTable dataTable;

        public ProfitCalculatorForm()
        {
            InitializeComponent();

            // Create and configure the DataTable
            dataTable = new DataTable();
            dataTable.Columns.Add("Description");
            dataTable.Columns.Add("Amount", typeof(decimal));

            // Bind the DataTable to the DataGridView
            dataGridView.DataSource = dataTable;
            Cursor.Current = Cursors.Default;

        }


        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            // Add a new row to the DataTable with the expense description and amount
            dataTable.Rows.Add(txtExpenseDescription.Text, decimal.Parse(txtExpenseAmount.Text));

            // Clear the input fields
            txtExpenseDescription.Text = "";
            txtExpenseAmount.Text = "";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Calculate the total revenue
            decimal totalRevenue = dataTable.AsEnumerable()
                .Where(row => row.Field<string>("Description") == "Revenue")
                .Sum(row => row.Field<decimal>("Amount"));

            // Calculate the total expenses
            decimal totalExpenses = dataTable.AsEnumerable()
                .Where(row => row.Field<string>("Description") != "Revenue")
                .Sum(row => row.Field<decimal>("Amount"));

            // Calculate the profit
            decimal profit = totalRevenue - totalExpenses;

            // Display the result
            lblProfit.Text = profit.ToString("C"); // Formats the profit as currency
        }
    }
}
