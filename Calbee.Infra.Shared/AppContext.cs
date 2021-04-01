using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Calbee.WMS.Entities.Users;
using Microsoft.Win32;
using System.IO;

namespace Calbee.Infra.Shared
{
    public class AppContext : IDisposable
    {
        System.Globalization.CultureInfo _cultureEnInfo = new System.Globalization.CultureInfo("en-US");
        private static string _IPAddress = Calbee.Infra.Common.Constants.IConstants.ipAddress;
        public static string FILE_CONFIG_PATH = new Uri(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase) + "/config.txt").LocalPath;

        public static string IPAddress
        {
            get { return _IPAddress; }
            set { _IPAddress = value; }
        }
        private User currentUser = null;
        public User CurrentUser
        {
            get { return currentUser; }
        }

        private static AppContext instance = new AppContext();
        public static AppContext Instance
        {
            get { return instance; }
        }

        public bool DoLogin(string userName, string passWord, ref string message)
        {
            try
            {
                bool result = false;
                var authorizeResult = Calbee.WMS.Services.Authorization.AuthorizeServiceProxy.WS.Authorize(userName, passWord);
                if (authorizeResult != null)
                {
                    this.currentUser = new User();
                    this.currentUser.UserId = authorizeResult.UserId;
                    Calbee.Infra.Common.Constants.WConstants.userId = authorizeResult.UserId;
                    this.currentUser.UserGroupId = authorizeResult.UserGroupId;
                    this.currentUser.EmployeeId = authorizeResult.EmployeeId;
                    this.currentUser.UserName = authorizeResult.UserName;
                    this.currentUser.FirstName = authorizeResult.FirstName;
                    this.currentUser.LastName = authorizeResult.LastName;
                    this.currentUser.Description = authorizeResult.Description;

                    result = true;
                }
                else
                {
                    // Handle error exception.
                    result = false;
                }

                return result;
            }
            catch (System.Net.WebException exWeb)
            {
                message = "Can not connect to server" + "\nError From System : " + exWeb.Message;
                return false;
            }
            catch (Exception ex)
            {
                message = "System error : " + ex.Message;
                return false;
            }
        }
        public bool DoValidateServiceName(string ipServiceName, ref string message)
        {
            try
            {
                bool result = false;
                string[] arrayIPServiceName = ipServiceName.Split('/');
                if (arrayIPServiceName.Length != 2)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }

                return result;
            }
            catch (System.Net.WebException exWeb)
            {
                message = "Can not connect to server" + "\nError From System : " + exWeb.Message;
                return false;
            }
            catch (Exception ex)
            {
                message = "System error : " + ex.Message;
                return false;
            }
        }
        public List<Calbee.WMS.Services.MasterService.ItemUom> UOMDDLBinding(string itemNumber)
        {
            try
            {
                List<Calbee.WMS.Services.MasterService.ItemUom> _listUOM = new List<Calbee.WMS.Services.MasterService.ItemUom>();
                Calbee.WMS.Services.MasterService.ItemUom _master;
                _listUOM = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetItemUoms(itemNumber, string.Empty).ToList();
                if (_listUOM != null)
                {
                    _master = new Calbee.WMS.Services.MasterService.ItemUom();
                    _master.Uom = Calbee.Infra.Common.Constants.WConstants.defaultDropdownSelect;
                    _listUOM.Insert(0, _master);
                }
                else
                {
                    _listUOM = null;
                }

                return _listUOM;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Calbee.WMS.Services.MasterService.ItemUom> UOMDDLDefault(string itemNumber)
        {
            try
            {
                List<Calbee.WMS.Services.MasterService.ItemUom> _listUOM = new List<Calbee.WMS.Services.MasterService.ItemUom>();
                Calbee.WMS.Services.MasterService.ItemUom _master;
                _listUOM = Calbee.WMS.Services.Masters.MasterServiceProxy.WS.GetItemUoms(itemNumber, string.Empty).ToList();
                if (_listUOM != null)
                {
                    _master = new Calbee.WMS.Services.MasterService.ItemUom();
                    _listUOM.Insert(0, _master);
                }
                else
                {
                    _listUOM = null;
                }

                return _listUOM;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetDateTimeServerString(string formatDate)
        {
            string str = "";
            try
            {
                DateTime OutputResult;
                bool OutputSpacial;
                Calbee.WMS.Services.Core.CoreServiceProxy.WS.GetCurrentDateTime(out OutputResult, out OutputSpacial);
                if (OutputResult != null)
                {
                    DateTime dateEng = Convert.ToDateTime(OutputResult, _cultureEnInfo);
                    str = dateEng.ToString(formatDate, _cultureEnInfo);
                }
                else
                {
                    str = string.Empty;
                }
            }
            catch
            {
                throw;
            }

            return str;
        }
        public DateTime GetDateTimeServer()
        {
            DateTime dtime = DateTime.Now;
            try
            {
                DateTime OutputResult;
                bool OutputSpacial;
                Calbee.WMS.Services.Core.CoreServiceProxy.WS.GetCurrentDateTime(out OutputResult, out OutputSpacial);
                if (OutputResult != null)
                {
                    dtime = Convert.ToDateTime(OutputResult, _cultureEnInfo);
                }
                else
                {
                    dtime = DateTime.Now;
                }
            }
            catch
            {
                throw;
            }

            return dtime;
        }

        public static string DeviceName
        {
            get
            {
                string str = "";
                try
                {
                    str = System.Net.Dns.GetHostName();
                }
                catch
                {
                    throw;
                }

                return str;
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

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
