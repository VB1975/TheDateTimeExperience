Public Class FrmDisplayingDateTime

    Private DateString As Date

    Private Sub FrmDisplayingDateTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Appointments
        PopulateTime()
        SetDefaults()

        ' Date Formatting
        DateFormatting()

        ' Time Formatting
        TimeFormatting()

        ' Digital Clock
        LblClock.Text = TimeValue(Now)

        ' Plus/Minus Date Values
        TxtDateString.Text = Today().ToLongDateString()

    End Sub

    '-------------------------------------------------------------------------------------------------------------------

    ' Appointments
    Private Sub PopulateTime()

        Dim X As Integer, nextMinute As Integer
        Dim currentMinutes As Integer = DateTime.Now.Minute

        cboAppointmentHour.Items.Clear()
        cboAppointmentMinute.Items.Clear()

        For X = 0 To 23
            cboAppointmentHour.Items.Add(Format(X, "00"))
        Next

        For X = 0 To 55 Step 5
            cboAppointmentMinute.Items.Add(Format(X, "00"))
        Next

        cboAppointmentHour.SelectedItem = Format(Now, "HH")

        If currentMinutes Mod 5 = 0 Then
            nextMinute = currentMinutes
        Else
            nextMinute = Math.Ceiling(currentMinutes / 5.0) * 5
            If nextMinute > 55 Then nextMinute = 0 ' Wrap around to 0 if it exceeds 55
        End If

        cboAppointmentMinute.SelectedItem = Format(nextMinute, "00")

    End Sub

    Private Sub SetAppointmentLabel() Handles CalAppointmentMonth.DateChanged,
                                             cboAppointmentHour.SelectedIndexChanged,
                                             cboAppointmentMinute.SelectedIndexChanged

        Dim AppointmentDate As Date = CalAppointmentMonth.SelectionStart
        Dim AppointmentTime As Date = TimeSerial(cboAppointmentHour.SelectedItem, cboAppointmentMinute.SelectedItem, 0)
        Dim AppointmentString As String

        If AppointmentTime <> #00:00:00# And AppointmentTime <> #12:00:00# Then
            AppointmentString = Format(AppointmentTime, "h:mm tt")
        Else
            If AppointmentTime = #00:00:00# Then
                AppointmentString = "Midnight"
            Else
                AppointmentString = "Noon"
            End If
        End If

        LblAppointmentDateTime.Text = Format(AppointmentDate, "dddd, dd MMMM yyyy") & " @ " & AppointmentString

    End Sub

    Private Sub SetDefaults()

        CalAppointmentMonth.SetDate(Now)
        Call PopulateTime()

    End Sub


    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click

        SetDefaults()

    End Sub

    '-------------------------------------------------------------------------------------------------------------------

    ' Date Range
    Private Sub CalDateRange_DateChanged(sender As Object, e As DateRangeEventArgs) Handles CalDateRange.DateChanged

        Dim StartDate As Date = CalDateRange.SelectionStart
        Dim EndDate As Date = CalDateRange.SelectionEnd
        TxtStartDate.Text = Format(StartDate, "yyyy-MM-dd")
        TxtEndDate.Text = Format(EndDate, "yyyy-MM-dd")

    End Sub

    '-------------------------------------------------------------------------------------------------------------------

    ' Date Formatting
    Private Sub DateFormatting()

        Dim SelectedDate As Date = DtpFormatDate.Value
        TxtShortDate.Text = SelectedDate.ToShortDateString
        TxtMediumDate.Text = SelectedDate.ToString("dd-MMM-yyyy")
        TxtLongDate.Text = SelectedDate.ToLongDateString
        TxtDay.Text = SelectedDate.DayOfWeek.ToString
        TxtDate.Text = SelectedDate.Day
        TxtMonth.Text = MonthName(SelectedDate.Month)
        TxtYear.Text = SelectedDate.Year

    End Sub

    Private Sub DtpFormatDate_ValueChanged(sender As Object, e As EventArgs) Handles DtpFormatDate.ValueChanged

        DateFormatting()

    End Sub

    '-------------------------------------------------------------------------------------------------------------------

    ' Time Formatting
    Private Sub TimeFormatting()

        Dim SelectedTime As Date = DtpTimeFormat.Value
        TxtShortTime.Text = SelectedTime.ToShortTimeString
        TxtMediumTime.Text = SelectedTime.ToString("h:mm:ss tt")
        TxtLongTime.Text = SelectedTime.ToLongTimeString
        TxtHours.Text = SelectedTime.Hour
        TxtMinutes.Text = SelectedTime.Minute
        TxtSeconds.Text = SelectedTime.Second

        If Hour(SelectedTime) < 12 Then
            TxtTimeOfDay.Text = "Morning"
        ElseIf Hour(SelectedTime) < 17 Then
            TxtTimeOfDay.Text = "Afternoon"
        ElseIf Hour(SelectedTime) < 20 Then
            TxtTimeOfDay.Text = "Evening"
        Else
            TxtTimeOfDay.Text = "Night"
        End If

    End Sub

    Private Sub DtpTimeFormat_ValueChanged(sender As Object, e As EventArgs) Handles DtpTimeFormat.ValueChanged

        TimeFormatting()

    End Sub

    '-------------------------------------------------------------------------------------------------------------------

    ' Digital Clock
    Private Sub TimClock_Tick(sender As Object, e As EventArgs) Handles TimClock.Tick

        LblClock.Text = TimeValue(Now)

    End Sub

    Private Sub LblClock_MouseHover(sender As Object, e As EventArgs) Handles LblClock.MouseHover

        Dim ClockToolTip As New ToolTip
        ClockToolTip.SetToolTip(LblClock, Format(Today(), "dddd, d MMMM yyyy"))

    End Sub

    '-------------------------------------------------------------------------------------------------------------------

    ' Plus/Minus Date Values
    Private Sub BtnSetToday_Click(sender As Object, e As EventArgs) Handles BtnSetToday.Click

        TxtDateString.Text = Today().ToLongDateString()

    End Sub

    Private Sub BtnMinusOneDay_Click(sender As Object, e As EventArgs) Handles BtnMinusOneDay.Click

        DateString = Date.Parse(TxtDateString.Text)
        TxtDateString.Text = DateString.AddDays(-1).ToLongDateString()

    End Sub

    Private Sub BtnPlusOneDay_Click(sender As Object, e As EventArgs) Handles BtnPlusOneDay.Click

        DateString = Date.Parse(TxtDateString.Text)
        TxtDateString.Text = DateString.AddDays(1).ToLongDateString()

    End Sub

    Private Sub BtnMinusOneWeek_Click(sender As Object, e As EventArgs) Handles BtnMinusOneWeek.Click

        DateString = Date.Parse(TxtDateString.Text)
        TxtDateString.Text = DateString.AddDays(-7).ToLongDateString()

    End Sub

    Private Sub BtnPlusOneWeek_Click(sender As Object, e As EventArgs) Handles BtnPlusOneWeek.Click

        DateString = Date.Parse(TxtDateString.Text)
        TxtDateString.Text = DateString.AddDays(7).ToLongDateString()

    End Sub

    Private Sub BtnMinusOneMonth_Click(sender As Object, e As EventArgs) Handles BtnMinusOneMonth.Click

        DateString = Date.Parse(TxtDateString.Text)
        TxtDateString.Text = DateString.AddMonths(-1).ToLongDateString()

    End Sub

    Private Sub BtnPlusOneMonth_Click(sender As Object, e As EventArgs) Handles BtnPlusOneMonth.Click

        DateString = Date.Parse(TxtDateString.Text)
        TxtDateString.Text = DateString.AddMonths(1).ToLongDateString()

    End Sub

    Private Sub BtnMinusOneYear_Click(sender As Object, e As EventArgs) Handles BtnMinusOneYear.Click

        DateString = Date.Parse(TxtDateString.Text)
        TxtDateString.Text = DateString.AddYears(-1).ToLongDateString()

    End Sub

    Private Sub BtnPlusOneYear_Click(sender As Object, e As EventArgs) Handles BtnPlusOneYear.Click

        DateString = Date.Parse(TxtDateString.Text)
        TxtDateString.Text = DateString.AddYears(1).ToLongDateString()

    End Sub
End Class
