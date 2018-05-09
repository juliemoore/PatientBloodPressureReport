' The frmPatientInformation class is opened by frmPatientBloodPressureReport and displays
' the patient.txt file, the number of high blood pressure patients and the average blood
' pressure of the patients
Option Strict On

Public Class frmPatientInformation

    ' Class level Private Variables
    Private intFill As Integer
    Private intStolicValue As Integer
    Private intHighStolicValue As Integer = 120
    Private intTotalStolicValues As Integer = 0
    Private intNumberOfPatients As Integer = 0
    Private dblAveStolicValue As Double

    Private Sub frmPatientInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' The frmPatientInformation load event is a second forms that displays
        ' the patient information, the average blood pressure value and the number of 
        ' high blood pressure patients. The form also creates an SteamWriter object and writes
        ' the records of patients with high blood pressure to the consult.txt file

        ' Initialize an instance of the StreamWriter objects and declare variables
        ' Create new consult.txt file if it doesn't exist or overwrite text if it does exist
        Dim fileName As String
        Dim folderPath As String = frmPatientBloodPressureReport.folderPath
        fileName = My.Computer.FileSystem.CombinePath(folderPath, "consult.txt")

        Dim objWriter As New IO.StreamWriter(fileName)
        Dim strFileError As String = "The file at " + fileName + " is not available. Restart when the file is available."

        ' Displays the patient name and stolic levels array in the list box
        For intFill = 0 To (frmPatientBloodPressureReport._strPatientName.Length - 1)
            ' Get the string format for the patient and add to string to list box
            Dim p = New Patient With {.strPatientName = frmPatientBloodPressureReport._strPatientName(intFill) & vbTab, .intSystolicLevel = frmPatientBloodPressureReport._intStolicValue(intFill)}
            lstPatientInformation.Items.Add(p)

            ' Gets the stolic value of the patient and assigns to variable
            intStolicValue = frmPatientBloodPressureReport._intStolicValue(intFill)

            ' Add value to the total stolic levels value to calculate the average stolic value
            ' and count the number of patients with a stolic value > 120
            intTotalStolicValues += intStolicValue

            ' Write patient record to consult file if patient has high stolic level
            If (intStolicValue > intHighStolicValue) Then
                intNumberOfPatients += 1
                ' Verify the consult.txt file exists
                If IO.File.Exists(fileName) Then
                    ' Write the file line by line until the file is completed
                    objWriter.WriteLine(frmPatientBloodPressureReport._strPatientName(intFill))
                    objWriter.WriteLine(intStolicValue.ToString())
                Else
                    MsgBox(strFileError, , "Error")
                    Close()
                End If
            Else
                intNumberOfPatients += 0
            End If
        Next
        ' Close SteamWriter
        objWriter.Close()

        ' Display the number of patients with a stolic value > 120 and
        ' display the daily average patient blood pressure by taking the
        ' total of all the patients'systolic values divided by the number
        ' of patients and round up using the Math.Cieling method
        dblAveStolicValue = intTotalStolicValues / frmPatientBloodPressureReport._strPatientName.Length - 1
        lblNumberOfPatients.Text = intNumberOfPatients.ToString()
        lblAverageValue.Text = Math.Ceiling(dblAveStolicValue).ToString()

        ' Display the number of patient record written to consult.txt file
        lblWritingToFile.Text = intNumberOfPatients.ToString() & " patient record(s) written to the consult.txt file"
        lblWritingToFile.Visible = True
    End Sub

    ' Patient class with an override function to format the patient information string for the listbox
    Public Class Patient
        Public Property strPatientName As String
        Public Property intSystolicLevel As Integer

        Public Overrides Function ToString() As String
            Return String.Format("{0, -10} {1, 20}", strPatientName, intSystolicLevel)
        End Function
    End Class

    Private Sub mnuHome_Click(sender As Object, e As EventArgs) Handles mnuHome.Click
        ' This sub procedure opens the first form
        Dim frmFirst As New frmPatientBloodPressureReport

        Hide()
        frmFirst.ShowDialog()
    End Sub

    Private Sub mnuClear2_Click(sender As Object, e As EventArgs) Handles mnuClear2.Click
        ' The mnuClear event restarts the application
        Application.Restart()
    End Sub

    Private Sub mnuExit2_Click(sender As Object, e As EventArgs) Handles mnuExit2.Click
        'The mnuExit click event closes the application
        Application.Exit()
    End Sub
End Class