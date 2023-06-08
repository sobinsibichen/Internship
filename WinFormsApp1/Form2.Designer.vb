<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(15, 98)
        Label1.Name = "Label1"
        Label1.Size = New Size(125, 23)
        Label1.TabIndex = 0
        Label1.Text = "Manufacturer:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(41, 196)
        Label2.Name = "Label2"
        Label2.Size = New Size(99, 23)
        Label2.TabIndex = 1
        Label2.Text = "Date Code:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(79, 308)
        Label3.Name = "Label3"
        Label3.Size = New Size(61, 23)
        Label3.TabIndex = 2
        Label3.Text = "ID No:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(346, 98)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 23)
        Label4.TabIndex = 3
        Label4.Text = "Test Stage:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(376, 196)
        Label5.Name = "Label5"
        Label5.Size = New Size(67, 23)
        Label5.TabIndex = 4
        Label5.Text = "Tester :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(355, 308)
        Label6.Name = "Label6"
        Label6.Size = New Size(88, 23)
        Label6.TabIndex = 5
        Label6.Text = "Serial No:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.isro_logo
        PictureBox1.Location = New Point(731, 81)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(168, 186)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.logo_transpace
        PictureBox2.Location = New Point(284, 584)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(344, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 7
        PictureBox2.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(239, 465)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 58)
        Button1.TabIndex = 8
        Button1.Text = "OK"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.Font = New Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(520, 465)
        Button2.Name = "Button2"
        Button2.Size = New Size(145, 58)
        Button2.TabIndex = 9
        Button2.Text = "Cancel"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' ComboBox1
        ' 
        ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"CEL", "KHMD", "VCB", "URSC"})
        ComboBox1.Location = New Point(146, 93)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(194, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' ComboBox2
        ' 
        ComboBox2.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBox2.FormattingEnabled = True
        ComboBox2.Items.AddRange(New Object() {"10%Electrical", "Initial Electrical", "Pre Built-in", "Post Built-in", "Final Electrical", "Pre-Seal", "Post-Seal", "Any Other"})
        ComboBox2.Location = New Point(449, 93)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(244, 28)
        ComboBox2.TabIndex = 11
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(146, 196)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(194, 27)
        TextBox1.TabIndex = 12
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(449, 196)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(244, 27)
        TextBox2.TabIndex = 13
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(146, 304)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(194, 27)
        TextBox3.TabIndex = 14
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(449, 304)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(244, 27)
        TextBox4.TabIndex = 15
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(920, 638)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox2)
        Controls.Add(PictureBox1)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form2"
        Text = "HMC Monogram &Test Details"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
End Class
