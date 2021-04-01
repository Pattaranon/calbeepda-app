using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Calbee.Infra.Shared;

namespace Calbee.WMS.UI.FormsBases
{
    public partial class frmBaseForms : Form
    {
        #region Member

        private static AppContext appContext = AppContext.Instance;
        public AppContext AppContext
        {
            get { return appContext; }
        }

        #endregion

        #region Constructor

        public frmBaseForms()
        {
            InitializeComponent();
        }

        #endregion
    }
}