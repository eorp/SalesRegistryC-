//IListManager.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CustomerFiles
{
    /// <summary>
    /// a generic interface to be implemented by manager classes
    /// contaning a collection of type List<T> where T can be any object type
    /// </summary>
    /// <typeparam name="T">object type</typeparam>
    public interface IListManager<T>
    {
        //number of items in the colection list
        int Count { get; }

        /// <summary>
        /// adds an element to a collection list
        /// </summary>
        /// <param name="aType">element type</param>
        void Add(T aType);

        /// <summary>
        /// remove element at given position from the collection
        /// </summary>
        /// <param name="anIndex">position to remove element at</param>
        void DeleteAt(int anIndex);

        /// <summary>
        /// remove all elements from a collection
        /// </summary>
        void DeleteAll();
        /// <summary>
        /// A collection should not be able to be indexed out of bounds.
        /// This method can be used from different places to ensure 
        /// correct indexing.
        /// </summary>
        /// <param name="index">index to be checked</param>
        /// <returns>true if within bounds, false otherwise</returns>
        bool CheckIndex(int anIndex);

        /// <summary>
        /// get one element object from the list and return that object
        /// </summary>
        /// <param name="index">position in the list</param>
        /// <returns>object at specified position</returns>
        T GetAt(int anIndex);

        /// <summary>
        /// to change an element in the list at the postition specified
        /// </summary>
        /// <param name="aType">new object data</param>
        /// <param name="anIndex">position in the list</param>
        void ChangeAt(T aType, int anIndex);
 
        /// <summary>
        /// prepare and return an array of strings
        /// containing information about objects in collection
        /// </summary>
        /// <returns>array of strings</returns>
        string[] ToStringArray();

        /// <summary>
        /// prepare and return a collection of List<string> type
        /// containing information about objects in collection
        /// </summary>
        /// <returns>collection of List<string> type</returns>
        List<string> ToStringList();

        /// <summary>
        /// binary serialisation of object to file
        /// </summary>
        /// <param name="fileName">file name</param>
        void BinarySerialise(string fileName);
        /// <summary>
        /// deserialise binary data from file
        /// </summary>
        /// <param name="fileName"></param>
        void BinaryDeSerialise(string fileName);

        /// <summary>
        /// serialise xml data to file
        /// </summary>
        /// <param name="fileName"></param>
        void XMLSerialise(string fileName);

        /// <summary>
        /// deserialise data from xml file
        /// </summary>
        /// <param name="fileName"></param>
        void XMLDeSerialise(string fileName);
    }
}
