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

        private void Form1_Load(object sender, EventArgs e) {
            XtraReport1 x = new XtraReport1();
            x.DataSource = TestData.CreateRows();
            ReportPrintTool pt = new ReportPrintTool(x);
            pt.AutoShowParametersPanel = true;
            pt.ShowPreviewDialog();
        }
    }
    public class TestData {
        public static List<TestData> CreateRows() {
            List<TestData> l = new List<TestData>();
            for (int i = 0; i < 50; i++) {
                if (i == 1)
                    l.Add(new TestData { ID = i, Value = "Begin.\n\n\n\n\n\n\n\n\n\n\nEnd." });
                else
                    l.Add(new TestData { ID = i, Value = "Begin. End." });
            }
            return l;
        }
        public int ID { get; set; }
        public string Value { get; set; }
    }
    public class DataContainer : List<TestData> {
    }
}
