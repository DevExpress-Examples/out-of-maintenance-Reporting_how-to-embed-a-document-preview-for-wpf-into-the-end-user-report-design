Imports Microsoft.VisualBasic
Imports System.Drawing
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.Design
Imports DevExpress.XtraReports.UserDesigner

Namespace Common
	Friend Class BarButtonTabPage
		Inherits XtraTabControl.TabPage
		Private ReadOnly barButtonItem As BarButtonItem
		Private wpfReportPreviewUserControl As WindowsFormsApplication1.WPF.WpfReportPreviewUserControl
		Private Caption As String
		Private reportCommand As ReportCommand

		Public Sub New(ByVal wpfReportPreviewUserControl As WindowsFormsApplication1.WPF.WpfReportPreviewUserControl, ByVal Caption As String, ByVal button As BarButtonItem, ByVal reportCommand As ReportCommand)
			MyBase.New(wpfReportPreviewUserControl, Caption, reportCommand)
			Me.wpfReportPreviewUserControl = wpfReportPreviewUserControl
			Me.Caption = Caption
			Me.reportCommand = reportCommand
			Me.barButtonItem = button
		End Sub
		Public Overrides Property Selected() As Boolean
			Get
				Return MyBase.Selected
			End Get
			Set(ByVal value As Boolean)
				If MyBase.Selected <> value Then
					barButtonItem.Down = value
				End If
				MyBase.Selected = value
			End Set
		End Property
		Public Overrides Property Visible() As Boolean
			Get
				Return MyBase.Visible
			End Get
			Set(ByVal value As Boolean)
				MyBase.Visible = value
				barButtonItem.Visibility = If(value, BarItemVisibility.Always, BarItemVisibility.Never)
			End Set
		End Property
		Public Overrides Property Image() As Image
			Get
				Return barButtonItem.Glyph
			End Get
			Set(ByVal value As Image)
				barButtonItem.Glyph = value
			End Set
		End Property
	End Class
End Namespace