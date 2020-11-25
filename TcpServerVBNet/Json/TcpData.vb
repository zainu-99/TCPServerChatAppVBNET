Imports Newtonsoft.Json

Public Class TcpData
    Public chatmessage As ChatMessage,
        userconnected As UserConnected,
        actionmessage As ActionMessage,
        type As String, remark As String
    Public Function getJsonString() As String
        Dim obj As New TcpData
        obj.chatmessage = chatmessage
        obj.userconnected = userconnected
        obj.actionmessage = actionmessage
        obj.remark = remark
        obj.type = type
        Return JsonConvert.SerializeObject(obj)
    End Function
    Public Shared Function getJsonObject(strJson As String) As TcpData
        Try
            Dim obj As TcpData = JsonConvert.DeserializeObject(Of TcpData)(strJson)
            Return obj
        Catch ex As Exception
            Return New TcpData
        End Try
    End Function
End Class
