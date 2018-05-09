<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientBloodPressureReport
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
        Me.components = New System.ComponentModel.Container()
        Me.mnuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDisplay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFileStatus = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblReadingToFile = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mnuFile.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuFile
        '
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(613, 24)
        Me.mnuFile.TabIndex = 1
        Me.mnuFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDisplay, Me.mnuClear, Me.mnuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuDisplay
        '
        Me.mnuDisplay.Name = "mnuDisplay"
        Me.mnuDisplay.Size = New System.Drawing.Size(218, 22)
        Me.mnuDisplay.Text = "Display Patient Information"
        '
        'mnuClear
        '
        Me.mnuClear.Name = "mnuClear"
        Me.mnuClear.Size = New System.Drawing.Size(218, 22)
        Me.mnuClear.Text = "Clear"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(218, 22)
        Me.mnuExit.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.lblFileStatus)
        Me.Panel1.Controls.Add(Me.ProgressBar1)
        Me.Panel1.Controls.Add(Me.lblReadingToFile)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.lblTitle)
        Me.Panel1.Location = New System.Drawing.Point(269, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 439)
        Me.Panel1.TabIndex = 2
        '
        'lblFileStatus
        '
        Me.lblFileStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblFileStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileStatus.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblFileStatus.Location = New System.Drawing.Point(54, 280)
        Me.lblFileStatus.Name = "lblFileStatus"
        Me.lblFileStatus.Size = New System.Drawing.Size(240, 20)
        Me.lblFileStatus.TabIndex = 9
        Me.lblFileStatus.Text = "Loading...100%"
        Me.lblFileStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DarkBlue
        Me.ProgressBar1.Location = New System.Drawing.Point(54, 311)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(240, 38)
        Me.ProgressBar1.TabIndex = 8
        '
        'lblReadingToFile
        '
        Me.lblReadingToFile.BackColor = System.Drawing.Color.Transparent
        Me.lblReadingToFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReadingToFile.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblReadingToFile.Location = New System.Drawing.Point(65, 363)
        Me.lblReadingToFile.Name = "lblReadingToFile"
        Me.lblReadingToFile.Size = New System.Drawing.Size(215, 42)
        Me.lblReadingToFile.TabIndex = 7
        Me.lblReadingToFile.Text = "Reading 88 patient record(s) from the patient.txt file"
        Me.lblReadingToFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblReadingToFile.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.DimGray
        Me.lblDate.Location = New System.Drawing.Point(76, 126)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(193, 25)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "Date: 00/00/0000"
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle.Location = New System.Drawing.Point(3, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(341, 81)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Daily Patient Blood Pressure Report"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogo
        '
        Me.picLogo.BackgroundImage = Global.Patient_Blood_Pressure_Report.My.Resources.Resources.blood_pressure
        Me.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogo.Location = New System.Drawing.Point(1, 27)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(327, 439)
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'frmPatientBloodPressureReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(613, 466)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picLogo)
        Me.Controls.Add(Me.mnuFile)
        Me.MainMenuStrip = Me.mnuFile
        Me.Name = "frmPatientBloodPressureReport"
        Me.Text = "Patient Blood Pressure Report"
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents mnuFile As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblReadingToFile As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lblFileStatus As Label
End Class
