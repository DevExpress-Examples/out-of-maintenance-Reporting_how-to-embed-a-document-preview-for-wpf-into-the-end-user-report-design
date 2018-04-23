Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Imports DevExpress.XtraReports

Namespace E3465.WPF
	Partial Public Class WpfReportPreviewUserControl
		Inherits UserControl
		Public Property Report() As IReport
			Get
				Return wpfReportPreviewControl1.Report
			End Get
			Set(ByVal value As IReport)
				wpfReportPreviewControl1.Report = value
			End Set
		End Property
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
