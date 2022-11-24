Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Dim i As Integer
    Dim r, path As String
    Private Sub bttOk_Click(sender As Object, e As EventArgs) Handles bttOk.Click
        If i = 0 Then
            bttJogar.Visible = True
            lblRegras.Text = "Primeiramente, terá de clicar no botão ´Jogar´ para iniciar o seu jogo."
            i += 1

        ElseIf i = 1 Then
            pct0.Visible = True
            pct1.Visible = True
            pct2.Visible = True
            pct3.Visible = True
            pctX.Visible = True
            i += 1
            lblRegras.Text = "Após clicar no botão, os 3 espaços irão mudar de símbolos aleatoriamente, até que vão todos parando, sucessivamente. O botão ´Jogar´ estará desativado enquanto isto acontece."

        ElseIf i = 2 Then
            lblRegras.Text = "O objetivo do jogo é a obtenção do número 7."
            i += 1

        ElseIf i = 3 Then
            lblRegras.Text = "Caso consiga um 7, irá ganhar 1000 créditos."
            pct1.Image = Image.FromFile(path & "7.jpg")
            i += 1

        ElseIf i = 4 Then
            lblRegras.Text = "Caso consiga dois 7, irá ganhar 2000 créditos."
            pct1.Image = Image.FromFile(path & "7.jpg")
            pct2.Image = Image.FromFile(path & "7.jpg")
            i += 1

        ElseIf i = 5 Then
            lblRegras.Text = "Caso consiga três 7, irá ganhar o prémio máximo de 10000 créditos."
            pct1.Image = Image.FromFile(path & "7.jpg")
            pct2.Image = Image.FromFile(path & "7.jpg")
            pct3.Image = Image.FromFile(path & "7.jpg")
            i += 1

        ElseIf i = 6 Then
            i += 1
            lblRegras.Text = "Sempre que conseguir ganhar um prémio, irá ouvir o som que acabou de ouvir e irá ver a imagem apresentada."
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
            pctX.Visible = False

        ElseIf i = 7 Then
            lblCrd.Visible = True
            i += 1
            lblRegras.Text = "O seu número total de créditos aparecerá no local denominado para tal. Irá iniciar com 5000 créditos, sendo que cada jogo gastará 500."
            lblCrd.Text &= " 5000"

        ElseIf i = 8 Then
            lblRegras.Text = "Quando alcançar os 0 créditos, não conseguirá jogar novamente."
            lblCrd.Text = "Créditos: 0"
            i += 1

        ElseIf i = 9 Then
            bttSair.Visible = True
            i += 1
            lblRegras.Text = "Terá também um botão ´Sair´ que fechará a Slot Machine quando você pretender."

        ElseIf i = 10 Then
            menu.Visible = True
            lblRegras.Text = "Por fim, tem também um menu com os botões ´Jogar´, ´Sair´, ´Ajuda´ e ´Índice´, que poderá aceder a qualquer momento."
            i += 1
        Else
            bttOk.Visible = False
            bttFechar.Visible = True
            bttVoltar.Visible = False
            lblRegras.Text = "Vamos experimentar!"
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 0
        path = Application.StartupPath & "fotos\"
    End Sub

    Private Sub bttFechar_Click(sender As Object, e As EventArgs) Handles bttFechar.Click
        Me.Close()
        Form1.Show()
    End Sub


    Private Sub bttVoltar_Click(sender As Object, e As EventArgs) Handles bttVoltar.Click
        r = MsgBox("Deseja voltar ao jogo?", vbQuestion + vbYesNo, "VOLTAR")
        If r = vbYes Then
            Me.Close()
            Form1.Show()
        End If
    End Sub
End Class