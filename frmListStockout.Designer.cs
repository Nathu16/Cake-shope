namespace BakeryInventorySystem
{
    partial class frmListStockout
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
            this.btnNew = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.DTPFROM = new System.Windows.Forms.DateTimePicker();
            this.DTPTO = new System.Windows.Forms.DateTimePicker();
            this.Label10 = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.TXTSEARCH = new System.Windows.Forms.TextBox();
            this.DTGLIST = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(768, 574);
            this.btnNew.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 36);
            this.btnNew.TabIndex = 74;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(660, 575);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 36);
            this.btnRefresh.TabIndex = 72;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Location = new System.Drawing.Point(867, 133);
            this.Label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(25, 17);
            this.Label17.TabIndex = 71;
            this.Label17.Text = "To";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(613, 133);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(40, 17);
            this.Label16.TabIndex = 70;
            this.Label16.Text = "From";
            // 
            // DTPFROM
            // 
            this.DTPFROM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPFROM.Location = new System.Drawing.Point(675, 127);
            this.DTPFROM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPFROM.Name = "DTPFROM";
            this.DTPFROM.Size = new System.Drawing.Size(184, 22);
            this.DTPFROM.TabIndex = 68;
            // 
            // DTPTO
            // 
            this.DTPTO.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTO.Location = new System.Drawing.Point(905, 127);
            this.DTPTO.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DTPTO.Name = "DTPTO";
            this.DTPTO.Size = new System.Drawing.Size(175, 22);
            this.DTPTO.TabIndex = 69;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(35, 578);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(86, 25);
            this.Label10.TabIndex = 67;
            this.Label10.Text = "Search :";
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(981, 574);
            this.Button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 36);
            this.Button1.TabIndex = 66;
            this.Button1.Text = "Close";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(873, 574);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 65;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // TXTSEARCH
            // 
            this.TXTSEARCH.BackColor = System.Drawing.Color.Cyan;
            this.TXTSEARCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTSEARCH.Location = new System.Drawing.Point(131, 575);
            this.TXTSEARCH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TXTSEARCH.Name = "TXTSEARCH";
            this.TXTSEARCH.Size = new System.Drawing.Size(521, 30);
            this.TXTSEARCH.TabIndex = 63;
            this.TXTSEARCH.TextChanged += new System.EventHandler(this.TXTSEARCH_TextChanged);
            // 
            // DTGLIST
            // 
            this.DTGLIST.AllowUserToAddRows = false;
            this.DTGLIST.AllowUserToDeleteRows = false;
            this.DTGLIST.AllowUserToResizeColumns = false;
            this.DTGLIST.AllowUserToResizeRows = false;
            this.DTGLIST.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DTGLIST.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DTGLIST.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLIST.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DTGLIST.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DTGLIST.Location = new System.Drawing.Point(4, 14);
            this.DTGLIST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DTGLIST.Name = "DTGLIST";
            this.DTGLIST.RowHeadersVisible = false;
            this.DTGLIST.RowHeadersWidth = 51;
            this.DTGLIST.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DTGLIST.Size = new System.Drawing.Size(1077, 554);
            this.DTGLIST.TabIndex = 64;
            this.DTGLIST.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLIST_CellContentClick);
            // 
            // frmListStockout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 618);
            this.Controls.Add(this.DTGLIST);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.DTPFROM);
            this.Controls.Add(this.DTPTO);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.TXTSEARCH);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmListStockout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Sold Items";
            this.Load += new System.EventHandler(this.frmListStockout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLIST)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnNew;
        internal System.Windows.Forms.Button btnRefresh;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.DateTimePicker DTPFROM;
        internal System.Windows.Forms.DateTimePicker DTPTO;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.TextBox TXTSEARCH;
        internal System.Windows.Forms.DataGridView DTGLIST;
    }
}