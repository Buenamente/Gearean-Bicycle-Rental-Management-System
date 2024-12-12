<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        staffprofile = New PictureBox()
        uploadstaffprofile = New Button()
        staffname = New TextBox()
        staffcontact = New TextBox()
        staffpassword = New TextBox()
        addstaff = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btnOpenForm2 = New Button()
        Button1 = New Button()
        CType(staffprofile, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' staffprofile
        ' 
        staffprofile.Location = New Point(65, 12)
        staffprofile.Name = "staffprofile"
        staffprofile.Size = New Size(119, 87)
        staffprofile.TabIndex = 0
        staffprofile.TabStop = False
        ' 
        ' uploadstaffprofile
        ' 
        uploadstaffprofile.Location = New Point(190, 76)
        uploadstaffprofile.Name = "uploadstaffprofile"
        uploadstaffprofile.Size = New Size(75, 23)
        uploadstaffprofile.TabIndex = 1
        uploadstaffprofile.Text = "upload"
        uploadstaffprofile.UseVisualStyleBackColor = True
        ' 
        ' staffname
        ' 
        staffname.Location = New Point(112, 132)
        staffname.Name = "staffname"
        staffname.Size = New Size(186, 23)
        staffname.TabIndex = 2
        ' 
        ' staffcontact
        ' 
        staffcontact.Location = New Point(112, 171)
        staffcontact.Name = "staffcontact"
        staffcontact.Size = New Size(186, 23)
        staffcontact.TabIndex = 3
        ' 
        ' staffpassword
        ' 
        staffpassword.Location = New Point(112, 208)
        staffpassword.Name = "staffpassword"
        staffpassword.Size = New Size(186, 23)
        staffpassword.TabIndex = 4
        ' 
        ' addstaff
        ' 
        addstaff.Location = New Point(112, 260)
        addstaff.Name = "addstaff"
        addstaff.Size = New Size(75, 23)
        addstaff.TabIndex = 5
        addstaff.Text = "add staff"
        addstaff.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(28, 138)
        Label1.Name = "Label1"
        Label1.Size = New Size(78, 17)
        Label1.TabIndex = 6
        Label1.Text = "staff name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(13, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(93, 17)
        Label2.TabIndex = 7
        Label2.Text = "staff number:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(36, 214)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 17)
        Label3.TabIndex = 8
        Label3.Text = "password:"
        ' 
        ' btnOpenForm2
        ' 
        btnOpenForm2.FlatStyle = FlatStyle.Popup
        btnOpenForm2.Image = My.Resources.Resources.turn_back
        btnOpenForm2.Location = New Point(262, 285)
        btnOpenForm2.Name = "btnOpenForm2"
        btnOpenForm2.Size = New Size(51, 36)
        btnOpenForm2.TabIndex = 17
        btnOpenForm2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 298)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 18
        Button1.Text = "staff  list"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(325, 333)
        Controls.Add(Button1)
        Controls.Add(btnOpenForm2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(addstaff)
        Controls.Add(staffpassword)
        Controls.Add(staffcontact)
        Controls.Add(staffname)
        Controls.Add(uploadstaffprofile)
        Controls.Add(staffprofile)
        Name = "Form7"
        Text = "Form7"
        CType(staffprofile, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents staffprofile As PictureBox
    Friend WithEvents uploadstaffprofile As Button
    Friend WithEvents staffname As TextBox
    Friend WithEvents staffcontact As TextBox
    Friend WithEvents staffpassword As TextBox
    Friend WithEvents addstaff As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnOpenForm2 As Button
    Friend WithEvents Button1 As Button
End Class
