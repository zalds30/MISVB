Public Class CalendarSchedule
    Dim currentDate As Date = Date.Today

    Private Sub CalendarSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For y As Integer = 2020 To 2030
            frmCalendarSchedule.ComboBox1.Items.Add(y)
        Next


        For m As Integer = 1 To 12
            frmCalendarSchedule.ComboBox2.Items.Add(MonthName(m))
        Next


        frmCalendarSchedule.ComboBox1.SelectedItem = currentDate.Year
        frmCalendarSchedule.ComboBox2.SelectedIndex = currentDate.Month - 1


        TableLayoutPanel1.Dock = DockStyle.Fill


        GenerateCalendar(currentDate)
    End Sub

    Private Sub GenerateCalendar(dateInMonth As Date)

        TableLayoutPanel1.Controls.Clear()
        TableLayoutPanel1.ColumnStyles.Clear()
        TableLayoutPanel1.RowStyles.Clear()

        TableLayoutPanel1.ColumnCount = 7
        TableLayoutPanel1.RowCount = 7


        For i As Integer = 0 To 6
            TableLayoutPanel1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 14.28F))
        Next


        TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Absolute, 30))
        For i As Integer = 1 To 6
            TableLayoutPanel1.RowStyles.Add(New RowStyle(SizeType.Percent, 16.66F))
        Next


        Dim daysOfWeek() As String = {"Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat"}
        For i As Integer = 0 To 6
            Dim lbl As New Label()
            lbl.Text = daysOfWeek(i)
            lbl.TextAlign = ContentAlignment.MiddleCenter
            lbl.Dock = DockStyle.Fill
            lbl.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            lbl.BackColor = Color.LightGray
            TableLayoutPanel1.Controls.Add(lbl, i, 0)
        Next


        Dim firstDayOfMonth As New Date(dateInMonth.Year, dateInMonth.Month, 1)
        Dim startDay As Integer = CInt(firstDayOfMonth.DayOfWeek)
        Dim daysInMonth As Integer = Date.DaysInMonth(dateInMonth.Year, dateInMonth.Month)


        Dim dayCounter As Integer = 1
        For row As Integer = 1 To 6
            For col As Integer = 0 To 6
                If row = 1 AndAlso col < startDay Then

                    TableLayoutPanel1.Controls.Add(New Label(), col, row)
                ElseIf dayCounter <= daysInMonth Then

                    Dim btn As New Button()
                    btn.Text = dayCounter.ToString()
                    btn.Dock = DockStyle.Fill
                    btn.FlatStyle = FlatStyle.Flat
                    btn.BackColor = Color.White
                    btn.ForeColor = Color.Black
                    AddHandler btn.Click, AddressOf DayButton_Click
                    TableLayoutPanel1.Controls.Add(btn, col, row)
                    dayCounter += 1
                End If
            Next
        Next
    End Sub

    Private Sub DayButton_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        MessageBox.Show("Select Day: " & btn.Text)
    End Sub

    Public Sub UpdateCalendarIfReady()
        If frmCalendarSchedule.ComboBox1.SelectedItem IsNot Nothing AndAlso frmCalendarSchedule.ComboBox2.SelectedItem IsNot Nothing Then
            Dim selectedYear As Integer = CInt(frmCalendarSchedule.ComboBox1.SelectedItem)
            Dim selectedMonth As Integer = frmCalendarSchedule.ComboBox2.SelectedIndex + 1
            Dim selectedDate As New Date(selectedYear, selectedMonth, 1)
            GenerateCalendar(selectedDate)
        End If
    End Sub
End Class
