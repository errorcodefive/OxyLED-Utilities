Imports System.Text.RegularExpressions
Public Class frmMain

    Public oxyLEDReader As String
    Public oxyLEDHeadings() As String = {
        "Time",
        "Time Elapsed",
        "pO2",
        "tau",
        "decay initial intensity",
        "decay integrated intensity",
        "SNR",
        "tau1",
        "tau2",
        "tau3",
        "IO-1",
        "IO-2",
        "Io-3",
        "Channel",
        "Date"}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblOxyLEDFileStatus.Text = "OxyLED File Status: Not Loaded"
    End Sub

    Private Sub btnLoadOxyLED_Click(sender As Object, e As EventArgs) Handles btnLoadOxyLED.Click
        Dim openFileOxyLED As New OpenFileDialog()

        openFileOxyLED.InitialDirectory = "C:\"
        openFileOxyLED.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"
        openFileOxyLED.FilterIndex = 2
        openFileOxyLED.RestoreDirectory = True
        If openFileOxyLED.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                oxyLEDReader = My.Computer.FileSystem.ReadAllText(openFileOxyLED.FileName)
            Catch ex As Exception
                MsgBox("Error reading file: " & ex.Message)
            End Try
        End If

        'Validate file Is oxyled
        'look on 19th line for a string
        'if not possible then file is not validated
        Dim validationArray() As String = Split(oxyLEDReader, vbCrLf)
        Dim validationCell() As String = Split(validationArray(18), vbTab)
        Try
            If (isRegexMatch(validationCell(0), "\d\d:\d\d:\d\d:\d\d\d")) Then
                lblOxyLEDFileStatus.Text = "OxyLED File Status: Loaded and Validated"
            End If
        Catch ex As Exception
            MsgBox("File may not be an oxyLED File")
        End Try

    End Sub

    Function isRegexMatch(ByVal text As String, ByVal expr As String) As Boolean
        Dim rgx As New Regex(expr)
        If (rgx.IsMatch(text)) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
