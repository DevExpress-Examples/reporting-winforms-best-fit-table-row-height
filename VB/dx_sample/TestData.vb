Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace dx_sample
	Public Class TestData
		Public Shared Function CreateRows() As List(Of TestData)
			Dim l As New List(Of TestData)()
			For i As Integer = 0 To 49
				If i = 1 Then
					l.Add(New TestData With {
						.ID = i,
						.Value = "Begin." & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & ControlChars.Lf & "End."
					})
				Else
					l.Add(New TestData With {
						.ID = i,
						.Value = "Begin. End."
					})
				End If
			Next i
			Return l
		End Function
		Public Property ID() As Integer
		Public Property Value() As String
	End Class
	Public Class DataContainer
		Inherits List(Of TestData)

	End Class
End Namespace
