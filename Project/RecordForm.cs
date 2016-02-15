//RecordForm.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Project.CustomerFiles;

namespace Project
{
    public partial class RecordForm : Form
    {
        //instance of customer class
        private Customer cust = new Customer();
        //variable to handle closing the form
        private bool m_closeForm;
       

        public RecordForm()
        {
            InitializeComponent();
            InitialiseGUI();
        }

        /// <summary>
        /// initialise components with data
        /// </summary>
        private void InitialiseGUI()
        {
            txtFirstName.Focus();
            //fill in countries list
            FillCountryComboBox();
            //fill in product names list
            FillProductNameComboBox();
            //set initial product price
            txtPrice.Text = "2.99";
            //disable editing of price field (will be assigned automatically depending on chosen product)
            txtPrice.Enabled = false;
            //fill in renewed combobox with data
            FillRenewedComboBox();
            //set expiry date to be a year ahead of payment date
            SetExpiry();

            m_closeForm = true;
        }

        /// <summary>
        /// replacing underscores in countries' names with a blank space
        /// and adding countries list to the combobox
        /// </summary>
        private void FillCountryComboBox()
        {
            string[] countryString = Enum.GetNames(typeof(Countries));
            for (int i = 0; i < countryString.Length - 1; i++)
                countryString[i] = countryString[i].Replace("_", " ");

            cmbCountry.Items.Clear();
            cmbCountry.Items.AddRange(countryString);
            //default country selected in the combobox
            cmbCountry.SelectedIndex = (int)Countries.Ireland;
        }

        /// <summary>
        /// replacing underscores in countries' names with a blank space
        /// and adding countries list to the combobox
        /// </summary>
        private void FillProductNameComboBox()
        {
            string[] productString = Enum.GetNames(typeof(ProductNames));
            for (int i = 0; i < productString.Length; i++)
                productString[i] = productString[i].Replace("_", " ");


            cmbProductName.Items.Clear();
            cmbProductName.Items.AddRange(productString);
            //default country selected in the combobox
            cmbProductName.SelectedIndex = (int)ProductNames._only_one_domain;
        }

        /// <summary>
        /// data to fill renewed combobox
        /// </summary>
        private void FillRenewedComboBox()
        {
            cmbRenewed.Items.Clear();

            cmbRenewed.Items.Add("yes");
            cmbRenewed.Items.Add("no");
            //set selected value to no
            cmbRenewed.SelectedIndex = 1;
        }

        /// <summary>
        /// handle adding new record or editing existing one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if all required fields are filled
            if(!ReadInput())
            {//the form can be closed
                m_closeForm = false;
            }
                //otherwise the form will not close so corrections can be made
            else
                m_closeForm = true;
           // MessageBox.Show(cust.ToString(), "", MessageBoxButtons.OK);
            
        }

