Public Class frmSensor
    Public sensorType As Integer
    Public Sub New(ByVal oxyLedLine As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        txtCurrentLine.Text = oxyLedLine
    End Sub
    Private Sub frmSensor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnSensor1_Click(sender As Object, e As EventArgs) Handles btnSensor1.Click
        sensorType = 1
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnSensor2_Click(sender As Object, e As EventArgs) Handles btnSensor2.Click
        sensorType = 2
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnSensor3_Click(sender As Object, e As EventArgs) Handles btnSensor3.Click
        sensorType = 3
        DialogResult = DialogResult.OK
    End Sub

    Private Sub btnTrash_Click(sender As Object, e As EventArgs) Handles btnTrash.Click
        sensorType = 4
        DialogResult = DialogResult.OK
    End Sub
End Class