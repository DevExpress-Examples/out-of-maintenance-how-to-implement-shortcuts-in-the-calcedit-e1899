Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub myCalcEdit2_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles myCalcEdit2.ButtonClick
			Select Case e.Button.Index

				Case 1
					TryCast(sender, CalcEdit).Text &= "m"
				Case 2
					TryCast(sender, CalcEdit).Text &= "t"
				Case Else
			End Select

		End Sub
	End Class
End Namespace
