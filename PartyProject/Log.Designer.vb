<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Log
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
        Me.lblLogC = New System.Windows.Forms.Label()
        Me.lblLogE = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblLogC
        '
        Me.lblLogC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLogC.Location = New System.Drawing.Point(12, 35)
        Me.lblLogC.Name = "lblLogC"
        Me.lblLogC.Size = New System.Drawing.Size(372, 403)
        Me.lblLogC.TabIndex = 2
        Me.lblLogC.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblLogE
        '
        Me.lblLogE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLogE.Location = New System.Drawing.Point(395, 35)
        Me.lblLogE.Name = "lblLogE"
        Me.lblLogE.Size = New System.Drawing.Size(372, 403)
        Me.lblLogE.TabIndex = 3
        Me.lblLogE.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Combat Log:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(500, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Environment Log:"
        '
        'Log
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 447)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblLogE)
        Me.Controls.Add(Me.lblLogC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Log"
        Me.Text = "Log"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLogC As Label
    Friend WithEvents lblLogE As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
