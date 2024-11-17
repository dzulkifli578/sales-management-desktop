namespace SalesManagement.Views
{
    partial class SalesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            dataGridViewSales = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonCheckout = new Button();
            buttonCart = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            labelQuantity = new Label();
            comboBoxProduct = new ComboBox();
            labelProduct = new Label();
            numericUpDownQuantity = new NumericUpDown();
            panel3 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewSales, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 80);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(800, 290);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // dataGridViewSales
            // 
            dataGridViewSales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSales.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewSales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSales.Dock = DockStyle.Fill;
            dataGridViewSales.Location = new Point(3, 3);
            dataGridViewSales.Name = "dataGridViewSales";
            dataGridViewSales.Size = new Size(394, 284);
            dataGridViewSales.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(403, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(394, 284);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(buttonCheckout, 1, 0);
            tableLayoutPanel3.Controls.Add(buttonCart, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 145);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(388, 136);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // buttonCheckout
            // 
            buttonCheckout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCheckout.Location = new Point(244, 50);
            buttonCheckout.Margin = new Padding(50);
            buttonCheckout.Name = "buttonCheckout";
            buttonCheckout.Size = new Size(94, 36);
            buttonCheckout.TabIndex = 1;
            buttonCheckout.Text = "Checkout";
            buttonCheckout.UseVisualStyleBackColor = true;
            buttonCheckout.Click += buttonCheckout_Click;
            // 
            // buttonCart
            // 
            buttonCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonCart.Location = new Point(50, 50);
            buttonCart.Margin = new Padding(50);
            buttonCart.Name = "buttonCart";
            buttonCart.Size = new Size(94, 36);
            buttonCart.TabIndex = 0;
            buttonCart.Text = "Add to Cart";
            buttonCart.UseVisualStyleBackColor = true;
            buttonCart.Click += buttonCart_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.3333359F));
            tableLayoutPanel4.Controls.Add(labelQuantity, 0, 1);
            tableLayoutPanel4.Controls.Add(comboBoxProduct, 1, 0);
            tableLayoutPanel4.Controls.Add(labelProduct, 0, 0);
            tableLayoutPanel4.Controls.Add(numericUpDownQuantity, 1, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(388, 136);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // labelQuantity
            // 
            labelQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new Point(3, 68);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(58, 68);
            labelQuantity.TabIndex = 4;
            labelQuantity.Text = "Quantity";
            labelQuantity.TextAlign = ContentAlignment.MiddleLeft;
            labelQuantity.Click += labelQuantity_Click;
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(67, 22);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(318, 23);
            comboBoxProduct.TabIndex = 2;
            // 
            // labelProduct
            // 
            labelProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(3, 0);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(58, 68);
            labelProduct.TabIndex = 3;
            labelProduct.Text = "Product";
            labelProduct.TextAlign = ContentAlignment.MiddleLeft;
            labelProduct.Click += labelProduct_Click;
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownQuantity.Location = new Point(67, 90);
            numericUpDownQuantity.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDownQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownQuantity.Name = "numericUpDownQuantity";
            numericUpDownQuantity.Size = new Size(318, 23);
            numericUpDownQuantity.TabIndex = 5;
            numericUpDownQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 370);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 80);
            panel3.TabIndex = 4;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(273, 14);
            label5.Name = "label5";
            label5.Size = new Size(229, 32);
            label5.TabIndex = 0;
            label5.Text = "Sales Management";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Yellow;
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 80);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 26);
            label1.Name = "label1";
            label1.Size = new Size(62, 30);
            label1.TabIndex = 0;
            label1.Text = "Sales";
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Form";
            FormClosing += SalesForm_FormClosing;
            FormClosed += SalesForm_FormClosed;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSales).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private Panel panel2;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridViewSales;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button buttonCheckout;
        private Button buttonCart;
        private TableLayoutPanel tableLayoutPanel4;
        private ComboBox comboBoxProduct;
        private Label labelQuantity;
        private Label labelProduct;
        private NumericUpDown numericUpDownQuantity;
    }
}