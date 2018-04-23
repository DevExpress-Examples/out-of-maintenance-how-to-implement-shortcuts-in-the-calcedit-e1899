Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Mask

Namespace WindowsApplication1
	Public Class MyCalcEdit
		Inherits CalcEdit
		Public Sub New()
			Properties.Mask.EditMask = "\d+[m,t]?"
			Properties.Mask.MaskType = MaskType.RegEx
		End Sub

		Public Overrides Property EditValue() As Object
			Get
				Dim val As Object = MyBase.EditValue
				If val IsNot Nothing Then
					val = val.ToString().Replace("m", "000000")
				End If
				If val IsNot Nothing Then
					val = val.ToString().Replace("t", "123456")
				End If
				Return val
			End Get
			Set(ByVal value As Object)
				MyBase.EditValue = value
			End Set
		End Property
	End Class
End Namespace
