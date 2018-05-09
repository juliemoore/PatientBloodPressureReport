' Program Name:     Patient Blood Pressure Report
' Author:           Julie Moore
' Date:             March 20, 2018
' Purpose:          The Patient Blood Pressure Report application determines which patients have a systolic
'                   blood pressure reading that is considered too high.

Option Strict On

Public Class frmPatientBloodPressureReport

    ' Public Shared variables for Patient Information form
    Public Shared intSizeOfRecords As Integer = 15
    Public Shared _strPatientName(intSizeOfRecords) As String
    Public Shared _intStolicValue(intSizeOfRecords) As Integer
    Public Shared testFile As System.IO.FileInfo
    Public Shared folderPath As String
    ' Private class variable
    Private intCount As Integer = 0

    Private Sub frmPatientBloodPressureReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmPaitentBloodPressureReport load event displays today's date, read's the patient text file and 
        ' puts the patient data into public shared arrays. The form displays a progress bar to inform the user 
        ' the patient file has been loaded and the number of patients loaded in the file

        ' These variables get today's date from the system clock, format the date and display in a label
        Dim regDate As Date = Date.Now()
        Dim strDate As String = regDate.ToString("MM\/dd\/yyyy")
        lblDate.Text = "Date: " & strDate

        ' Enable the timer to post the progress of the file writer in the progress bar
        Timer1.Enabled = True

        ' Initialize an instance of the StreamReader object and declare variables
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfPatientFile As String = "patient.txt"
        Dim strFileError As String = "The file at " + strLocationAndNameOfPatientFile + " is not available. Restart when the file is available."
        testFile = My.Computer.FileSystem.GetFileInfo(strLocationAndNameOfPatientFile)
        folderPath = testFile.DirectoryName
        Dim fileName As String = testFile.Name

        ' Verify the patient.txt file exists
        If IO.File.Exists(strLocationAndNameOfPatientFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfPatientFile)
            Do While objReader.Peek <> -1
                ' Read each line and assign data to arrays
                _strPatientName(intCount) = objReader.ReadLine()
                _intStolicValue(intCount) = Convert.ToInt32(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If

        ' Code if dynamic arrays are desired
        ' Assign a new array if size has changed since declaration
        ' If (intSizeOfRecords <> intCount - 1) Then
        ' ReDim Preserve _strPatientName(intCount - 1)
        ' ReDim Preserve _intStolicValue(intCount - 1)
        ' End If

    End Sub

    'This method uses the timer to increment the progress bar value to display to the user that the patient 
    ' data is being written to the patient.txt file. This method tests if there are 1 or more patients 
    ' Using the intCount variable that already counts the number Of records In the file. If there are any 
    ' patients, the status bar will increment by 10 until it reaches 100 And display the results In a status 
    ' bar label And a label that displays the number Of patient records written To the patient.txt file
    Private Sub ProgressBarStatusUpdate()
        If (intCount >= 1) Then
            ProgressBar1.Value = ProgressBar1.Value + 10
            lblFileStatus.Text = "Loading....." & ProgressBar1.Value & "%"
            If (ProgressBar1.Value = ProgressBar1.Maximum) Then
                Timer1.Enabled = False
                lblReadingToFile.Text = "Loaded " & intCount & " patient record(s) from the patient.txt file"
                lblReadingToFile.Visible = True
            End If
        Else
            lblFileStatus.Visible = False
            lblReadingToFile.Text = "There are no patient's with high stolic values today."
            lblReadingToFile.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' call ProgressBarStatusUpdate method to implement progress bar
        ProgressBarStatusUpdate()
    End Sub

    Private Sub mnuDisplay_Click(sender As Object, e As EventArgs) Handles mnuDisplay.Click
        ' This Sub procedure opens the second form
        Dim frmSecond As New frmPatientInformation

        Hide()
        frmSecond.ShowDialog()
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear event restarts the application
        Application.Restart()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        'The mnuExit click event closes the application
        Application.Exit()
    End Sub

    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub
End Class
