//Customer.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.CustomerFiles
{
     [Serializable]
    /// <summary>
    /// this class inherits from Person class
    /// </summary>
    public class Customer: Person
    {
        //customer ID
        private int m_id;
        //instance of product class
        private Product m_product;

        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Customer()
            : this(null, null, new Address(), null, new Product(), 0)
        {
        }

        /// <summary>
        /// Constructor with 6 parameters. This is  constructor that has most
        /// number of parameters. It is in this constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="fname">first name</param>
        /// <param name="lname">surname</param>
        /// <param name="addr">address data</param>
        /// <param name="email">email</param>
        /// <param name="product">product data</param>
        /// <param name="id">customer id</param>
        public Customer(string fname, string lname, Address addr, string email, Product product, int id)
            : base(fname, lname, addr, email)
        {
            m_id = id;
            m_product = product;
        }
        

        /// <summary>
        /// read and write access to customer id value
        /// </summary>
        public int CustomerId
        {
            get { return m_id; }
            set { m_id = value; }
        }

        /// <summary>
        /// read and write access to product data
        /// </summary>
        public Product ProductData
        {
            get { return m_product; }
            set { m_product = value; }
        }

        /// <summary>
        /// returns a formatted string containing all the object's data
        /// </summary>
        /// <returns>formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-4} {1, -40} {2, 30}", m_id, base.ToString(), m_product.ToString());

            return strOut;
        }
    }
}
