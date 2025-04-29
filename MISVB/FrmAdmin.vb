Public Class frmAdmin
    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        pagepanel.Controls.Clear()
        Dim frm As New frmDashboard() ' <-- palitan ito ng tamang form
        frm.TopLevel = False
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pagepanel.Controls.Add(frm)
        frm.Show()

        panelform.Dock = DockStyle.Top
        Dim myControl As New Dashboard() ' <-- siguraduhing ito ay tamang UserControl
        myControl.Dock = DockStyle.Fill
        panelform.Controls.Clear()
        panelform.Controls.Add(myControl)

    End Sub

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = Windows.Forms.FormWindowState.Maximized
    End Sub

    Private Sub btnjobposting_Click(sender As Object, e As EventArgs) Handles btnjobposting.Click
        pagepanel.Controls.Clear()
        Dim frm As New frmJobpositons()
        frm.TopLevel = False
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pagepanel.Controls.Add(frm)
        frm.Show()

        panelform.Dock = DockStyle.Top
        Dim myControl As New Jobpostions()
        myControl.Dock = DockStyle.Fill
        panelform.Controls.Clear()
        panelform.Controls.Add(myControl)
    End Sub

    Private Sub btnapplication_Click(sender As Object, e As EventArgs) Handles btnapplication.Click
        pagepanel.Controls.Clear()
        Dim frm As New frmAdminDashboard()
        frm.TopLevel = False
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frm.Dock = DockStyle.Fill
        pagepanel.Controls.Add(frm)
        frm.Show()

        panelform.Dock = DockStyle.Top
        Dim myControl As New AdminDashBoard()
        myControl.Dock = DockStyle.Fill
        panelform.Controls.Clear()
        panelform.Controls.Add(myControl)
    End Sub
End Class
