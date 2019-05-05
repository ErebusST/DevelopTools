using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CreateProject.Util
{
    class XMLUtil
    {
        private static String xmlPath = Application.StartupPath + @"\\setting.xml";
        private static String DataTypeXmlPath = Application.StartupPath + @"\\DataType.xml";
        public static String getValue(String key)
        {
            XmlReader reader = null;
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreComments = true;//忽略文档里面的注释
                CreateDefaultXml();
                reader = XmlReader.Create(xmlPath, settings);
                xmlDoc.Load(reader);
                XmlNode xn = xmlDoc.SelectSingleNode("Config");
                XmlNodeList nodes = xn.ChildNodes;
                String value = "";
                bool isExist = false;

                foreach (XmlNode node in nodes)
                {
                    String tempKey = node.Name;
                    if (key.Trim().Equals(tempKey.Trim()))
                    {
                        value = node.Attributes["value"].Value.ToString();
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    return "";
                }

                return value.Trim();
            }
            catch
            {
                return "";
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader = null;
                }
            }
        }

        private static void CreateDefaultXml()
        {
            StreamWriter writer = null;
            try
            {
                if (!File.Exists(xmlPath))
                {
                    StringBuilder xmlContent = new StringBuilder();
                    xmlContent.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
                    xmlContent.AppendLine("<Config>");
                    xmlContent.AppendLine("<DataBaseType value=\"MySql\" ></DataBaseType>");
                    xmlContent.AppendLine("<Host value=\"\" ></Host>");
                    xmlContent.AppendLine("<UserName value=\"admin\" ></UserName>");
                    xmlContent.AppendLine("<WorkType value=\"net\" ></WorkType>");
                    xmlContent.AppendLine("<Port  value=\"\" ></Port>");
                    xmlContent.AppendLine("<DBUserName value=\"\" ></DBUserName>");
                    xmlContent.AppendLine("<PassWord value=\"\" ></PassWord>");
                    xmlContent.AppendLine("<SelectedDataBase value=\"\" ></SelectedDataBase>");
                    xmlContent.AppendLine("<SelectTable value=\"\" ></SelectTable>");
                    xmlContent.AppendLine("</Config>");
                    writer = File.CreateText(xmlPath);
                    writer.Write(xmlContent.ToString());

                }
            }
            catch (Exception)
            {


            }
            finally
            {
                if (writer != null)
                {
                    writer.Close();
                }
            }
        }

        public static void setValue(String key, String value)
        {
            XmlReader reader = null;
            try
            {
                CreateDefaultXml();
                XmlDocument xmlDoc = new XmlDocument();
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreComments = true;//忽略文档里面的注释
                reader = XmlReader.Create(xmlPath, settings);
                xmlDoc.Load(reader);
                XmlNode xn = xmlDoc.SelectSingleNode("Config");
                XmlNodeList nodes = xn.ChildNodes;

                bool isExist = false;
                foreach (XmlNode node in nodes)
                {
                    String tempKey = node.Name;
                    if (key.Trim().Equals(tempKey.Trim()))
                    {
                        node.Attributes["value"].Value = value;

                        isExist = true;
                    }
                }
                if (!isExist)
                {
                    XmlNode newNode = xmlDoc.CreateElement(key);
                    XmlAttribute attr = xmlDoc.CreateAttribute("value");
                    attr.Value = value;
                    newNode.Attributes.Append(attr);
                    xn.AppendChild(newNode);
                }
                reader.Close();
                XmlTextWriter xw = new XmlTextWriter(xmlPath, Encoding.UTF8);
                xw.Formatting = System.Xml.Formatting.Indented;
                xmlDoc.WriteTo(xw);
                xw.Close();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader = null;
                }
            }
        }


        public static void innerText(String key, String value)
        {
            XmlReader reader = null;
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreComments = true;//忽略文档里面的注释
                reader = XmlReader.Create(xmlPath, settings);
                xmlDoc.Load(reader);
                XmlNode xn = xmlDoc.SelectSingleNode("Config");
                XmlNodeList nodes = xn.ChildNodes;

                bool isExist = false;
                foreach (XmlNode node in nodes)
                {
                    String tempKey = node.Name;
                    if (key.Trim().Equals(tempKey.Trim()))
                    {
                        node.InnerText = value;
                        isExist = true;
                    }
                }
                if (!isExist)
                {
                    XmlNode newNode = xmlDoc.CreateElement(key);
                    newNode.InnerText = value;
                    xn.AppendChild(newNode);
                }
                reader.Close();
                XmlTextWriter xw = new XmlTextWriter(xmlPath, Encoding.UTF8);
                xw.Formatting = System.Xml.Formatting.Indented;
                xmlDoc.WriteTo(xw);
                xw.Close();
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader = null;
                }
            }
        }

        public static String getInnerText(String key)
        {
            XmlReader reader = null;
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                XmlReaderSettings settings = new XmlReaderSettings();
                settings.IgnoreComments = true;//忽略文档里面的注释
                reader = XmlReader.Create(xmlPath, settings);
                xmlDoc.Load(reader);
                XmlNode xn = xmlDoc.SelectSingleNode("Config");
                XmlNodeList nodes = xn.ChildNodes;
                String value = "";
                bool isExist = false;
                foreach (XmlNode node in nodes)
                {
                    String tempKey = node.Name;
                    if (key.Trim().Equals(tempKey.Trim()))
                    {
                        value = node.InnerText;
                        isExist = true;
                        break;
                    }
                }
                if (!isExist)
                {
                    value = "";
                }

                return value;
            }
            catch
            {
                return "";
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                    reader = null;
                }
            }
        }

        public static DataTable getDataTypeDT()
        {
            try
            {
                if (File.Exists(DataTypeXmlPath))
                {
                    DataTable dataTypeDT = new DataTable();
                    dataTypeDT.TableName = "DataType";
                    dataTypeDT.Columns.Add("CodeDataType", typeof(String));
                    dataTypeDT.Columns.Add("SqlDataType", typeof(String));
                    dataTypeDT.ReadXml(DataTypeXmlPath);
                    return dataTypeDT;
                }
                else
                {
                    throw new Exception("未找到数据类型配置文件 [" + DataTypeXmlPath + "]");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
