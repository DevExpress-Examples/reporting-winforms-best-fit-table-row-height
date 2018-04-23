Imports Microsoft.VisualBasic
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

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim x As New XtraReport1()
			x.DataSource = TestData.CreateRows()
			Dim pt As New ReportPrintTool(x)
			pt.AutoShowParametersPanel = True
			pt.ShowPreviewDialog()
		End Sub
	End Class
	Public Class TestData
		Public Shared Function CreateRows() As List(Of TestData)
			Dim l As New List(Of TestData)()
			For i As Integer = 0 To 49
				If i = 1 Then
					l.Add(New TestData With {.ID = i, .Value = "Begin." & Constants.vbLf + Constants.vbLf + Constants.vbLf + Constants.vbLf + Constants.vbLf + Constants.vbLf + Constants.vbLf + Constants.vbLf + Constants.vbLf + Constants.vbLf + Constants.vbLf & "End."})
				Else
					l.Add(New TestData With {.ID = i, .Value = "Begin. End."})
				End If
			Next i
			Return l
		End Function
		Private privateID As Integer
		Public Property ID() As Integer
			Get
				Return privateID
			End Get
			Set(ByVal value As Integer)
				privateID = value
			End Set
		End Property
		Private privateValue As String
		Public Property Value() As String
			Get
				Return privateValue
			End Get
			Set(ByVal value As String)
				privateValue = value
			End Set
		End Property
	End Class
	Public Class DataContainer
		Inherits List(Of TestData)
	End Class
End Namespace
