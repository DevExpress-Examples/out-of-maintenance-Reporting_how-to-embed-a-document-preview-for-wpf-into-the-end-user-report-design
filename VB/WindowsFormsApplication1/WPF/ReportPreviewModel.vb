Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Printing

Namespace WindowsFormsApplication1.WPF
	Public Class ReportPreviewModel
		Inherits XtraReportPreviewModel
		Protected Overrides Function CanPageSetup(ByVal parameter As Object) As Boolean
			Return False
		End Function
		Protected Overrides Function CanScale(ByVal parameter As Object) As Boolean
			Return False
		End Function
	End Class
End Namespace
