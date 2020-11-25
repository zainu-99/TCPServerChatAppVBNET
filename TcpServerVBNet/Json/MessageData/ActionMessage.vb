Imports Newtonsoft.Json
Public Class ActionMessage
    Public idMessage As String
    Public idUserSender As String
    Public idUserReciever As String
    Public action As String
    Public booleanValue As Boolean
    Public stringValue As String
    Public integerValue As Int32
    Public Sub New()

    End Sub
    Public Function getJsonString() As String
        Dim obj As New ActionMessage
        obj.idMessage = idMessage
        obj.idUserSender = idUserSender
        obj.idUserReciever = idUserReciever
        obj.action = action
        obj.booleanValue = booleanValue
        obj.stringValue = stringValue
        obj.integerValue = integerValue
        Return JsonConvert.SerializeObject(obj)
    End Function
    Public Shared Function getJsonObject(strJson As String) As ActionMessage
        Try
            Dim obj As ActionMessage = JsonConvert.DeserializeObject(Of ActionMessage)(strJson)
            Return obj
        Catch ex As Exception
            Return New ActionMessage
        End Try
    End Function
End Class
