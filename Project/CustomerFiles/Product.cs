//Product.cs
//Created by Evgeniya O'Regan Pevchikh, 5/1/2013
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.CustomerFiles
{
    public class Product
    {
        //product name
        string m_name;
        //product price
        double m_price;
        //payment date
        Date paymentDate;
        //expiry date
        Date expiryDate;
        //is product renewed
        string m_renewed;
        //domain names
        string m_domains;

        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Product()
            : this(String.Empty, 0.0, new Date(), new Date(), String.Empty, String.Empty)
        {
        }

        /// <summary>
        /// Constructor with 6 parameters. This is  constructor that has most
        /// number of parameters. It is in this constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="payment"></param>
        /// <param name="expiry"></param>
        /// <param name="renewed"></param>
        /// <param name="domains"></param>
        public Product(string name, double price, Date payment, Date expiry, string renewed, string domains)
        {
            m_name = name;
            m_price = price;
            paymentDate = payment;
            expiryDate = expiry;
            m_renewed = renewed;
            m_domains = domains;
        }

        /// <summary>
        /// read and write access to product name
        /// </summary>
        public string ProductName
        {
            get { return m_name; }
            set { m_name = value; }
        }

        /// <summary>
        /// read and write access to product price
        /// </summary>
        public double ProductPrice
        {
            get { return m_price; }
            set { m_price = value; }
        }

        /// <summary>
        /// read and write access to payment date value
        /// </summary>
        public Date PaymentDate
        {
            get { return paymentDate; }
            set { paymentDate = value; }
        }

        /// <summary>
        /// read and write access to expiry date value
        /// </summary>
        public Date ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        /// <summary>
        /// read and write access to renewed value
        /// </summary>
        public string ProductRenewed
        {
            get { return m_renewed; }
            set { m_renewed = value; }
        }

        /// <summary>
        /// read and write access to domain names value
        /// </summary>
        public string DomainNames
        {
            get { return m_domains; }
            set { m_domains = value; }
        }

        /// <summary>
        /// returns a formatted string containing all the object's data
        /// </summary>
        /// <returns>formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, 5} {1, 16} {2,16} {3,3} {4,-20}", m_price, paymentDate.ToString(), expiryDate.ToString(), m_renewed, m_domains);

            return strOut;
        }
    }
}
