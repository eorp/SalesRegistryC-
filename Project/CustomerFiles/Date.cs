//Date.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.CustomerFiles
{
    public class Date
    {
        //day
        private int m_day;
        //month
        private int m_month;
        //year
        private int m_year;

        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        public Date()
            : this(0, 0, 0)
        {
        }

        /// <summary>
        /// Constructor with 3 parameters. This is  constructor that has most
        /// number of parameters. It is in tis constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="day"></param>
        /// <param name="month"></param>
        /// <param name="year"></param>
        public Date(int day, int month, int year)
        {
            m_day = day;
            m_month = month;
            m_year = year;
        }

        /// <summary>
        /// Property related to the field m_day
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Day
        {
            get { return m_day; }
            set { m_day = value; }
        }

        /// <summary>
        /// Property related to the field m_month
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Month
        {
            get { return m_month; }
            set { m_month = value; }
        }

        /// <summary>
        /// Property related to the field m_year
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public int Year
        {
            get { return m_year; }
            set { m_year = value; }
        }

        /// <summary>
        /// Delivers a formatted string with data stored in the object. The values will
        /// appear as columns.  
        /// </summary>
        /// <returns>the Formatted strings.</returns>
        /// <remarks></remarks>
        public override string ToString()
        {
            string strOut = string.Format("{0,3} {1, 9} {2, 4}", 
                m_day,GetMonth(m_month),m_year);
           // strOut = strOut.ToUpper();
            return strOut;
        }

        /// <summary>
        /// convert month number into text
        /// </summary>
        /// <param name="month">month in numeric form</param>
        /// <returns>month in text form</returns>
        private string GetMonth(int month)
        {
            string monthString = String.Empty;
            switch (month)
            {
                case 1: monthString = "January"; break;
                case 2: monthString = "February"; break;
                case 3: monthString = "March"; break;
                case 4: monthString = "April"; break;
                case 5: monthString = "May"; break;
                case 6: monthString = "June"; break;
                case 7: monthString = "July"; break;
                case 8: monthString = "August"; break;
                case 9: monthString = "September"; break;
                case 10: monthString = "October"; break;
                case 11: monthString = "November"; break;
                case 12: monthString = "December"; break;
            }

            return monthString;
        }

    }
}
