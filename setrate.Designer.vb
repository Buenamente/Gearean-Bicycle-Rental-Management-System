<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class setrate
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
        currentrate = New Label()
        Label3 = New Label()
        Label2 = New Label()
        changerate = New TextBox()
        savechanges = New Button()
        btnDefault = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 15.75F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(91, 30)
        Label1.TabIndex = 0
        Label1.Text = "Set Rate"
        ' 
        ' currentrate
        ' 
        currentrate.AutoSize = True
        currentrate.Location = New Point(119, 84)
        currentrate.Name = "currentrate"
        currentrate.Size = New Size(41, 15)
        currentrate.TabIndex = 1
        currentrate.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(40, 84)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 2
        Label3.Text = "Current rate:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(40, 123)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 15)
        Label2.TabIndex = 3
        Label2.Text = "change rate:"
        ' 
        ' changerate
        ' 
        changerate.Location = New Point(118, 123)
        changerate.Name = "changerate"
        changerate.Size = New Size(100, 23)
        changerate.TabIndex = 4
        ' 
        ' savechanges
        ' 
        savechanges.Location = New Point(143, 164)
        savechanges.Name = "savechanges"
        savechanges.Size = New Size(75, 23)
        savechanges.TabIndex = 5
        savechanges.Text = "save"
        savechanges.UseVisualStyleBackColor = True
        ' 
        ' btnDefault
        ' 
        btnDefault.Location = New Point(52, 164)
        btnDefault.Name = "btnDefault"
        btnDefault.Size = New Size(75, 23)
        btnDefault.TabIndex = 6
        btnDefault.Text = "default"
        btnDefault.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(224, 254)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 7
        Button1.Text = "back"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' setrate
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(311, 289)
        Controls.Add(Button1)
        Controls.Add(btnDefault)
        Controls.Add(savechanges)
        Controls.Add(changerate)
        Controls.Add(Label2)
        Controls.Add(Label3)
        Controls.Add(currentrate)
        Controls.Add(Label1)
        Name = "setrate"
        Text = "setrate"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents currentrate As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents changerate As TextBox
    Friend WithEvents savechanges As Button
    Friend WithEvents btnDefault As Button
    Friend WithEvents Button1 As Button
End Class
