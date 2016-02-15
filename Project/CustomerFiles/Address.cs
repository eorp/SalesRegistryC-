//Address.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.CustomerFiles
{
    public class Address
    {
        //city of address
        private string m_city;
        //street of the address
        private string m_street;
        //zip code of the address
        private string m_zipCode;
        //the string will contain an error message for missing fields
        private string m_strErrMsg;
        //country of the address
        private Countries m_country;
        //address state
        private string m_state;
      

        //Constructors are overloaded and called in a chain

        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        /// <remarks></remarks>
        public Address()
            : this("Cork", "Main Street", String.Empty)
        {

        }

        /// <summary>
        /// Constructor with three parameters - calls the constructor with 
        /// four parameters, using a default value as the last argument.
        /// </summary>
        /// <param name="city">input - city</param>
        /// <param name="street">input - street</param>
        /// <param name="zip">input - zip code</param>
        public Address(string city, string street, string state)
            : this(city, street, state, String.Empty)
        {
        }

        /// <summary>
        /// Constructor with 4 parameters - calls the constructor with 
        /// 5 parameters, using a default value as the last argument.
        /// </summary>
        /// <param name="city">input - city</param>
        /// <param name="street">input - street</param>
        /// <param name="state">input - state</param>
        /// <param name="zip">input - zip code</param>
        public Address(string city, string street, string state, string zip)
            : this(city, street, state, zip, Countries.Ireland)
        {
        }
        /// <summary>
        /// Constructor with 5 parameters. This is  constructor that has most
        /// number of parameters. It is in tis constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="city">input - city</param>
        /// <param name="street">input - street</param>
        /// <param name="state">input - state</param>
        /// <param name="zip">input - zip code</param>
        /// <param name="country">input - country</param>
        public Address(string city, string street, string state, string zip, Countries country)
        {
            m_city = city;
            m_street = street;
            m_state = state;
            m_zipCode = zip;
            m_country = country;
        }

        /// <summary>
        /// Copy constructor: Use this when you are copying
        /// from one object to another object of this class
        /// </summary>
        /// <param name="other"></param>
        public Address(Address other)
        {
            this.m_street = other.m_street;
            this.m_state = other.m_state;
            this.m_zipCode = other.m_zipCode;
            this.m_city = other.m_city;
        }

      


        /// <summary>
        /// Property related to the field m_city
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string City
        {
            //get city name
            get { return m_city; }

            set { m_city = value; }
        }


        /// <summary>
        /// Property related to m_country field
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public Countries Country
        {
            //get country name
            get { return m_country; }

            set { m_country = value; }
        }

        /// <summary>
        /// Property related to the field m_street
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Street
        {
            //get street name
            get { return m_street; }

            set { m_street = value; }
        }

        /// <summary>
        /// Property related to the field m_state
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string State
        {
            //get state name
            get { return m_state; }

            set { m_state = value; }
        }

        /// <summary>
        /// Property related to the field m_strErrMsg
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string ErrorMessage
        {
            //get error message
            get { return m_strErrMsg; }

            set { m_strErrMsg = value; }
        }

        /// <summary>
        /// Property related to the field m_zipCode
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string ZipCode
        {
            //get zip value
            get { return m_zipCode; }

            set { m_zipCode = value; }
        }

        /// <summary>
        /// Delivers a formatted string with data stored in the object. The values will
        /// appear as columns.  
        /// </summary>
        /// <returns>the Formatted strings.</returns>
        /// <remarks></remarks>
        public override string ToString()
        {
            string strOut = string.Format("{0,-14}",GetCountryString());
            strOut = strOut.ToUpper();
            return strOut;
        }

        /// <summary>
        /// checks that required address fields (street and city)
        /// are entered
        /// </summary>
        /// <returns>true if required fields are provided and false+error message otherwise</returns>
        public bool CheckData()
        {
            if (!String.IsNullOrEmpty(m_city) && !String.IsNullOrEmpty(m_street))
                return true;
            else
            {
                m_strErrMsg = "Street and city are required fields";
            }
            return false;
        }

        /// <summary>
        /// replace underscores in country's name by spaces
        /// </summary>
        /// <returns>the country name without underscore</returns>
        public string GetCountryString()
        {
            string countryStr = m_country.ToString();
            countryStr = countryStr.Replace("_", " ");

            return countryStr;
        }


    }
}
