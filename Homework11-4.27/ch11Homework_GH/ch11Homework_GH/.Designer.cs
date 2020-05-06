namespace ch11Homework_GH
{
    partial class AddandUpdateForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateOrderID = new System.Windows.Forms.Label();
            this.OrderID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.UpdateClientID = new System.Windows.Forms.Label();
            this.UpdateClientName = new System.Windows.Forms.Label();
            this.UpdateOrderTotalMoney = new System.Windows.Forms.Label();
            this.ClientID = new System.Windows.Forms.TextBox();
            this.ClientName = new System.Windows.Forms.TextBox();
            this.OrderTotalMoney = new System.Windows.Forms.TextBox();
            this.OrderItemdataGridView = new System.Windows.Forms.DataGridView();
            this.OrderItembindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.OrderAddUpdate = new System.Windows.Forms.Button();
            this.OrderItemAddUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderitemIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderItemTotalMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItembindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.OrderItemdataGridView, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 7);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(790, 189);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.UpdateOrderID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.OrderID, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(166, 185);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // UpdateOrderID
            // 
            this.UpdateOrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateOrderID.AutoSize = true;
            this.UpdateOrderID.Location = new System.Drawing.Point(2, 86);
            this.UpdateOrderID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateOrderID.Name = "UpdateOrderID";
            this.UpdateOrderID.Size = new System.Drawing.Size(79, 12);
            this.UpdateOrderID.TabIndex = 0;
            this.UpdateOrderID.Text = "Order ID :";
            // 
            // OrderID
            // 
            this.OrderID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderID.Location = new System.Drawing.Point(85, 82);
            this.OrderID.Margin = new System.Windows.Forms.Padding(2);
            this.OrderID.Name = "OrderID";
            this.OrderID.Size = new System.Drawing.Size(79, 21);
            this.OrderID.TabIndex = 1;
            this.OrderID.Text = "5";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.Controls.Add(this.UpdateClientID, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.UpdateClientName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.UpdateOrderTotalMoney, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.ClientID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ClientName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.OrderTotalMoney, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(172, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(230, 185);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // UpdateClientID
            // 
            this.UpdateClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateClientID.AutoSize = true;
            this.UpdateClientID.Location = new System.Drawing.Point(2, 24);
            this.UpdateClientID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateClientID.Name = "UpdateClientID";
            this.UpdateClientID.Size = new System.Drawing.Size(65, 12);
            this.UpdateClientID.TabIndex = 0;
            this.UpdateClientID.Text = "ClientID";
            // 
            // UpdateClientName
            // 
            this.UpdateClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateClientName.AutoSize = true;
            this.UpdateClientName.Location = new System.Drawing.Point(2, 85);
            this.UpdateClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateClientName.Name = "UpdateClientName";
            this.UpdateClientName.Size = new System.Drawing.Size(65, 12);
            this.UpdateClientName.TabIndex = 1;
            this.UpdateClientName.Text = "ClientName";
            // 
            // UpdateOrderTotalMoney
            // 
            this.UpdateOrderTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateOrderTotalMoney.AutoSize = true;
            this.UpdateOrderTotalMoney.Location = new System.Drawing.Point(2, 141);
            this.UpdateOrderTotalMoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UpdateOrderTotalMoney.Name = "UpdateOrderTotalMoney";
            this.UpdateOrderTotalMoney.Size = new System.Drawing.Size(65, 24);
            this.UpdateOrderTotalMoney.TabIndex = 2;
            this.UpdateOrderTotalMoney.Text = "OrderTotalMoney";
            // 
            // ClientID
            // 
            this.ClientID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientID.Location = new System.Drawing.Point(71, 20);
            this.ClientID.Margin = new System.Windows.Forms.Padding(2);
            this.ClientID.Name = "ClientID";
            this.ClientID.Size = new System.Drawing.Size(157, 21);
            this.ClientID.TabIndex = 3;
            this.ClientID.Text = "1";
            // 
            // ClientName
            // 
            this.ClientName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientName.Location = new System.Drawing.Point(71, 81);
            this.ClientName.Margin = new System.Windows.Forms.Padding(2);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(157, 21);
            this.ClientName.TabIndex = 4;
            this.ClientName.Text = "张三";
            // 
            // OrderTotalMoney
            // 
            this.OrderTotalMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderTotalMoney.Location = new System.Drawing.Point(71, 143);
            this.OrderTotalMoney.Margin = new System.Windows.Forms.Padding(2);
            this.OrderTotalMoney.Name = "OrderTotalMoney";
            this.OrderTotalMoney.Size = new System.Drawing.Size(157, 21);
            this.OrderTotalMoney.TabIndex = 5;
            this.OrderTotalMoney.Text = "600";
            // 
            // OrderItemdataGridView
            // 
            this.OrderItemdataGridView.AllowDrop = true;
            this.OrderItemdataGridView.AllowUserToOrderColumns = true;
            this.OrderItemdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemdataGridView.AutoGenerateColumns = false;
            this.OrderItemdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderItemdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderitemIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.productNumDataGridViewTextBoxColumn,
            this.orderItemTotalMoneyDataGridViewTextBoxColumn});
            this.OrderItemdataGridView.DataSource = this.OrderItembindingSource;
            this.OrderItemdataGridView.Location = new System.Drawing.Point(407, 3);
            this.OrderItemdataGridView.MultiSelect = false;
            this.OrderItemdataGridView.Name = "OrderItemdataGridView";
            this.OrderItemdataGridView.RowTemplate.Height = 23;
            this.OrderItemdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.OrderItemdataGridView.Size = new System.Drawing.Size(380, 183);
            this.OrderItemdataGridView.TabIndex = 2;
            // 
            // OrderItembindingSource
            // 
            this.OrderItembindingSource.DataSource = typeof(ch11Homework_GH.OrderItem);
            // 
            // OrderAddUpdate
            // 
            this.OrderAddUpdate.Location = new System.Drawing.Point(231, 201);
            this.OrderAddUpdate.Name = "OrderAddUpdate";
            this.OrderAddUpdate.Size = new System.Drawing.Size(135, 42);
            this.OrderAddUpdate.TabIndex = 1;
            this.OrderAddUpdate.Text = "OrderAddUpdate";
            this.OrderAddUpdate.UseVisualStyleBackColor = true;
            this.OrderAddUpdate.Click += new System.EventHandler(this.OrderAddUpdate_Click);
            // 
            // OrderItemAddUpdate
            // 
            this.OrderItemAddUpdate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.OrderItemAddUpdate.Location = new System.Drawing.Point(547, 201);
            this.OrderItemAddUpdate.Name = "OrderItemAddUpdate";
            this.OrderItemAddUpdate.Size = new System.Drawing.Size(136, 42);
            this.OrderItemAddUpdate.TabIndex = 2;
            this.OrderItemAddUpdate.Text = "OrderItemAddUpdaten";
            this.OrderItemAddUpdate.UseVisualStyleBackColor = true;
            this.OrderItemAddUpdate.Click += new System.EventHandler(this.OrderItemAddUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 247);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(788, 60);
            this.dataGridView1.TabIndex = 3;
            // 
            // orderitemIDDataGridViewTextBoxColumn
            // 
            this.orderitemIDDataGridViewTextBoxColumn.DataPropertyName = "OrderitemID";
            this.orderitemIDDataGridViewTextBoxColumn.HeaderText = "OrderitemID";
            this.orderitemIDDataGridViewTextBoxColumn.Name = "orderitemIDDataGridViewTextBoxColumn";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // productNumDataGridViewTextBoxColumn
            // 
            this.productNumDataGridViewTextBoxColumn.DataPropertyName = "ProductNum";
            this.productNumDataGridViewTextBoxColumn.HeaderText = "ProductNum";
            this.productNumDataGridViewTextBoxColumn.Name = "productNumDataGridViewTextBoxColumn";
            // 
            // orderItemTotalMoneyDataGridViewTextBoxColumn
            // 
            this.orderItemTotalMoneyDataGridViewTextBoxColumn.DataPropertyName = "OrderItemTotalMoney";
            this.orderItemTotalMoneyDataGridViewTextBoxColumn.HeaderText = "OrderItemTotalMoney";
            this.orderItemTotalMoneyDataGridViewTextBoxColumn.Name = "orderItemTotalMoneyDataGridViewTextBoxColumn";
            this.orderItemTotalMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AddandUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 308);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.OrderItemAddUpdate);
            this.Controls.Add(this.OrderAddUpdate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddandUpdateForm";
            this.Text = "Add&UpdateForm";
            this.Load += new System.EventHandler(this.AddandUpdateForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItemdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderItembindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label UpdateOrderID;
        private System.Windows.Forms.TextBox OrderID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label UpdateClientID;
        private System.Windows.Forms.Label UpdateClientName;
        private System.Windows.Forms.Label UpdateOrderTotalMoney;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox ClientID;
        private System.Windows.Forms.TextBox ClientName;
        private System.Windows.Forms.TextBox OrderTotalMoney;
        private System.Windows.Forms.Button OrderAddUpdate;
        private System.Windows.Forms.Button OrderItemAddUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView OrderItemdataGridView;
        private System.Windows.Forms.BindingSource OrderItembindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderitemIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderItemTotalMoneyDataGridViewTextBoxColumn;
    }
}