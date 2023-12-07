
Public Class Form1
    Dim checker As Boolean
    Dim plusone As Integer

    Private Sub enable_false()
        btnTik1.Enabled = False
        btnTik2.Enabled = False
        btnTik3.Enabled = False
        btnTik4.Enabled = False
        btnTik5.Enabled = False
        btnTik6.Enabled = False
        btnTik7.Enabled = False
        btnTik8.Enabled = False
        btnTik9.Enabled = False

    End Sub
    Private Function CheckForWinner() As Boolean
        ' Example logic - replace this with your actual win condition checks
        ' This example assumes the game is won when a player fills three buttons in a row

        ' Horizontal checks
        If btnTik1.Text <> "" AndAlso btnTik1.Text = btnTik2.Text AndAlso btnTik1.Text = btnTik3.Text Then
            Return True ' A player won
        ElseIf btnTik4.Text <> "" AndAlso btnTik4.Text = btnTik5.Text AndAlso btnTik4.Text = btnTik6.Text Then
            Return True ' A player won
        ElseIf btnTik7.Text <> "" AndAlso btnTik7.Text = btnTik8.Text AndAlso btnTik7.Text = btnTik9.Text Then
            Return True ' A player won
        End If

        ' Vertical checks
        If btnTik1.Text <> "" AndAlso btnTik1.Text = btnTik4.Text AndAlso btnTik1.Text = btnTik7.Text Then
            Return True ' A player won
        ElseIf btnTik2.Text <> "" AndAlso btnTik2.Text = btnTik5.Text AndAlso btnTik2.Text = btnTik8.Text Then
            Return True ' A player won
        ElseIf btnTik3.Text <> "" AndAlso btnTik3.Text = btnTik6.Text AndAlso btnTik3.Text = btnTik9.Text Then
            Return True ' A player won
        End If

        ' Diagonal checks
        If btnTik1.Text <> "" AndAlso btnTik1.Text = btnTik5.Text AndAlso btnTik1.Text = btnTik9.Text Then
            Return True ' A player won
        ElseIf btnTik3.Text <> "" AndAlso btnTik3.Text = btnTik5.Text AndAlso btnTik3.Text = btnTik7.Text Then
            Return True ' A player won
        End If

        Return False ' No winner yet
    End Function
    Private Sub TieCheck()
        ' Check if the game is a tie
        If Not CheckForWinner() AndAlso btnTik1.Text <> "" AndAlso btnTik2.Text <> "" AndAlso btnTik3.Text <> "" AndAlso
       btnTik4.Text <> "" AndAlso btnTik5.Text <> "" AndAlso btnTik6.Text <> "" AndAlso
       btnTik7.Text <> "" AndAlso btnTik8.Text <> "" AndAlso btnTik9.Text <> "" Then
            MessageBox.Show("It's a tie!", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            enable_false() ' Disable buttons to prevent further moves
        End If
    End Sub

    Private Sub enable_true()
        btnTik1.Enabled = True
        btnTik2.Enabled = True
        btnTik3.Enabled = True
        btnTik4.Enabled = True
        btnTik5.Enabled = True
        btnTik6.Enabled = True
        btnTik7.Enabled = True
        btnTik8.Enabled = True
        btnTik9.Enabled = True
    End Sub

    Private Sub btn(sender As Object, e As EventArgs)
        'If btnTik1.Text = "X" Then
        'End If
        'btnTik2.Text = "X"
        'btnTik3.Text = "X"
        'btnTik4.Text = "X"
        'btnTik5.Text = "X"
        'btnTik6.Text = "X"
        'btnTik7.Text = "X"
        'btnTik8.Text = "X"
        'btnTik9.Text = "X"

    End Sub

    Private Sub score()
        If (btnTik1.Text = "X" And btnTik2.Text = "X" And btnTik3.Text = "X") Then

            btnTik1.BackColor = Color.Aqua
            btnTik2.BackColor = Color.Aqua
            btnTik3.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            enable_false()


        End If

        If (btnTik1.Text = "X" And btnTik4.Text = "X" And btnTik7.Text = "X") Then

            btnTik1.BackColor = Color.Aqua
            btnTik4.BackColor = Color.Aqua
            btnTik7.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        If (btnTik1.Text = "X" And btnTik5.Text = "X" And btnTik9.Text = "X") Then

            btnTik1.BackColor = Color.Aqua
            btnTik5.BackColor = Color.Aqua
            btnTik9.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If

        If (btnTik3.Text = "X" And btnTik5.Text = "X" And btnTik7.Text = "X") Then

            btnTik3.BackColor = Color.Aqua
            btnTik5.BackColor = Color.Aqua
            btnTik7.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        If (btnTik3.Text = "X" And btnTik6.Text = "X" And btnTik9.Text = "X") Then

            btnTik3.BackColor = Color.Aqua
            btnTik6.BackColor = Color.Aqua
            btnTik9.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If

        If (btnTik2.Text = "X" And btnTik5.Text = "X" And btnTik8.Text = "X") Then

            btnTik2.BackColor = Color.Aqua
            btnTik5.BackColor = Color.Aqua
            btnTik8.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        If (btnTik4.Text = "X" And btnTik5.Text = "X" And btnTik6.Text = "X") Then

            btnTik4.BackColor = Color.Aqua
            btnTik5.BackColor = Color.Aqua
            btnTik6.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If

        If (btnTik7.Text = "X" And btnTik8.Text = "X" And btnTik9.Text = "X") Then

            btnTik7.BackColor = Color.Aqua
            btnTik8.BackColor = Color.Aqua
            btnTik9.BackColor = Color.Aqua
            MessageBox.Show("Player X won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Xtxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If


        '====================================================================================================='
        If (btnTik1.Text = "O" And btnTik2.Text = "O" And btnTik3.Text = "O") Then

            btnTik1.BackColor = Color.Red
            btnTik2.BackColor = Color.Red
            btnTik3.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If

        If (btnTik1.Text = "O" And btnTik4.Text = "O" And btnTik7.Text = "O") Then

            btnTik1.BackColor = Color.Red
            btnTik4.BackColor = Color.Red
            btnTik7.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        If (btnTik1.Text = "O" And btnTik5.Text = "O" And btnTik9.Text = "O") Then

            btnTik1.BackColor = Color.Red
            btnTik5.BackColor = Color.Red
            btnTik9.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If

        If (btnTik3.Text = "O" And btnTik5.Text = "O" And btnTik7.Text = "O") Then

            btnTik3.BackColor = Color.Red
            btnTik5.BackColor = Color.Red
            btnTik7.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        If (btnTik3.Text = "O" And btnTik6.Text = "O" And btnTik9.Text = "O") Then

            btnTik3.BackColor = Color.Red
            btnTik6.BackColor = Color.Red
            btnTik9.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If

        If (btnTik2.Text = "O" And btnTik5.Text = "O" And btnTik8.Text = "O") Then

            btnTik2.BackColor = Color.Red
            btnTik5.BackColor = Color.Red
            btnTik8.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If
        If (btnTik4.Text = "O" And btnTik5.Text = "O" And btnTik6.Text = "O") Then

            btnTik4.BackColor = Color.Red
            btnTik5.BackColor = Color.Red
            btnTik6.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Xtxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If

        If (btnTik7.Text = "O" And btnTik8.Text = "O" And btnTik9.Text = "O") Then

            btnTik7.BackColor = Color.Red
            btnTik8.BackColor = Color.Red
            btnTik9.BackColor = Color.Red
            MessageBox.Show("Player O won", "TicTacToe", MessageBoxButtons.OK, MessageBoxIcon.Information)
            plusone = Convert.ToInt64(Otxt.Text)
            Otxt.Text = Convert.ToString(plusone + 1)
            enable_false()
        End If





    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        enable_false()
        checker = False ' Ensure Player X starts the game


    End Sub



    Private Sub btnTik1_Click(sender As Object, e As EventArgs) Handles btnTik1.Click
        If (checker = False) Then
            btnTik1.Text = "X"
            btnTik1.Enabled = False
            checker = True
            score()

        Else
            btnTik1.Text = "O"
            checker = False
            score()
            btnTik1.Enabled = False

        End If

        TieCheck()

    End Sub

    Private Sub btnTik2_Click(sender As Object, e As EventArgs) Handles btnTik2.Click
        If (checker = False) Then
            btnTik2.Text = "X"
            btnTik2.Enabled = False
            checker = True
            score()
        Else
            btnTik2.Text = "O"
            checker = False
            score()
            btnTik2.Enabled = False
        End If

        TieCheck()

    End Sub

    Private Sub btnTik3_Click(sender As Object, e As EventArgs) Handles btnTik3.Click
        If (checker = False) Then
            btnTik3.Text = "X"
            btnTik3.Enabled = False
            checker = True
            score()
        Else
            btnTik3.Text = "O"
            checker = False
            score()
            btnTik3.Enabled = False
        End If

        TieCheck()

    End Sub

    Private Sub btnTik4_Click(sender As Object, e As EventArgs) Handles btnTik4.Click
        If (checker = False) Then
            btnTik4.Text = "X"
            btnTik4.Enabled = False
            checker = True
            score()
        Else
            btnTik4.Text = "O"
            checker = False
            score()
            btnTik4.Enabled = False
        End If

        TieCheck()

    End Sub

    Private Sub btnTik5_Click(sender As Object, e As EventArgs) Handles btnTik5.Click
        If (checker = False) Then
            btnTik5.Text = "X"
            btnTik5.Enabled = False
            checker = True
            score()
        Else
            btnTik5.Text = "O"
            checker = False
            score()
            btnTik5.Enabled = False
        End If

        TieCheck()

    End Sub

    Private Sub btnTik6_Click(sender As Object, e As EventArgs) Handles btnTik6.Click
        If (checker = False) Then
            btnTik6.Text = "X"
            btnTik6.Enabled = False
            checker = True
            score()
        Else
            btnTik6.Text = "O"
            checker = False
            score()
            btnTik6.Enabled = False
        End If

        TieCheck()

    End Sub

    Private Sub btnTik7_Click(sender As Object, e As EventArgs) Handles btnTik7.Click
        If (checker = False) Then
            btnTik7.Text = "X"
            btnTik7.Enabled = False
            checker = True
            score()
        Else
            btnTik7.Text = "O"
            checker = False
            score()
            btnTik7.Enabled = False
        End If

        TieCheck()

    End Sub

    Private Sub btnTik8_Click(sender As Object, e As EventArgs) Handles btnTik8.Click
        If (checker = False) Then
            btnTik8.Text = "X"
            btnTik8.Enabled = False
            checker = True
            score()
        Else
            btnTik8.Text = "O"
            checker = False
            score()
            btnTik8.Enabled = False
        End If

        TieCheck()

    End Sub

    Private Sub btnTik9_Click(sender As Object, e As EventArgs) Handles btnTik9.Click
        If (checker = False) Then
            btnTik9.Text = "X"
            btnTik9.Enabled = False
            checker = True
            score()
        Else
            btnTik9.Text = "O"
            checker = False
            score()
            btnTik9.Enabled = False
        End If

        TieCheck()

    End Sub



    Private Sub Newgamebtn_Click(sender As Object, e As EventArgs) Handles Newgamebtn.Click

        btnTik1.Text = ""
        btnTik1.BackColor = Color.WhiteSmoke
        btnTik2.Text = ""
        btnTik2.BackColor = Color.WhiteSmoke
        btnTik3.Text = ""
        btnTik3.BackColor = Color.WhiteSmoke
        btnTik4.Text = ""
        btnTik4.BackColor = Color.WhiteSmoke
        btnTik5.Text = ""
        btnTik5.BackColor = Color.WhiteSmoke
        btnTik6.Text = ""
        btnTik6.BackColor = Color.WhiteSmoke
        btnTik7.Text = ""
        btnTik7.BackColor = Color.WhiteSmoke
        btnTik8.Text = ""
        btnTik8.BackColor = Color.WhiteSmoke
        btnTik9.Text = ""
        btnTik9.BackColor = Color.WhiteSmoke

        Xtxt.Text = "0"
        Otxt.Text = "0"
        enable_true()
        'For Each ctrl As Control In Me.Controls
        '    If TypeOf ctrl Is Button Then
        '        Dim btn As Button = DirectCast(ctrl, Button)
        '        btn.Text = "" ' Clear the text of each button
        '    End If
        'Next

        'Xtxt.Text = "0"
        'Otxt.Text = "0"

        'For Each i As Control In Me.Controls
        '    If TypeOf i Is Button Then
        '        Dim btn As Button = DirectCast(i, Button)
        '        btn.BackColor = Color.WhiteSmoke ' Change the back color to Red (you can use any color)
        '    End If
        'Next


    End Sub

    Private Sub Rsbtn_Click(sender As Object, e As EventArgs) Handles Rsbtn.Click

        'btn()

        checker = False

        btnTik1.Enabled = True
        btnTik2.Enabled = True
        btnTik3.Enabled = True
        btnTik4.Enabled = True
        btnTik5.Enabled = True
        btnTik6.Enabled = True
        btnTik7.Enabled = True
        btnTik8.Enabled = True
        btnTik9.Enabled = True

        btnTik1.Text = ""
        btnTik1.BackColor = Color.WhiteSmoke
        btnTik2.Text = ""
        btnTik2.BackColor = Color.WhiteSmoke
        btnTik3.Text = ""
        btnTik3.BackColor = Color.WhiteSmoke
        btnTik4.Text = ""
        btnTik4.BackColor = Color.WhiteSmoke
        btnTik5.Text = ""
        btnTik5.BackColor = Color.WhiteSmoke
        btnTik6.Text = ""
        btnTik6.BackColor = Color.WhiteSmoke
        btnTik7.Text = ""
        btnTik7.BackColor = Color.WhiteSmoke
        btnTik8.Text = ""
        btnTik8.BackColor = Color.WhiteSmoke
        btnTik9.Text = ""
        btnTik9.BackColor = Color.WhiteSmoke

        'For Each ctrl As Control In Me.Controls
        '    If TypeOf ctrl Is Button Then
        '        Dim btn As Button = DirectCast(ctrl, Button)
        '        btn.Text = "" ' Clear the text of each button
        '    End If
        'Next
        'Newgamebtn.Enabled = True

        'For Each i As Control In Me.Controls
        '    If TypeOf i Is Button Then
        '        Dim btn As Button = DirectCast(i, Button)
        '        btn.BackColor = Color.WhiteSmoke ' Change the back color to Red (you can use any color)
        '    End If
        'Next

    End Sub

    Private Function btn() As Integer
        Throw New NotImplementedException()
    End Function

    Private Sub Extbtn_Click(sender As Object, e As EventArgs) Handles Extbtn.Click
        Form2.Show()
        Me.Hide()
        'Dim iExit As DialogResult


        'iExit = MessageBox.Show("Confirm if you want to exit", "TicTacToe", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        'If iExit = DialogResult.Yes Then
        '    Application.Exit()
        'End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub
End Class
