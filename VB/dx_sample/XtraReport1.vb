Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.NativeBricks

Namespace dx_sample
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport

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
			If DetailHeight <> 0 Then
				Return
			End If
			For Each p As DevExpress.XtraPrinting.Page In Me.Pages
				For Each b As Brick In p
					If TypeOf b Is TableBrick Then
						DetailHeight = Math.Max(DetailHeight, b.Size.Height)
					End If
				Next b
			Next p
			Select Case Me.ReportUnit
				Case ReportUnit.HundredthsOfAnInch
					DetailHeight = 100 * GraphicsUnitConverter.Convert(DetailHeight, GraphicsUnit.Document, GraphicsUnit.Inch)
				Case ReportUnit.TenthsOfAMillimeter
					DetailHeight = 10 * GraphicsUnitConverter.Convert(DetailHeight, GraphicsUnit.Document, GraphicsUnit.Millimeter)
			End Select
		End Sub
	End Class
End Namespace
