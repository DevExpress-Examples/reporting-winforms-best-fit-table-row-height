using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dx_sample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            XtraReport1 x = new XtraReport1();
            x.DataSource = TestData.CreateRows();
            ReportPrintTool pt = new ReportPrintTool(x);
            pt.AutoShowParametersPanel = true;
            pt.ShowPreviewDialog();
        }
    }
}
