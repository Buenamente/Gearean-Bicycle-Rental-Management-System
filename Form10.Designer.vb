<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        profile = New PictureBox()
        Label4 = New Label()
        satffeditsave = New Button()
        staffnumber = New TextBox()
        staffpassword = New TextBox()
        staffdelete = New Button()
        staffname = New TextBox()
        stafflist = New ListBox()
        btnOpenForm2 = New Button()
        CType(profile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(35, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 15)
        Label1.TabIndex = 26
        Label1.Text = "Staff list"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(226, 162)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 15)
        Label2.TabIndex = 27
        Label2.Text = "staff name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(197, 199)
        Label3.Name = "Label3"
        Label3.Size = New Size(92, 15)
        Label3.TabIndex = 28
        Label3.Text = "contact number"
        ' 
        ' profile
        ' 
        profile.Location = New Point(237, 39)
        profile.Name = "profile"
        profile.Size = New Size(135, 93)
        profile.TabIndex = 29
        profile.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(191, 231)
        Label4.Name = "Label4"
        Label4.Size = New Size(98, 15)
        Label4.TabIndex = 30
        Label4.Text = "current password"
        ' 
        ' satffeditsave
        ' 
        satffeditsave.Location = New Point(214, 279)
        satffeditsave.Name = "satffeditsave"
        satffeditsave.Size = New Size(75, 23)
        satffeditsave.TabIndex = 31
        satffeditsave.Text = "save"
        satffeditsave.UseVisualStyleBackColor = True
        ' 
        ' staffnumber
        ' 
        staffnumber.AcceptsReturn = True
        staffnumber.Location = New Point(295, 199)
        staffnumber.Name = "staffnumber"
        staffnumber.Size = New Size(100, 23)
        staffnumber.TabIndex = 33
        ' 
        ' staffpassword
        ' 
        staffpassword.Location = New Point(295, 231)
        staffpassword.Name = "staffpassword"
        staffpassword.Size = New Size(100, 23)
        staffpassword.TabIndex = 34
        ' 
        ' staffdelete
        ' 
        staffdelete.Location = New Point(320, 279)
        staffdelete.Name = "staffdelete"
        staffdelete.Size = New Size(75, 23)
        staffdelete.TabIndex = 35
        staffdelete.Text = "delete"
        staffdelete.UseVisualStyleBackColor = True
        ' 
        ' staffname
        ' 
        staffname.AcceptsReturn = True
        staffname.Location = New Point(295, 159)
        staffname.Name = "staffname"
        staffname.Size = New Size(100, 23)
        staffname.TabIndex = 36
        ' 
        ' stafflist
        ' 
        stafflist.FormattingEnabled = True
        stafflist.ItemHeight = 15
        stafflist.Location = New Point(36, 32)
        stafflist.Name = "stafflist"
        stafflist.Size = New Size(155, 319)
        stafflist.TabIndex = 37
        ' 
        ' btnOpenForm2
        ' 
        btnOpenForm2.FlatStyle = FlatStyle.Popup
        btnOpenForm2.Image = My.Resources.Resources.turn_back
        btnOpenForm2.Location = New Point(344, 332)
        btnOpenForm2.Name = "btnOpenForm2"
        btnOpenForm2.Size = New Size(51, 36)
        btnOpenForm2.TabIndex = 38
        btnOpenForm2.UseVisualStyleBackColor = True
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(401, 416)
        Controls.Add(btnOpenForm2)
        Controls.Add(stafflist)
        Controls.Add(staffname)
        Controls.Add(staffdelete)
        Controls.Add(staffpassword)
        Controls.Add(staffnumber)
        Controls.Add(satffeditsave)
        Controls.Add(Label4)
        Controls.Add(profile)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form10"
        Text = "Form10"
        CType(profile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents profile As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents satffeditsave As Button
    Friend WithEvents staffnumber As TextBox
    Friend WithEvents staffpassword As TextBox
    Friend WithEvents staffdelete As Button
    Friend WithEvents staffname As TextBox
    Friend WithEvents stafflist As ListBox
    Friend WithEvents btnOpenForm2 As Button
End Class
