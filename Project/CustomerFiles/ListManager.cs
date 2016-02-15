//ListManager.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace Project.CustomerFiles
{
    
    /// <summary>
    /// this class implements IListManager interface
    /// and provides implementation for methods in that interface
    /// </summary>
    /// <typeparam name="T">generic object type</typeparam>
    public class ListManager<T>: IListManager<T>
    {
        //list of objects
        private List<T> m_list;

        public ListManager()
        {
            //create new list of objects
            m_list = new List<T>();
        }

        /// <summary>
        /// read-only access to the number of records in the animal list
        /// </summary>
        public int Count
        {
            get { return m_list.Count; }
        }
        /// <summary>
        /// add object to the list - implementation
        /// </summary>
        /// <param name="obj">object</param>
        public void Add(T obj)
        {
            //if object is not empty
            if (obj != null)
                //add object to the list
                m_list.Add(obj);
        }
        /// <summary>
        /// A collection should not be able to be indexed out of bounds.
        /// This method can be used from different places to ensure 
        /// correct indexing.
        /// </summary>
        /// <param name="index">index to be checked</param>
        /// <returns>true if within bounds, false otherwise</returns>
        public bool CheckIndex(int index)
        {
            return ((index >= 0) && (index < m_list.Count));
        }
        /// <summary>
        /// remove element at given position from the collection
        /// </summary>
        /// <param name="anIndex">position to remove element at</param>
        public void DeleteAt(int index)
        {
            //if index is within range
            if (CheckIndex(index))
                //remove object from that position
                m_list.RemoveAt(index);
        }

        /// <summary>
        /// clear all elements from the list
        /// </summary>
        public void DeleteAll()
        {
            //if list has at least one element
            if (m_list.Count > 0)
                //clear the list
                m_list.Clear();
        }

        /// <summary>
        /// return object from defined postion
        /// </summary>
        /// <param name="index">position in the list</param>
        /// <returns>selected object in the list</returns>
        public T GetAt(int index)
        {
            //if postion is within range
            if (CheckIndex(index))
                //return object from that position
                return m_list[index];
            return default(T);
        }

        /// <summary>
        /// to change an element in the list at the postition specified
        /// </summary>
        /// <param name="obj">new object data</param>
        /// <param name="index">selected position in the list</param>
        public void ChangeAt(T obj, int index)
        {
            //if postion is within range
            if (CheckIndex(index))
                //replace element with new object data
                m_list[index] = obj;
           
        }

        /// <summary>
        /// prepare and return an array of strings
        /// containing information about objects in collection
        /// </summary>
        /// <returns>array of strings</returns>
        public string[] ToStringArray()
        {
            //create a new array of strings
            string[] objectStr = new string[m_list.Count];
            int i = 0;

            //go through each record in the list and add each record as a string to array of strings
            foreach (T obj in m_list)
                objectStr[i++] = obj.ToString();

            return objectStr;
        }

        /// <summary>
        /// prepare and return a collection of List<string> type
        /// containing information about objects in collection
        /// </summary>
        /// <returns>collection of List<string> type</returns>
        public List<string> ToStringList()
        {
            //create new list of strings
            List<string> objString = new List<string>();
            //set the number of elements
            objString.Capacity = m_list.Count;

            int i=0;
            //go through each record in the list and add each record as a string to list of strings
            foreach (string obj in objString)
                objString.Add(m_list[i++].ToString());
            return objString;
        }

        public List<T> ObjectList
        {
            get { return m_list; }
        }
        /// <summary>
        /// serialise data to binary file implementation
        /// </summary>
        /// <param name="fileName"></param>
        
        public void BinarySerialise(string fileName)
        {
            BinarySerialiserUtility.Serialize<List<T>>(m_list,fileName);
        }
        /// <summary>
        /// deserialise data from binary file
        /// </summary>
        /// <param name="fileName"></param>
                public void BinaryDeSerialise(string fileName)
        {
            m_list = BinarySerialiserUtility.Deserialize<List<T>>(fileName);
            
        }
        /// <summary>
        /// serialise data to xml file
        /// </summary>
        /// <param name="fileName"></param>
        
        public void XMLSerialise(string fileName)
        {
            XMLSerialiserUtility.SerializeToFile<List<T>>(fileName, m_list);
            
        }

    
        /// <summary>
        /// /deserialise data from xml file
        /// </summary>
        /// <param name="fileName"></param>
        
        public void XMLDeSerialise(string fileName)
        {
            m_list = XMLSerialiserUtility.DeserializeFromFile<List<T>>(fileName);
            Console.WriteLine(m_list.ToString());
          
        }
    }
}
