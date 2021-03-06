﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Me.btnLoadOxyLED = New System.Windows.Forms.Button()
        Me.lblOxyLEDFileStatus = New System.Windows.Forms.Label()
        Me.btnParseOxyLED = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvChunkData = New System.Windows.Forms.DataGridView()
        Me.sensor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_lines = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num_chunks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnExLines = New System.Windows.Forms.Button()
        CType(Me.dgvChunkData, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'btnParseOxyLED
        '
        Me.btnParseOxyLED.Location = New System.Drawing.Point(15, 85)
        Me.btnParseOxyLED.Name = "btnParseOxyLED"
        Me.btnParseOxyLED.Size = New System.Drawing.Size(109, 23)
        Me.btnParseOxyLED.TabIndex = 3
        Me.btnParseOxyLED.Text = "Parse oxyLED"
        Me.btnParseOxyLED.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "3 Sensors"
        '
        'dgvChunkData
        '
        Me.dgvChunkData.AllowUserToAddRows = False
        Me.dgvChunkData.AllowUserToDeleteRows = False
        Me.dgvChunkData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChunkData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sensor, Me.num_lines, Me.num_chunks})
        Me.dgvChunkData.Location = New System.Drawing.Point(15, 129)
        Me.dgvChunkData.Name = "dgvChunkData"
        Me.dgvChunkData.ReadOnly = True
        Me.dgvChunkData.Size = New System.Drawing.Size(379, 150)
        Me.dgvChunkData.TabIndex = 6
        '
        'sensor
        '
        Me.sensor.HeaderText = "Sensor"
        Me.sensor.Name = "sensor"
        Me.sensor.ReadOnly = True
        '
        'num_lines
        '
        Me.num_lines.HeaderText = "Number of Lines"
        Me.num_lines.Name = "num_lines"
        Me.num_lines.ReadOnly = True
        '
        'num_chunks
        '
        Me.num_chunks.HeaderText = "Number of Chunks"
        Me.num_chunks.Name = "num_chunks"
        Me.num_chunks.ReadOnly = True
        '
        'btnExLines
        '
        Me.btnExLines.Location = New System.Drawing.Point(15, 285)
        Me.btnExLines.Name = "btnExLines"
        Me.btnExLines.Size = New System.Drawing.Size(98, 23)
        Me.btnExLines.TabIndex = 7
        Me.btnExLines.Text = "Export All Lines"
        Me.btnExLines.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnExLines)
        Me.Controls.Add(Me.dgvChunkData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnParseOxyLED)
        Me.Controls.Add(Me.lblOxyLEDFileStatus)
        Me.Controls.Add(Me.btnLoadOxyLED)
        Me.Name = "frmMain"
        Me.Text = "OxyLED Utilities"
        CType(Me.dgvChunkData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLoadOxyLED As Button
    Friend WithEvents lblOxyLEDFileStatus As Label
    Friend WithEvents btnParseOxyLED As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvChunkData As DataGridView
    Friend WithEvents sensor As DataGridViewTextBoxColumn
    Friend WithEvents num_lines As DataGridViewTextBoxColumn
    Friend WithEvents num_chunks As DataGridViewTextBoxColumn
    Friend WithEvents btnExLines As Button
End Class
