Imports System.IO
Imports System.Net.Sockets

Public Class Client
    Dim message As StreamWriter
    Public Event getMessage(ByVal stream As NetworkStream, client As Client)
    Public Event clientDisconnected(ByVal client As Client)
    Private tcpClient As TcpClient
    Private _objecttID As String
    Private _clientID As String
    Public Property ClientId() As String
        Get
            Return _clientId
        End Get
        Set(val As String)
            _clientId = val
        End Set
    End Property
    Public ReadOnly Property ObjectId() As String
        Get
            Return _objecttID
        End Get
    End Property
    Sub New(ByVal tcpClient As TcpClient, objectId As String)
        Try
            _objecttID = objectId
            Me.tcpClient = tcpClient
            tcpClient.GetStream.BeginRead(New Byte() {0}, 0, 0, AddressOf ReadAllClientMessage, Nothing)
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub ReadAllClientMessage()
        Try
            RaiseEvent getMessage(tcpClient.GetStream, Me)
            tcpClient.GetStream.BeginRead(New Byte() {0}, 0, 0, New AsyncCallback(AddressOf ReadAllClientMessage), Nothing)
        Catch ex As Exception
            RaiseEvent clientDisconnected(Me)
        End Try
    End Sub
    Public Sub SendMessage(ByVal Messsage As String)
        Try
            message = New StreamWriter(tcpClient.GetStream)
            message.WriteLine(Messsage)
            message.Flush()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Class
