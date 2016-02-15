namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtSalesYear = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSalesRange = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRecords = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalCustomers = new System.Windows.Forms.Label();
            this.lbTotalSales = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentReport = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogReport = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialogReport = new System.Windows.Forms.PrintDialog();
            this.printDialogReportYear = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialogReportYear = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentReportYear = new System.Drawing.Printing.PrintDocument();
            this.toolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSortPaymentDate = new System.Windows.Forms.Button();
            this.btnSortEmail = new System.Windows.Forms.Button();
            this.btnSortPrice = new System.Windows.Forms.Button();
            this.btnSortCountry = new System.Windows.Forms.Button();
            this.btnSortFullName = new System.Windows.Forms.Button();
            this.btnPreviewYearlyReport = new System.Windows.Forms.Button();
            this.btnPrintYearlyReport = new System.Windows.Forms.Button();
            this.btnPreviewReport = new System.Windows.Forms.Button();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnPreviewInvoice = new System.Windows.Forms.Button();
            this.btnPrintInvoice = new System.Windows.Forms.Button();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportForSelectedMonthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportForSelectedYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportForSelectedMonthToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReportForSelectedTearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreRecordsToOriginalOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1360, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click_1);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem,
            this.restoreRecordsToOriginalOrderToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(68, 27);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 27);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(144, 28);
            this.aboutToolStripMenuItem1.Text = "About..";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtSalesYear);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtSalesRange);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(484, 178);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display Options";
            // 
            // dtSalesYear
            // 
            this.dtSalesYear.Location = new System.Drawing.Point(276, 113);
            this.dtSalesYear.Margin = new System.Windows.Forms.Padding(4);
            this.dtSalesYear.Name = "dtSalesYear";
            this.dtSalesYear.ShowUpDown = true;
            this.dtSalesYear.Size = new System.Drawing.Size(191, 30);
            this.dtSalesYear.TabIndex = 16;
            this.dtSalesYear.ValueChanged += new System.EventHandler(this.dtSalesYear_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(15, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Show Sales for the year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Show Sales for the month:";
            // 
            // dtSalesRange
            // 
            this.dtSalesRange.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSalesRange.Location = new System.Drawing.Point(275, 53);
            this.dtSalesRange.Margin = new System.Windows.Forms.Padding(4);
            this.dtSalesRange.Name = "dtSalesRange";
            this.dtSalesRange.Size = new System.Drawing.Size(191, 30);
            this.dtSalesRange.TabIndex = 14;
            this.dtSalesRange.ValueChanged += new System.EventHandler(this.dtSalesRange_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnPreviewYearlyReport);
            this.groupBox2.Controls.Add(this.btnPrintYearlyReport);
            this.groupBox2.Controls.Add(this.btnPreviewReport);
            this.groupBox2.Controls.Add(this.btnPrintReport);
            this.groupBox2.Controls.Add(this.btnPreviewInvoice);
            this.groupBox2.Controls.Add(this.btnPrintInvoice);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(505, 58);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(843, 178);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Printing Options";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnSortPaymentDate);
            this.panel1.Controls.Add(this.btnSortEmail);
            this.panel1.Controls.Add(this.btnSortPrice);
            this.panel1.Controls.Add(this.btnSortCountry);
            this.panel1.Controls.Add(this.btnSortFullName);
            this.panel1.Location = new System.Drawing.Point(12, 244);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1335, 86);
            this.panel1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1151, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID        Full Name                Country                              Email    " +
    "                           Price       Payment Date     Expiry Date        Renew" +
    "ed     Domain Names";
            // 
            // lstRecords
            // 
            this.lstRecords.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRecords.FormattingEnabled = true;
            this.lstRecords.ItemHeight = 17;
            this.lstRecords.Location = new System.Drawing.Point(12, 331);
            this.lstRecords.Margin = new System.Windows.Forms.Padding(4);
            this.lstRecords.Name = "lstRecords";
            this.lstRecords.Size = new System.Drawing.Size(1328, 157);
            this.lstRecords.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbTotalCustomers);
            this.panel2.Controls.Add(this.lbTotalSales);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 489);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1329, 42);
            this.panel2.TabIndex = 22;
            // 
            // lbTotalCustomers
            // 
            this.lbTotalCustomers.AutoEllipsis = true;
            this.lbTotalCustomers.AutoSize = true;
            this.lbTotalCustomers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotalCustomers.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCustomers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalCustomers.Location = new System.Drawing.Point(283, 10);
            this.lbTotalCustomers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalCustomers.MinimumSize = new System.Drawing.Size(80, 0);
            this.lbTotalCustomers.Name = "lbTotalCustomers";
            this.lbTotalCustomers.Size = new System.Drawing.Size(80, 25);
            this.lbTotalCustomers.TabIndex = 18;
            this.lbTotalCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbTotalSales
            // 
            this.lbTotalSales.AutoEllipsis = true;
            this.lbTotalSales.AutoSize = true;
            this.lbTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbTotalSales.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalSales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTotalSales.Location = new System.Drawing.Point(699, 10);
            this.lbTotalSales.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTotalSales.MinimumSize = new System.Drawing.Size(80, 0);
            this.lbTotalSales.Name = "lbTotalSales";
            this.lbTotalSales.Size = new System.Drawing.Size(80, 25);
            this.lbTotalSales.TabIndex = 17;
            this.lbTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(473, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "Total Amount of Sales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(4, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "Total Number of Customers:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Controls.Add(this.btnEdit);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Location = new System.Drawing.Point(292, 539);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(723, 100);
            this.panel3.TabIndex = 23;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocumentReport
            // 
            this.printDocumentReport.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentReport_PrintPage);
            // 
            // printPreviewDialogReport
            // 
            this.printPreviewDialogReport.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogReport.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogReport.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogReport.Enabled = true;
            this.printPreviewDialogReport.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogReport.Icon")));
            this.printPreviewDialogReport.Name = "printPreviewDialogReport";
            this.printPreviewDialogReport.Visible = false;
            // 
            // printDialogReport
            // 
            this.printDialogReport.UseEXDialog = true;
            // 
            // printDialogReportYear
            // 
            this.printDialogReportYear.UseEXDialog = true;
            // 
            // printPreviewDialogReportYear
            // 
            this.printPreviewDialogReportYear.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogReportYear.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogReportYear.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogReportYear.Enabled = true;
            this.printPreviewDialogReportYear.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogReportYear.Icon")));
            this.printPreviewDialogReportYear.Name = "printPreviewDialogReportYear";
            this.printPreviewDialogReportYear.Visible = false;
            // 
            // printDocumentReportYear
            // 
            this.printDocumentReportYear.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentReportYear_PrintPage);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = global::Project.Properties.Resources.b_add;
            this.btnAdd.Location = new System.Drawing.Point(20, 11);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 80);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = global::Project.Properties.Resources.b_edit;
            this.btnEdit.Location = new System.Drawing.Point(267, 11);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(180, 80);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit Record";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = global::Project.Properties.Resources.b_delete;
            this.btnDelete.Location = new System.Drawing.Point(505, 11);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(199, 80);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset2.Image = global::Project.Properties.Resources.a_refresh_a;
            this.btnReset2.Location = new System.Drawing.Point(1249, 11);
            this.btnReset2.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(53, 49);
            this.btnReset2.TabIndex = 14;
            this.btnReset2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipHelp.SetToolTip(this.btnReset2, "Restore original order of records");
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Image = global::Project.Properties.Resources.a_refresh;
            this.btnReset.Location = new System.Drawing.Point(4, 6);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(53, 49);
            this.btnReset.TabIndex = 7;
            this.btnReset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTipHelp.SetToolTip(this.btnReset, "Restore records original order");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSortPaymentDate
            // 
            this.btnSortPaymentDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSortPaymentDate.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortPaymentDate.Image = global::Project.Properties.Resources.a_sort;
            this.btnSortPaymentDate.Location = new System.Drawing.Point(672, 11);
            this.btnSortPaymentDate.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortPaymentDate.Name = "btnSortPaymentDate";
            this.btnSortPaymentDate.Size = new System.Drawing.Size(53, 49);
            this.btnSortPaymentDate.TabIndex = 9;
            this.toolTipHelp.SetToolTip(this.btnSortPaymentDate, "Sort by payment date");
            this.btnSortPaymentDate.UseVisualStyleBackColor = true;
            this.btnSortPaymentDate.Click += new System.EventHandler(this.btnSortPaymentDate_Click);
            // 
            // btnSortEmail
            // 
            this.btnSortEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSortEmail.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortEmail.Image = global::Project.Properties.Resources.a_sort;
            this.btnSortEmail.Location = new System.Drawing.Point(400, 10);
            this.btnSortEmail.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortEmail.Name = "btnSortEmail";
            this.btnSortEmail.Size = new System.Drawing.Size(53, 49);
            this.btnSortEmail.TabIndex = 11;
            this.toolTipHelp.SetToolTip(this.btnSortEmail, "Sort by email address");
            this.btnSortEmail.UseVisualStyleBackColor = true;
            this.btnSortEmail.Click += new System.EventHandler(this.btnSortEmail_Click);
            // 
            // btnSortPrice
            // 
            this.btnSortPrice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSortPrice.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortPrice.Image = global::Project.Properties.Resources.a_sort;
            this.btnSortPrice.Location = new System.Drawing.Point(566, 11);
            this.btnSortPrice.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortPrice.Name = "btnSortPrice";
            this.btnSortPrice.Size = new System.Drawing.Size(53, 49);
            this.btnSortPrice.TabIndex = 6;
            this.toolTipHelp.SetToolTip(this.btnSortPrice, "Sort by price");
            this.btnSortPrice.UseVisualStyleBackColor = true;
            this.btnSortPrice.Click += new System.EventHandler(this.btnSortPrice_Click);
            // 
            // btnSortCountry
            // 
            this.btnSortCountry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSortCountry.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortCountry.Image = global::Project.Properties.Resources.a_sort;
            this.btnSortCountry.Location = new System.Drawing.Point(214, 9);
            this.btnSortCountry.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortCountry.Name = "btnSortCountry";
            this.btnSortCountry.Size = new System.Drawing.Size(53, 49);
            this.btnSortCountry.TabIndex = 12;
            this.toolTipHelp.SetToolTip(this.btnSortCountry, "Sort by country");
            this.btnSortCountry.UseVisualStyleBackColor = true;
            this.btnSortCountry.Click += new System.EventHandler(this.btnSortCountry_Click);
            // 
            // btnSortFullName
            // 
            this.btnSortFullName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSortFullName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortFullName.Image = global::Project.Properties.Resources.a_sort;
            this.btnSortFullName.Location = new System.Drawing.Point(75, 6);
            this.btnSortFullName.Margin = new System.Windows.Forms.Padding(4);
            this.btnSortFullName.Name = "btnSortFullName";
            this.btnSortFullName.Size = new System.Drawing.Size(53, 49);
            this.btnSortFullName.TabIndex = 10;
            this.toolTipHelp.SetToolTip(this.btnSortFullName, "Sort by full name");
            this.btnSortFullName.UseVisualStyleBackColor = true;
            this.btnSortFullName.Click += new System.EventHandler(this.btnSortFullName_Click);
            // 
            // btnPreviewYearlyReport
            // 
            this.btnPreviewYearlyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreviewYearlyReport.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewYearlyReport.Image = global::Project.Properties.Resources.b_preview;
            this.btnPreviewYearlyReport.Location = new System.Drawing.Point(359, 105);
            this.btnPreviewYearlyReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviewYearlyReport.Name = "btnPreviewYearlyReport";
            this.btnPreviewYearlyReport.Size = new System.Drawing.Size(225, 55);
            this.btnPreviewYearlyReport.TabIndex = 23;
            this.btnPreviewYearlyReport.Text = "Preview Selected Yearly Sales Report";
            this.btnPreviewYearlyReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviewYearlyReport.UseVisualStyleBackColor = true;
            this.btnPreviewYearlyReport.Click += new System.EventHandler(this.btnPreviewYearlyReport_Click);
            // 
            // btnPrintYearlyReport
            // 
            this.btnPrintYearlyReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintYearlyReport.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintYearlyReport.Image = global::Project.Properties.Resources.b_print;
            this.btnPrintYearlyReport.Location = new System.Drawing.Point(359, 34);
            this.btnPrintYearlyReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintYearlyReport.Name = "btnPrintYearlyReport";
            this.btnPrintYearlyReport.Size = new System.Drawing.Size(225, 55);
            this.btnPrintYearlyReport.TabIndex = 22;
            this.btnPrintYearlyReport.Text = "Print Selected Yearly Sales Report";
            this.btnPrintYearlyReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintYearlyReport.UseVisualStyleBackColor = true;
            this.btnPrintYearlyReport.Click += new System.EventHandler(this.btnPrintYearlyReport_Click);
            // 
            // btnPreviewReport
            // 
            this.btnPreviewReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreviewReport.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewReport.Image = global::Project.Properties.Resources.b_preview;
            this.btnPreviewReport.Location = new System.Drawing.Point(19, 105);
            this.btnPreviewReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviewReport.Name = "btnPreviewReport";
            this.btnPreviewReport.Size = new System.Drawing.Size(253, 55);
            this.btnPreviewReport.TabIndex = 21;
            this.btnPreviewReport.Text = "Preview Selected Monthly Sales Report";
            this.btnPreviewReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviewReport.UseVisualStyleBackColor = true;
            this.btnPreviewReport.Click += new System.EventHandler(this.btnPreviewReport_Click);
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintReport.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Image = global::Project.Properties.Resources.b_print;
            this.btnPrintReport.Location = new System.Drawing.Point(19, 34);
            this.btnPrintReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(253, 55);
            this.btnPrintReport.TabIndex = 20;
            this.btnPrintReport.Text = "Print Selected Monthly Sales Report";
            this.btnPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnPreviewInvoice
            // 
            this.btnPreviewInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreviewInvoice.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviewInvoice.Image = global::Project.Properties.Resources.b_preview;
            this.btnPreviewInvoice.Location = new System.Drawing.Point(673, 105);
            this.btnPreviewInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreviewInvoice.Name = "btnPreviewInvoice";
            this.btnPreviewInvoice.Size = new System.Drawing.Size(149, 55);
            this.btnPreviewInvoice.TabIndex = 19;
            this.btnPreviewInvoice.Text = "Preview Invoice";
            this.btnPreviewInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPreviewInvoice.UseVisualStyleBackColor = true;
            this.btnPreviewInvoice.Click += new System.EventHandler(this.btnPreviewInvoice_Click);
            // 
            // btnPrintInvoice
            // 
            this.btnPrintInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintInvoice.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintInvoice.Image = global::Project.Properties.Resources.b_print;
            this.btnPrintInvoice.Location = new System.Drawing.Point(673, 34);
            this.btnPrintInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintInvoice.Name = "btnPrintInvoice";
            this.btnPrintInvoice.Size = new System.Drawing.Size(149, 55);
            this.btnPrintInvoice.TabIndex = 7;
            this.btnPrintInvoice.Text = "Print Invoice";
            this.btnPrintInvoice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrintInvoice.UseVisualStyleBackColor = true;
            this.btnPrintInvoice.Click += new System.EventHandler(this.btnPrintInvoice_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem,
            this.salesReportForSelectedMonthToolStripMenuItem,
            this.salesReportForSelectedYearToolStripMenuItem});
            this.printToolStripMenuItem.Image = global::Project.Properties.Resources.a_print;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(424, 28);
            this.invoiceToolStripMenuItem.Text = "Invoice";
            this.invoiceToolStripMenuItem.Click += new System.EventHandler(this.invoiceToolStripMenuItem_Click_1);
            // 
            // salesReportForSelectedMonthToolStripMenuItem
            // 
            this.salesReportForSelectedMonthToolStripMenuItem.Name = "salesReportForSelectedMonthToolStripMenuItem";
            this.salesReportForSelectedMonthToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.salesReportForSelectedMonthToolStripMenuItem.Size = new System.Drawing.Size(424, 28);
            this.salesReportForSelectedMonthToolStripMenuItem.Text = "Sales Report for Selected Month";
            this.salesReportForSelectedMonthToolStripMenuItem.Click += new System.EventHandler(this.salesReportForSelectedMonthToolStripMenuItem_Click);
            // 
            // salesReportForSelectedYearToolStripMenuItem
            // 
            this.salesReportForSelectedYearToolStripMenuItem.Name = "salesReportForSelectedYearToolStripMenuItem";
            this.salesReportForSelectedYearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.salesReportForSelectedYearToolStripMenuItem.Size = new System.Drawing.Size(424, 28);
            this.salesReportForSelectedYearToolStripMenuItem.Text = "Sales Report for Selected Year";
            this.salesReportForSelectedYearToolStripMenuItem.Click += new System.EventHandler(this.salesReportForSelectedYearToolStripMenuItem_Click);
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem1,
            this.salesReportForSelectedMonthToolStripMenuItem1,
            this.salesReportForSelectedTearToolStripMenuItem});
            this.printPreviewToolStripMenuItem.Image = global::Project.Properties.Resources.a_preview;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(201, 28);
            this.printPreviewToolStripMenuItem.Text = "Print Preview";
            // 
            // invoiceToolStripMenuItem1
            // 
            this.invoiceToolStripMenuItem1.Name = "invoiceToolStripMenuItem1";
            this.invoiceToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.invoiceToolStripMenuItem1.Size = new System.Drawing.Size(475, 28);
            this.invoiceToolStripMenuItem1.Text = "Invoice";
            this.invoiceToolStripMenuItem1.Click += new System.EventHandler(this.invoiceToolStripMenuItem1_Click_1);
            // 
            // salesReportForSelectedMonthToolStripMenuItem1
            // 
            this.salesReportForSelectedMonthToolStripMenuItem1.Name = "salesReportForSelectedMonthToolStripMenuItem1";
            this.salesReportForSelectedMonthToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.M)));
            this.salesReportForSelectedMonthToolStripMenuItem1.Size = new System.Drawing.Size(475, 28);
            this.salesReportForSelectedMonthToolStripMenuItem1.Text = "Sales Report for Selected Month";
            this.salesReportForSelectedMonthToolStripMenuItem1.Click += new System.EventHandler(this.salesReportForSelectedMonthToolStripMenuItem1_Click);
            // 
            // salesReportForSelectedTearToolStripMenuItem
            // 
            this.salesReportForSelectedTearToolStripMenuItem.Name = "salesReportForSelectedTearToolStripMenuItem";
            this.salesReportForSelectedTearToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Y)));
            this.salesReportForSelectedTearToolStripMenuItem.Size = new System.Drawing.Size(475, 28);
            this.salesReportForSelectedTearToolStripMenuItem.Text = "Sales Report for Selected Year";
            this.salesReportForSelectedTearToolStripMenuItem.Click += new System.EventHandler(this.salesReportForSelectedTearToolStripMenuItem_Click);
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.countryToolStripMenuItem,
            this.emailToolStripMenuItem,
            this.fullNameToolStripMenuItem,
            this.paymentDateToolStripMenuItem,
            this.priceToolStripMenuItem});
            this.sortByToolStripMenuItem.Image = global::Project.Properties.Resources.a_sort2;
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(438, 28);
            this.sortByToolStripMenuItem.Text = "Sort by";
            // 
            // countryToolStripMenuItem
            // 
            this.countryToolStripMenuItem.Name = "countryToolStripMenuItem";
            this.countryToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.countryToolStripMenuItem.Size = new System.Drawing.Size(320, 28);
            this.countryToolStripMenuItem.Text = "Country";
            this.countryToolStripMenuItem.Click += new System.EventHandler(this.countryToolStripMenuItem_Click);
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.E)));
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(320, 28);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // fullNameToolStripMenuItem
            // 
            this.fullNameToolStripMenuItem.Name = "fullNameToolStripMenuItem";
            this.fullNameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.fullNameToolStripMenuItem.Size = new System.Drawing.Size(320, 28);
            this.fullNameToolStripMenuItem.Text = "Full Name";
            this.fullNameToolStripMenuItem.Click += new System.EventHandler(this.fullNameToolStripMenuItem_Click);
            // 
            // paymentDateToolStripMenuItem
            // 
            this.paymentDateToolStripMenuItem.Name = "paymentDateToolStripMenuItem";
            this.paymentDateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.paymentDateToolStripMenuItem.Size = new System.Drawing.Size(320, 28);
            this.paymentDateToolStripMenuItem.Text = "Payment Date";
            this.paymentDateToolStripMenuItem.Click += new System.EventHandler(this.paymentDateToolStripMenuItem_Click);
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(320, 28);
            this.priceToolStripMenuItem.Text = "Price";
            this.priceToolStripMenuItem.Click += new System.EventHandler(this.priceToolStripMenuItem_Click);
            // 
            // restoreRecordsToOriginalOrderToolStripMenuItem
            // 
            this.restoreRecordsToOriginalOrderToolStripMenuItem.Image = global::Project.Properties.Resources.a_refresh2;
            this.restoreRecordsToOriginalOrderToolStripMenuItem.Name = "restoreRecordsToOriginalOrderToolStripMenuItem";
            this.restoreRecordsToOriginalOrderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.restoreRecordsToOriginalOrderToolStripMenuItem.Size = new System.Drawing.Size(438, 28);
            this.restoreRecordsToOriginalOrderToolStripMenuItem.Text = "Restore Records to Original Order";
            this.restoreRecordsToOriginalOrderToolStripMenuItem.Click += new System.EventHandler(this.restoreRecordsToOriginalOrderToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 638);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lstRecords);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Sales Records";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportForSelectedMonthToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReportForSelectedYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salesReportForSelectedMonthToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salesReportForSelectedTearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreRecordsToOriginalOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtSalesYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSalesRange;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPreviewYearlyReport;
        private System.Windows.Forms.Button btnPrintYearlyReport;
        private System.Windows.Forms.Button btnPreviewReport;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.Button btnPreviewInvoice;
        private System.Windows.Forms.Button btnPrintInvoice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSortPaymentDate;
        private System.Windows.Forms.Button btnSortEmail;
        private System.Windows.Forms.Button btnSortPrice;
        private System.Windows.Forms.Button btnSortCountry;
        private System.Windows.Forms.Button btnSortFullName;
        private System.Windows.Forms.ListBox lstRecords;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTotalCustomers;
        private System.Windows.Forms.Label lbTotalSales;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocumentReport;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogReport;
        private System.Windows.Forms.PrintDialog printDialogReport;
        private System.Windows.Forms.PrintDialog printDialogReportYear;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogReportYear;
        private System.Drawing.Printing.PrintDocument printDocumentReportYear;
        private System.Windows.Forms.ToolTip toolTipHelp;
        private System.Windows.Forms.Button btnReset2;
    }
}

