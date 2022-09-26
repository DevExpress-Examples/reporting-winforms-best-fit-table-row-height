Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.NativeBricks

Namespace dx_sample

    Public Partial Class XtraReport1
        Inherits XtraReport

        Private DetailHeight As Single = 0

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub CreateCustomDocument()
            CreateDocument()
            xrTable2.BeginInit()
            xrTable2.HeightF = DetailHeight
            xrTable2.EndInit()
            CreateDocument()
        End Sub

        Protected Overrides Sub AfterReportPrint()
            If DetailHeight <> 0 Then Return
            For Each p As Page In Pages
                For Each b As Brick In p
                    If TypeOf b Is TableBrick Then
                        DetailHeight = Math.Max(DetailHeight, b.Size.Height)
                    End If
                Next
            Next

            Select Case ReportUnit
                Case ReportUnit.HundredthsOfAnInch
                    DetailHeight = 100 * GraphicsUnitConverter.Convert(DetailHeight, GraphicsUnit.Document, GraphicsUnit.Inch)
                Case ReportUnit.TenthsOfAMillimeter
                    DetailHeight = 10 * GraphicsUnitConverter.Convert(DetailHeight, GraphicsUnit.Document, GraphicsUnit.Millimeter)
            End Select
        End Sub
    End Class
End Namespace
