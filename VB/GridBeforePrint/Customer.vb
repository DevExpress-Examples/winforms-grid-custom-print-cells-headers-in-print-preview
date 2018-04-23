Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace GridBeforePrint
	Friend Class Customer
'INSTANT VB NOTE: The variable firstName was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private firstName_Renamed As String
'INSTANT VB NOTE: The variable lastName was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private lastName_Renamed As String
'INSTANT VB NOTE: The variable id was renamed since Visual Basic does not allow variables and other class members to have the same name:
		Private id_Renamed As Integer
		Public Property Id() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				id_Renamed = value
			End Set
		End Property

		Public Property LastName() As String
			Get
				Return lastName_Renamed
			End Get
			Set(ByVal value As String)
				lastName_Renamed = value
			End Set
		End Property

		Public Property FirstName() As String
			Get
				Return firstName_Renamed
			End Get
			Set(ByVal value As String)
				firstName_Renamed = value
			End Set
		End Property

		Public Sub New()
		End Sub

		Public Sub New(ByVal firstName As String, ByVal lastName As String, ByVal id As Integer)
			Me.FirstName = firstName
			Me.LastName = lastName
			Me.Id = id
		End Sub
	End Class
End Namespace
