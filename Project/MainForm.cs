//MainForm.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.CustomerFiles;
using System.Drawing.Printing;

namespace Project
{
    public partial class MainForm : Form
    {
        //instance of customermanager object
        private CustomerManager manager = null;
        //path to the file with data
        private string fileName = Application.StartupPath + "\\data.xml";
        //total number of customers
        private int totalCustomers = 0;
        //total amount of sales
        private double totalSales = 0.0;
        //copy of records to stored sorted records by month,year
        List<Customer> copySortedByTime;
        //copy of records to store sorted records by year
        List<Customer> copySortedByYear;
        //variable to keep track whether records were sorted by certain time period to enable further sorting by other parameters
        //0-not sorted by time, 1- sorted by month,year, 2-sorted by year
        private int sortedByTimePeriod;

        public MainForm()
        {
            InitializeComponent();
            //create customer manager object
            manager = new CustomerManager();
            //initialise form components
            InitialiseGUI();
            
        }
        /// <summary>
        /// setup form components with data
        /// </summary>
        private void InitialiseGUI()
        {
            //read data from file
            ReadData(fileName);
            //update the data to be displayed
            //UpdateList();

            //display month and year
            dtSalesRange.Format = DateTimePickerFormat.Custom;
            dtSalesRange.CustomFormat = "MMMM yyyy";

            //display year only
            dtSalesYear.Format = DateTimePickerFormat.Custom;
            dtSalesYear.CustomFormat = "yyyy";
            dtSalesYear.ShowUpDown = true;
            //calculate total number of customers and total sales from data read
            GetTotals(manager.ObjectList);
            //display totals for number of custmores and sales
            RefreshTotals();
            //list not sorted initially
            sortedByTimePeriod = 0;
            //hide reset button
            btnReset2.Visible = false;
        }
        /// <summary>
        /// read data from xml file and display
        /// previously saved data
        /// </summary>
        /// <param name="file">file name to read data from</param>
        private void ReadData(string file)
        {
            //try xml deserialsation and update list if successful
            try
            {
                manager.XMLDeSerialise(file);
                //update results with file data
                UpdateList();
            }
            catch (Exception ex)
            {//show warning if any exceptions occur
                MessageBox.Show(string.Format("Could not retrieve data from file {0}! Exception: {1}", fileName, ex.ToString()), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                        
        }
        /// <summary>
        /// save data to xml file
        /// </summary>
        /// <param name="file">file name</param>
        private void SaveToFile(string file)
        {
            try
            {
                manager.XMLSerialise(file);
            //    MessageBox.Show(string.Format("{0} saved on disk sussessfully", file), "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("{0} could not be saved on disk! Exception: {1}", file, ex.ToString()), "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /// <summary>
        /// displays all added customers' info in the listbox
        /// </summary>
        private void UpdateList()
        {
            //save records to xml file
            SaveToFile(fileName);
            //refresh records list
            lstRecords.Items.Clear();
            lstRecords.Items.AddRange(manager.ToStringArray());

            //get totals for original records list
            GetTotals(manager.ObjectList);
            //update totals
            RefreshTotals();


        }
        /// <summary>
        /// update totals for customer count and sales revenue for an updated records list
        /// </summary>
        private void RefreshTotals()
        {
            lbTotalCustomers.Text = totalCustomers.ToString();

            lbTotalSales.Text = totalSales.ToString();
        }

        /// <summary>
        /// get total number of customer and total sales figure
        /// </summary>
        /// <param name="copy">list of records</param>
        private void GetTotals(List<Customer> copy)
        {
            double price = 0.0;
            //get total sales price
            for (int i = 0; i < copy.Count; i++)
                price += copy[i].ProductData.ProductPrice;

            totalSales = price;
            //total number of customers
            totalCustomers = copy.Count;

        }



        /*******************Add, Edit and deletecustomer records******************/
        /// <summary>
        /// add new record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            RecordForm recForm = new RecordForm();

            //when user enters all data in contact form and click ok
            if (recForm.ShowDialog() == DialogResult.OK)
            {
                Customer customer = new Customer(recForm.CustomerData.FirstName, recForm.CustomerData.Surname, recForm.CustomerData.AddressData, recForm.CustomerData.Email, recForm.CustomerData.ProductData, manager.GetNewId);

                //add new record to customers list
                manager.Add(customer);
                //display updated info in the listbox
                UpdateList();
            }

        }
        /// <summary>
        /// edit record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if the record is selected
            if (IsSelected())
            {
                //create an instance of contactform
                RecordForm frmContact = new RecordForm();
                //provided the record is selected from the listbox
                if (manager.GetAt(lstRecords.SelectedIndex) != null)
                {
                    //get selected record's ino and display it on contact form
                    frmContact.CustomerData = manager.GetAt(lstRecords.SelectedIndex);
                    //save id
                    int id = frmContact.CustomerData.CustomerId;

                    //when user chooses to update corrected info and click ok button
                    if (frmContact.ShowDialog() == DialogResult.OK)
                    {
                        frmContact.CustomerData.CustomerId = id;
                        //save updated info
                        manager.ChangeAt(frmContact.CustomerData, lstRecords.SelectedIndex);
                        
                        //update data in the listbox
                        UpdateList();
                    }

                }
            }

        }
        /// <summary>
        /// delete record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //provided the record is selected in the listbox
            if (IsSelected())
            {
                if (manager.CheckIndex(lstRecords.SelectedIndex))
                    //if user chooses to proceed with record deletion
                    if (MessageBox.Show("Are you sure you want to delete this record?", "Delete record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //delete the record from the list
                        manager.DeleteAt(lstRecords.SelectedIndex);
                        //and update display info
                        UpdateList();
                    }
            }

        }

        /// <summary>
        /// checks whether a record is selected in the listbox
        /// </summary>
        /// <returns>true if record is selected and false otherwise</returns>
        private bool IsSelected()
        {
            if (lstRecords.SelectedIndex != -1)
                return true;
            else
                MessageBox.Show("Please select a record first before performing this operation","Warning",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            return false;
        }

        //____________________Displaying data for selected time period
        /// <summary>
        /// display records for selected month
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtSalesRange_ValueChanged(object sender, EventArgs e)
        {
            //sorted by month/year
            sortedByTimePeriod = 1;
            lstRecords.Items.Clear();
            lstRecords.Items.AddRange(ShowSelectedSales(dtSalesRange.Value.Month, dtSalesRange.Value.Year, 0));
            RefreshTotals();
        }
        /// <summary>
        /// show records for selected year
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void dtSalesYear_ValueChanged(object sender, EventArgs e)
        {
            sortedByTimePeriod = 2;
            lstRecords.Items.Clear();
            lstRecords.Items.AddRange(ShowSelectedSales(0, dtSalesYear.Value.Year, 0));
            RefreshTotals();
        }
        /// <summary>
        /// get records for selected year both for displaying(print=0)
        /// and for printing(print=1)
        /// </summary>
        /// <param name="year">selected year</param>
        /// <param name="print">for printing(1) or for displaying(0)</param>
        /// <returns>array of records for selected year</returns>
        public string[] ShowSelectedSales(int month,int year, int print)
        {
            //create a copy of the original list
           // List<Customer> copySorted = manager.ObjectList;
            if (month == 0)
            {
                //create a copy of the original list
                copySortedByYear = manager.ObjectList;
                //find records for the year selected
                copySortedByYear = copySortedByYear.FindAll(c => c.ProductData.PaymentDate.Year.Equals(year));
                //calculate the totals for the new list of records
                GetTotals(copySortedByYear);
                return manager.GetSortedCustomerInfo(copySortedByYear, print);
            }
            else
            {
                //create a copy of the original list
                copySortedByTime = manager.ObjectList;
                //find all records for selected month
                copySortedByTime = copySortedByTime.FindAll(c => c.ProductData.PaymentDate.Month.Equals(month) && c.ProductData.PaymentDate.Year.Equals(year));
                //calculate the totals for the new list of records
                GetTotals(copySortedByTime);
                return manager.GetSortedCustomerInfo(copySortedByTime, print);
            }
           
        }

        //___________________________Sorting records
        /// <summary>
        /// get customer list either sorted or
        /// in original order
        /// </summary>
        /// <param name="byTime">indicates whether customer list is sorted or not</param>
        /// <returns></returns>
        private List<Customer> CustomerList(int byTime)
        {
            //create a copy of the list
            List<Customer> copySorted = manager.ObjectList;
            if (byTime == 1) copySorted = copySortedByTime;
            else if (byTime == 2)
                copySorted = copySortedByYear;
            return copySorted;
        }
        /// <summary>
        /// generic method for sorting records by provided value
        /// </summary>
        /// <param name="sort">value to be sorted by</param>
        /// <returns>sorted array of strings</returns>
        private string[] SortedBy(string sort, int byTime)
        {
            //create a copy of the customer list sorted or unsorted
            List<Customer> copySorted = CustomerList(sortedByTimePeriod);
           

            //sort records by value selected
            switch (sort)
            {
                case "price": copySorted = copySorted.OrderBy(customers => customers.ProductData.ProductPrice).ToList();
                    break;
                case "country": copySorted = copySorted.OrderBy(customers => customers.AddressData.Country).ToList();
                    break;
                case "name": copySorted = copySorted.OrderBy(customers => customers.FullName).ToList();
                    break;
                case "email": copySorted = copySorted.OrderBy(customers => customers.Email).ToList();
                    break;
                case "date": copySorted = copySorted.OrderBy(c => c.ProductData.PaymentDate.Day).ThenBy(c => c.ProductData.PaymentDate.Month).ThenBy(c => c.ProductData.PaymentDate.Year).ToList();
                    break;

            }
            //calculate totals for sorted list
            GetTotals(copySorted);

            return manager.GetSortedCustomerInfo(copySorted, 0);

        }

        /// <summary>
        /// generic method for displaying records sorted by selected value
        /// </summary>
        /// <param name="sortedBy">value to be sorted by</param>
        private void ShowSortedRecords(string sortedBy)
        {
            string[] sorted = SortedBy(sortedBy,sortedByTimePeriod);
            //display updated list
            lstRecords.Items.Clear();
            lstRecords.Items.AddRange(sorted);
            //update totals
            RefreshTotals();

        }
        /// <summary>
        /// show records sorted by customer's full name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortFullName_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("name");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// show records sorted by country
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortCountry_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("country");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// show records sorted by email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortEmail_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("email");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// show records sorted by price
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortPrice_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("price");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// show records sorted by payment date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortPaymentDate_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("date");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// restore the records for selected month/year from being
        /// sorted by some other value to their original state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset2_Click(object sender, EventArgs e)
        {
            //clear the listbox
            lstRecords.Items.Clear();
            //show records sorted by selected month/year or year only (undo any other sorting perormed on the records)
            if (sortedByTimePeriod == 1)
                lstRecords.Items.AddRange(ShowSelectedSales(dtSalesRange.Value.Month, dtSalesRange.Value.Year, 0));
            else if (sortedByTimePeriod == 2)
                lstRecords.Items.AddRange(ShowSelectedSales(0, dtSalesYear.Value.Year, 0));

            RefreshTotals();
        }
        /// <summary>
        /// reset records list to original unsorted state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //refresh records list
            GetTotals(manager.ObjectList);
            UpdateList();
            sortedByTimePeriod = 0;
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// check whether the refresh button used to restore
        /// the original order of records for selected month of the year or for
        /// selected year
        /// </summary>
        private void CheckRefreshButtonVisibility()
        {
            //if all records are shown - hide the button
            if (sortedByTimePeriod == 0)
                btnReset2.Visible = false;
            else
                //if records are sorted by selected month or year - show the button
                btnReset2.Visible = true;
        }


        //__________________Print and preview invoices

        /// <summary>
        /// generate text for invoice for a selected record
        /// </summary>
        /// <param name="ind">index of selected records</param>
        /// <returns>invoice text</returns>
        public string GetInvoice(int ind)
        {
            string text;
            //create a copy of the customer list sorted or unsorted
            List<Customer> copySorted = CustomerList(sortedByTimePeriod);
            
            
            text = "\n\n\nCompany Name\n\nCompany Contact Details\n\n______________________________\nInvoice Number: " + (ind + 17253);
            text += "\n\nTo:          " + copySorted[ind].FullName + "\n\nFees:    " + copySorted[ind].ProductData.ProductName;
            text += "\n\n                                    " + copySorted[ind].ProductData.ProductPrice;
            text += "\n\n                  TOTAL:  " + copySorted[ind].ProductData.ProductPrice;

            return text;
        }
        /// <summary>
        /// setup invoice layout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);

            //get information for selected record for the invoice
            string print = GetInvoice(lstRecords.SelectedIndex);

            g.DrawString(print, new Font("Cambria", 12), brush, 10, 10);
        }
        /// <summary>
        /// print invoice for the record selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            //make sure the record is selected
            if (IsSelected())
                Printing(printDialog1, printDocument1);
        }
        /// <summary>
        /// preview invoice for the record chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreviewInvoice_Click(object sender, EventArgs e)
        {
            //if a record is chosen from the list
            if (IsSelected())
                PrintPreview(printPreviewDialog1, printDocument1);
        }
        /// <summary>
        /// generic method for printing a document
        /// </summary>
        /// <param name="pd">print dialog object</param>
        /// <param name="doc">printdocument object</param>
        private void Printing(PrintDialog pd, PrintDocument doc)
        {
            pd.Document = doc;

            if (pd.ShowDialog() == DialogResult.OK)
                doc.Print();
        }

        /// <summary>
        /// generic method for print preview
        /// </summary>
        /// <param name="ppd">printpreviewdialog object</param>
        /// <param name="doc">printdocument object</param>
        private void PrintPreview(PrintPreviewDialog ppd, PrintDocument doc)
        {
            ppd.Document = doc;
            ppd.ShowDialog();
        }
        /// <summary>
        /// print monthly sales report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            Printing(printDialogReport, printDocumentReport);
        }
        /// <summary>
        /// setup document to be printed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocumentReport_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);

