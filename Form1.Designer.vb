<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.btnLoadOxyLED = New System.Windows.Forms.Button()
        Me.lblOxyLEDFileStatus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLoadOxyLED
        '
        Me.btnLoadOxyLED.Location = New System.Drawing.Point(12, 12)
        Me.btnLoadOxyLED.Name = "btnLoadOxyLED"
        Me.btnLoadOxyLED.Size = New System.Drawing.Size(132, 23)
        Me.btnLoadOxyLED.TabIndex = 0
        Me.btnLoadOxyLED.Text = "Load OxyLED File"
        Me.btnLoadOxyLED.UseVisualStyleBackColor = True
        '
        'lblOxyLEDFileStatus
        '
        Me.lblOxyLEDFileStatus.AutoSize = True
        Me.lblOxyLEDFileStatus.Location = New System.Drawing.Point(12, 42)
        Me.lblOxyLEDFileStatus.Name = "lblOxyLEDFileStatus"
        Me.lblOxyLEDFileStatus.Size = New System.Drawing.Size(101, 13)
        Me.lblOxyLEDFileStatus.TabIndex = 1
        Me.lblOxyLEDFileStatus.Text = "OxyLED File Status:"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblOxyLEDFileStatus)
        Me.Controls.Add(Me.btnLoadOxyLED)
        Me.Name = "frmMain"
        Me.Text = "OxyLED Utilities"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadOxyLED As Button
    Friend WithEvents lblOxyLEDFileStatus As Label
End Class
