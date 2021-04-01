using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Calbee.Infra.Logging
{
    public class Logger : IDisposable
    {

        #region IDisposable Members

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
