Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace SideBySideReport
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim masterReport As New MasterReport()
			Dim printTool As New ReportPrintTool(masterReport)
			printTool.ShowPreviewDialog()
		End Sub
	End Class
End Namespace