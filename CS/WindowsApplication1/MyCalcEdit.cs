using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Mask;

namespace WindowsApplication1
{
    public class MyCalcEdit : CalcEdit
    {
        public MyCalcEdit()
        {
            Properties.Mask.EditMask = @"\d+[m,t]?";
            Properties.Mask.MaskType = MaskType.RegEx;
        }

        public override object EditValue
        {
            get
            {
                object val = base.EditValue;
                if (val != null) val = val.ToString().Replace("m", "000000");
                if (val != null) val = val.ToString().Replace("t", "123456");
                return val;
            }
            set
            {
                base.EditValue = value;
            }
        }
    }
}
