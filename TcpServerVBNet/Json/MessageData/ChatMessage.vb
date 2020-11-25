Imports Newtonsoft.Json

Public Class ChatMessage
    Public idMessage As String, idUserSender As String, nameUserSender As String = "", idUserReciever As String, message As String, fileAttached As String
    Public Sub New()

    End Sub
    Public Function getJsonString() As String
        Dim obj As New ChatMessage
        obj.idMessage = idMessage
        obj.idUserSender = idUserSender
        obj.nameUserSender = nameUserSender
        obj.idUserReciever = idUserReciever
        obj.message = message
        obj.fileAttached = fileAttached
        Return JsonConvert.SerializeObject(obj)
    End Function
    Public Shared Function getJsonObject(strJson As String) As ChatMessage
        Try
            Dim obj As ChatMessage = JsonConvert.DeserializeObject(Of ChatMessage)(strJson)
            Return obj
        Catch ex As Exception
            Return New ChatMessage
        End Try
    End Function
End Class
