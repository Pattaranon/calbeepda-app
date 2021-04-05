using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Calbee.WMS.Services.Count
{
    public static class CountLocationServiceProxy
    {
        public static int _UserID = 0;
        private static string _IPAddress = Calbee.Infra.Common.Constants.IConstants.ipAddress;
        public static string FILE_CONFIG_PATH = new Uri(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "/config.txt").LocalPath;

        private static Calbee.WMS.Services.CountLocationService.CountLocationService _WS = new Calbee.WMS.Services.CountLocationService.CountLocationService();

        public static string IPAddress
        {
            get { return _IPAddress; }
            set { _IPAddress = value; }
        }
        public static Calbee.WMS.Services.CountLocationService.CountLocationService WS
        {
            get
            {
                _WS.Url = "http://" + _IPAddress + "/CountLocationService.svc";
                _WS.Timeout = Calbee.Infra.Common.Constants.IConstants.timeOut;
                return _WS;
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
