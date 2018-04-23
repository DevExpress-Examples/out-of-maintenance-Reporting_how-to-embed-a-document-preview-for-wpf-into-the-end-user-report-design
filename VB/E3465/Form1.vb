Imports Microsoft.VisualBasic
Imports System.Drawing
Imports System.Reflection
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner
Imports E3465.WPF

Namespace E3465
    Partial Public Class Form1
        Inherits XtraForm
        Private reportTabControl As ReportTabControl
        Private ReadOnly wpfReportPreviewUserControl As New WpfReportPreviewUserControl()
        Public Sub New()
            InitializeComponent()

            ' Hanlde the DesignerHostLoaded event of a Design Panel, 
            ' to add a new page to the ReportTabControl for showing Document Preview.
            AddHandler xrDesignPanel1.DesignerHostLoaded, AddressOf xrDesignPanel1_DesignerHostLoaded
            xrDesignPanel1.OpenReport(New XtraReport())

        End Sub
        Private Sub xrDesignPanel1_DesignerHostLoaded(ByVal sender As Object, ByVal e As DesignerLoadedEventArgs)
            reportTabControl = CType(e.DesignerHost.GetService(GetType(ReportTabControl)), ReportTabControl)
            Dim logic = reportTabControl.GetProperty(Of TabControlLogic)("Logic")
            Dim bar = logic.GetProperty(Of Bar)("StatusBar")
            AddTabPage(bar)
        End Sub

        Private Sub AddTabPage(ByVal bar As Bar)
            Const Caption As String = "WPF Preview"

            Dim button = New BarButtonItem(bar.Manager, Caption) With {.ButtonStyle = BarButtonStyle.Check, .PaintStyle = BarItemPaintStyle.CaptionGlyph, .GroupIndex = 1, .Glyph = Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream("WpfPreview.ico"))}
            bar.InsertItem(bar.ItemLinks(reportTabControl.Pages.Count), button)

            Dim page = New BarButtonTabPage(wpfReportPreviewUserControl, Caption, button, ReportCommand.None)
            reportTabControl.AddPage(wpfReportPreviewUserControl, page)

            ' Handle the WPF Preview BarButtonItem click event
            AddHandler button.ItemClick, AddressOf button_ItemClick
        End Sub

        Private Sub button_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Const WpfPreviewPageIndex As Integer = 4
            reportTabControl.SelectedIndex = WpfPreviewPageIndex
            If wpfReportPreviewUserControl.Report IsNot Nothing Then
                wpfReportPreviewUserControl.Report.Dispose()
            End If
            Dim report = xrDesignPanel1.Report.Clone()
            report.CreateDocument(True)
            wpfReportPreviewUserControl.Report = report
        End Sub
    End Class
End Namespace