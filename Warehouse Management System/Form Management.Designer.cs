namespace Warehouse_Management_System
{
    partial class Form_Management
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOfGoodsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.stockDataDataSet1 = new Warehouse_Management_System.StockDataDataSet1();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbeuro = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rtbdescription = new System.Windows.Forms.RichTextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbregister = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.itemTableAdapter1 = new Warehouse_Management_System.StockDataDataSet1TableAdapters.ItemTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataDataSet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgv);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 397);
            this.panel1.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.AutoGenerateColumns = false;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.quantityOfGoodsDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.itemBindingSource1;
            this.dgv.Location = new System.Drawing.Point(32, 87);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(308, 276);
            this.dgv.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.Frozen = true;
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 30;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.Frozen = true;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 55;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.Frozen = true;
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 80;
            // 
            // quantityOfGoodsDataGridViewTextBoxColumn
            // 
            this.quantityOfGoodsDataGridViewTextBoxColumn.DataPropertyName = "QuantityOfGoods";
            this.quantityOfGoodsDataGridViewTextBoxColumn.Frozen = true;
            this.quantityOfGoodsDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityOfGoodsDataGridViewTextBoxColumn.Name = "quantityOfGoodsDataGridViewTextBoxColumn";
            this.quantityOfGoodsDataGridViewTextBoxColumn.Width = 50;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 50;
            // 
            // itemBindingSource1
            // 
            this.itemBindingSource1.DataMember = "Item";
            this.itemBindingSource1.DataSource = this.stockDataDataSet1;
            // 
            // stockDataDataSet1
            // 
            this.stockDataDataSet1.DataSetName = "StockDataDataSet1";
            this.stockDataDataSet1.Locale = new System.Globalization.CultureInfo("");
            this.stockDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(813, 49);
            this.panel3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(212, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Warehouse Management System";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.lbeuro);
            this.panel2.Controls.Add(this.tbSearch);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.numeric);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.rtbdescription);
            this.panel2.Controls.Add(this.tbPrice);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.tbName);
            this.panel2.Controls.Add(this.lbregister);
            this.panel2.Location = new System.Drawing.Point(471, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(305, 276);
            this.panel2.TabIndex = 10;
            // 
            // lbeuro
            // 
            this.lbeuro.AutoSize = true;
            this.lbeuro.BackColor = System.Drawing.SystemColors.Window;
            this.lbeuro.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbeuro.Location = new System.Drawing.Point(270, 54);
            this.lbeuro.Name = "lbeuro";
            this.lbeuro.Size = new System.Drawing.Size(14, 16);
            this.lbeuro.TabIndex = 14;
            this.lbeuro.Text = "€";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Window;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Image = global::Warehouse_Management_System.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(225, 239);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 31);
            this.btnSearch.TabIndex = 19;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(34, 240);
            this.tbSearch.MaxLength = 20;
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(236, 29);
            this.tbSearch.TabIndex = 19;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Gainsboro;
            this.btnEdit.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(206, 179);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 30);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label6.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(63, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Product search by name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAdd.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(109, 179);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 30);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDelete.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(10, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 30);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(13, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Number of products";
            // 
            // numeric
            // 
            this.numeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numeric.Location = new System.Drawing.Point(146, 148);
            this.numeric.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numeric.Name = "numeric";
            this.numeric.Size = new System.Drawing.Size(120, 16);
            this.numeric.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Product description";
            // 
            // rtbdescription
            // 
            this.rtbdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbdescription.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbdescription.Location = new System.Drawing.Point(145, 90);
            this.rtbdescription.Name = "rtbdescription";
            this.rtbdescription.Size = new System.Drawing.Size(143, 41);
            this.rtbdescription.TabIndex = 12;
            this.rtbdescription.Text = "";
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(160, 52);
            this.tbPrice.MaxLength = 20;
            this.tbPrice.Multiline = true;
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(128, 20);
            this.tbPrice.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(10, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "The cost of the product";
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.Location = new System.Drawing.Point(94, 17);
            this.tbName.MaxLength = 20;
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(128, 20);
            this.tbName.TabIndex = 9;
            // 
            // lbregister
            // 
            this.lbregister.AutoSize = true;
            this.lbregister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbregister.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbregister.ForeColor = System.Drawing.Color.Black;
            this.lbregister.Location = new System.Drawing.Point(12, 18);
            this.lbregister.Name = "lbregister";
            this.lbregister.Size = new System.Drawing.Size(70, 16);
            this.lbregister.TabIndex = 8;
            this.lbregister.Text = "New name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(441, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Warehouse_Management_System.Properties.Resources.warehouse;
            this.pictureBox1.Location = new System.Drawing.Point(364, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // itemTableAdapter1
            // 
            this.itemTableAdapter1.ClearBeforeFill = true;
            // 
            // Form_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 397);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form_Management";
            this.Text = "Form_Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Management_FormClosed);
            this.Load += new System.EventHandler(this.Form_Management_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataDataSet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbregister;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtbdescription;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numeric;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv;
        
        private System.Windows.Forms.DataGridViewTextBoxColumn typeIdDataGridViewTextBoxColumn;
        private StockDataDataSet1 stockDataDataSet1;
        private System.Windows.Forms.BindingSource itemBindingSource1;
        private StockDataDataSet1TableAdapters.ItemTableAdapter itemTableAdapter1;
        private System.Windows.Forms.Label lbeuro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOfGoodsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}