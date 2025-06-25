<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        Label4 = New Label()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(115, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 0
        Button1.Text = "計算"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 78)
        Label1.Name = "Label1"
        Label1.Size = New Size(32, 15)
        Label1.TabIndex = 1
        Label1.Text = "1から"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(77, 70)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(67, 23)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(147, 78)
        Label2.Name = "Label2"
        Label2.Size = New Size(70, 15)
        Label2.TabIndex = 3
        Label2.Text = "までの合計は"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(262, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 15)
        Label4.TabIndex = 5
        Label4.Text = "です。"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(214, 70)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(51, 23)
        TextBox2.TabIndex = 6
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(313, 450)
        Controls.Add(TextBox2)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "１から入力した数までの合計"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox

End Class
