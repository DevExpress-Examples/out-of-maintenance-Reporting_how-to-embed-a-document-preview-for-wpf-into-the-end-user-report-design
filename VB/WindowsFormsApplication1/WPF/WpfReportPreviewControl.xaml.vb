Imports Microsoft.VisualBasic
Imports System.Windows.Controls
Imports DevExpress.XtraReports

Namespace WindowsFormsApplication1.WPF
	Partial Public Class WpfReportPreviewControl
		Inherits UserControl
		Public Property Report() As IReport
			Get
				Return (CType(preview.Model, ReportPreviewModel)).Report
			End Get
			Set(ByVal value As IReport)
				CType(preview.Model, ReportPreviewModel).Report = value
			End Set
		End Property
		Public Sub New()
			InitializeComponent()
		End Sub
	End Class
End Namespace
