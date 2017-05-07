<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Linear
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Linear))
        Me.windowButton = New System.Windows.Forms.Button()
        Me.plotButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bBox = New System.Windows.Forms.TextBox()
        Me.aBox = New System.Windows.Forms.TextBox()
        Me.yMaxbox = New System.Windows.Forms.TextBox()
        Me.yMinbox = New System.Windows.Forms.TextBox()
        Me.xMaxbox = New System.Windows.Forms.TextBox()
        Me.xMinbox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FunctionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dBox = New System.Windows.Forms.TextBox()
        Me.cBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'windowButton
        '
        Me.windowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.windowButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.windowButton.Location = New System.Drawing.Point(356, 644)
        Me.windowButton.Name = "windowButton"
        Me.windowButton.Size = New System.Drawing.Size(80, 32)
        Me.windowButton.TabIndex = 0
        Me.windowButton.Text = "set Window"
        Me.windowButton.UseVisualStyleBackColor = True
        '
        'plotButton
        '
        Me.plotButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.plotButton.Location = New System.Drawing.Point(1172, 644)
        Me.plotButton.Name = "plotButton"
        Me.plotButton.Size = New System.Drawing.Size(80, 32)
        Me.plotButton.TabIndex = 1
        Me.plotButton.Text = "Plot"
        Me.plotButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 657)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "xMin"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 657)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "yMin"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(94, 657)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "xMax"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(271, 657)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "yMax"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(843, 657)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "y="
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1008, 657)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "(x -"
        '
        'bBox
        '
        Me.bBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bBox.BackColor = System.Drawing.SystemColors.Menu
        Me.bBox.Location = New System.Drawing.Point(952, 654)
        Me.bBox.Name = "bBox"
        Me.bBox.Size = New System.Drawing.Size(50, 20)
        Me.bBox.TabIndex = 8
        Me.bBox.Text = "b"
        '
        'aBox
        '
        Me.aBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aBox.BackColor = System.Drawing.SystemColors.Menu
        Me.aBox.Location = New System.Drawing.Point(867, 654)
        Me.aBox.Name = "aBox"
        Me.aBox.Size = New System.Drawing.Size(50, 20)
        Me.aBox.TabIndex = 9
        Me.aBox.Text = "a"
        '
        'yMaxbox
        '
        Me.yMaxbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.yMaxbox.BackColor = System.Drawing.SystemColors.Menu
        Me.yMaxbox.Location = New System.Drawing.Point(300, 654)
        Me.yMaxbox.Name = "yMaxbox"
        Me.yMaxbox.Size = New System.Drawing.Size(50, 20)
        Me.yMaxbox.TabIndex = 10
        Me.yMaxbox.Text = "10"
        '
        'yMinbox
        '
        Me.yMinbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.yMinbox.BackColor = System.Drawing.SystemColors.Menu
        Me.yMinbox.Location = New System.Drawing.Point(215, 654)
        Me.yMinbox.Name = "yMinbox"
        Me.yMinbox.Size = New System.Drawing.Size(50, 20)
        Me.yMinbox.TabIndex = 11
        Me.yMinbox.Text = "-10"
        '
        'xMaxbox
        '
        Me.xMaxbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xMaxbox.BackColor = System.Drawing.SystemColors.Menu
        Me.xMaxbox.Location = New System.Drawing.Point(123, 654)
        Me.xMaxbox.Name = "xMaxbox"
        Me.xMaxbox.Size = New System.Drawing.Size(50, 20)
        Me.xMaxbox.TabIndex = 12
        Me.xMaxbox.Text = "10"
        '
        'xMinbox
        '
        Me.xMinbox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.xMinbox.BackColor = System.Drawing.SystemColors.Menu
        Me.xMinbox.Location = New System.Drawing.Point(38, 654)
        Me.xMinbox.Name = "xMinbox"
        Me.xMinbox.Size = New System.Drawing.Size(50, 20)
        Me.xMinbox.TabIndex = 13
        Me.xMinbox.Text = "-10"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FunctionToolStripMenuItem, Me.InfoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FunctionToolStripMenuItem
        '
        Me.FunctionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LinearToolStripMenuItem, Me.ManualToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FunctionToolStripMenuItem.Name = "FunctionToolStripMenuItem"
        Me.FunctionToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.FunctionToolStripMenuItem.Text = "Function"
        '
        'LinearToolStripMenuItem
        '
        Me.LinearToolStripMenuItem.Name = "LinearToolStripMenuItem"
        Me.LinearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LinearToolStripMenuItem.Text = "Trigonometric"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'dBox
        '
        Me.dBox.BackColor = System.Drawing.SystemColors.Menu
        Me.dBox.Location = New System.Drawing.Point(1116, 654)
        Me.dBox.Name = "dBox"
        Me.dBox.Size = New System.Drawing.Size(50, 20)
        Me.dBox.TabIndex = 15
        Me.dBox.Text = "d"
        '
        'cBox
        '
        Me.cBox.BackColor = System.Drawing.SystemColors.Menu
        Me.cBox.Location = New System.Drawing.Point(1035, 654)
        Me.cBox.Name = "cBox"
        Me.cBox.Size = New System.Drawing.Size(50, 20)
        Me.cBox.TabIndex = 16
        Me.cBox.Text = "c"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(923, 657)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "sin("
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(1091, 657)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = ") +"
        '
        'Linear
        '
        Me.AccessibleDescription = "Plots functions"
        Me.AccessibleName = "Plotter"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cBox)
        Me.Controls.Add(Me.dBox)
        Me.Controls.Add(Me.xMinbox)
        Me.Controls.Add(Me.xMaxbox)
        Me.Controls.Add(Me.yMinbox)
        Me.Controls.Add(Me.yMaxbox)
        Me.Controls.Add(Me.aBox)
        Me.Controls.Add(Me.bBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plotButton)
        Me.Controls.Add(Me.windowButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(715, 250)
        Me.Name = "Linear"
        Me.Text = "Plotter - Trigonometric"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents windowButton As Button
    Friend WithEvents plotButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents bBox As TextBox
    Friend WithEvents aBox As TextBox
    Friend WithEvents yMaxbox As TextBox
    Friend WithEvents yMinbox As TextBox
    Friend WithEvents xMaxbox As TextBox
    Friend WithEvents xMinbox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FunctionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dBox As TextBox
    Friend WithEvents cBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
End Class
