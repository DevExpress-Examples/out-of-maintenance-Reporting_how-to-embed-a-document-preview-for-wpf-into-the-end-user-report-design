Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins

Namespace E3465
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			' Set the Office 2007 Blue skin
			OfficeSkins.Register()
			SkinManager.EnableFormSkins()
			UserLookAndFeel.Default.UseWindowsXPTheme = False
			UserLookAndFeel.Default.Style = LookAndFeelStyle.Skin
			UserLookAndFeel.Default.SkinName = "Office 2007 Blue"

			Application.Run(New Form1())
		End Sub
	End Class
End Namespace
