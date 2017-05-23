<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class zeroDivision
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(zeroDivision))
        Me.zeroBox = New System.Windows.Forms.PictureBox()
        CType(Me.zeroBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'zeroBox
        '
        Me.zeroBox.Image = Global.Plotter.My.Resources.Resources.animated_time_paradox
        Me.zeroBox.Location = New System.Drawing.Point(6, 4)
        Me.zeroBox.Name = "zeroBox"
        Me.zeroBox.Size = New System.Drawing.Size(750, 600)
        Me.zeroBox.TabIndex = 0
        Me.zeroBox.TabStop = False
        '
        'zeroDivision
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 608)
        Me.Controls.Add(Me.zeroBox)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(778, 647)
        Me.MinimumSize = New System.Drawing.Size(778, 647)
        Me.Name = "zeroDivision"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "APOCALYPSE"
        CType(Me.zeroBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents zeroBox As PictureBox
End Class
