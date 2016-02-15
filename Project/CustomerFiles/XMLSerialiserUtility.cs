//XMLSerialiserUtility.cs
//Created by Evgeniya O'Regan Pevchikh, 7/1/2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace Project.CustomerFiles
{
    /// <summary>
    /// helper class to handle xml de/serialsation
    /// </summary>
    public class XMLSerialiserUtility
    {
        /// <summary>
        /// method to serialise any type of object to xml 
        /// </summary>
        /// <typeparam name="T">type of object</typeparam>
        /// <param name="filePath">File path including the name of the file to be serialised</param>
        /// <param name="obj">Object containing data to be serialized</param>
        /// <returns></returns>
        public static void SerializeToFile<T>(string filePath, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            TextWriter writer = new StreamWriter(filePath);
            try
            {
                serializer.Serialize(writer, obj);
            }
            finally
            {
                if (writer != null)

                    writer.Close();
            }
        }
        /// <summary>
        /// Deserialise any xml file serialised  using the above method
        /// </summary>
        /// <typeparam name="T">type of object</typeparam>
        /// <param name="filePath">xml file to be deserialised</param>
        /// <returns>The object containing data read from the xml file</returns>
        public static T DeserializeFromFile<T>(string filePath)
        {
          
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            object obj = null;
            
            TextReader reader = null;

            try
            {
                reader = new StreamReader(filePath);
                obj = (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }
            return (T)obj;
        }

    }
}
