
using System.Windows.Forms;

namespace Clinic_Mang_Sys.Forms
{
    public partial class ProfitCalculatorForm : Form
    {
        private DataGridView dataGridView;
        private Label lblExpenseDescription;
        private TextBox txtExpenseDescription;
        private Label lblExpenseAmount;
        private TextBox txtExpenseAmount;
        private Button btnAddExpense;
        private Button btnCalculate;
        private Label lblProfit;

       

        private void InitializeComponent()
        {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblExpenseDescription = new System.Windows.Forms.Label();
            this.txtExpenseDescription = new System.Windows.Forms.TextBox();
            this.lblExpenseAmount = new System.Windows.Forms.Label();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblProfit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(400, 200);
            this.dataGridView.TabIndex = 0;
            // 
            // lblExpenseDescription
            // 
            this.lblExpenseDescription.AutoSize = true;
            this.lblExpenseDescription.Location = new System.Drawing.Point(12, 226);
            this.lblExpenseDescription.Name = "lblExpenseDescription";
            this.lblExpenseDescription.Size = new System.Drawing.Size(110, 13);
            this.lblExpenseDescription.TabIndex = 1;
            this.lblExpenseDescription.Text = "Expense Description:";
            // 
            // txtExpenseDescription
            // 
            this.txtExpenseDescription.Location = new System.Drawing.Point(128, 223);
            this.txtExpenseDescription.Name = "txtExpenseDescription";
            this.txtExpenseDescription.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseDescription.TabIndex = 2;
            // 
            // lblExpenseAmount
            // 
            this.lblExpenseAmount.AutoSize = true;
            this.lblExpenseAmount.Location = new System.Drawing.Point(12, 252);
            this.lblExpenseAmount.Name = "lblExpenseAmount";
            this.lblExpenseAmount.Size = new System.Drawing.Size(89, 13);
            this.lblExpenseAmount.TabIndex = 3;
            this.lblExpenseAmount.Text = "Expense Amount:";
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(128, 249);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(100, 20);
            this.txtExpenseAmount.TabIndex = 4;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(15, 281);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(213, 23);
            this.btnAddExpense.TabIndex = 5;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(234, 281);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(178, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate Profit";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Location = new System.Drawing.Point(12, 326);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(37, 13);
            this.lblProfit.TabIndex = 7;
            this.lblProfit.Text = "Profit: ";
            // 
            // ProfitCalculatorForm
            // 
            this.ClientSize = new System.Drawing.Size(424, 358);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAddExpense);
            this.Controls.Add(this.txtExpenseAmount);
            this.Controls.Add(this.lblExpenseAmount);
            this.Controls.Add(this.txtExpenseDescription);
            this.Controls.Add(this.lblExpenseDescription);
            this.Controls.Add(this.dataGridView);
            this.Name = "ProfitCalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clinic Profit Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}