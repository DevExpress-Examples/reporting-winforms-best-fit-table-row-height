Imports DevExpress.XtraReports.UI
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms

Namespace dx_sample

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim x As XtraReport1 = New XtraReport1()
            x.DataSource = TestData.CreateRows()
            Dim pt As ReportPrintTool = New ReportPrintTool(x)
            pt.AutoShowParametersPanel = True
            pt.ShowPreviewDialog()
        End Sub
    End Class

    Public Class TestData

        Public Shared Function CreateRows() As List(Of TestData)
            Dim l As List(Of TestData) = New List(Of TestData)()
            For i As Integer = 0 To 50 - 1
                If i = 1 Then
                    l.Add(New TestData With {.ID = i, .Value = "Begin." & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & Microsoft.VisualBasic.Constants.vbLf & "End."})
                Else
                    l.Add(New TestData With {.ID = i, .Value = "Begin. End."})
                End If
            Next

            Return l
        End Function

        Public Property ID As Integer

        Public Property Value As String
    End Class

    Public Class DataContainer
        Inherits List(Of TestData)

    End Class
End Namespace
