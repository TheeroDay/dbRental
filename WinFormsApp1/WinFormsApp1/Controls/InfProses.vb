Imports System.Data.Odbc
Public Interface InfProses
    Function InsertData(Ob As Object) As OdbcCommand
    Function updateData(Ob As Object) As OdbcCommand
    Function deleteData(Ob As String) As OdbcCommand
    Function tampilData() As DataView
    Function cariData(Ob As Object) As DataView
    Function Login(username As String) As DataView
End Interface
