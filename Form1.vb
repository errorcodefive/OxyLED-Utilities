Imports System.Text.RegularExpressions
Imports Microsoft.Office.Interop
Public Class frmMain

    Public oxyLEDReader As String
    Public oxyLEDSensorHeadings() As String = {
        "Red LED",
        "Blue LED",
        "Red Laser"
        }
    Public oxyLEDSensoryNum As Integer
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

    Dim objApp As New Excel.Application
    Dim objBook As Excel.Workbook = objApp.Worksbooks.add()

    Dim RawRedLED As New List(Of String)
    Dim RawBlueLED As New List(Of String)
    Dim RawRedLASER As New List(Of String)
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
    Private Sub btnParseOxyLED_Click(sender As Object, e As EventArgs) Handles btnParseOxyLED.Click
        Dim numSensors As Integer = 3

        Dim tempString As String() = Split(oxyLEDReader, vbCrLf)
        Dim croppedOxyLED As New List(Of String)

        dgvChunkData.Rows.Add("Red LED", 0, 0)
        dgvChunkData.Rows.Add("Blue LED", 0, 0)
        dgvChunkData.Rows.Add("Red LASER", 0, 0)

        For i = 18 To tempString.Length - 1
            croppedOxyLED.Add(tempString(i))
        Next

        Dim startChunk As Integer
        Dim endChunk As Integer = -1
        Dim sensorNum As Integer
        For i = 0 To croppedOxyLED.Count - 1
            Dim currentLine As String
            currentLine = croppedOxyLED(i)
            Dim tokenizeCurrentLine As String()
            If currentLine <> "" Then
                tokenizeCurrentLine = Split(currentLine, vbTab)
            Else
                tokenizeCurrentLine(1) = 0
            End If

            Try
                If tokenizeCurrentLine(1) = 0 Then
                    'Open frm2 msgbox and present the current line and ask for which sensor belongs
                    Dim selectSensor As New frmSensor(currentLine)
                    Dim dr As DialogResult = selectSensor.ShowDialog()
                    If dr = DialogResult.OK Then

                        'this checks if its the first chunk or not
                        If endChunk < 0 Then
                            'nothing different

                        Else
                            'this is not the first chunk
                            'since it's not the first and we found another 0 then everything from startChunk to end Chunk is added to the appropriate list

                            If (sensorNum = 1) Then
                                dgvChunkData.Rows(0).Cells(2).Value = dgvChunkData.Rows(0).Cells(2).Value + 1
                            ElseIf (sensorNum = 2) Then
                                dgvChunkData.Rows(1).Cells(2).Value = dgvChunkData.Rows(1).Cells(2).Value + 1
                            ElseIf (sensorNum = 3) Then
                                dgvChunkData.Rows(2).Cells(2).Value = dgvChunkData.Rows(2).Cells(2).Value + 1
                            End If

                            For j = startChunk To endChunk
                                'correct list
                                If (sensorNum = 1) Then
                                    RawRedLED.Add(croppedOxyLED(j))
                                    dgvChunkData.Rows(0).Cells(1).Value = dgvChunkData.Rows(0).Cells(1).Value + 1
                                ElseIf sensorNum = 2 Then
                                    RawBlueLED.Add(croppedOxyLED(j))
                                    dgvChunkData.Rows(1).Cells(1).Value = dgvChunkData.Rows(1).Cells(1).Value + 1
                                ElseIf sensorNum = 3 Then
                                    RawRedLASER.Add(croppedOxyLED(j))
                                    dgvChunkData.Rows(2).Cells(1).Value = dgvChunkData.Rows(2).Cells(1).Value + 1
                                ElseIf sensorNum = 4 Then
                                    'this is trash
                                End If
                            Next
                        End If
                        sensorNum = selectSensor.sensorType
                        startChunk = i

                    End If
                ElseIf tokenizeCurrentLine(1) <> 0 Then
                    endChunk = i
                End If
            Catch ex As Exception
                Exit For
                MsgBox(ex)
            End Try

        Next
        MsgBox("Completed")
        Dim totalLines As Integer
        Dim totalChunks As Integer
        totalLines = dgvChunkData.Rows(0).Cells(1).Value + dgvChunkData.Rows(1).Cells(1).Value + dgvChunkData.Rows(2).Cells(1).Value
        totalChunks = dgvChunkData.Rows(0).Cells(2).Value + dgvChunkData.Rows(1).Cells(2).Value + dgvChunkData.Rows(2).Cells(2).Value
        dgvChunkData.Rows.Add("Sum", totalLines, totalChunks)
        'update data grid view



    End Sub

    Private Sub btnExLines_Click(sender As Object, e As EventArgs) Handles btnExLines.Click
        Dim redLEDSheet As Excel.Worksheet = CType(objBook.Sheets("Red LED"), Excel.Worksheet)
        Dim blueLEDSheet As Excel.Worksheet = CType(objBook.Sheets("Blue LED"), Excel.Worksheet)
        Dim redLASERSheet As Excel.Worksheet = CType(objBook.Sheets("Red LASER"), Excel.Worksheet)

        'we want to export all lines for each sensor (1 sensor per sheet)
        'export only time, time elapsed, po2, SNR, LED Channel (0,1,2,6,13)



    End Sub
End Class
