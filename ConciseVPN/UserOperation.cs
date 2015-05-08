using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ConciseVPN
{
    /**
     *  用户信息操作
     */
    class UserOperation
    {
        public static List<string[]> ReadInfo(String fileName)
        {
            exists(fileName);
            List<string[]> userInfos = new List<string[]>();
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlElement rootElem = doc.DocumentElement;
            XmlNodeList personNodes = rootElem.GetElementsByTagName("user");
            foreach (XmlNode node in personNodes)
            {
               string userName = ((XmlElement)node).GetAttribute("name");
               string userPass = ((XmlElement)node).GetAttribute("password");
                userInfos.Add(new string[]{userName,userPass});
            }
            return userInfos;
        }

        private static void exists(String fileName)
        {
            if (!File.Exists(fileName))
            {
                string fileContent = 
                    "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n"+
                    "<root>\n" +
                     "\t<user name=\"admin\" password=\"admin\" />\n" +
                     "\t<user name=\"可以有多个user节点\" password=\"admin\" />\n" +
                    "</root>";
               // File.WriteAllText(@fileName,fileContent,Encoding.UTF8);
                StreamWriter writer = new StreamWriter(fileName,false);
                writer.Write(fileContent);
                writer.Close();
                
            }
        }
    }
}