            //get info for selected month and year
            string[] print = ShowSelectedSales(dtSalesRange.Value.Month, dtSalesRange.Value.Year, 1);

            //setup document layout
            int x = 20, y = 20;

            g.DrawString("Sales Report for " + dtSalesRange.Value.Month.ToString() + "/" + dtSalesRange.Value.Year, new Font("Cambria", 14), brush, x, 40);
            y += 50;

            foreach (string line in print)
            {

                g.DrawString(line, new Font("Cambria", 12), brush, x, y);
                y += 20;
            }
            string total = "Total:\t\t" + totalSales.ToString();
            g.DrawString("\n" + total, new Font("Cambria", 14), brush, x, (y + 17));

        }
        /// <summary>
        /// preview monthly report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreviewReport_Click(object sender, EventArgs e)
        {
            PrintPreview(printPreviewDialogReport, printDocumentReport);
        }
        /// <summary>
        /// setup document to be printed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocumentReportYear_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush brush = new SolidBrush(Color.Black);

            //get inforamtion for selected year
            string[] print = ShowSelectedSales(0, dtSalesYear.Value.Year, 1);

            //set document layout
            int x = 20, y = 20;

            g.DrawString("Sales Report for the year " + dtSalesYear.Value.Year, new Font("Cambria", 14), brush, x, 40);
            y += 50;

