namespace BakeryInventorySystem
{
    partial class frmStockout
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
            this.Label4 = new System.Windows.Forms.Label();
            this.txtPROCODE = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.TXTPRICE = new System.Windows.Forms.TextBox();
            this.Label13 = new System.Windows.Forms.Label();
            this.LBLUNIT = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.TXTTOT = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TXTQTY = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.BTNNEW = new System.Windows.Forms.Button();
            this.LBLTRANSNUM = new System.Windows.Forms.Label();
            this.BTNSAVE = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.DTPTRANSDATE = new System.Windows.Forms.DateTimePicker();
            this.BTNCLOSE = new System.Windows.Forms.Button();
            this.Label6 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.TXTAVAILQTY = new System.Windows.Forms.TextBox();
            this.TXTPRODUCT = new System.Windows.Forms.TextBox();
            this.TXTDESC = new System.Windows.Forms.RichTextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.LBLMSG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(29, 52);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(117, 18);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "Product Code:";
            // 
            // txtPROCODE
            // 
            this.txtPROCODE.Location = new System.Drawing.Point(167, 44);
            this.txtPROCODE.Margin = new System.Windows.Forms.Padding(4);
            this.txtPROCODE.Name = "txtPROCODE";
            this.txtPROCODE.Size = new System.Drawing.Size(431, 30);
            this.txtPROCODE.TabIndex = 36;
            this.txtPROCODE.TextChanged += new System.EventHandler(this.txtPROCODE_TextChanged);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(91, 213);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(59, 20);
            this.Label10.TabIndex = 33;
            this.Label10.Text = "Price:";
            this.Label10.Click += new System.EventHandler(this.Label10_Click);
            // 
            // TXTPRICE
            // 
            this.TXTPRICE.Enabled = false;
            this.TXTPRICE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRICE.Location = new System.Drawing.Point(167, 201);
            this.TXTPRICE.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTPRICE.Name = "TXTPRICE";
            this.TXTPRICE.Size = new System.Drawing.Size(176, 36);
            this.TXTPRICE.TabIndex = 32;
            this.TXTPRICE.TextChanged += new System.EventHandler(this.TXTPRICE_TextChanged);
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label13.Location = new System.Drawing.Point(55, 82);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(179, 20);
            this.Label13.TabIndex = 32;
            this.Label13.Text = "Remaining Quantity:";
            // 
            // LBLUNIT
            // 
            this.LBLUNIT.Enabled = false;
            this.LBLUNIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLUNIT.Location = new System.Drawing.Point(269, 70);
            this.LBLUNIT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LBLUNIT.Name = "LBLUNIT";
            this.LBLUNIT.Size = new System.Drawing.Size(176, 34);
            this.LBLUNIT.TabIndex = 31;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(139, 123);
            this.Label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(107, 20);
            this.Label8.TabIndex = 23;
            this.Label8.Text = "Total Price:";
            // 
            // TXTTOT
            // 
            this.TXTTOT.Enabled = false;
            this.TXTTOT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTTOT.Location = new System.Drawing.Point(272, 112);
            this.TXTTOT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTTOT.Name = "TXTTOT";
            this.TXTTOT.Size = new System.Drawing.Size(176, 34);
            this.TXTTOT.TabIndex = 22;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(149, 41);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(85, 20);
            this.Label9.TabIndex = 21;
            this.Label9.Text = "Quantity:";
            // 
            // TXTQTY
            // 
            this.TXTQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTQTY.Location = new System.Drawing.Point(269, 30);
            this.TXTQTY.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTQTY.Name = "TXTQTY";
            this.TXTQTY.Size = new System.Drawing.Size(176, 34);
            this.TXTQTY.TabIndex = 20;
            this.TXTQTY.TextChanged += new System.EventHandler(this.TXTQTY_TextChanged);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(832, 471);
            this.btnList.Margin = new System.Windows.Forms.Padding(4);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(113, 39);
            this.btnList.TabIndex = 54;
            this.btnList.Text = "List";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(45, 257);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(91, 40);
            this.Label7.TabIndex = 29;
            this.Label7.Text = "Available \r\nQuantity:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label13);
            this.GroupBox2.Controls.Add(this.LBLUNIT);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.TXTTOT);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.TXTQTY);
            this.GroupBox2.Location = new System.Drawing.Point(419, 202);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox2.Size = new System.Drawing.Size(624, 169);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Summary";
            // 
            // BTNNEW
            // 
            this.BTNNEW.Location = new System.Drawing.Point(587, 471);
            this.BTNNEW.Margin = new System.Windows.Forms.Padding(4);
            this.BTNNEW.Name = "BTNNEW";
            this.BTNNEW.Size = new System.Drawing.Size(113, 39);
            this.BTNNEW.TabIndex = 51;
            this.BTNNEW.Text = "New";
            this.BTNNEW.UseVisualStyleBackColor = true;
            this.BTNNEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // LBLTRANSNUM
            // 
            this.LBLTRANSNUM.AutoSize = true;
            this.LBLTRANSNUM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTRANSNUM.Location = new System.Drawing.Point(156, 38);
            this.LBLTRANSNUM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLTRANSNUM.Name = "LBLTRANSNUM";
            this.LBLTRANSNUM.Size = new System.Drawing.Size(73, 25);
            this.LBLTRANSNUM.TabIndex = 45;
            this.LBLTRANSNUM.Text = "NONE";
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Location = new System.Drawing.Point(708, 471);
            this.BTNSAVE.Margin = new System.Windows.Forms.Padding(4);
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(113, 39);
            this.BTNSAVE.TabIndex = 50;
            this.BTNSAVE.Text = "Save";
            this.BTNSAVE.UseVisualStyleBackColor = true;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(17, 42);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(99, 17);
            this.Label2.TabIndex = 44;
            this.Label2.Text = "Transaction #:";
            // 
            // DTPTRANSDATE
            // 
            this.DTPTRANSDATE.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPTRANSDATE.Location = new System.Drawing.Point(873, 34);
            this.DTPTRANSDATE.Margin = new System.Windows.Forms.Padding(4);
            this.DTPTRANSDATE.Name = "DTPTRANSDATE";
            this.DTPTRANSDATE.Size = new System.Drawing.Size(192, 22);
            this.DTPTRANSDATE.TabIndex = 47;
            this.DTPTRANSDATE.ValueChanged += new System.EventHandler(this.DTPTRANSDATE_ValueChanged);
            // 
            // BTNCLOSE
            // 
            this.BTNCLOSE.Location = new System.Drawing.Point(953, 470);
            this.BTNCLOSE.Margin = new System.Windows.Forms.Padding(4);
            this.BTNCLOSE.Name = "BTNCLOSE";
            this.BTNCLOSE.Size = new System.Drawing.Size(113, 39);
            this.BTNCLOSE.TabIndex = 49;
            this.BTNCLOSE.Text = "Close";
            this.BTNCLOSE.UseVisualStyleBackColor = true;
            this.BTNCLOSE.Click += new System.EventHandler(this.BTNCLOSE_Click);
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(705, 38);
            this.Label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(121, 17);
            this.Label6.TabIndex = 46;
            this.Label6.Text = "Transaction Date:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtPROCODE);
            this.GroupBox1.Controls.Add(this.Label10);
            this.GroupBox1.Controls.Add(this.TXTPRICE);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.TXTAVAILQTY);
            this.GroupBox1.Controls.Add(this.GroupBox2);
            this.GroupBox1.Controls.Add(this.TXTPRODUCT);
            this.GroupBox1.Controls.Add(this.TXTDESC);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(15, 67);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox1.Size = new System.Drawing.Size(1051, 386);
            this.GroupBox1.TabIndex = 48;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Product Details";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // TXTAVAILQTY
            // 
            this.TXTAVAILQTY.Enabled = false;
            this.TXTAVAILQTY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTAVAILQTY.Location = new System.Drawing.Point(167, 257);
            this.TXTAVAILQTY.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTAVAILQTY.Name = "TXTAVAILQTY";
            this.TXTAVAILQTY.Size = new System.Drawing.Size(176, 36);
            this.TXTAVAILQTY.TabIndex = 28;
            this.TXTAVAILQTY.TextChanged += new System.EventHandler(this.TXTAVAILQTY_TextChanged);
            // 
            // TXTPRODUCT
            // 
            this.TXTPRODUCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTPRODUCT.Location = new System.Drawing.Point(167, 82);
            this.TXTPRODUCT.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTPRODUCT.Name = "TXTPRODUCT";
            this.TXTPRODUCT.Size = new System.Drawing.Size(719, 26);
            this.TXTPRODUCT.TabIndex = 28;
            // 
            // TXTDESC
            // 
            this.TXTDESC.Enabled = false;
            this.TXTDESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDESC.Location = new System.Drawing.Point(167, 116);
            this.TXTDESC.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.TXTDESC.Name = "TXTDESC";
            this.TXTDESC.Size = new System.Drawing.Size(719, 79);
            this.TXTDESC.TabIndex = 30;
            this.TXTDESC.Text = "";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(77, 86);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 18);
            this.Label3.TabIndex = 3;
            this.Label3.Text = "Product:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(45, 118);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(99, 18);
            this.Label5.TabIndex = 6;
            this.Label5.Text = "Description:";
            // 
            // LBLMSG
            // 
            this.LBLMSG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMSG.Location = new System.Drawing.Point(16, 11);
            this.LBLMSG.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLMSG.Name = "LBLMSG";
            this.LBLMSG.Size = new System.Drawing.Size(1055, 23);
            this.LBLMSG.TabIndex = 52;
            this.LBLMSG.Text = "Label11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 55;
            this.label1.Text = "By:- Deep Gadhiya";
            // 
            // frmStockout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 537);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.BTNNEW);
            this.Controls.Add(this.LBLTRANSNUM);
            this.Controls.Add(this.BTNSAVE);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.DTPTRANSDATE);
            this.Controls.Add(this.BTNCLOSE);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.LBLMSG);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStockout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stockout";
            this.Load += new System.EventHandler(this.frmStockout_Load);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtPROCODE;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox TXTPRICE;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.TextBox LBLUNIT;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox TXTTOT;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox TXTQTY;
        internal System.Windows.Forms.Button btnList;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button BTNNEW;
        internal System.Windows.Forms.Label LBLTRANSNUM;
        internal System.Windows.Forms.Button BTNSAVE;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker DTPTRANSDATE;
        internal System.Windows.Forms.Button BTNCLOSE;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox TXTAVAILQTY;
        internal System.Windows.Forms.TextBox TXTPRODUCT;
        internal System.Windows.Forms.RichTextBox TXTDESC;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label LBLMSG;
        private System.Windows.Forms.Label label1;
    }
}