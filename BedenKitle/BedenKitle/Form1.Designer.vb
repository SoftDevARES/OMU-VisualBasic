<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(162))
        Label1.Location = New Point(121, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(181, 25)
        Label1.TabIndex = 0
        Label1.Text = "Beden Kitle İndeksi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(127, 110)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "Boyun"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(129, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(34, 15)
        Label3.TabIndex = 2
        Label3.Text = "Kilon"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(199, 110)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(201, 148)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(201, 204)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 5
        Button1.Text = "Hesapla"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(198, 249)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 15)
        Label4.TabIndex = 6
        Label4.Text = "Beden Kitle İndeksi : "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(198, 278)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 15)
        Label5.TabIndex = 7
        Label5.Text = "Durumun : "
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(381, 74)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(304, 190)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
