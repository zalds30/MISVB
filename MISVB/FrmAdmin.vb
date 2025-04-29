Public Class frmAdmin
    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        pagepanel.Controls.Clear()
        Dim frm As New frmAdminDashboard()
        frm.TopLevel = False
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pagepanel.Controls.Add(frm)
        frm.Show()

    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
    End Sub
End Class
