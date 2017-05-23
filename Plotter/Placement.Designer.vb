<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Placement
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Placement))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.adBox = New System.Windows.Forms.PictureBox()
        Me.errorBox = New System.Windows.Forms.TextBox()
        CType(Me.adBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Diese Fehlermeldung wurde Ihnen präsentiert von"
        '
        'adBox
        '
        Me.adBox.Image = CType(resources.GetObject("adBox.Image"), System.Drawing.Image)
        Me.adBox.Location = New System.Drawing.Point(12, 175)
        Me.adBox.Name = "adBox"
        Me.adBox.Size = New System.Drawing.Size(600, 134)
        Me.adBox.TabIndex = 1
        Me.adBox.TabStop = False
        '
        'errorBox
        '
        Me.errorBox.Enabled = False
        Me.errorBox.Location = New System.Drawing.Point(15, 12)
        Me.errorBox.Multiline = True
        Me.errorBox.Name = "errorBox"
        Me.errorBox.Size = New System.Drawing.Size(597, 144)
        Me.errorBox.TabIndex = 2
        '
        'Placement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 281)
        Me.Controls.Add(Me.errorBox)
        Me.Controls.Add(Me.adBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(640, 320)
        Me.MinimumSize = New System.Drawing.Size(640, 320)
        Me.Name = "Placement"
        Me.Text = "Error"
        CType(Me.adBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents adBox As PictureBox
    Friend WithEvents errorBox As TextBox
End Class
