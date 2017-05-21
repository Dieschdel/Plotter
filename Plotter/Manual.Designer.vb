<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Manual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Manual))
        Me.windowButton = New System.Windows.Forms.Button()
        Me.plotButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.yMaxbox = New System.Windows.Forms.TextBox()
        Me.yMinbox = New System.Windows.Forms.TextBox()
        Me.xMaxbox = New System.Windows.Forms.TextBox()
        Me.xMinbox = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.displayBox = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'windowButton
        '
        resources.ApplyResources(Me.windowButton, "windowButton")
        Me.windowButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.windowButton.Name = "windowButton"
        Me.windowButton.UseVisualStyleBackColor = True
        '
        'plotButton
        '
        resources.ApplyResources(Me.plotButton, "plotButton")
        Me.plotButton.Name = "plotButton"
        Me.plotButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'yMaxbox
        '
        resources.ApplyResources(Me.yMaxbox, "yMaxbox")
        Me.yMaxbox.BackColor = System.Drawing.SystemColors.Menu
        Me.yMaxbox.Name = "yMaxbox"
        '
        'yMinbox
        '
        resources.ApplyResources(Me.yMinbox, "yMinbox")
        Me.yMinbox.BackColor = System.Drawing.SystemColors.Menu
        Me.yMinbox.Name = "yMinbox"
        '
        'xMaxbox
        '
        resources.ApplyResources(Me.xMaxbox, "xMaxbox")
        Me.xMaxbox.BackColor = System.Drawing.SystemColors.Menu
        Me.xMaxbox.Name = "xMaxbox"
        '
        'xMinbox
        '
        resources.ApplyResources(Me.xMinbox, "xMinbox")
        Me.xMinbox.BackColor = System.Drawing.SystemColors.Menu
        Me.xMinbox.Name = "xMinbox"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        resources.ApplyResources(Me.InfoToolStripMenuItem, "InfoToolStripMenuItem")
        '
        'Button1
        '
        resources.ApplyResources(Me.Button1, "Button1")
        Me.Button1.Name = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'displayBox
        '
        resources.ApplyResources(Me.displayBox, "displayBox")
        Me.displayBox.Name = "displayBox"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Manual
        '
        Me.AcceptButton = Me.windowButton
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Controls.Add(Me.displayBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.xMinbox)
        Me.Controls.Add(Me.xMaxbox)
        Me.Controls.Add(Me.yMinbox)
        Me.Controls.Add(Me.yMaxbox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.plotButton)
        Me.Controls.Add(Me.windowButton)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Manual"
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
    Friend WithEvents yMaxbox As TextBox
    Friend WithEvents yMinbox As TextBox
    Friend WithEvents xMaxbox As TextBox
    Friend WithEvents xMinbox As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button1 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents displayBox As TextBox
    Friend WithEvents Timer1 As Timer
End Class
