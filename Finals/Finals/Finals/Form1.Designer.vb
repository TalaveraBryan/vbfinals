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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Panel1 = New Panel()
        PictureBox1 = New PictureBox()
        Label5 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        Otxt = New Label()
        Xtxt = New Label()
        PlayerO = New Label()
        PlayerX = New Label()
        Newgamebtn = New Button()
        Extbtn = New Button()
        Rsbtn = New Button()
        Panel3 = New Panel()
        btnTik9 = New Button()
        btnTik8 = New Button()
        btnTik7 = New Button()
        btnTik6 = New Button()
        btnTik5 = New Button()
        btnTik4 = New Button()
        btnTik3 = New Button()
        btnTik2 = New Button()
        btnTik1 = New Button()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Navy
        Panel1.BorderStyle = BorderStyle.Fixed3D
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label5)
        Panel1.Location = New Point(12, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1335, 129)
        Panel1.TabIndex = 0
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(3, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(152, 119)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 17
        PictureBox1.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("MS Reference Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.ForeColor = Color.GreenYellow
        Label5.Location = New Point(413, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(407, 79)
        Label5.TabIndex = 16
        Label5.Text = "Tic Tac Toe"
        ' 
        ' Panel2
        ' 
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Panel3)
        Panel2.Location = New Point(12, 147)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1335, 578)
        Panel2.TabIndex = 1
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.ForestGreen
        Panel4.BorderStyle = BorderStyle.Fixed3D
        Panel4.Controls.Add(Otxt)
        Panel4.Controls.Add(Xtxt)
        Panel4.Controls.Add(PlayerO)
        Panel4.Controls.Add(PlayerX)
        Panel4.Controls.Add(Newgamebtn)
        Panel4.Controls.Add(Extbtn)
        Panel4.Controls.Add(Rsbtn)
        Panel4.Location = New Point(660, 3)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(668, 545)
        Panel4.TabIndex = 2
        ' 
        ' Otxt
        ' 
        Otxt.BackColor = Color.WhiteSmoke
        Otxt.BorderStyle = BorderStyle.Fixed3D
        Otxt.Enabled = False
        Otxt.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Otxt.Location = New Point(373, 168)
        Otxt.Name = "Otxt"
        Otxt.Size = New Size(234, 86)
        Otxt.TabIndex = 15
        Otxt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Xtxt
        ' 
        Xtxt.BackColor = Color.WhiteSmoke
        Xtxt.BorderStyle = BorderStyle.Fixed3D
        Xtxt.Enabled = False
        Xtxt.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        Xtxt.Location = New Point(373, 33)
        Xtxt.Name = "Xtxt"
        Xtxt.Size = New Size(234, 86)
        Xtxt.TabIndex = 14
        Xtxt.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PlayerO
        ' 
        PlayerO.AutoSize = True
        PlayerO.Font = New Font("MS Reference Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point)
        PlayerO.Location = New Point(23, 168)
        PlayerO.Name = "PlayerO"
        PlayerO.Size = New Size(343, 79)
        PlayerO.TabIndex = 13
        PlayerO.Text = "Player O:"
        ' 
        ' PlayerX
        ' 
        PlayerX.AutoSize = True
        PlayerX.Font = New Font("MS Reference Sans Serif", 48F, FontStyle.Bold, GraphicsUnit.Point)
        PlayerX.Location = New Point(23, 33)
        PlayerX.Name = "PlayerX"
        PlayerX.Size = New Size(337, 79)
        PlayerX.TabIndex = 12
        PlayerX.Text = "Player X:"
        ' 
        ' Newgamebtn
        ' 
        Newgamebtn.BackColor = Color.WhiteSmoke
        Newgamebtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Newgamebtn.Location = New Point(84, 288)
        Newgamebtn.Name = "Newgamebtn"
        Newgamebtn.Size = New Size(523, 96)
        Newgamebtn.TabIndex = 11
        Newgamebtn.Text = "New game"
        Newgamebtn.UseVisualStyleBackColor = False
        ' 
        ' Extbtn
        ' 
        Extbtn.BackColor = Color.WhiteSmoke
        Extbtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Extbtn.Location = New Point(346, 418)
        Extbtn.Name = "Extbtn"
        Extbtn.Size = New Size(261, 87)
        Extbtn.TabIndex = 10
        Extbtn.Text = "Back"
        Extbtn.UseVisualStyleBackColor = False
        ' 
        ' Rsbtn
        ' 
        Rsbtn.BackColor = Color.WhiteSmoke
        Rsbtn.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point)
        Rsbtn.Location = New Point(84, 417)
        Rsbtn.Name = "Rsbtn"
        Rsbtn.Size = New Size(220, 88)
        Rsbtn.TabIndex = 9
        Rsbtn.Text = "Reset"
        Rsbtn.UseVisualStyleBackColor = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.Black
        Panel3.BorderStyle = BorderStyle.Fixed3D
        Panel3.Controls.Add(btnTik9)
        Panel3.Controls.Add(btnTik8)
        Panel3.Controls.Add(btnTik7)
        Panel3.Controls.Add(btnTik6)
        Panel3.Controls.Add(btnTik5)
        Panel3.Controls.Add(btnTik4)
        Panel3.Controls.Add(btnTik3)
        Panel3.Controls.Add(btnTik2)
        Panel3.Controls.Add(btnTik1)
        Panel3.Location = New Point(12, 3)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(629, 545)
        Panel3.TabIndex = 1
        ' 
        ' btnTik9
        ' 
        btnTik9.BackColor = Color.WhiteSmoke
        btnTik9.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        btnTik9.Location = New Point(415, 363)
        btnTik9.Name = "btnTik9"
        btnTik9.Size = New Size(200, 158)
        btnTik9.TabIndex = 8
        btnTik9.UseVisualStyleBackColor = False
        ' 
        ' btnTik8
        ' 
        btnTik8.BackColor = Color.WhiteSmoke
        btnTik8.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        btnTik8.Location = New Point(209, 363)
        btnTik8.Name = "btnTik8"
        btnTik8.Size = New Size(200, 158)
        btnTik8.TabIndex = 7
        btnTik8.UseVisualStyleBackColor = False
        ' 
        ' btnTik7
        ' 
        btnTik7.BackColor = Color.WhiteSmoke
        btnTik7.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        btnTik7.Location = New Point(3, 363)
        btnTik7.Name = "btnTik7"
        btnTik7.Size = New Size(200, 158)
        btnTik7.TabIndex = 6
        btnTik7.UseVisualStyleBackColor = False
        ' 
        ' btnTik6
        ' 
        btnTik6.BackColor = Color.WhiteSmoke
        btnTik6.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        btnTik6.Location = New Point(415, 186)
        btnTik6.Name = "btnTik6"
        btnTik6.Size = New Size(200, 158)
        btnTik6.TabIndex = 5
        btnTik6.UseVisualStyleBackColor = False
        ' 
        ' btnTik5
        ' 
        btnTik5.BackColor = Color.WhiteSmoke
        btnTik5.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        btnTik5.Location = New Point(209, 186)
        btnTik5.Name = "btnTik5"
        btnTik5.Size = New Size(200, 158)
        btnTik5.TabIndex = 4
        btnTik5.UseVisualStyleBackColor = False
        ' 
        ' btnTik4
        ' 
        btnTik4.BackColor = Color.WhiteSmoke
        btnTik4.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        btnTik4.Location = New Point(3, 186)
        btnTik4.Name = "btnTik4"
        btnTik4.Size = New Size(200, 158)
        btnTik4.TabIndex = 3
        btnTik4.UseVisualStyleBackColor = False
        ' 
        ' btnTik3
        ' 
        btnTik3.BackColor = Color.WhiteSmoke
        btnTik3.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        btnTik3.Location = New Point(415, 13)
        btnTik3.Name = "btnTik3"
        btnTik3.Size = New Size(200, 158)
        btnTik3.TabIndex = 2
        btnTik3.UseVisualStyleBackColor = False
        ' 
        ' btnTik2
        ' 
        btnTik2.BackColor = Color.WhiteSmoke
        btnTik2.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        btnTik2.Location = New Point(209, 13)
        btnTik2.Name = "btnTik2"
        btnTik2.Size = New Size(200, 158)
        btnTik2.TabIndex = 1
        btnTik2.UseVisualStyleBackColor = False
        ' 
        ' btnTik1
        ' 
        btnTik1.BackColor = Color.WhiteSmoke
        btnTik1.Font = New Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point)
        btnTik1.Location = New Point(3, 13)
        btnTik1.Name = "btnTik1"
        btnTik1.Size = New Size(200, 158)
        btnTik1.TabIndex = 0
        btnTik1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.CadetBlue
        ClientSize = New Size(1370, 749)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "TicTacToe"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PlayerX As Label
    Friend WithEvents Newgamebtn As Button
    Friend WithEvents Extbtn As Button
    Friend WithEvents Rsbtn As Button
    Friend WithEvents btnTik9 As Button
    Friend WithEvents btnTik8 As Button
    Friend WithEvents btnTik7 As Button
    Friend WithEvents btnTik6 As Button
    Friend WithEvents btnTik5 As Button
    Friend WithEvents btnTik4 As Button
    Friend WithEvents btnTik3 As Button
    Friend WithEvents btnTik2 As Button
    Friend WithEvents btnTik1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Otxt As Label
    Friend WithEvents Xtxt As Label
    Friend WithEvents PlayerO As Label
    Friend WithEvents PictureBox1 As PictureBox

End Class
