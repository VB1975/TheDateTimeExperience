<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDisplayingDateTime
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDisplayingDateTime))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblAppointmentDateTime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CalAppointmentMonth = New System.Windows.Forms.MonthCalendar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAppointmentHour = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAppointmentMinute = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtEndDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtStartDate = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CalDateRange = New System.Windows.Forms.MonthCalendar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtYear = New System.Windows.Forms.TextBox()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.TxtMonth = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtDate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtDay = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtLongDate = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtMediumDate = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtShortDate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpFormatDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.TxtTimeOfDay = New System.Windows.Forms.TextBox()
        Me.LblTimeOfDay = New System.Windows.Forms.Label()
        Me.TxtSeconds = New System.Windows.Forms.TextBox()
        Me.LblSeconds = New System.Windows.Forms.Label()
        Me.TxtMinutes = New System.Windows.Forms.TextBox()
        Me.LblMinutes = New System.Windows.Forms.Label()
        Me.TxtHours = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtLongTime = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TxtMediumTime = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtShortTime = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.DtpTimeFormat = New System.Windows.Forms.DateTimePicker()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LblClock = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TimClock = New System.Windows.Forms.Timer(Me.components)
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnSetToday = New System.Windows.Forms.Button()
        Me.BtnPlusOneYear = New System.Windows.Forms.Button()
        Me.BtnMinusOneYear = New System.Windows.Forms.Button()
        Me.BtnPlusOneMonth = New System.Windows.Forms.Button()
        Me.BtnMinusOneMonth = New System.Windows.Forms.Button()
        Me.BtnPlusOneWeek = New System.Windows.Forms.Button()
        Me.BtnMinusOneWeek = New System.Windows.Forms.Button()
        Me.BtnPlusOneDay = New System.Windows.Forms.Button()
        Me.BtnMinusOneDay = New System.Windows.Forms.Button()
        Me.TxtDateString = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnReset)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LblAppointmentDateTime)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.CalAppointmentMonth)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboAppointmentHour)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cboAppointmentMinute)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(395, 281)
        Me.Panel1.TabIndex = 19
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(248, 98)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(132, 39)
        Me.BtnReset.TabIndex = 21
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Appointment Date && Time"
        '
        'LblAppointmentDateTime
        '
        Me.LblAppointmentDateTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LblAppointmentDateTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAppointmentDateTime.ForeColor = System.Drawing.Color.Teal
        Me.LblAppointmentDateTime.Location = New System.Drawing.Point(7, 234)
        Me.LblAppointmentDateTime.Name = "LblAppointmentDateTime"
        Me.LblAppointmentDateTime.Size = New System.Drawing.Size(373, 36)
        Me.LblAppointmentDateTime.TabIndex = 19
        Me.LblAppointmentDateTime.Text = "Friday, 20 December 2024 @ 4:30 pm"
        Me.LblAppointmentDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 3)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(111, 20)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = "Appointment"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(308, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 28)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = ":"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalAppointmentMonth
        '
        Me.CalAppointmentMonth.Location = New System.Drawing.Point(7, 32)
        Me.CalAppointmentMonth.Name = "CalAppointmentMonth"
        Me.CalAppointmentMonth.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(248, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hrs"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAppointmentHour
        '
        Me.cboAppointmentHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAppointmentHour.FormattingEnabled = True
        Me.cboAppointmentHour.Location = New System.Drawing.Point(248, 55)
        Me.cboAppointmentHour.Name = "cboAppointmentHour"
        Me.cboAppointmentHour.Size = New System.Drawing.Size(58, 28)
        Me.cboAppointmentHour.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Mins"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAppointmentMinute
        '
        Me.cboAppointmentMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAppointmentMinute.FormattingEnabled = True
        Me.cboAppointmentMinute.Location = New System.Drawing.Point(322, 55)
        Me.cboAppointmentMinute.Name = "cboAppointmentMinute"
        Me.cboAppointmentMinute.Size = New System.Drawing.Size(58, 28)
        Me.cboAppointmentMinute.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtEndDate)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.TxtStartDate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.CalDateRange)
        Me.Panel2.Location = New System.Drawing.Point(413, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(247, 281)
        Me.Panel2.TabIndex = 21
        '
        'TxtEndDate
        '
        Me.TxtEndDate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TxtEndDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEndDate.Location = New System.Drawing.Point(109, 240)
        Me.TxtEndDate.Name = "TxtEndDate"
        Me.TxtEndDate.ReadOnly = True
        Me.TxtEndDate.Size = New System.Drawing.Size(127, 26)
        Me.TxtEndDate.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 243)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "End Date:"
        '
        'TxtStartDate
        '
        Me.TxtStartDate.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.TxtStartDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtStartDate.Location = New System.Drawing.Point(109, 208)
        Me.TxtStartDate.Name = "TxtStartDate"
        Me.TxtStartDate.ReadOnly = True
        Me.TxtStartDate.Size = New System.Drawing.Size(127, 26)
        Me.TxtStartDate.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Start Date:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(136, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Range of Dates"
        '
        'CalDateRange
        '
        Me.CalDateRange.Location = New System.Drawing.Point(7, 32)
        Me.CalDateRange.MaxSelectionCount = 14
        Me.CalDateRange.Name = "CalDateRange"
        Me.CalDateRange.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.TxtYear)
        Me.Panel3.Controls.Add(Me.lblYear)
        Me.Panel3.Controls.Add(Me.TxtMonth)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.TxtDate)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.TxtDay)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.TxtLongDate)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.TxtMediumDate)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.TxtShortDate)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.DtpFormatDate)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Location = New System.Drawing.Point(666, 12)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(395, 281)
        Me.Panel3.TabIndex = 21
        '
        'TxtYear
        '
        Me.TxtYear.BackColor = System.Drawing.SystemColors.Info
        Me.TxtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtYear.Location = New System.Drawing.Point(129, 243)
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.ReadOnly = True
        Me.TxtYear.Size = New System.Drawing.Size(252, 26)
        Me.TxtYear.TabIndex = 36
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(3, 245)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(52, 20)
        Me.lblYear.TabIndex = 35
        Me.lblYear.Text = "Year:"
        '
        'TxtMonth
        '
        Me.TxtMonth.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMonth.Location = New System.Drawing.Point(129, 211)
        Me.TxtMonth.Name = "TxtMonth"
        Me.TxtMonth.ReadOnly = True
        Me.TxtMonth.Size = New System.Drawing.Size(252, 26)
        Me.TxtMonth.TabIndex = 34
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 213)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 20)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Month:"
        '
        'TxtDate
        '
        Me.TxtDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDate.Location = New System.Drawing.Point(129, 179)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.ReadOnly = True
        Me.TxtDate.Size = New System.Drawing.Size(252, 26)
        Me.TxtDate.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(3, 181)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 20)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Date:"
        '
        'TxtDay
        '
        Me.TxtDay.BackColor = System.Drawing.SystemColors.Info
        Me.TxtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDay.Location = New System.Drawing.Point(129, 147)
        Me.TxtDay.Name = "TxtDay"
        Me.TxtDay.ReadOnly = True
        Me.TxtDay.Size = New System.Drawing.Size(252, 26)
        Me.TxtDay.TabIndex = 30
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(3, 149)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 20)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Day:"
        '
        'TxtLongDate
        '
        Me.TxtLongDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtLongDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLongDate.Location = New System.Drawing.Point(129, 115)
        Me.TxtLongDate.Name = "TxtLongDate"
        Me.TxtLongDate.ReadOnly = True
        Me.TxtLongDate.Size = New System.Drawing.Size(252, 26)
        Me.TxtLongDate.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(3, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Long Date:"
        '
        'TxtMediumDate
        '
        Me.TxtMediumDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMediumDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMediumDate.Location = New System.Drawing.Point(129, 83)
        Me.TxtMediumDate.Name = "TxtMediumDate"
        Me.TxtMediumDate.ReadOnly = True
        Me.TxtMediumDate.Size = New System.Drawing.Size(252, 26)
        Me.TxtMediumDate.TabIndex = 26
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Medium Date:"
        '
        'TxtShortDate
        '
        Me.TxtShortDate.BackColor = System.Drawing.SystemColors.Info
        Me.TxtShortDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtShortDate.Location = New System.Drawing.Point(129, 52)
        Me.TxtShortDate.Name = "TxtShortDate"
        Me.TxtShortDate.ReadOnly = True
        Me.TxtShortDate.Size = New System.Drawing.Size(252, 26)
        Me.TxtShortDate.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Short Date:"
        '
        'DtpFormatDate
        '
        Me.DtpFormatDate.Location = New System.Drawing.Point(181, 3)
        Me.DtpFormatDate.Name = "DtpFormatDate"
        Me.DtpFormatDate.Size = New System.Drawing.Size(200, 26)
        Me.DtpFormatDate.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(3, 3)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(140, 20)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Date Formatting"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.TxtTimeOfDay)
        Me.Panel4.Controls.Add(Me.LblTimeOfDay)
        Me.Panel4.Controls.Add(Me.TxtSeconds)
        Me.Panel4.Controls.Add(Me.LblSeconds)
        Me.Panel4.Controls.Add(Me.TxtMinutes)
        Me.Panel4.Controls.Add(Me.LblMinutes)
        Me.Panel4.Controls.Add(Me.TxtHours)
        Me.Panel4.Controls.Add(Me.Label19)
        Me.Panel4.Controls.Add(Me.TxtLongTime)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.TxtMediumTime)
        Me.Panel4.Controls.Add(Me.Label21)
        Me.Panel4.Controls.Add(Me.TxtShortTime)
        Me.Panel4.Controls.Add(Me.Label22)
        Me.Panel4.Controls.Add(Me.DtpTimeFormat)
        Me.Panel4.Controls.Add(Me.Label23)
        Me.Panel4.Location = New System.Drawing.Point(666, 299)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(395, 281)
        Me.Panel4.TabIndex = 22
        '
        'TxtTimeOfDay
        '
        Me.TxtTimeOfDay.BackColor = System.Drawing.SystemColors.Info
        Me.TxtTimeOfDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtTimeOfDay.Location = New System.Drawing.Point(129, 243)
        Me.TxtTimeOfDay.Name = "TxtTimeOfDay"
        Me.TxtTimeOfDay.ReadOnly = True
        Me.TxtTimeOfDay.Size = New System.Drawing.Size(252, 26)
        Me.TxtTimeOfDay.TabIndex = 36
        '
        'LblTimeOfDay
        '
        Me.LblTimeOfDay.AutoSize = True
        Me.LblTimeOfDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimeOfDay.Location = New System.Drawing.Point(3, 245)
        Me.LblTimeOfDay.Name = "LblTimeOfDay"
        Me.LblTimeOfDay.Size = New System.Drawing.Size(109, 20)
        Me.LblTimeOfDay.TabIndex = 35
        Me.LblTimeOfDay.Text = "Time of Day:"
        '
        'TxtSeconds
        '
        Me.TxtSeconds.BackColor = System.Drawing.SystemColors.Info
        Me.TxtSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSeconds.Location = New System.Drawing.Point(129, 211)
        Me.TxtSeconds.Name = "TxtSeconds"
        Me.TxtSeconds.ReadOnly = True
        Me.TxtSeconds.Size = New System.Drawing.Size(252, 26)
        Me.TxtSeconds.TabIndex = 34
        '
        'LblSeconds
        '
        Me.LblSeconds.AutoSize = True
        Me.LblSeconds.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeconds.Location = New System.Drawing.Point(3, 213)
        Me.LblSeconds.Name = "LblSeconds"
        Me.LblSeconds.Size = New System.Drawing.Size(79, 20)
        Me.LblSeconds.TabIndex = 33
        Me.LblSeconds.Text = "Seconds"
        '
        'TxtMinutes
        '
        Me.TxtMinutes.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMinutes.Location = New System.Drawing.Point(129, 179)
        Me.TxtMinutes.Name = "TxtMinutes"
        Me.TxtMinutes.ReadOnly = True
        Me.TxtMinutes.Size = New System.Drawing.Size(252, 26)
        Me.TxtMinutes.TabIndex = 32
        '
        'LblMinutes
        '
        Me.LblMinutes.AutoSize = True
        Me.LblMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMinutes.Location = New System.Drawing.Point(3, 181)
        Me.LblMinutes.Name = "LblMinutes"
        Me.LblMinutes.Size = New System.Drawing.Size(77, 20)
        Me.LblMinutes.TabIndex = 31
        Me.LblMinutes.Text = "Minutes:"
        '
        'TxtHours
        '
        Me.TxtHours.BackColor = System.Drawing.SystemColors.Info
        Me.TxtHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtHours.Location = New System.Drawing.Point(129, 147)
        Me.TxtHours.Name = "TxtHours"
        Me.TxtHours.ReadOnly = True
        Me.TxtHours.Size = New System.Drawing.Size(252, 26)
        Me.TxtHours.TabIndex = 30
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 149)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(62, 20)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "Hours:"
        '
        'TxtLongTime
        '
        Me.TxtLongTime.BackColor = System.Drawing.SystemColors.Info
        Me.TxtLongTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtLongTime.Location = New System.Drawing.Point(129, 115)
        Me.TxtLongTime.Name = "TxtLongTime"
        Me.TxtLongTime.ReadOnly = True
        Me.TxtLongTime.Size = New System.Drawing.Size(252, 26)
        Me.TxtLongTime.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(3, 117)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 20)
        Me.Label20.TabIndex = 27
        Me.Label20.Text = "Long Time:"
        '
        'TxtMediumTime
        '
        Me.TxtMediumTime.BackColor = System.Drawing.SystemColors.Info
        Me.TxtMediumTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMediumTime.Location = New System.Drawing.Point(129, 83)
        Me.TxtMediumTime.Name = "TxtMediumTime"
        Me.TxtMediumTime.ReadOnly = True
        Me.TxtMediumTime.Size = New System.Drawing.Size(252, 26)
        Me.TxtMediumTime.TabIndex = 26
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(3, 85)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(119, 20)
        Me.Label21.TabIndex = 25
        Me.Label21.Text = "Medium Time:"
        '
        'TxtShortTime
        '
        Me.TxtShortTime.BackColor = System.Drawing.SystemColors.Info
        Me.TxtShortTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtShortTime.Location = New System.Drawing.Point(129, 52)
        Me.TxtShortTime.Name = "TxtShortTime"
        Me.TxtShortTime.ReadOnly = True
        Me.TxtShortTime.Size = New System.Drawing.Size(252, 26)
        Me.TxtShortTime.TabIndex = 24
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(3, 54)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(101, 20)
        Me.Label22.TabIndex = 23
        Me.Label22.Text = "Short Time:"
        '
        'DtpTimeFormat
        '
        Me.DtpTimeFormat.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.DtpTimeFormat.Location = New System.Drawing.Point(284, 3)
        Me.DtpTimeFormat.Name = "DtpTimeFormat"
        Me.DtpTimeFormat.ShowUpDown = True
        Me.DtpTimeFormat.Size = New System.Drawing.Size(97, 26)
        Me.DtpTimeFormat.TabIndex = 19
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(3, 3)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(139, 20)
        Me.Label23.TabIndex = 18
        Me.Label23.Text = "Time Formatting"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.LblClock)
        Me.Panel5.Controls.Add(Me.Label18)
        Me.Panel5.Location = New System.Drawing.Point(413, 299)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(247, 142)
        Me.Panel5.TabIndex = 23
        '
        'LblClock
        '
        Me.LblClock.BackColor = System.Drawing.SystemColors.ControlLight
        Me.LblClock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblClock.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LblClock.Location = New System.Drawing.Point(11, 37)
        Me.LblClock.Name = "LblClock"
        Me.LblClock.Size = New System.Drawing.Size(222, 82)
        Me.LblClock.TabIndex = 19
        Me.LblClock.Text = "00:00:00"
        Me.LblClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(3, 3)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(109, 20)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "Digital Clock"
        '
        'TimClock
        '
        Me.TimClock.Enabled = True
        Me.TimClock.Interval = 1000
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.BtnSetToday)
        Me.Panel6.Controls.Add(Me.BtnPlusOneYear)
        Me.Panel6.Controls.Add(Me.BtnMinusOneYear)
        Me.Panel6.Controls.Add(Me.BtnPlusOneMonth)
        Me.Panel6.Controls.Add(Me.BtnMinusOneMonth)
        Me.Panel6.Controls.Add(Me.BtnPlusOneWeek)
        Me.Panel6.Controls.Add(Me.BtnMinusOneWeek)
        Me.Panel6.Controls.Add(Me.BtnPlusOneDay)
        Me.Panel6.Controls.Add(Me.BtnMinusOneDay)
        Me.Panel6.Controls.Add(Me.TxtDateString)
        Me.Panel6.Controls.Add(Me.Label17)
        Me.Panel6.Location = New System.Drawing.Point(413, 447)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(247, 133)
        Me.Panel6.TabIndex = 24
        '
        'BtnSetToday
        '
        Me.BtnSetToday.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnSetToday.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnSetToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetToday.ForeColor = System.Drawing.Color.Blue
        Me.BtnSetToday.Location = New System.Drawing.Point(183, 33)
        Me.BtnSetToday.Name = "BtnSetToday"
        Me.BtnSetToday.Size = New System.Drawing.Size(53, 27)
        Me.BtnSetToday.TabIndex = 34
        Me.BtnSetToday.Text = "Today"
        Me.BtnSetToday.UseVisualStyleBackColor = False
        '
        'BtnPlusOneYear
        '
        Me.BtnPlusOneYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPlusOneYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlusOneYear.Location = New System.Drawing.Point(183, 95)
        Me.BtnPlusOneYear.Name = "BtnPlusOneYear"
        Me.BtnPlusOneYear.Size = New System.Drawing.Size(52, 23)
        Me.BtnPlusOneYear.TabIndex = 33
        Me.BtnPlusOneYear.Text = "+1y"
        Me.BtnPlusOneYear.UseVisualStyleBackColor = True
        '
        'BtnMinusOneYear
        '
        Me.BtnMinusOneYear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMinusOneYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinusOneYear.Location = New System.Drawing.Point(183, 66)
        Me.BtnMinusOneYear.Name = "BtnMinusOneYear"
        Me.BtnMinusOneYear.Size = New System.Drawing.Size(52, 23)
        Me.BtnMinusOneYear.TabIndex = 32
        Me.BtnMinusOneYear.Text = "-1y"
        Me.BtnMinusOneYear.UseVisualStyleBackColor = True
        '
        'BtnPlusOneMonth
        '
        Me.BtnPlusOneMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPlusOneMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlusOneMonth.Location = New System.Drawing.Point(125, 95)
        Me.BtnPlusOneMonth.Name = "BtnPlusOneMonth"
        Me.BtnPlusOneMonth.Size = New System.Drawing.Size(52, 23)
        Me.BtnPlusOneMonth.TabIndex = 31
        Me.BtnPlusOneMonth.Text = "+1m"
        Me.BtnPlusOneMonth.UseVisualStyleBackColor = True
        '
        'BtnMinusOneMonth
        '
        Me.BtnMinusOneMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMinusOneMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinusOneMonth.Location = New System.Drawing.Point(125, 66)
        Me.BtnMinusOneMonth.Name = "BtnMinusOneMonth"
        Me.BtnMinusOneMonth.Size = New System.Drawing.Size(52, 23)
        Me.BtnMinusOneMonth.TabIndex = 30
        Me.BtnMinusOneMonth.Text = "-1m"
        Me.BtnMinusOneMonth.UseVisualStyleBackColor = True
        '
        'BtnPlusOneWeek
        '
        Me.BtnPlusOneWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPlusOneWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlusOneWeek.Location = New System.Drawing.Point(67, 95)
        Me.BtnPlusOneWeek.Name = "BtnPlusOneWeek"
        Me.BtnPlusOneWeek.Size = New System.Drawing.Size(52, 23)
        Me.BtnPlusOneWeek.TabIndex = 29
        Me.BtnPlusOneWeek.Text = "+1w"
        Me.BtnPlusOneWeek.UseVisualStyleBackColor = True
        '
        'BtnMinusOneWeek
        '
        Me.BtnMinusOneWeek.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMinusOneWeek.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinusOneWeek.Location = New System.Drawing.Point(67, 66)
        Me.BtnMinusOneWeek.Name = "BtnMinusOneWeek"
        Me.BtnMinusOneWeek.Size = New System.Drawing.Size(52, 23)
        Me.BtnMinusOneWeek.TabIndex = 28
        Me.BtnMinusOneWeek.Text = "-1w"
        Me.BtnMinusOneWeek.UseVisualStyleBackColor = True
        '
        'BtnPlusOneDay
        '
        Me.BtnPlusOneDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPlusOneDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPlusOneDay.Location = New System.Drawing.Point(9, 95)
        Me.BtnPlusOneDay.Name = "BtnPlusOneDay"
        Me.BtnPlusOneDay.Size = New System.Drawing.Size(52, 23)
        Me.BtnPlusOneDay.TabIndex = 27
        Me.BtnPlusOneDay.Text = "+1d"
        Me.BtnPlusOneDay.UseVisualStyleBackColor = True
        '
        'BtnMinusOneDay
        '
        Me.BtnMinusOneDay.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMinusOneDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMinusOneDay.Location = New System.Drawing.Point(9, 66)
        Me.BtnMinusOneDay.Name = "BtnMinusOneDay"
        Me.BtnMinusOneDay.Size = New System.Drawing.Size(52, 23)
        Me.BtnMinusOneDay.TabIndex = 26
        Me.BtnMinusOneDay.Text = "-1d"
        Me.BtnMinusOneDay.UseVisualStyleBackColor = True
        '
        'TxtDateString
        '
        Me.TxtDateString.BackColor = System.Drawing.SystemColors.Info
        Me.TxtDateString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDateString.Location = New System.Drawing.Point(7, 33)
        Me.TxtDateString.Name = "TxtDateString"
        Me.TxtDateString.ReadOnly = True
        Me.TxtDateString.Size = New System.Drawing.Size(170, 26)
        Me.TxtDateString.TabIndex = 25
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 3)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(199, 20)
        Me.Label17.TabIndex = 18
        Me.Label17.Text = "Plus/Minus Date Values"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 299)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 281)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'FrmDisplayingDateTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 589)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDisplayingDateTime"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Displaying Dates & Times"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LblAppointmentDateTime As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CalAppointmentMonth As MonthCalendar
    Friend WithEvents Label3 As Label
    Friend WithEvents cboAppointmentHour As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cboAppointmentMinute As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents CalDateRange As MonthCalendar
    Friend WithEvents TxtEndDate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtStartDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents BtnReset As Button
    Friend WithEvents DtpFormatDate As DateTimePicker
    Friend WithEvents TxtDate As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtDay As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtLongDate As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtMediumDate As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtShortDate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents lblYear As Label
    Friend WithEvents TxtMonth As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtTimeOfDay As TextBox
    Friend WithEvents LblTimeOfDay As Label
    Friend WithEvents TxtSeconds As TextBox
    Friend WithEvents LblSeconds As Label
    Friend WithEvents TxtMinutes As TextBox
    Friend WithEvents LblMinutes As Label
    Friend WithEvents TxtHours As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TxtLongTime As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtMediumTime As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtShortTime As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents DtpTimeFormat As DateTimePicker
    Friend WithEvents Label23 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LblClock As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents TimClock As Timer
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TxtDateString As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents BtnPlusOneWeek As Button
    Friend WithEvents BtnMinusOneWeek As Button
    Friend WithEvents BtnPlusOneDay As Button
    Friend WithEvents BtnMinusOneDay As Button
    Friend WithEvents BtnPlusOneYear As Button
    Friend WithEvents BtnMinusOneYear As Button
    Friend WithEvents BtnPlusOneMonth As Button
    Friend WithEvents BtnMinusOneMonth As Button
    Friend WithEvents BtnSetToday As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
