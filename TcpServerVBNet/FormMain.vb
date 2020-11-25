Imports System.IO
Imports System.Net
Imports System.Net.Sockets

Public Class FormMain
    Dim listener As TcpListener
    Dim clients As New List(Of Client)
    Dim curDateCode As String = ""
    Dim counterClinet As Int32 = 0
    Dim CounterMsgSended = 0
    Dim dataset As New DataSet
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listener = New TcpListener(IPAddress.Any, 9797)
        UpdateData("10.80.23.160:9797", Nothing, True, False)
        listener.Start()
        listener.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), listener)
    End Sub
    Sub AcceptClient(ByVal ar As IAsyncResult)
        If curDateCode <> DateTime.Now.ToString("yyyyMMdd") Then
            curDateCode = DateTime.Now.ToString("yyyyMMdd")
            counterClinet = 0
        End If
        counterClinet += 1
        Dim client = New Client(listener.EndAcceptTcpClient(ar), curDateCode & counterClinet.ToString)
        AddHandler(client.getMessage), AddressOf MessageReceived
        AddHandler(client.clientDisconnected), AddressOf ClientDisconnected
        clients.Add(client)
        UpdateData("New Client With ObjectId: " & client.ObjectId, Nothing, True, False)
        listener.BeginAcceptTcpClient(New AsyncCallback(AddressOf AcceptClient), listener)
    End Sub

    Sub MessageReceived(ByVal stream As NetworkStream, ByVal client As Client)
        Try
            If stream IsNot Nothing Then
                'Dim buffer() As Byte = New Byte(1024){}
                'Using ms = New MemoryStream()
                '    dataset.WriteXml(ms)
                '    ms.Position = 0
                '    Dim read = 0
                '    While (read = ms.Read(buffer, 0, 1024)) <> 0
                '        stream.Write(buffer, 0, read)
                '    End While
                'End Using
                'stream.Flush()
                'stream.Close()
                Dim str = New StreamReader(stream).ReadLine
                Dim msg = TcpData.getJsonObject(str)
                If msg.type = "UserConnected" Then
                    client.ClientId = msg.userconnected.idUser
                End If
                UpdateData(str, msg, True, True)
            Else
                clients.Remove(client)
            End If
        Catch ex As Exception
            UpdateData(ex.Message, Nothing, True, False)
        End Try
    End Sub
    Sub ClientDisconnected(ByVal client As Client)
        Try
            clients.Remove(client)
            UpdateData("Client Disconnected With ObjectId: " & client.ObjectId, Nothing, True, False)

            Dim msg As New TcpData()
            Dim obj As New UserConnected()
            obj.idUser = client.ClientId
            obj.status = "offline"
            obj.note = ""
            msg.userconnected = obj
            msg.type = obj.GetType().Name
            msg.remark = ""
            UpdateData(msg.getJsonString, msg, True, True)

        Catch ex As Exception
            UpdateData(ex.Message, Nothing, True, False)
        End Try
    End Sub
    Sub UpdateData(str As String, msg As TcpData, Optional log As Boolean = True, Optional sendmsg As Boolean = True)
        If InvokeRequired Then
            Invoke(Sub() UpdateData(str, msg, log, sendmsg))
        Else
            If log Then
                WriteLog(str)
            End If
            If sendmsg Then
                If msg.type = "UserConnected" Then
                    SendMessage(str, "")
                ElseIf msg.type = "ActionMessage" Then
                    SendMessage(str, msg.actionmessage.idUserReciever)
                ElseIf msg.type = "ChatMessage" Then
                    SendMessage(str, msg.chatmessage.idUserSender)
                    SendMessage(str, msg.chatmessage.idUserReciever)
                End If
            End If
        End If
    End Sub
    Sub WriteLog(str As String)
        RichTextBoxLog.AppendText(DateTime.Now.ToString() & ": " & str & vbNewLine)
    End Sub
    Sub SendMessage(str As String, ClientId As String)
        Dim list As List(Of Client)
        If ClientId = "" Then list = clients Else list = clients.FindAll(Function(c) c.ClientId = ClientId)
        Parallel.ForEach(list, Sub(client As Client)
                                   Try
                                       client.SendMessage(str)
                                   Catch ex As Exception
                                       list.Remove(client)
                                   End Try
                               End Sub)
    End Sub
    Sub BroadCastMessage(str As String, ClientId As String)
        Dim list As List(Of Client)
        If ClientId = "" Then list = clients Else list = clients.FindAll(Function(c) c.ClientId = ClientId)
        Parallel.ForEach(list, Sub(client As Client)
                                   Try
                                       client.SendMessage(str)
                                   Catch ex As Exception
                                       list.Remove(client)
                                   End Try
                               End Sub)
    End Sub

    Private Sub RichTextBoxLog_TextChanged(sender As Object, e As EventArgs) Handles RichTextBoxLog.TextChanged
        LabelLogLine.Text = "Log Line : " & RichTextBoxLog.Lines.Count
        LabelNumberOfClient.Text = "Client : " & clients.Count
        LabelMessageSend.Text = "Message Sended :  " & CounterMsgSended.ToString
        If RichTextBoxLog.Lines.Length > 9999 Then
            CounterMsgSended = 0
            RichTextBoxLog.Clear()
        End If
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        RichTextBoxLog.Clear()
        CounterMsgSended = 0
    End Sub
End Class
