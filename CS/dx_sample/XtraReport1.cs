using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.NativeBricks;

namespace dx_sample {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        float DetailHeight = 0;
        public XtraReport1() {
            InitializeComponent();
        }
        public void CreateCustomDocument() {
            CreateDocument();
            xrTable2.BeginInit();
            xrTable2.HeightF = DetailHeight;
            xrTable2.EndInit();
            CreateDocument();
        }
        protected override void AfterReportPrint() {
            if (DetailHeight != 0) return;
            foreach (DevExpress.XtraPrinting.Page p in this.Pages) {
                foreach (Brick b in p) {
                    if (b is TableBrick) {
                        DetailHeight = Math.Max(DetailHeight, b.Size.Height);        
                    }
                }
            }
            switch (this.ReportUnit) {
                case ReportUnit.HundredthsOfAnInch:
                    DetailHeight = 100 * GraphicsUnitConverter.Convert(DetailHeight, GraphicsUnit.Document, GraphicsUnit.Inch);
                    break;
                case ReportUnit.TenthsOfAMillimeter:
                    DetailHeight = 10 * GraphicsUnitConverter.Convert(DetailHeight, GraphicsUnit.Document, GraphicsUnit.Millimeter);
                    break;
            }
        }
    }
}
