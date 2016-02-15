//CustomerManager.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.CustomerFiles;
using System.Xml.Serialization;
using System.IO;

namespace Project
{
    public class CustomerManager: ListManager<Customer>
    {
        
         

        public CustomerManager()
        {
        }

        /// <summary>
        /// get sorted records from customer list in array of strings
        /// </summary>
        /// <returns>array of strings</returns>
        public string[] GetSortedCustomerInfo(List<Customer> sorted, int print)
        {
            //create a new array of strings
            string[] customerStr = new string[sorted.Count];

            int i = 0;

            //go through each record in the customer list and add each record as a string to array of strings
            foreach (Customer obj in sorted)
                //for displayng
                if (print == 0)
                    customerStr[i++] = obj.ToString();
                else
                    //for printing
                    customerStr[i++] = obj.ProductData.PaymentDate.ToString() + "\t\t" + obj.ProductData.ProductPrice;


            return customerStr;

        }
        
        /// <summary>
        /// read-only access to an id for each customer
        /// </summary>
        public int GetNewId
        {
            get { return Count + 150; }
        }
    }
}
