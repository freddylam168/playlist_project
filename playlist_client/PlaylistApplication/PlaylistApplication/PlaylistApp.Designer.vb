<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PlaylistApp
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
        Me.btnAddPlaylist = New System.Windows.Forms.Button()
        Me.btnEditPlaylist = New System.Windows.Forms.Button()
        Me.btnSearchUsername = New System.Windows.Forms.Button()
        Me.btnSearchPlaylist = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRank = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPlaylist
        '
        Me.btnAddPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPlaylist.Location = New System.Drawing.Point(224, 12)
        Me.btnAddPlaylist.Name = "btnAddPlaylist"
        Me.btnAddPlaylist.Size = New System.Drawing.Size(88, 51)
        Me.btnAddPlaylist.TabIndex = 3
        Me.btnAddPlaylist.Text = "Add Playlist"
        Me.btnAddPlaylist.UseVisualStyleBackColor = True
        '
        'btnEditPlaylist
        '
        Me.btnEditPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditPlaylist.Location = New System.Drawing.Point(328, 12)
        Me.btnEditPlaylist.Name = "btnEditPlaylist"
        Me.btnEditPlaylist.Size = New System.Drawing.Size(88, 51)
        Me.btnEditPlaylist.TabIndex = 4
        Me.btnEditPlaylist.Text = "Edit Playlist"
        Me.btnEditPlaylist.UseVisualStyleBackColor = True
        '
        'btnSearchUsername
        '
        Me.btnSearchUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchUsername.Location = New System.Drawing.Point(12, 12)
        Me.btnSearchUsername.Name = "btnSearchUsername"
        Me.btnSearchUsername.Size = New System.Drawing.Size(88, 51)
        Me.btnSearchUsername.TabIndex = 5
        Me.btnSearchUsername.Text = "Search by Username"
        Me.btnSearchUsername.UseVisualStyleBackColor = True
        '
        'btnSearchPlaylist
        '
        Me.btnSearchPlaylist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPlaylist.Location = New System.Drawing.Point(120, 12)
        Me.btnSearchPlaylist.Name = "btnSearchPlaylist"
        Me.btnSearchPlaylist.Size = New System.Drawing.Size(88, 51)
        Me.btnSearchPlaylist.TabIndex = 6
        Me.btnSearchPlaylist.Text = "Search by Playlist Name"
        Me.btnSearchPlaylist.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(509, 14)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(73, 47)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Remove"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnRank
        '
        Me.btnRank.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRank.ForeColor = System.Drawing.Color.Blue
        Me.btnRank.Location = New System.Drawing.Point(433, 12)
        Me.btnRank.Name = "btnRank"
        Me.btnRank.Size = New System.Drawing.Size(60, 51)
        Me.btnRank.TabIndex = 12
        Me.btnRank.Text = "Rate"
        Me.btnRank.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Designed by Freddy"
        '
        'txtLogout
        '
        Me.txtLogout.Location = New System.Drawing.Point(507, 67)
        Me.txtLogout.Name = "txtLogout"
        Me.txtLogout.Size = New System.Drawing.Size(75, 23)
        Me.txtLogout.TabIndex = 15
        Me.txtLogout.Text = "Logout"
        Me.txtLogout.UseVisualStyleBackColor = True
        '
        'PlaylistApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(592, 97)
        Me.Controls.Add(Me.txtLogout)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnRank)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearchPlaylist)
        Me.Controls.Add(Me.btnSearchUsername)
        Me.Controls.Add(Me.btnEditPlaylist)
        Me.Controls.Add(Me.btnAddPlaylist)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(608, 135)
        Me.MinimumSize = New System.Drawing.Size(608, 135)
        Me.Name = "PlaylistApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YouTube Playlist Application"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddPlaylist As Button
    Friend WithEvents btnEditPlaylist As Button
    Friend WithEvents btnSearchUsername As Button
    Friend WithEvents btnSearchPlaylist As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnRank As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLogout As Button
End Class