        /// <summary>
        /// set product price according to product chosen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbProductName.SelectedIndex)
            {
                case 0: txtPrice.Text = "2.99"; break;
                case 1: txtPrice.Text = "9.99"; break;
                case 2: txtPrice.Text = "15.99"; break;
                case 3: txtPrice.Text = "24.99"; break;
            }
        }

        /// <summary>
        /// change expiry date when payment date is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtPayment_ValueChanged(object sender, EventArgs e)
        {
            SetExpiry();
        }

        /// <summary>
        /// set expiry date to be one year ahead from payment date
        /// </summary>
        private void SetExpiry()
        {
            //get payment date value
            DateTime payment = dtPayment.Value;
            //add one year to it
            payment = payment.AddYears(1);
            //assign this date to expiry date
            dtExpiry.Value = payment;
        }

        /// <summary>
        /// read and write access to customer data
        /// </summary>
        public Customer CustomerData
        {
            get { return cust; }
            
            set 
            { 
                if(cust!=null)
                {
                cust = value;
                //assign values to the fields for editing
                UpdateGUI();}
            }
        }

        
        /// <summary>
        /// assign values from selected record to the form's fields
        /// for editing
        /// </summary>
        private void UpdateGUI()
        {
            txtFirstName.Text = cust.FirstName;
            txtSurname.Text = cust.Surname;

            txtEmail.Text = cust.Email;

            txtCity.Text = cust.AddressData.City;
            txtStreet.Text = cust.AddressData.Street;
            txtState.Text = cust.AddressData.State;
            txtZip.Text = cust.AddressData.ZipCode;
            cmbCountry.SelectedIndex = (int)cust.AddressData.Country;

            cmbProductName.SelectedItem = cust.ProductData.ProductName;
            txtPrice.Text = cust.ProductData.ProductPrice.ToString();

            dtPayment.Value = new DateTime(cust.ProductData.PaymentDate.Year,cust.ProductData.PaymentDate.Month, cust.ProductData.PaymentDate.Day);
            dtExpiry.Value = new DateTime(cust.ProductData.ExpiryDate.Year,cust.ProductData.ExpiryDate.Month, cust.ProductData.ExpiryDate.Day);

            cmbRenewed.SelectedValue = cust.ProductData.ProductRenewed;
            txtDomains.Text = cust.ProductData.DomainNames;

        }

        /// <summary>
        /// create address object with data provided
        /// </summary>
        /// <returns>address object</returns>
        private Address ReadAddress()
        {
            Address addr = new Address(txtCity.Text, txtStreet.Text, txtState.Text,txtZip.Text,(Countries)cmbCountry.SelectedIndex);
            return addr;
        }

        /// <summary>
        /// create person object with data provided
        /// </summary>
        /// <returns>person object</returns>
        private Person ReadPerson()
        {
            Person person = new Person(txtFirstName.Text,txtSurname.Text,ReadAddress(),txtEmail.Text);
            return person;
        }

        /// <summary>
        /// create date object with data provided
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>
        private Date ReadDate(int day, int month, int year)
        {
            Date date = new Date(day,month,year);
            return date;
        }

        /// <summary>
        /// create product object with data provided
        /// </summary>
        /// <returns></returns>
        private Product ReadProduct()
        {
            
            Product product = new Product(cmbProductName.SelectedItem.ToString(), double.Parse(txtPrice.Text),ReadDate(dtPayment.Value.Day,dtPayment.Value.Month,dtPayment.Value.Year),ReadDate(dtExpiry.Value.Day,dtExpiry.Value.Month,dtExpiry.Value.Year),cmbRenewed.SelectedItem.ToString(),txtDomains.Text );
            return product;
        }

        /// <summary>
        /// check if all required fields are filled
        /// </summary>
        /// <returns>true or false depending on the result</returns>
        private bool ReadInput()
        {
            Product product = ReadProduct();
            Address addr = ReadAddress();
            //create new customer object with data provided
            cust = new Customer(txtFirstName.Text, txtSurname.Text, addr, txtEmail.Text, product,1);
        
      
            return ReadAndValidateName()&& ReadAndValidateEmail();
        }

        /// <summary>
        /// handle cancelling adding and editing the record
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if user confirms their wish to cancel the action
            if (MessageBox.Show("Are you sure you want to cancel this action?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //close the form
                m_closeForm = true;
                this.Close();
            }
            else
                m_closeForm = false;
            
        }

     
        /// <summary>
        /// make sure that full name is entered
        /// </summary>
        /// <returns>true if the name is filled in, flase otherwise</returns>
        private bool ReadAndValidateName()
        {
            string fName = txtFirstName.Text;
            string lName = txtSurname.Text;

            if (InputUtility.IsInValidString(fName))
            {
                MessageBox.Show("Invalid input in the first name field!\nPlease enter a valid name (at least one character is required)", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //put focus on requred field
                txtFirstName.Focus();
                txtFirstName.Text = " ";
                txtFirstName.SelectAll();
            }
            else if (InputUtility.IsInValidString(lName))
            {
                MessageBox.Show("Invalid input in the last name field!\nPlease enter a valid name (at least one character is required)", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //put focus on requred field
                txtSurname.Focus();
                txtSurname.Text = " ";
                txtSurname.SelectAll();
            }
            else
                return true;

            return false;

        }

        /// <summary>
        /// ensure that a proper email address is entered
        /// </summary>
        /// <returns></returns>
        private bool ReadAndValidateEmail()
        {
            string email = txtEmail.Text;

            if (!InputUtility.IsValidEmail(email))
            {
                MessageBox.Show("Invalid email address!", "Invalid Input!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.Text = " ";
                txtEmail.SelectAll();

            }
            else
                return true;

            return false;

        }
        /// <summary>
        /// handles form closing event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_closeForm)
                e.Cancel = false;       //close the form
            else
                e.Cancel = true;        //leave the form open
        }

        
    }
}
