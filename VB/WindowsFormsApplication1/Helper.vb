Imports System.IO
Imports System.Reflection
Imports DevExpress.XtraReports.UI

Namespace Common
	Public Module Helper
        Sub New()
        End Sub
        <System.Runtime.CompilerServices.Extension()> _
        Public Function Clone(ByVal report As XtraReport) As XtraReport
            Using ms = New MemoryStream()
                report.SaveLayoutToXml(ms)
                ms.Position = 0
                Return XtraReport.FromStream(ms, True)
            End Using
        End Function
        <System.Runtime.CompilerServices.Extension()> _
        Public Function GetProperty(Of T)(ByVal obj As Object, ByVal propertyName As String) As T
            Dim field = obj.GetType().GetProperty(propertyName, BindingFlags.Instance Or BindingFlags.NonPublic)
            Return CType(field.GetValue(obj, Nothing), T)
        End Function
	End Module
End Namespace