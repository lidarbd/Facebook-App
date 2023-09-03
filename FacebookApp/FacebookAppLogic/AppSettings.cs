using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookAppLogic
{
    public class AppSettings
    {
        private string m_LastAccessToken;
        private bool m_RememberUser;

        public AppSettings()
        {
            m_LastAccessToken = null;
            m_RememberUser = false;
        }

        public bool RememberUser
        {
            get { return m_RememberUser; }
            set { m_RememberUser = value; }
        }

        public string LastAccessToken
        {
            get { return m_LastAccessToken; }
            set { m_LastAccessToken = value; }
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings obj = new AppSettings();

            if (File.Exists(@"AppSettingsFile.xml"))
            {
                using (Stream stream = new FileStream(@"AppSettingsFile.xml", FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    obj = serializer.Deserialize(stream) as AppSettings;
                }
            }

            return obj;
        }

        public bool CheckIfRememberUser()
        {
            return m_RememberUser && !string.IsNullOrEmpty(m_LastAccessToken);
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(@"AppSettingsFile.xml", File.Exists("AppSettingsFile.xml") ? FileMode.Truncate : FileMode.CreateNew))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
