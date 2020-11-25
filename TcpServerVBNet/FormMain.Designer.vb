<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBoxLog = New System.Windows.Forms.RichTextBox()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.LabelLogLine = New System.Windows.Forms.Label()
        Me.LabelMessageSend = New System.Windows.Forms.Label()
        Me.LabelNumberOfClient = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Log Data"
        '
        'RichTextBoxLog
        '
        Me.RichTextBoxLog.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBoxLog.BackColor = System.Drawing.Color.White
        Me.RichTextBoxLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBoxLog.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBoxLog.Location = New System.Drawing.Point(10, 23)
        Me.RichTextBoxLog.Name = "RichTextBoxLog"
        Me.RichTextBoxLog.ReadOnly = True
        Me.RichTextBoxLog.Size = New System.Drawing.Size(906, 313)
        Me.RichTextBoxLog.TabIndex = 1
        Me.RichTextBoxLog.Text = ""
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClear.Location = New System.Drawing.Point(793, 342)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(123, 37)
        Me.ButtonClear.TabIndex = 6
        Me.ButtonClear.Text = "Clear Log History"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'LabelLogLine
        '
        Me.LabelLogLine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelLogLine.AutoSize = True
        Me.LabelLogLine.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLogLine.ForeColor = System.Drawing.Color.Maroon
        Me.LabelLogLine.Location = New System.Drawing.Point(10, 378)
        Me.LabelLogLine.Name = "LabelLogLine"
        Me.LabelLogLine.Size = New System.Drawing.Size(61, 15)
        Me.LabelLogLine.TabIndex = 10
        Me.LabelLogLine.Text = "Log Line :"
        '
        'LabelMessageSend
        '
        Me.LabelMessageSend.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelMessageSend.AutoSize = True
        Me.LabelMessageSend.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMessageSend.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.LabelMessageSend.Location = New System.Drawing.Point(10, 359)
        Me.LabelMessageSend.Name = "LabelMessageSend"
        Me.LabelMessageSend.Size = New System.Drawing.Size(123, 15)
        Me.LabelMessageSend.TabIndex = 8
        Me.LabelMessageSend.Text = "Message Sended :  0"
        '
        'LabelNumberOfClient
        '
        Me.LabelNumberOfClient.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelNumberOfClient.AutoSize = True
        Me.LabelNumberOfClient.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNumberOfClient.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LabelNumberOfClient.Location = New System.Drawing.Point(10, 339)
        Me.LabelNumberOfClient.Name = "LabelNumberOfClient"
        Me.LabelNumberOfClient.Size = New System.Drawing.Size(48, 15)
        Me.LabelNumberOfClient.TabIndex = 9
        Me.LabelNumberOfClient.Text = "Client : "
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(924, 400)
        Me.Controls.Add(Me.LabelLogLine)
        Me.Controls.Add(Me.LabelMessageSend)
        Me.Controls.Add(Me.LabelNumberOfClient)
        Me.Controls.Add(Me.ButtonClear)
        Me.Controls.Add(Me.RichTextBoxLog)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Name = "FormMain"
        Me.Text = "Form Tcp Sever"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBoxLog As RichTextBox
    Friend WithEvents ButtonClear As Button
    Friend WithEvents LabelLogLine As Label
    Friend WithEvents LabelMessageSend As Label
    Friend WithEvents LabelNumberOfClient As Label
End Class
