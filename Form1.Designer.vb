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
        btnClickHere = New Button()
        CheckBox1 = New CheckBox()
        CheckBox2 = New CheckBox()
        RadioButton1 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton3 = New RadioButton()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        ComboBox1 = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ComboBox3 = New ComboBox()
        SuspendLayout()
        ' 
        ' btnClickHere
        ' 
        btnClickHere.Location = New Point(381, 443)
        btnClickHere.Name = "btnClickHere"
        btnClickHere.Size = New Size(144, 62)
        btnClickHere.TabIndex = 0
        btnClickHere.Text = "Click here"
        btnClickHere.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(340, 338)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(131, 29)
        CheckBox1.TabIndex = 1
        CheckBox1.Text = "Sign Me Up"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(340, 373)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(115, 29)
        CheckBox2.TabIndex = 2
        CheckBox2.Text = "Subscribe"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(612, 93)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(75, 29)
        RadioButton1.TabIndex = 3
        RadioButton1.TabStop = True
        RadioButton1.Text = "Male"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(612, 128)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(93, 29)
        RadioButton2.TabIndex = 4
        RadioButton2.TabStop = True
        RadioButton2.Text = "Female"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(612, 158)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(82, 29)
        RadioButton3.TabIndex = 5
        RadioButton3.TabStop = True
        RadioButton3.Text = "Other"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(331, 156)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(331, 108)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(173, 31)
        TextBox2.TabIndex = 7
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Mr", "Mrs", "Ms", "Dr", "Prof"})
        ComboBox1.Location = New Point(331, 200)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(182, 33)
        ComboBox1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(179, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 25)
        Label1.TabIndex = 9
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(179, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(76, 25)
        Label2.TabIndex = 10
        Label2.Text = "Suname"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe Print", 20F, FontStyle.Bold Or FontStyle.Underline, GraphicsUnit.Point)
        Label3.Location = New Point(-5, 9)
        Label3.Name = "Label3"
        Label3.Size = New Size(873, 71)
        Label3.TabIndex = 11
        Label3.Text = "Sign Up For Raphulu Security Self Service"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(179, 208)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 25)
        Label4.TabIndex = 12
        Label4.Text = "Title"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(179, 257)
        Label5.Name = "Label5"
        Label5.Size = New Size(119, 25)
        Label5.TabIndex = 13
        Label5.Text = "Marital Status"
        ' 
        ' ComboBox3
        ' 
        ComboBox3.FormattingEnabled = True
        ComboBox3.Items.AddRange(New Object() {"Single", "Devorced", "Married"})
        ComboBox3.Location = New Point(331, 257)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(182, 33)
        ComboBox3.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Info
        ClientSize = New Size(946, 546)
        Controls.Add(ComboBox3)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(RadioButton3)
        Controls.Add(RadioButton2)
        Controls.Add(RadioButton1)
        Controls.Add(CheckBox2)
        Controls.Add(CheckBox1)
        Controls.Add(btnClickHere)
        Name = "Form1"
        Text = "Self Service"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClickHere As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
End Class
