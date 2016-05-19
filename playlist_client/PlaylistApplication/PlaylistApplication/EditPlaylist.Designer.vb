<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditPlaylist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrPlaylist = New System.Windows.Forms.TextBox()
        Me.txtNewPlaylist = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNewID = New System.Windows.Forms.TextBox()
        Me.txtNewTitle = New System.Windows.Forms.TextBox()
        Me.txtNewUrl = New System.Windows.Forms.TextBox()
        Me.txtNewDuration = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.Label()
        Me.txtNewUsername = New System.Windows.Forms.TextBox()
        Me.txtCurrUsername = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(17, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Current Playlist:"
        '
        'txtCurrPlaylist
        '
        Me.txtCurrPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrPlaylist.Location = New System.Drawing.Point(169, 90)
        Me.txtCurrPlaylist.Name = "txtCurrPlaylist"
        Me.txtCurrPlaylist.Size = New System.Drawing.Size(228, 23)
        Me.txtCurrPlaylist.TabIndex = 2
        '
        'txtNewPlaylist
        '
        Me.txtNewPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewPlaylist.Location = New System.Drawing.Point(169, 125)
        Me.txtNewPlaylist.Name = "txtNewPlaylist"
        Me.txtNewPlaylist.Size = New System.Drawing.Size(228, 23)
        Me.txtNewPlaylist.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(17, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "New Playlist Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(17, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "New Track ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(17, 205)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "New Title:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(18, 244)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "New URL:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(18, 283)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "New Duration:"
        '
        'txtNewID
        '
        Me.txtNewID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewID.Location = New System.Drawing.Point(169, 161)
        Me.txtNewID.Name = "txtNewID"
        Me.txtNewID.Size = New System.Drawing.Size(228, 23)
        Me.txtNewID.TabIndex = 4
        '
        'txtNewTitle
        '
        Me.txtNewTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewTitle.Location = New System.Drawing.Point(169, 199)
        Me.txtNewTitle.Name = "txtNewTitle"
        Me.txtNewTitle.Size = New System.Drawing.Size(228, 23)
        Me.txtNewTitle.TabIndex = 5
        '
        'txtNewUrl
        '
        Me.txtNewUrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUrl.Location = New System.Drawing.Point(169, 238)
        Me.txtNewUrl.Name = "txtNewUrl"
        Me.txtNewUrl.Size = New System.Drawing.Size(228, 23)
        Me.txtNewUrl.TabIndex = 6
        '
        'txtNewDuration
        '
        Me.txtNewDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewDuration.Location = New System.Drawing.Point(169, 277)
        Me.txtNewDuration.Name = "txtNewDuration"
        Me.txtNewDuration.Size = New System.Drawing.Size(228, 23)
        Me.txtNewDuration.TabIndex = 7
        '
        'btnUpdate
        '
        Me.btnUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(403, 272)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(88, 33)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label9.Location = New System.Drawing.Point(18, 316)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 13)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Designed by Freddy"
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(403, 311)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(18, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "New Username:"
        '
        'txtUsername
        '
        Me.txtUsername.AutoSize = True
        Me.txtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.White
        Me.txtUsername.Location = New System.Drawing.Point(18, 23)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(145, 17)
        Me.txtUsername.TabIndex = 28
        Me.txtUsername.Text = "Current Username:"
        '
        'txtNewUsername
        '
        Me.txtNewUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNewUsername.Location = New System.Drawing.Point(169, 52)
        Me.txtNewUsername.Name = "txtNewUsername"
        Me.txtNewUsername.Size = New System.Drawing.Size(228, 23)
        Me.txtNewUsername.TabIndex = 1
        '
        'txtCurrUsername
        '
        Me.txtCurrUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrUsername.Location = New System.Drawing.Point(169, 17)
        Me.txtCurrUsername.Name = "txtCurrUsername"
        Me.txtCurrUsername.Size = New System.Drawing.Size(228, 23)
        Me.txtCurrUsername.TabIndex = 0
        '
        'EditPlaylist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(498, 339)
        Me.Controls.Add(Me.txtCurrUsername)
        Me.Controls.Add(Me.txtNewUsername)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNewDuration)
        Me.Controls.Add(Me.txtNewUrl)
        Me.Controls.Add(Me.txtNewTitle)
        Me.Controls.Add(Me.txtNewID)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNewPlaylist)
        Me.Controls.Add(Me.txtCurrPlaylist)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(514, 377)
        Me.MinimumSize = New System.Drawing.Size(514, 377)
        Me.Name = "EditPlaylist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Playlist"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrPlaylist As TextBox
    Friend WithEvents txtNewPlaylist As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtNewID As TextBox
    Friend WithEvents txtNewTitle As TextBox
    Friend WithEvents txtNewUrl As TextBox
    Friend WithEvents txtNewDuration As TextBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As Label
    Friend WithEvents txtNewUsername As TextBox
    Friend WithEvents txtCurrUsername As TextBox
End Class
