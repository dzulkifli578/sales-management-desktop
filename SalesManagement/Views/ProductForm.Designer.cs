namespace SalesManagement.Forms
{
    partial class ProductForm
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
            label1 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            splitContainer1 = new SplitContainer();
            dataGridViewProduct = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            numericUpDownStock = new NumericUpDown();
            numericUpDownPrice = new NumericUpDown();
            labelStock = new Label();
            labelPrice = new Label();
            labelProductName = new Label();
            textBoxProductName = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            buttonAdd = new Button();
            buttonEdit = new Button();
            buttonDelete = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 26);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 0;
            label1.Text = "Product";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 80);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(273, 24);
            label5.Name = "label5";
            label5.Size = new Size(229, 32);
            label5.TabIndex = 0;
            label5.Text = "Sales Management";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 370);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 80);
            panel3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 80);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridViewProduct);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(800, 290);
            splitContainer1.SplitterDistance = 376;
            splitContainer1.TabIndex = 1;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Dock = DockStyle.Fill;
            dataGridViewProduct.Location = new Point(0, 0);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.Size = new Size(376, 290);
            dataGridViewProduct.TabIndex = 0;
            dataGridViewProduct.CellDoubleClick += dataGridViewProduct_CellDoubleClick;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.821558F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.1784439F));
            tableLayoutPanel2.Controls.Add(numericUpDownStock, 1, 2);
            tableLayoutPanel2.Controls.Add(numericUpDownPrice, 1, 1);
            tableLayoutPanel2.Controls.Add(labelStock, 0, 2);
            tableLayoutPanel2.Controls.Add(labelPrice, 0, 1);
            tableLayoutPanel2.Controls.Add(labelProductName, 0, 0);
            tableLayoutPanel2.Controls.Add(textBoxProductName, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(420, 190);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownStock.Location = new Point(94, 146);
            numericUpDownStock.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(323, 23);
            numericUpDownStock.TabIndex = 22;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            numericUpDownPrice.DecimalPlaces = 2;
            numericUpDownPrice.Location = new Point(94, 83);
            numericUpDownPrice.Maximum = new decimal(new int[] { -727379968, 232, 0, 0 });
            numericUpDownPrice.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(323, 23);
            numericUpDownPrice.TabIndex = 1;
            numericUpDownPrice.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // labelStock
            // 
            labelStock.Anchor = AnchorStyles.Left;
            labelStock.AutoSize = true;
            labelStock.Location = new Point(3, 150);
            labelStock.Name = "labelStock";
            labelStock.Size = new Size(36, 15);
            labelStock.TabIndex = 16;
            labelStock.Text = "Stock";
            labelStock.TextAlign = ContentAlignment.MiddleCenter;
            labelStock.Click += labelStock_Click;
            // 
            // labelPrice
            // 
            labelPrice.Anchor = AnchorStyles.Left;
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(3, 87);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(33, 15);
            labelPrice.TabIndex = 18;
            labelPrice.Text = "Price";
            labelPrice.TextAlign = ContentAlignment.MiddleCenter;
            labelPrice.Click += labelPrice_Click;
            // 
            // labelProductName
            // 
            labelProductName.Anchor = AnchorStyles.Left;
            labelProductName.AutoSize = true;
            labelProductName.Location = new Point(3, 24);
            labelProductName.Name = "labelProductName";
            labelProductName.Size = new Size(84, 15);
            labelProductName.TabIndex = 20;
            labelProductName.Text = "Product Name";
            labelProductName.TextAlign = ContentAlignment.MiddleCenter;
            labelProductName.Click += labelProductName_Click;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            textBoxProductName.Location = new Point(94, 20);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(323, 23);
            textBoxProductName.TabIndex = 21;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(buttonAdd, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonEdit, 1, 0);
            tableLayoutPanel1.Controls.Add(buttonDelete, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 190);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(420, 100);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonAdd.Location = new Point(30, 30);
            buttonAdd.Margin = new Padding(30);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(79, 40);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(169, 30);
            buttonEdit.Margin = new Padding(30);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(70, 35);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDelete.Location = new Point(308, 30);
            buttonDelete.Margin = new Padding(30);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(82, 40);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Form";
            FormClosed += ProductForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private SplitContainer splitContainer1;
        private Label labelProductName;
        private TextBox textBoxProductName;
        private Label labelPrice;
        private Label labelStock;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonAdd;
        private Button buttonEdit;
        private Button buttonDelete;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridView dataGridViewProduct;
        private NumericUpDown numericUpDownStock;
        private NumericUpDown numericUpDownPrice;
    }
}