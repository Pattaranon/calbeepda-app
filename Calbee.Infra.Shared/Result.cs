using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.Infra.Shared
{
    public class Result<TData, TReturnStatus>
    {
        #region Members

        private TData data;
        private Exception exception;
        private TReturnStatus status;
        private bool isError;
        private List<string> brokenRules;
        private string code;
        private string description;
        private object mapList;

        #endregion

        #region Properties

        public TData Data
        {
            get { return data; }
        }

        public TReturnStatus Status
        {
            get { return status; }
        }

        public bool IsError
        {
            get { return isError; }
        }

        public Exception Exception
        {
            get { return exception; }
        }

        public List<string> BrokenRules
        {
            get { return brokenRules; }
            set { brokenRules = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public object MapList
        {
            get { return mapList; }
            set { mapList = value; }
        }

        #endregion

        #region Constructors

        public Result(TData resultData, TReturnStatus returnStatus)
        {
            this.data = resultData;
            this.status = returnStatus;
            this.isError = false;
            this.code = this.status.ToString().ToUpper();
        }

        public Result(Exception ex)
        {
            this.exception = ex;
            this.isError = true;
            this.status = default(TReturnStatus);
            this.code = "ERROR";
        }

        #endregion
    }

    public class Result<TReturnStatus>
    {
        #region Members

        private Exception exception;
        private TReturnStatus status;
        private bool isError;
        private List<string> brokenRules;
        private string code;
        private string description;
        private object mapList;

        #endregion

        #region Properties

        public TReturnStatus Status
        {
            get { return status; }
        }

        public bool IsError
        {
            get { return isError; }
        }

        public Exception Exception
        {
            get { return exception; }
        }

        public List<string> BrokenRules
        {
            get { return brokenRules; }
            set { brokenRules = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public object MapList
        {
            get { return mapList; }
            set { mapList = value; }
        }

        #endregion

        #region Constructors

        public Result(TReturnStatus returnStatus)
        {
            this.status = returnStatus;
            this.isError = false;
            this.code = this.status.ToString().ToUpper();
        }

        public Result(Exception ex)
        {
            this.exception = ex;
            this.isError = true;
            this.status = default(TReturnStatus);
            this.code = "ERROR";
        }

        #endregion

    }
}
