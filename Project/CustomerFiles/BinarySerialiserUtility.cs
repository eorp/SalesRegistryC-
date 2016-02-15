//BinarySerialiserUtility.cs
//Created by Evgeniya O'Regan Pevchikh, 8/1/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


namespace Project.CustomerFiles
{
    /// <summary>
    /// helper class to handle binary de/serialisation
    /// </summary>
    public class BinarySerialiserUtility
    {
        /// <summary>
        /// method to serialise any type of object 
        /// </summary>
        /// <param name="obj"> Object to be serialised</param>
        /// <param name="filePath">File path including the name of the file to be serialised.</param>
        public static void Serialize<T>(object obj, string filePath)
        {
            FileStream fileObj = null;
            try
            {
                //Steps in serializing an object
                fileObj = new FileStream(filePath, FileMode.Create);
                BinaryFormatter binFormatter = new BinaryFormatter();
                binFormatter.Serialize(fileObj, obj);
            }
            finally
            {
                if (fileObj != null)
                    fileObj.Close();
            }
        }


        /// <summary>
        /// Generic method for deserialising any type of object 
        /// </summary>
        /// <typeparam name="T"> Any object</typeparam>
        /// <param name="filepath">File path including the name of the file to be deserialised</param>
        /// <returns>deserialised object</returns>
        public static T Deserialize<T>(string filepath)
        {
            FileStream fileObj = null;
            object obj = null;
            try
            {
                if (!File.Exists(filepath))
                {
                    throw new FileNotFoundException("The file is not found. ", filepath);
                }

                fileObj = new FileStream(filepath, FileMode.Open);

                BinaryFormatter binFormatter = new BinaryFormatter();
                obj = binFormatter.Deserialize(fileObj);
            }
            finally
            {
                if (fileObj != null)
                {
                    fileObj.Close();

                }
            }
            return (T)obj;
        }

    }
}
