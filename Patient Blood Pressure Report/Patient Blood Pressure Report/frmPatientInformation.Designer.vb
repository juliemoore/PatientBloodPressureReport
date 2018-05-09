<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPatientInformation
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
        Me.mnuFile = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HomeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFile2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHome = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuClear2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.picLogo2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lstPatientInformation = New System.Windows.Forms.ListBox()
        Me.lblTitle2 = New System.Windows.Forms.Label()
        Me.lblAverageValue = New System.Windows.Forms.Label()
        Me.lblAveragePatientValue = New System.Windows.Forms.Label()
        Me.lblNumberOfPatients = New System.Windows.Forms.Label()
        Me.lblPatientsOver120 = New System.Windows.Forms.Label()
        Me.lblWritingToFile = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.lnlStolicValue = New System.Windows.Forms.Label()
        Me.mnuFile.SuspendLayout()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuFile
        '
        Me.mnuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.mnuFile2})
        Me.mnuFile.Location = New System.Drawing.Point(0, 0)
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(613, 24)
        Me.mnuFile.TabIndex = 0
        Me.mnuFile.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HomeToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(29, 21)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'HomeToolStripMenuItem
        '
        Me.HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        Me.HomeToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.HomeToolStripMenuItem.Text = "Home"
        '
        'mnuFile2
        '
        Me.mnuFile2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHome, Me.mnuClear2, Me.mnuExit2})
        Me.mnuFile2.Name = "mnuFile2"
        Me.mnuFile2.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile2.Text = "File"
        '
        'mnuHome
        '
        Me.mnuHome.Name = "mnuHome"
        Me.mnuHome.Size = New System.Drawing.Size(152, 22)
        Me.mnuHome.Text = "Home"
        '
        'mnuClear2
        '
        Me.mnuClear2.Name = "mnuClear2"
        Me.mnuClear2.Size = New System.Drawing.Size(152, 22)
        Me.mnuClear2.Text = "Clear"
        '
        'mnuExit2
        '
        Me.mnuExit2.Name = "mnuExit2"
        Me.mnuExit2.Size = New System.Drawing.Size(152, 22)
        Me.mnuExit2.Text = "Exit"
        '
        'picLogo2
        '
        Me.picLogo2.BackgroundImage = Global.Patient_Blood_Pressure_Report.My.Resources.Resources.blood_pressure
        Me.picLogo2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picLogo2.Location = New System.Drawing.Point(0, 28)
        Me.picLogo2.Name = "picLogo2"
        Me.picLogo2.Size = New System.Drawing.Size(327, 531)
        Me.picLogo2.TabIndex = 1
        Me.picLogo2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblWritingToFile)
        Me.Panel1.Controls.Add(Me.lblAverageValue)
        Me.Panel1.Controls.Add(Me.lblAveragePatientValue)
        Me.Panel1.Controls.Add(Me.lblNumberOfPatients)
        Me.Panel1.Controls.Add(Me.lblPatientsOver120)
        Me.Panel1.Controls.Add(Me.lstPatientInformation)
        Me.Panel1.Controls.Add(Me.lblTitle2)
        Me.Panel1.Location = New System.Drawing.Point(269, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 531)
        Me.Panel1.TabIndex = 2
        '
        'lstPatientInformation
        '
        Me.lstPatientInformation.BackColor = System.Drawing.Color.White
        Me.lstPatientInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPatientInformation.FormattingEnabled = True
        Me.lstPatientInformation.ItemHeight = 20
        Me.lstPatientInformation.Location = New System.Drawing.Point(32, 103)
        Me.lstPatientInformation.Name = "lstPatientInformation"
        Me.lstPatientInformation.Size = New System.Drawing.Size(280, 264)
        Me.lstPatientInformation.TabIndex = 1
        '
        'lblTitle2
        '
        Me.lblTitle2.AutoSize = True
        Me.lblTitle2.Font = New System.Drawing.Font("Impact", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblTitle2.Location = New System.Drawing.Point(49, 14)
        Me.lblTitle2.Name = "lblTitle2"
        Me.lblTitle2.Size = New System.Drawing.Size(246, 36)
        Me.lblTitle2.TabIndex = 0
        Me.lblTitle2.Text = "Patient Information"
        '
        'lblAverageValue
        '
        Me.lblAverageValue.AutoSize = True
        Me.lblAverageValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageValue.ForeColor = System.Drawing.Color.Red
        Me.lblAverageValue.Location = New System.Drawing.Point(253, 476)
        Me.lblAverageValue.Name = "lblAverageValue"
        Me.lblAverageValue.Size = New System.Drawing.Size(59, 31)
        Me.lblAverageValue.TabIndex = 10
        Me.lblAverageValue.Text = "888"
        Me.lblAverageValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAveragePatientValue
        '
        Me.lblAveragePatientValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAveragePatientValue.Location = New System.Drawing.Point(29, 470)
        Me.lblAveragePatientValue.Name = "lblAveragePatientValue"
        Me.lblAveragePatientValue.Size = New System.Drawing.Size(158, 36)
        Me.lblAveragePatientValue.TabIndex = 9
        Me.lblAveragePatientValue.Text = "Today's average patient systolic value:"
        Me.lblAveragePatientValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumberOfPatients
        '
        Me.lblNumberOfPatients.AutoSize = True
        Me.lblNumberOfPatients.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfPatients.ForeColor = System.Drawing.Color.Red
        Me.lblNumberOfPatients.Location = New System.Drawing.Point(268, 420)
        Me.lblNumberOfPatients.Name = "lblNumberOfPatients"
        Me.lblNumberOfPatients.Size = New System.Drawing.Size(44, 31)
        Me.lblNumberOfPatients.TabIndex = 8
        Me.lblNumberOfPatients.Text = "88"
        Me.lblNumberOfPatients.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPatientsOver120
        '
        Me.lblPatientsOver120.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientsOver120.Location = New System.Drawing.Point(29, 408)
        Me.lblPatientsOver120.Name = "lblPatientsOver120"
        Me.lblPatientsOver120.Size = New System.Drawing.Size(189, 49)
        Me.lblPatientsOver120.TabIndex = 7
        Me.lblPatientsOver120.Text = "Number of patients with a systolic value above 120:"
        Me.lblPatientsOver120.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWritingToFile
        '
        Me.lblWritingToFile.BackColor = System.Drawing.Color.Transparent
        Me.lblWritingToFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWritingToFile.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblWritingToFile.Location = New System.Drawing.Point(3, 373)
        Me.lblWritingToFile.Name = "lblWritingToFile"
        Me.lblWritingToFile.Size = New System.Drawing.Size(338, 22)
        Me.lblWritingToFile.TabIndex = 11
        Me.lblWritingToFile.Text = "88 patient record(s) written to the consult.txt file"
        Me.lblWritingToFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWritingToFile.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel2.Controls.Add(Me.lnlStolicValue)
        Me.Panel2.Controls.Add(Me.lblPatientName)
        Me.Panel2.Location = New System.Drawing.Point(32, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 32)
        Me.Panel2.TabIndex = 12
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.ForeColor = System.Drawing.Color.White
        Me.lblPatientName.Location = New System.Drawing.Point(1, 12)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(101, 20)
        Me.lblPatientName.TabIndex = 0
        Me.lblPatientName.Text = "PatientName"
        Me.lblPatientName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lnlStolicValue
        '
        Me.lnlStolicValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnlStolicValue.ForeColor = System.Drawing.Color.White
        Me.lnlStolicValue.Location = New System.Drawing.Point(168, 0)
        Me.lnlStolicValue.Name = "lnlStolicValue"
        Me.lnlStolicValue.Size = New System.Drawing.Size(109, 30)
        Me.lnlStolicValue.TabIndex = 1
        Me.lnlStolicValue.Text = "Systolic Value"
        Me.lnlStolicValue.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'frmPatientInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(613, 558)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.picLogo2)
        Me.Controls.Add(Me.mnuFile)
        Me.MainMenuStrip = Me.mnuFile
        Me.Name = "frmPatientInformation"
        Me.Text = "Patient Information"
        Me.mnuFile.ResumeLayout(False)
        Me.mnuFile.PerformLayout()
        CType(Me.picLogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuFile As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuFile2 As ToolStripMenuItem
    Friend WithEvents mnuHome As ToolStripMenuItem
    Friend WithEvents mnuClear2 As ToolStripMenuItem
    Friend WithEvents mnuExit2 As ToolStripMenuItem
    Friend WithEvents picLogo2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblTitle2 As Label
    Friend WithEvents lstPatientInformation As ListBox
    Friend WithEvents lblAverageValue As Label
    Friend WithEvents lblAveragePatientValue As Label
    Friend WithEvents lblNumberOfPatients As Label
    Friend WithEvents lblPatientsOver120 As Label
    Friend WithEvents lblWritingToFile As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lnlStolicValue As Label
    Friend WithEvents lblPatientName As Label
End Class
