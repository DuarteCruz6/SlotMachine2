<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.bttVoltar = New System.Windows.Forms.Button()
        Me.bttFechar = New System.Windows.Forms.Button()
        Me.bttOk = New System.Windows.Forms.Button()
        Me.lblRegras = New System.Windows.Forms.Label()
        Me.menu = New System.Windows.Forms.MenuStrip()
        Me.JogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarCréditosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pct0 = New System.Windows.Forms.PictureBox()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.pct2 = New System.Windows.Forms.PictureBox()
        Me.pct3 = New System.Windows.Forms.PictureBox()
        Me.bttJogar = New System.Windows.Forms.Button()
        Me.bttSair = New System.Windows.Forms.Button()
        Me.lblCrd = New System.Windows.Forms.Label()
        Me.pctX = New System.Windows.Forms.PictureBox()
        Me.bttCrd = New System.Windows.Forms.Button()
        Me.bttRegras = New System.Windows.Forms.Button()
        Me.menu.SuspendLayout()
        CType(Me.pct0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctX, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.JogoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogarToolStripMenuItem, Me.SairToolStripMenuItem, Me.AdicionarCréditosToolStripMenuItem})
        Me.JogoToolStripMenuItem.Name = "JogoToolStripMenuItem"
        Me.JogoToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.JogoToolStripMenuItem.Text = "Jogo"
        '
        'JogarToolStripMenuItem
        '
        Me.JogarToolStripMenuItem.Name = "JogarToolStripMenuItem"
        Me.JogarToolStripMenuItem.ShortcutKeyDisplayString = "F2"
        Me.JogarToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.JogarToolStripMenuItem.Text = "Jogar"
        '
        'SairToolStripMenuItem
        '
        Me.SairToolStripMenuItem.Name = "SairToolStripMenuItem"
        Me.SairToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+F4"
        Me.SairToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SairToolStripMenuItem.Text = "Sair"
        '
        'AdicionarCréditosToolStripMenuItem
        '
        Me.AdicionarCréditosToolStripMenuItem.Name = "AdicionarCréditosToolStripMenuItem"
        Me.AdicionarCréditosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AdicionarCréditosToolStripMenuItem.Text = "Adicionar Créditos"
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
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 100000.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(-25, -60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(891, 65535)
        Me.TextBox1.TabIndex = 39
        '
        'pct0
        '
        Me.pct0.Image = Global.slotmachine2.My.Resources.Resources.slot_machine
        Me.pct0.Location = New System.Drawing.Point(273, 185)
        Me.pct0.Name = "pct0"
        Me.pct0.Size = New System.Drawing.Size(485, 656)
        Me.pct0.TabIndex = 40
        Me.pct0.TabStop = False
        '
        'pct1
        '
        Me.pct1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct1.Location = New System.Drawing.Point(386, 391)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(92, 125)
        Me.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct1.TabIndex = 41
        Me.pct1.TabStop = False
        '
        'pct2
        '
        Me.pct2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct2.Location = New System.Drawing.Point(484, 391)
        Me.pct2.Name = "pct2"
        Me.pct2.Size = New System.Drawing.Size(97, 125)
        Me.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct2.TabIndex = 42
        Me.pct2.TabStop = False
        '
        'pct3
        '
        Me.pct3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct3.Location = New System.Drawing.Point(587, 391)
        Me.pct3.Name = "pct3"
        Me.pct3.Size = New System.Drawing.Size(90, 125)
        Me.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct3.TabIndex = 43
        Me.pct3.TabStop = False
        '
        'bttJogar
        '
        Me.bttJogar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bttJogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttJogar.FlatAppearance.BorderSize = 0
        Me.bttJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttJogar.ForeColor = System.Drawing.Color.White
        Me.bttJogar.Location = New System.Drawing.Point(376, 598)
        Me.bttJogar.Name = "bttJogar"
        Me.bttJogar.Size = New System.Drawing.Size(102, 37)
        Me.bttJogar.TabIndex = 44
        Me.bttJogar.Text = "JOGAR"
        Me.bttJogar.UseVisualStyleBackColor = False
        Me.bttJogar.Visible = False
        '
        'bttSair
        '
        Me.bttSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttSair.FlatAppearance.BorderSize = 0
        Me.bttSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttSair.ForeColor = System.Drawing.Color.White
        Me.bttSair.Location = New System.Drawing.Point(587, 598)
        Me.bttSair.Name = "bttSair"
        Me.bttSair.Size = New System.Drawing.Size(107, 37)
        Me.bttSair.TabIndex = 45
        Me.bttSair.Text = "SAIR"
        Me.bttSair.UseVisualStyleBackColor = False
        Me.bttSair.Visible = False
        '
        'lblCrd
        '
        Me.lblCrd.AutoSize = True
        Me.lblCrd.BackColor = System.Drawing.Color.Khaki
        Me.lblCrd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCrd.ForeColor = System.Drawing.Color.Black
        Me.lblCrd.Location = New System.Drawing.Point(480, 637)
        Me.lblCrd.Name = "lblCrd"
        Me.lblCrd.Size = New System.Drawing.Size(71, 21)
        Me.lblCrd.TabIndex = 46
        Me.lblCrd.Text = "Créditos:"
        Me.lblCrd.Visible = False
        '
        'pctX
        '
        Me.pctX.Image = Global.slotmachine2.My.Resources.Resources.xxx
        Me.pctX.Location = New System.Drawing.Point(326, 755)
        Me.pctX.Name = "pctX"
        Me.pctX.Size = New System.Drawing.Size(414, 86)
        Me.pctX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctX.TabIndex = 47
        Me.pctX.TabStop = False
        '
        'bttCrd
        '
        Me.bttCrd.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttCrd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bttCrd.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttCrd.FlatAppearance.BorderSize = 0
        Me.bttCrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttCrd.ForeColor = System.Drawing.Color.White
        Me.bttCrd.Location = New System.Drawing.Point(350, 691)
        Me.bttCrd.Name = "bttCrd"
        Me.bttCrd.Size = New System.Drawing.Size(102, 49)
        Me.bttCrd.TabIndex = 48
        Me.bttCrd.Text = "ADICIONAR CRÉDITOS"
        Me.bttCrd.UseVisualStyleBackColor = False
        Me.bttCrd.Visible = False
        '
        'bttRegras
        '
        Me.bttRegras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttRegras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bttRegras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttRegras.FlatAppearance.BorderSize = 0
        Me.bttRegras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttRegras.ForeColor = System.Drawing.Color.White
        Me.bttRegras.Location = New System.Drawing.Point(615, 691)
        Me.bttRegras.Name = "bttRegras"
        Me.bttRegras.Size = New System.Drawing.Size(102, 49)
        Me.bttRegras.TabIndex = 49
        Me.bttRegras.Text = "REGRAS"
        Me.bttRegras.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 906)
        Me.Controls.Add(Me.bttRegras)
        Me.Controls.Add(Me.bttCrd)
        Me.Controls.Add(Me.bttVoltar)
        Me.Controls.Add(Me.pctX)
        Me.Controls.Add(Me.lblCrd)
        Me.Controls.Add(Me.bttSair)
        Me.Controls.Add(Me.bttJogar)
        Me.Controls.Add(Me.pct3)
        Me.Controls.Add(Me.pct2)
        Me.Controls.Add(Me.pct1)
        Me.Controls.Add(Me.pct0)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.bttFechar)
        Me.Controls.Add(Me.bttOk)
        Me.Controls.Add(Me.lblRegras)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form2"
        Me.Text = "Slot Machine - Regras"
        Me.menu.ResumeLayout(False)
        Me.menu.PerformLayout()
        CType(Me.pct0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bttVoltar As Button
    Friend WithEvents bttFechar As Button
    Friend WithEvents bttOk As Button
    Friend WithEvents lblRegras As Label
    Friend WithEvents menu As MenuStrip
    Friend WithEvents JogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JogarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pct0 As PictureBox
    Friend WithEvents pct1 As PictureBox
    Friend WithEvents pct2 As PictureBox
    Friend WithEvents pct3 As PictureBox
    Friend WithEvents bttJogar As Button
    Friend WithEvents bttSair As Button
    Friend WithEvents lblCrd As Label
    Friend WithEvents pctX As PictureBox
    Friend WithEvents bttCrd As Button
    Friend WithEvents bttRegras As Button
    Friend WithEvents AdicionarCréditosToolStripMenuItem As ToolStripMenuItem
End Class
