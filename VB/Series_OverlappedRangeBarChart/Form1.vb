Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace Series_OverlappedRangeBarChart
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            ' Create a new chart.
            Dim rangeBarChart As New ChartControl()

            ' Create two range bar series.
            Dim series1 As New Series("Series 1", ViewType.RangeBar)
            Dim series2 As New Series("Series 2", ViewType.RangeBar)

            ' Add points to them.
            series1.Points.Add(New SeriesPoint("A", 9, 15))
            series1.Points.Add(New SeriesPoint("B", 4, 10))
            series1.Points.Add(New SeriesPoint("C", 3, 13))
            series1.Points.Add(New SeriesPoint("D", 2, 11))
            series1.Points.Add(New SeriesPoint("E", 1, 10))

            series2.Points.Add(New SeriesPoint("A", 10, 13))
            series2.Points.Add(New SeriesPoint("B", 5, 7))
            series2.Points.Add(New SeriesPoint("C", 6, 9))
            series2.Points.Add(New SeriesPoint("D", 3, 7))
            series2.Points.Add(New SeriesPoint("E", 2, 8))

            ' Add both series to the chart.
            rangeBarChart.Series.AddRange(New Series() {series1, series2})

            ' Access the view-type-specific options of the series.
            Dim myView1 As RangeBarSeriesView = CType(series1.View, RangeBarSeriesView)
            myView1.MaxValueMarker.Visible = True
            myView1.MinValueMarker.Visible = True
            myView1.MinValueMarker.Kind = MarkerKind.Circle
            myView1.MinValueMarker.Kind = MarkerKind.Circle
            myView1.MaxValueMarker.Kind = MarkerKind.Star
            myView1.MaxValueMarker.StarPointCount = 5
            CType(series2.View, RangeBarSeriesView).BarWidth = 0.4

            ' Access the type-specific options of the diagram.
            CType(rangeBarChart.Diagram, XYDiagram).Rotated = True

            ' Hide the legend (if necessary).
            rangeBarChart.Legend.Visible = False

            ' Add a title to the chart (if necessary).
            rangeBarChart.Titles.Add(New ChartTitle())
            rangeBarChart.Titles(0).Text = "Overlapped Range Bar Chart"
            rangeBarChart.Titles(0).WordWrap = True

            ' Add the chart to the form.
            rangeBarChart.Dock = DockStyle.Fill
            Me.Controls.Add(rangeBarChart)
        End Sub

    End Class
End Namespace