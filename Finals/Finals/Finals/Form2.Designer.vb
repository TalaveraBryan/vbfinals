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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(-4, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(497, 341)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightSkyBlue
        Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), Image)
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Modern No. 20", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.ImageAlign = ContentAlignment.BottomLeft
        Button1.Location = New Point(24, 91)
        Button1.Name = "Button1"
        Button1.Size = New Size(102, 55)
        Button1.TabIndex = 1
        Button1.Text = "Play Game"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.AutoSize = True
        Button2.BackColor = Color.LightSkyBlue
        Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), Image)
        Button2.FlatStyle = FlatStyle.Popup
        Button2.Font = New Font("Modern No. 20", 21.7499981F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.ForeColor = Color.White
        Button2.Location = New Point(24, 164)
        Button2.Name = "Button2"
        Button2.Size = New Size(102, 55)
        Button2.TabIndex = 2
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(489, 341)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "PlayTicTacToe"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
