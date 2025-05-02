Public Class frmCalendarSchedule

    Private myCalendar As CalendarSchedule
    Private Sub frmCalendarSchedule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Panel1.Dock = DockStyle.None

        myCalendar = New CalendarSchedule()
        myCalendar.Dock = DockStyle.Fill

        Panel1.Controls.Clear()
        Panel1.Controls.Add(myCalendar)


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If myCalendar IsNot Nothing Then
            myCalendar.UpdateCalendarIfReady()
        End If
    End Sub


End Class
