Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Namespace dx_sample
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub simpleButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles simpleButton1.Click
			Dim x As New XtraReport1()
			x.DataSource = TestData.CreateRows()
			Dim pt As New ReportPrintTool(x)
			pt.AutoShowParametersPanel = True
			pt.ShowPreviewDialog()
		End Sub
	End Class
End Namespace