            foreach (string line in print)
            {

                g.DrawString(line, new Font("Cambria", 12), brush, x, y);
                y += 20;
            }
            string total = "Total:\t\t" + totalSales.ToString();
            g.DrawString("\n" + total, new Font("Cambria", 14), brush, x, (y + 17));

        }
        /// <summary>
        /// preview yearly report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPreviewYearlyReport_Click(object sender, EventArgs e)
        {
            PrintPreview(printPreviewDialogReportYear, printDocumentReportYear);
        }
        /// <summary>
        /// print yearly report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrintYearlyReport_Click(object sender, EventArgs e)
        {
            Printing(printDialogReportYear, printDocumentReportYear);
        }
//_______________________menu events
        
        /// <summary>
        /// exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this application?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }
        /// <summary>
        /// print invoice from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void invoiceToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //make sure the record is selected
            if (IsSelected())
                Printing(printDialog1, printDocument1);
        
        }
        /// <summary>
        /// print monthly report from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesReportForSelectedMonthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Printing(printDialogReport, printDocumentReport);
        }
        /// <summary>
        /// print yearly report from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesReportForSelectedYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Printing(printDialogReportYear, printDocumentReportYear);
        }
        /// <summary>
        /// restore records to unsorted state from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void restoreRecordsToOriginalOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateList();
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// sort records by country from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void countryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("country");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// sort records by email from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("email");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// sort records by name from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fullNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("name");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// sort records by payment date from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void paymentDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("date");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// sort records by price from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void priceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSortedRecords("price");
            CheckRefreshButtonVisibility();
        }
        /// <summary>
        /// show about box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBoxApp about = new AboutBoxApp();
            about.Show();
        }
        /// <summary>
        /// preview invoice from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void invoiceToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            //if a record is chosen from the list
            if (IsSelected())
                PrintPreview(printPreviewDialog1, printDocument1);
        
        }
        /// <summary>
        /// preview montly report from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesReportForSelectedMonthToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PrintPreview(printPreviewDialogReport, printDocumentReport);
        }
        /// <summary>
        /// preview yearly report from menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void salesReportForSelectedTearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreview(printPreviewDialogReportYear, printDocumentReportYear);
        }

    }
}
