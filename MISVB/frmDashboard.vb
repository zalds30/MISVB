Public Class frmDashboard
    Private Sub frmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Sample Data")
        Chart1.Series.Clear()
        Dim series As New DataVisualization.Charting.Series("SampleData")
        series.ChartType = DataVisualization.Charting.SeriesChartType.Doughnut
        series.Points.AddXY("January", 100)
        series.Points.AddXY("February", 120)
        series.Points.AddXY("March", 90)
        series.Points.AddXY("April", 150)
        Chart1.Series.Add(series)
    End Sub
End Class