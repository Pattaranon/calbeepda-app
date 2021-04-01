using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Calbee.WMS.Services.ServiceMode
{
    public static class Mode
    {
        private static string _IPAddress = string.IsNullOrEmpty(ReadConfig()) ? Calbee.Infra.Common.Constants.IConstants.ipAddress : ReadConfig();
        public static string FILE_CONFIG_PATH = new Uri(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "/config.txt").LocalPath;
        public static string IPAddress
        {
            get { return _IPAddress; }
            set { _IPAddress = value; }
        }

        public static bool IsOnline()
        {
            try
            {
                DateTime OutputResult; 
                bool OutputSpacial;
                using (Calbee.WMS.Services.CoreService.CoreService wsTest = new Calbee.WMS.Services.CoreService.CoreService())
                {
                    wsTest.Url = "http://" + _IPAddress + "/coreservice.svc";
                    wsTest.GetCurrentDateTime(out OutputResult, out OutputSpacial);
                    if (OutputResult != null)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (System.Net.WebException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static string ReadConfig()
        {
            try
            {
                FILE_CONFIG_PATH = new Uri(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "/config.txt").LocalPath;
                if (!System.IO.File.Exists(FILE_CONFIG_PATH))
                {
                    SaveConfig(_IPAddress);
                }
                string result;
                System.IO.StreamReader sr = new StreamReader(FILE_CONFIG_PATH);
                result = sr.ReadToEnd();
                sr.Close();
                sr.Dispose();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void SaveConfig(string ip)
        {
            try
            {
                FILE_CONFIG_PATH = new Uri(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "/config.txt").LocalPath;
                System.IO.StreamWriter sw = new StreamWriter(FILE_CONFIG_PATH);
                sw.Write(ip);
                sw.Flush();
                sw.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}