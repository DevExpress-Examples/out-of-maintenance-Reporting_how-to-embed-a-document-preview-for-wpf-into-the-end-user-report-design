Imports Microsoft.VisualBasic
Imports System
Namespace E3465.WPF
	Partial Public Class WpfReportPreviewUserControl
		''' <summary> 
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.elementHost1 = New System.Windows.Forms.Integration.ElementHost()
			Me.wpfReportPreviewControl1 = New E3465.WPF.WpfReportPreviewControl()
			Me.SuspendLayout()
			' 
			' elementHost1
			' 
			Me.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.elementHost1.Location = New System.Drawing.Point(0, 0)
			Me.elementHost1.Name = "elementHost1"
			Me.elementHost1.Size = New System.Drawing.Size(1060, 512)
			Me.elementHost1.TabIndex = 0
			Me.elementHost1.Text = "elementHost1"
			Me.elementHost1.Child = Me.wpfReportPreviewControl1
			' 
			' WPFReportPreviewUserControl
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.elementHost1)
			Me.Name = "WPFReportPreviewUserControl"
			Me.Size = New System.Drawing.Size(1060, 512)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private elementHost1 As System.Windows.Forms.Integration.ElementHost
		Private wpfReportPreviewControl1 As WpfReportPreviewControl
	End Class
End Namespace
