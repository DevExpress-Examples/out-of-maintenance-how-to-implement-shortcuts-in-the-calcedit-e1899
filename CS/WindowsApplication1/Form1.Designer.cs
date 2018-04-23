namespace WindowsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.myCalcEdit2 = new WindowsApplication1.MyCalcEdit();
            this.myCalcEdit1 = new WindowsApplication1.MyCalcEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myCalcEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCalcEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(241, 66);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "[Number]m = [Number]000000\r\n[Number]t = [Number]123456\r\n";
            // 
            // myCalcEdit2
            // 
            this.myCalcEdit2.EditValue = "1";
            this.myCalcEdit2.Location = new System.Drawing.Point(12, 140);
            this.myCalcEdit2.Name = "myCalcEdit2";
            this.myCalcEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "m", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "X000000", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "t", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "X123456", null, null, true)});
            this.myCalcEdit2.Properties.Mask.EditMask = "\\d+[m,t]?";
            this.myCalcEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.myCalcEdit2.Size = new System.Drawing.Size(241, 20);
            this.myCalcEdit2.TabIndex = 2;
            this.myCalcEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.myCalcEdit2_ButtonClick);
            // 
            // myCalcEdit1
            // 
            this.myCalcEdit1.EditValue = "1";
            this.myCalcEdit1.Location = new System.Drawing.Point(12, 100);
            this.myCalcEdit1.Name = "myCalcEdit1";
            this.myCalcEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.myCalcEdit1.Properties.Mask.EditMask = "\\d+[m,t]?";
            this.myCalcEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.myCalcEdit1.Size = new System.Drawing.Size(241, 20);
            this.myCalcEdit1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 177);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.myCalcEdit2);
            this.Controls.Add(this.myCalcEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myCalcEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myCalcEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MyCalcEdit myCalcEdit1;
        private MyCalcEdit myCalcEdit2;
        private System.Windows.Forms.TextBox textBox1;


    }
}

