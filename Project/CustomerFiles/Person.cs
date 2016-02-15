//Person.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.CustomerFiles
{
    public class Person
    {
        //first name
        private string m_firstName;
        //surname
        private string m_surname;
        //instance of address class
        private Address m_address;
        //email
        private string m_email;

        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Person()
            : this(String.Empty, String.Empty, new Address(), String.Empty)
        {
        }
        /// <summary>
        /// Constructor with 4 parameters. This is  constructor that has most
        /// number of parameters. It is in this constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="fname">first name</param>
        /// <param name="lname">surname</param>
        /// <param name="addr">address</param>
        /// <param name="email">email</param>
        public Person(string fname,string lname, Address addr, string email)
        {
            m_firstName = fname;
            m_surname = lname;
            m_address = addr;
            m_email = email;
        }
        /// <summary>
        /// Property related to the field m_firstName
        /// Both read and write access
        /// </summary>
        public string FirstName
        {
            get { return m_firstName; }
            set
            {
                m_firstName = value;
            }
        }

        /// <summary>
        /// Property related to the field m_surname
        /// Both read and write access
        /// </summary>
        public string Surname
        {
            get { return m_surname; }

            set { m_surname = value; }
        }

        /// <summary>
        /// read-only access to a string containing 
        /// first and last name
        /// </summary>
        public string FullName
        {
            get { return (m_firstName + " " + m_surname).ToUpper(); }

        }


        /// <summary>
        /// Property related to the field m_email
        /// Both read and write access
        /// </summary>
        public string Email
        {
            get { return m_email; }
            set { m_email = value; }

        }

        /// <summary>
        /// Property related to the field m_address
        /// Both read and write access
        /// </summary>
        public Address AddressData
        {
            get { return m_address; }
            set { m_address = value; }
        }

        /// <summary>
        /// returns a formatted string containing all the object's data
        /// </summary>
        /// <returns>formatted string</returns>
        public override string ToString()
        {
            string strOut = string.Format("{0,-20} {1, 1} {2, -30}", FullName, m_address.ToString(), m_email.ToString());
            
            return strOut;
        }

    }
}
