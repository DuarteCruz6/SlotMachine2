
Imports System.Reflection.Metadata.Ecma335

Public Class Form1
    Dim crd, i, j, b As Double
    Dim n1, n2, n3 As Integer
    Dim r, path, a As String
    Private Sub tmn1_Tick(sender As Object, e As EventArgs) Handles tmn1.Tick
        Randomize()
        If i = 0 Then
            n1 = Int(Rnd() * 10)
            pct1.Image = Image.FromFile(path & Trim(Str(n1) & ".png"))
            n2 = Int(Rnd() * 10)
            pct2.Image = Image.FromFile(path & Trim(Str(n2) & ".png"))
            n3 = Int(Rnd() * 10)
            pct3.Image = Image.FromFile(path & Trim(Str(n3) & ".png"))
        ElseIf i = 1 Then
            n2 = Int(Rnd() * 10)
            pct2.Image = Image.FromFile(path & Trim(Str(n2) & ".png"))
            n3 = Int(Rnd() * 10)
            pct3.Image = Image.FromFile(path & Trim(Str(n3) & ".png"))
        ElseIf i = 2 Then
            n3 = Int(Rnd() * 10)
            pct3.Image = Image.FromFile(path & Trim(Str(n3) & ".png"))
        End If
    End Sub

    Private Sub JogarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JogarToolStripMenuItem.Click
        bttJogar.PerformClick()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        bttSair.PerformClick()
    End Sub

    Private Sub ÍndiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÍndiceToolStripMenuItem.Click
        bttRegras.PerformClick()
    End Sub

    Private Sub AcercaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaToolStripMenuItem.Click
        MsgBox("Créditos: Duarte Cruz 12T4", vbInformation + vbOKOnly, "CRÉDITOS")
    End Sub

    Private Sub AdicionarCréditosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdicionarCréditosToolStripMenuItem.Click
        bttCrd.PerformClick()
    End Sub

    Private Sub bttRegras_Click(sender As Object, e As EventArgs) Handles bttRegras.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub tmn3_Tick(sender As Object, e As EventArgs) Handles tmn3.Tick
        tmn3.Enabled = False
        pctY.Visible = False
        pctZ.Visible = False
        pctA.Visible = False
    End Sub

    Private Sub bttCrd_Click(sender As Object, e As EventArgs) Handles bttCrd.Click
        a = InputBox("Quantos créditos deseja adicionar? (5 Euros = 500 Créditos)", "ADICIONAR CRÉDITOS", 1000)
        If a <> "" Then
            b = a
            r = MsgBox("Irá custar-lhe " & Int(a) / 100 & " euros. Pretende continuar?", vbYesNo + vbInformation, "CUSTO")
            If r = vbYes Then
                crd += Int(a)
                lblCrd.Text = "Créditos: " & crd
                bttJogar.Enabled = True
            Else
                If crd = 0 Then
                    MsgBox("Sem problemas! Infelizmente, assim, não poderá jogar novamente. Até à próxima!", vbInformation)
                End If
            End If
        End If
    End Sub

    Private Sub tmn2_Tick(sender As Object, e As EventArgs) Handles tmn2.Tick
        i += 1
        If i = 3 Then
            tmn1.Enabled = False
            tmn2.Enabled = False
            bttJogar.Enabled = True
            If n1 = 7 And n2 = 7 And n3 = 7 Then
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
                pctX.Visible = False
                MsgBox("PARABÉNS, VOCÊ GANHOU 100000 CRÉDITOS!", vbInformation + vbOKOnly, "Prémio")
                crd += 10000
                lblCrd.Text = "Créditos: " + Str(crd)

            ElseIf (n1 = 7 And n2 = 7) Or (n1 = 7 And n3 = 7) Or (n2 = 7 And n3 = 7) Then
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
                pctX.Visible = False
                MsgBox("PARABÉNS, VOCÊ GANHOU 2000 CRÉDITOS!", vbInformation + vbOKOnly, "Prémio")
                crd += 2000
                lblCrd.Text = "Créditos: " + Str(crd)

            ElseIf n1 = 7 Or n2 = 7 Or n3 = 7 Then
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
                pctX.Visible = False
                MsgBox("PARABÉNS, VOCÊ GANHOU 1000 CRÉDITOS!", vbInformation + vbOKOnly, "Prémio")
                crd += 1000
                lblCrd.Text = "Créditos: " + Str(crd)

            Else
                MsgBox("Infelizmente não ganhou :(", vbInformation + vbOKOnly, "Prémio")
            End If
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        crd = 5000
        lblCrd.Text = lblCrd.Text + Str(crd)
        i = 0
        path = Application.StartupPath & "fotos\"
    End Sub


    Private Sub bttSair_Click(sender As Object, e As EventArgs) Handles bttSair.Click
        r = MsgBox("Deseja fechar a Slot Machine?", vbQuestion + vbYesNo, "ENCERRAR")
        If r = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub bttJogar_Click(sender As Object, e As EventArgs) Handles bttJogar.Click
        bttJogar.Enabled = False
        pctX.Visible = True
        pctZ.Visible = True
        pctY.Visible = True
        pctA.Visible = True
        i = 0
        If crd = 0 Then
            MsgBox("Por favor insira créditos", vbCritical + vbOKOnly, "ATENÇÃO")
        Else
            tmn1.Enabled = True
            tmn2.Enabled = True
            tmn3.Enabled = True
            crd -= 500
        End If
        lblCrd.Text = "Créditos: " + Str(crd)
    End Sub

End Class


