Imports Newtonsoft.Json

Public Class UserConnected
    Public idUser As String
    Public status As String
    Public note As String
    Public Sub New()

    End Sub
    Public Function getJsonString() As String
        Dim obj As New UserConnected
        obj.idUser = idUser
        obj.status = status
        obj.note = note
        Return JsonConvert.SerializeObject(obj)
    End Function
    Public Shared Function getJsonObject(strJson As String) As UserConnected
        Try
            Dim obj As UserConnected = JsonConvert.DeserializeObject(Of UserConnected)(strJson)
            Return obj
        Catch ex As Exception
            Return New UserConnected
        End Try
    End Function
End Class
