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
        Me.bttVoltar = New System.Windows.Forms.Button()
        Me.bttFechar = New System.Windows.Forms.Button()
        Me.bttOk = New System.Windows.Forms.Button()
        Me.lblRegras = New System.Windows.Forms.Label()
        Me.pctX = New System.Windows.Forms.PictureBox()
        Me.lblCrd = New System.Windows.Forms.Label()
        Me.pct3 = New System.Windows.Forms.PictureBox()
        Me.pct2 = New System.Windows.Forms.PictureBox()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.bttSair = New System.Windows.Forms.Button()
        Me.bttJogar = New System.Windows.Forms.Button()
        Me.pct0 = New System.Windows.Forms.PictureBox()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.JogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.pctX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menu.SuspendLayout()
        Me.SuspendLayout()
        '
        'bttVoltar
        '
        Me.bttVoltar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttVoltar.Location = New System.Drawing.Point(724, 133)
        Me.bttVoltar.Name = "bttVoltar"
        Me.bttVoltar.Size = New System.Drawing.Size(117, 72)
        Me.bttVoltar.TabIndex = 29
        Me.bttVoltar.Text = "Voltar ao Jogo"
        Me.bttVoltar.UseVisualStyleBackColor = True
        Me.bttVoltar.Visible = False
        '
        'bttFechar
        '
        Me.bttFechar.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttFechar.Location = New System.Drawing.Point(724, 34)
        Me.bttFechar.Name = "bttFechar"
        Me.bttFechar.Size = New System.Drawing.Size(117, 36)
        Me.bttFechar.TabIndex = 28
        Me.bttFechar.Text = "Vamos!"
        Me.bttFechar.UseVisualStyleBackColor = True
        Me.bttFechar.Visible = False
        '
        'bttOk
        '
        Me.bttOk.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bttOk.Location = New System.Drawing.Point(724, 34)
        Me.bttOk.Name = "bttOk"
        Me.bttOk.Size = New System.Drawing.Size(117, 36)
        Me.bttOk.TabIndex = 27
        Me.bttOk.Text = "PRÓXIMO"
        Me.bttOk.UseVisualStyleBackColor = True
        '
        'lblRegras
        '
        Me.lblRegras.AutoSize = True
        Me.lblRegras.BackColor = System.Drawing.Color.White
        Me.lblRegras.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRegras.Location = New System.Drawing.Point(48, 38)
        Me.lblRegras.MaximumSize = New System.Drawing.Size(549, 90)
        Me.lblRegras.Name = "lblRegras"
        Me.lblRegras.Size = New System.Drawing.Size(316, 28)
        Me.lblRegras.TabIndex = 19
        Me.lblRegras.Text = "As regras do jogo são as seguintes:"
        '
        'pctX
        '
        Me.pctX.Image = Global.slotmachine2.My.Resources.Resources.xxx
        Me.pctX.Location = New System.Drawing.Point(284, 782)
        Me.pctX.Name = "pctX"
        Me.pctX.Size = New System.Drawing.Size(414, 86)
        Me.pctX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctX.TabIndex = 37
        Me.pctX.TabStop = False
        Me.pctX.Visible = False
        '
        'lblCrd
        '
        Me.lblCrd.AutoSize = True
        Me.lblCrd.BackColor = System.Drawing.Color.White
        Me.lblCrd.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCrd.Location = New System.Drawing.Point(29, 566)
        Me.lblCrd.Name = "lblCrd"
        Me.lblCrd.Size = New System.Drawing.Size(122, 37)
        Me.lblCrd.TabIndex = 36
        Me.lblCrd.Text = "Créditos:"
        Me.lblCrd.Visible = False
        '
        'pct3
        '
        Me.pct3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct3.Location = New System.Drawing.Point(559, 410)
        Me.pct3.Name = "pct3"
        Me.pct3.Size = New System.Drawing.Size(90, 125)
        Me.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct3.TabIndex = 35
        Me.pct3.TabStop = False
        Me.pct3.Visible = False
        '
        'pct2
        '
        Me.pct2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct2.Location = New System.Drawing.Point(455, 410)
        Me.pct2.Name = "pct2"
        Me.pct2.Size = New System.Drawing.Size(87, 125)
        Me.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct2.TabIndex = 34
        Me.pct2.TabStop = False
        Me.pct2.Visible = False
        '
        'pct1
        '
        Me.pct1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct1.Location = New System.Drawing.Point(350, 410)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(90, 125)
        Me.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct1.TabIndex = 33
        Me.pct1.TabStop = False
        Me.pct1.Visible = False
        '
        'bttSair
        '
        Me.bttSair.Location = New System.Drawing.Point(28, 432)
        Me.bttSair.Name = "bttSair"
        Me.bttSair.Size = New System.Drawing.Size(123, 74)
        Me.bttSair.TabIndex = 32
        Me.bttSair.Text = "SAIR"
        Me.bttSair.UseVisualStyleBackColor = True
        Me.bttSair.Visible = False
        '
        'bttJogar
        '
        Me.bttJogar.Location = New System.Drawing.Point(28, 293)
        Me.bttJogar.Name = "bttJogar"
        Me.bttJogar.Size = New System.Drawing.Size(123, 74)
        Me.bttJogar.TabIndex = 31
        Me.bttJogar.Text = "JOGAR"
        Me.bttJogar.UseVisualStyleBackColor = True
        Me.bttJogar.Visible = False
        '
        'pct0
        '
        Me.pct0.Image = Global.slotmachine2.My.Resources.Resources.slot_machine
        Me.pct0.Location = New System.Drawing.Point(236, 212)
        Me.pct0.Name = "pct0"
        Me.pct0.Size = New System.Drawing.Size(485, 656)
        Me.pct0.TabIndex = 30
        Me.pct0.TabStop = False
        Me.pct0.Visible = False
        '
        'menu
        '
        Me.menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogoToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.menu.Location = New System.Drawing.Point(0, 0)
        Me.menu.Name = "menu"
        Me.menu.Size = New System.Drawing.Size(866, 24)
        Me.menu.TabIndex = 38
        Me.menu.Text = "menu"
        '
        'JogoToolStripMenuItem
        '
        Me.JogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogarToolStripMenuItem, Me.SairToolStripMenuItem})
        Me.JogoToolStripMenuItem.Name = "JogoToolStripMenuItem"
        Me.JogoToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.JogoToolStripMenuItem.Text = "Jogo"
        '
        'JogarToolStripMenuItem
        '
        Me.JogarToolStripMenuItem.Name = "JogarToolStripMenuItem"
        Me.JogarToolStripMenuItem.ShortcutKeyDisplayString = "F2"
        Me.JogarToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.JogarToolStripMenuItem.Text = "Jogar"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F4"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÍndiceToolStripMenuItem, Me.AcercaToolStripMenuItem})
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AjudaToolStripMenuItem.Text = "Ajuda"
        '
        'ÍndiceToolStripMenuItem
        '
        Me.ÍndiceToolStripMenuItem.Name = "ÍndiceToolStripMenuItem"
        Me.ÍndiceToolStripMenuItem.ShortcutKeyDisplayString = "F1"
        Me.ÍndiceToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ÍndiceToolStripMenuItem.Text = "Índice"
        '
        'AcercaToolStripMenuItem
        '
        Me.AcercaToolStripMenuItem.Name = "AcercaToolStripMenuItem"
        Me.AcercaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.AcercaToolStripMenuItem.Text = "Acerca"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 100000.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(-25, -60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(891, 65535)
        Me.TextBox1.TabIndex = 39
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 906)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.pctX)
        Me.Controls.Add(Me.lblCrd)
        Me.Controls.Add(Me.pct3)
        Me.Controls.Add(Me.pct2)
        Me.Controls.Add(Me.pct1)
        Me.Controls.Add(Me.bttSair)
        Me.Controls.Add(Me.bttJogar)
        Me.Controls.Add(Me.bttVoltar)
        Me.Controls.Add(Me.bttFechar)
        Me.Controls.Add(Me.bttOk)
        Me.Controls.Add(Me.lblRegras)
        Me.Controls.Add(Me.pct0)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.pctX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttVoltar As Button
    Friend WithEvents bttFechar As Button
    Friend WithEvents bttOk As Button
    Friend WithEvents lblRegras As Label
    Friend WithEvents pctX As PictureBox
    Friend WithEvents lblCrd As Label
    Friend WithEvents pct3 As PictureBox
    Friend WithEvents pct2 As PictureBox
    Friend WithEvents pct1 As PictureBox
    Friend WithEvents bttSair As Button
    Friend WithEvents bttJogar As Button
    Friend WithEvents pct0 As PictureBox
    Friend WithEvents menu As MenuStrip
    Friend WithEvents JogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JogarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
End Class
