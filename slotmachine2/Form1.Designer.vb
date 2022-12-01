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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bttJogar = New System.Windows.Forms.Button()
        Me.bttSair = New System.Windows.Forms.Button()
        Me.pct1 = New System.Windows.Forms.PictureBox()
        Me.pct2 = New System.Windows.Forms.PictureBox()
        Me.pct3 = New System.Windows.Forms.PictureBox()
        Me.tmn1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.JogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdicionarCréditosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmn2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCrd = New System.Windows.Forms.Label()
        Me.pctX = New System.Windows.Forms.PictureBox()
        Me.bttCrd = New System.Windows.Forms.Button()
        Me.bttRegras = New System.Windows.Forms.Button()
        Me.pctY = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.pctZ = New System.Windows.Forms.PictureBox()
        Me.pctA = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.tmn3 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pctX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctY, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctZ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.slotmachine2.My.Resources.Resources.slot_machine
        Me.PictureBox1.Location = New System.Drawing.Point(234, 158)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(485, 656)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'bttJogar
        '
        Me.bttJogar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttJogar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bttJogar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttJogar.FlatAppearance.BorderSize = 0
        Me.bttJogar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttJogar.ForeColor = System.Drawing.Color.White
        Me.bttJogar.Location = New System.Drawing.Point(344, 572)
        Me.bttJogar.Name = "bttJogar"
        Me.bttJogar.Size = New System.Drawing.Size(102, 37)
        Me.bttJogar.TabIndex = 1
        Me.bttJogar.Text = "JOGAR"
        Me.bttJogar.UseVisualStyleBackColor = False
        '
        'bttSair
        '
        Me.bttSair.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttSair.FlatAppearance.BorderSize = 0
        Me.bttSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttSair.ForeColor = System.Drawing.Color.White
        Me.bttSair.Location = New System.Drawing.Point(539, 572)
        Me.bttSair.Name = "bttSair"
        Me.bttSair.Size = New System.Drawing.Size(107, 37)
        Me.bttSair.TabIndex = 3
        Me.bttSair.Text = "SAIR"
        Me.bttSair.UseVisualStyleBackColor = False
        '
        'pct1
        '
        Me.pct1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct1.Location = New System.Drawing.Point(344, 359)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(90, 125)
        Me.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct1.TabIndex = 4
        Me.pct1.TabStop = False
        '
        'pct2
        '
        Me.pct2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct2.Location = New System.Drawing.Point(452, 359)
        Me.pct2.Name = "pct2"
        Me.pct2.Size = New System.Drawing.Size(87, 125)
        Me.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct2.TabIndex = 5
        Me.pct2.TabStop = False
        '
        'pct3
        '
        Me.pct3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct3.Location = New System.Drawing.Point(556, 359)
        Me.pct3.Name = "pct3"
        Me.pct3.Size = New System.Drawing.Size(90, 125)
        Me.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct3.TabIndex = 6
        Me.pct3.TabStop = False
        '
        'tmn1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogoToolStripMenuItem, Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(802, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
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
        'tmn2
        '
        Me.tmn2.Interval = 2000
        '
        'lblCrd
        '
        Me.lblCrd.AutoSize = True
        Me.lblCrd.BackColor = System.Drawing.Color.Khaki
        Me.lblCrd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCrd.ForeColor = System.Drawing.Color.Black
        Me.lblCrd.Location = New System.Drawing.Point(431, 612)
        Me.lblCrd.Name = "lblCrd"
        Me.lblCrd.Size = New System.Drawing.Size(71, 21)
        Me.lblCrd.TabIndex = 8
        Me.lblCrd.Text = "Créditos:"
        '
        'pctX
        '
        Me.pctX.Image = Global.slotmachine2.My.Resources.Resources.xxx
        Me.pctX.Location = New System.Drawing.Point(288, 728)
        Me.pctX.Name = "pctX"
        Me.pctX.Size = New System.Drawing.Size(414, 86)
        Me.pctX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctX.TabIndex = 10
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
        Me.bttCrd.Location = New System.Drawing.Point(305, 664)
        Me.bttCrd.Name = "bttCrd"
        Me.bttCrd.Size = New System.Drawing.Size(102, 49)
        Me.bttCrd.TabIndex = 41
        Me.bttCrd.Text = "ADICIONAR CRÉDITOS"
        Me.bttCrd.UseVisualStyleBackColor = False
        '
        'bttRegras
        '
        Me.bttRegras.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttRegras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.bttRegras.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bttRegras.FlatAppearance.BorderSize = 0
        Me.bttRegras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bttRegras.ForeColor = System.Drawing.Color.White
        Me.bttRegras.Location = New System.Drawing.Point(580, 664)
        Me.bttRegras.Name = "bttRegras"
        Me.bttRegras.Size = New System.Drawing.Size(102, 49)
        Me.bttRegras.TabIndex = 42
        Me.bttRegras.Text = "REGRAS"
        Me.bttRegras.UseVisualStyleBackColor = False
        '
        'pctY
        '
        Me.pctY.BackColor = System.Drawing.Color.White
        Me.pctY.BackgroundImage = CType(resources.GetObject("pctY.BackgroundImage"), System.Drawing.Image)
        Me.pctY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pctY.Location = New System.Drawing.Point(-686, 271)
        Me.pctY.Name = "pctY"
        Me.pctY.Size = New System.Drawing.Size(1001, 119)
        Me.pctY.TabIndex = 52
        Me.pctY.TabStop = False
        Me.pctY.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 100000.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(-44, -32289)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(891, 65535)
        Me.TextBox1.TabIndex = 40
        '
        'pctZ
        '
        Me.pctZ.BackgroundImage = CType(resources.GetObject("pctZ.BackgroundImage"), System.Drawing.Image)
        Me.pctZ.Location = New System.Drawing.Point(267, 386)
        Me.pctZ.Name = "pctZ"
        Me.pctZ.Size = New System.Drawing.Size(71, 65)
        Me.pctZ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctZ.TabIndex = 53
        Me.pctZ.TabStop = False
        Me.pctZ.Visible = False
        '
        'pctA
        '
        Me.pctA.Image = CType(resources.GetObject("pctA.Image"), System.Drawing.Image)
        Me.pctA.Location = New System.Drawing.Point(321, 299)
        Me.pctA.Name = "pctA"
        Me.pctA.Size = New System.Drawing.Size(17, 91)
        Me.pctA.TabIndex = 54
        Me.pctA.TabStop = False
        Me.pctA.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(305, 280)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(17, 91)
        Me.PictureBox5.TabIndex = 55
        Me.PictureBox5.TabStop = False
        '
        'tmn3
        '
        Me.tmn3.Interval = 750
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(802, 926)
        Me.Controls.Add(Me.pctA)
        Me.Controls.Add(Me.pctZ)
        Me.Controls.Add(Me.pctY)
        Me.Controls.Add(Me.bttRegras)
        Me.Controls.Add(Me.bttCrd)
        Me.Controls.Add(Me.pctX)
        Me.Controls.Add(Me.lblCrd)
        Me.Controls.Add(Me.pct3)
        Me.Controls.Add(Me.pct2)
        Me.Controls.Add(Me.pct1)
        Me.Controls.Add(Me.bttSair)
        Me.Controls.Add(Me.bttJogar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TextBox1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pctX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctY, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctZ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bttJogar As Button
    Friend WithEvents bttSair As Button
    Friend WithEvents pct1 As PictureBox
    Friend WithEvents pct2 As PictureBox
    Friend WithEvents pct3 As PictureBox
    Friend WithEvents tmn1 As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents JogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JogarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SairToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tmn2 As Timer
    Friend WithEvents lblCrd As Label
    Friend WithEvents pctX As PictureBox
    Friend WithEvents AdicionarCréditosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bttCrd As Button
    Friend WithEvents bttRegras As Button
    Friend WithEvents pctY As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents pctZ As PictureBox
    Friend WithEvents pctA As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents tmn3 As Timer
End Class
