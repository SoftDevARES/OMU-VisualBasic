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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        topla_btn = New RadioButton()
        cikart_btn = New RadioButton()
        carp_btn = New RadioButton()
        bol_btn = New RadioButton()
        Button1 = New Button()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 66)
        Label1.Name = "Label1"
        Label1.Size = New Size(41, 15)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 100)
        Label2.Name = "Label2"
        Label2.Size = New Size(41, 15)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(133, 64)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(135, 106)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(100, 23)
        TextBox2.TabIndex = 3
        ' 
        ' topla_btn
        ' 
        topla_btn.AutoSize = True
        topla_btn.Location = New Point(134, 158)
        topla_btn.Name = "topla_btn"
        topla_btn.Size = New Size(53, 19)
        topla_btn.TabIndex = 4
        topla_btn.TabStop = True
        topla_btn.Text = "Topla"
        topla_btn.UseVisualStyleBackColor = True
        ' 
        ' cikart_btn
        ' 
        cikart_btn.AutoSize = True
        cikart_btn.Location = New Point(133, 192)
        cikart_btn.Name = "cikart_btn"
        cikart_btn.Size = New Size(56, 19)
        cikart_btn.TabIndex = 5
        cikart_btn.TabStop = True
        cikart_btn.Text = "Çıkart"
        cikart_btn.UseVisualStyleBackColor = True
        ' 
        ' carp_btn
        ' 
        carp_btn.AutoSize = True
        carp_btn.Location = New Point(133, 232)
        carp_btn.Name = "carp_btn"
        carp_btn.Size = New Size(50, 19)
        carp_btn.TabIndex = 6
        carp_btn.TabStop = True
        carp_btn.Text = "Çarp"
        carp_btn.UseVisualStyleBackColor = True
        ' 
        ' bol_btn
        ' 
        bol_btn.AutoSize = True
        bol_btn.Location = New Point(135, 268)
        bol_btn.Name = "bol_btn"
        bol_btn.Size = New Size(42, 19)
        bol_btn.TabIndex = 7
        bol_btn.TabStop = True
        bol_btn.Text = "Böl"
        bol_btn.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(291, 207)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 8
        Button1.Text = "Hesapla"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(125, 316)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 15)
        Label3.TabIndex = 9
        Label3.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(772, 501)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(bol_btn)
        Controls.Add(carp_btn)
        Controls.Add(cikart_btn)
        Controls.Add(topla_btn)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents topla_btn As RadioButton
    Friend WithEvents cikart_btn As RadioButton
    Friend WithEvents carp_btn As RadioButton
    Friend WithEvents bol_btn As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label

End Class
