<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSensor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSensor1 = New System.Windows.Forms.Button()
        Me.btnSensor2 = New System.Windows.Forms.Button()
        Me.btnSensor3 = New System.Windows.Forms.Button()
        Me.txtCurrentLine = New System.Windows.Forms.TextBox()
        Me.btnTrash = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(120, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What sensor is this chunk for?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(123, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Previous Chunk Was:"
        '
        'btnSensor1
        '
        Me.btnSensor1.Location = New System.Drawing.Point(56, 58)
        Me.btnSensor1.Name = "btnSensor1"
        Me.btnSensor1.Size = New System.Drawing.Size(75, 23)
        Me.btnSensor1.TabIndex = 2
        Me.btnSensor1.Text = "Red LED"
        Me.btnSensor1.UseVisualStyleBackColor = True
        '
        'btnSensor2
        '
        Me.btnSensor2.Location = New System.Drawing.Point(158, 58)
        Me.btnSensor2.Name = "btnSensor2"
        Me.btnSensor2.Size = New System.Drawing.Size(75, 23)
        Me.btnSensor2.TabIndex = 3
        Me.btnSensor2.Text = "Blue LED"
        Me.btnSensor2.UseVisualStyleBackColor = True
        '
        'btnSensor3
        '
        Me.btnSensor3.Location = New System.Drawing.Point(264, 58)
        Me.btnSensor3.Name = "btnSensor3"
        Me.btnSensor3.Size = New System.Drawing.Size(75, 23)
        Me.btnSensor3.TabIndex = 4
        Me.btnSensor3.Text = "Red LASER"
        Me.btnSensor3.UseVisualStyleBackColor = True
        '
        'txtCurrentLine
        '
        Me.txtCurrentLine.AcceptsTab = True
        Me.txtCurrentLine.AllowDrop = True
        Me.txtCurrentLine.Location = New System.Drawing.Point(56, 100)
        Me.txtCurrentLine.Name = "txtCurrentLine"
        Me.txtCurrentLine.Size = New System.Drawing.Size(842, 20)
        Me.txtCurrentLine.TabIndex = 5
        '
        'btnTrash
        '
        Me.btnTrash.Location = New System.Drawing.Point(370, 58)
        Me.btnTrash.Name = "btnTrash"
        Me.btnTrash.Size = New System.Drawing.Size(75, 23)
        Me.btnTrash.TabIndex = 6
        Me.btnTrash.Text = "Trash It"
        Me.btnTrash.UseVisualStyleBackColor = True
        '
        'frmSensor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 308)
        Me.Controls.Add(Me.btnTrash)
        Me.Controls.Add(Me.txtCurrentLine)
        Me.Controls.Add(Me.btnSensor3)
        Me.Controls.Add(Me.btnSensor2)
        Me.Controls.Add(Me.btnSensor1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmSensor"
        Me.Text = "Sensor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSensor1 As Button
    Friend WithEvents btnSensor2 As Button
    Friend WithEvents btnSensor3 As Button
    Friend WithEvents txtCurrentLine As TextBox
    Friend WithEvents btnTrash As Button
End Class
