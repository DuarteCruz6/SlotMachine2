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
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmn2 = New System.Windows.Forms.Timer(Me.components)
        Me.lblCrd = New System.Windows.Forms.Label()
        Me.pctX = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pctX, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.bttJogar.Location = New System.Drawing.Point(25, 299)
        Me.bttJogar.Name = "bttJogar"
        Me.bttJogar.Size = New System.Drawing.Size(123, 74)
        Me.bttJogar.TabIndex = 1
        Me.bttJogar.Text = "JOGAR"
        Me.bttJogar.UseVisualStyleBackColor = True
        '
        'bttSair
        '
        Me.bttSair.Location = New System.Drawing.Point(25, 437)
        Me.bttSair.Name = "bttSair"
        Me.bttSair.Size = New System.Drawing.Size(123, 74)
        Me.bttSair.TabIndex = 3
        Me.bttSair.Text = "SAIR"
        Me.bttSair.UseVisualStyleBackColor = True
        '
        'pct1
        '
        Me.pct1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct1.Location = New System.Drawing.Point(344, 359)
        Me.pct1.Name = "pct1"
        Me.pct1.Size = New System.Drawing.Size(90, 125)
        Me.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct1.TabIndex = 4
        Me.pct1.TabStop = False
        '
        'pct2
        '
        Me.pct2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct2.Location = New System.Drawing.Point(452, 359)
        Me.pct2.Name = "pct2"
        Me.pct2.Size = New System.Drawing.Size(87, 125)
        Me.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pct2.TabIndex = 5
        Me.pct2.TabStop = False
        '
        'pct3
        '
        Me.pct3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pct3.Location = New System.Drawing.Point(556, 359)
        Me.pct3.Name = "pct3"
        Me.pct3.Size = New System.Drawing.Size(90, 125)
        Me.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
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
        'tmn2
        '
        Me.tmn2.Interval = 2000
        '
        'lblCrd
        '
        Me.lblCrd.AutoSize = True
        Me.lblCrd.BackColor = System.Drawing.Color.White
        Me.lblCrd.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCrd.Location = New System.Drawing.Point(26, 587)
        Me.lblCrd.Name = "lblCrd"
        Me.lblCrd.Size = New System.Drawing.Size(122, 37)
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
        'TextBox1
        '
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 100000.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TextBox1.Location = New System.Drawing.Point(-44, -32289)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(891, 65535)
        Me.TextBox1.TabIndex = 40
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 957)
        Me.Controls.Add(Me.pctX)
        Me.Controls.Add(Me.lblCrd)
        Me.Controls.Add(Me.pct3)
        Me.Controls.Add(Me.pct2)
        Me.Controls.Add(Me.pct1)
        Me.Controls.Add(Me.bttSair)
        Me.Controls.Add(Me.bttJogar)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
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
    Friend WithEvents TextBox1 As TextBox
End Class
