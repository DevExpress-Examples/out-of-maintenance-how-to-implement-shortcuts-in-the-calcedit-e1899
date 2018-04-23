Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class Form1
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

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim serializableAppearanceObject1 As New DevExpress.Utils.SerializableAppearanceObject()
			Dim serializableAppearanceObject2 As New DevExpress.Utils.SerializableAppearanceObject()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.myCalcEdit2 = New WindowsApplication1.MyCalcEdit()
			Me.myCalcEdit1 = New WindowsApplication1.MyCalcEdit()
			CType(Me.myCalcEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myCalcEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' textBox1
			' 
			Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(204)))
			Me.textBox1.Location = New System.Drawing.Point(12, 12)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.ReadOnly = True
			Me.textBox1.Size = New System.Drawing.Size(241, 66)
			Me.textBox1.TabIndex = 3
			Me.textBox1.Text = "[Number]m = [Number]000000" & Constants.vbCrLf & "[Number]t = [Number]123456" & Constants.vbCrLf
			' 
			' myCalcEdit2
			' 
			Me.myCalcEdit2.EditValue = "1"
			Me.myCalcEdit2.Location = New System.Drawing.Point(12, 140)
			Me.myCalcEdit2.Name = "myCalcEdit2"
			Me.myCalcEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "m", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "X000000", Nothing, Nothing, True), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "t", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "X123456", Nothing, Nothing, True)})
			Me.myCalcEdit2.Properties.Mask.EditMask = "\d+[m,t]?"
			Me.myCalcEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			Me.myCalcEdit2.Size = New System.Drawing.Size(241, 20)
			Me.myCalcEdit2.TabIndex = 2
'			Me.myCalcEdit2.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.myCalcEdit2_ButtonClick);
			' 
			' myCalcEdit1
			' 
			Me.myCalcEdit1.EditValue = "1"
			Me.myCalcEdit1.Location = New System.Drawing.Point(12, 100)
			Me.myCalcEdit1.Name = "myCalcEdit1"
			Me.myCalcEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.myCalcEdit1.Properties.Mask.EditMask = "\d+[m,t]?"
			Me.myCalcEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx
			Me.myCalcEdit1.Size = New System.Drawing.Size(241, 20)
			Me.myCalcEdit1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 177)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.myCalcEdit2)
			Me.Controls.Add(Me.myCalcEdit1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.myCalcEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myCalcEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private myCalcEdit1 As MyCalcEdit
		Private WithEvents myCalcEdit2 As MyCalcEdit
		Private textBox1 As System.Windows.Forms.TextBox


	End Class
End Namespace

