using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HANACANPC
{
    public class CustomGridview
    {
        private static CustomGridview _instance;
        private CustomGridview() { }
        public static CustomGridview Instance
        {
            get{
                if (_instance != null) return _instance;
                _instance = new CustomGridview();
                return _instance;
            }
            private set { _instance = value; }
        }
        public void CustomDrawRowIndicator(RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) return;
            e.Info.DisplayText = (e.RowHandle + 1).ToString();
            e.Info.Appearance.Font = new Font("Tahoma", 10f);
            
        }

        public void CustomDrawRowIndicatorErrorResort(RowIndicatorCustomDrawEventArgs e)
        {
            if (!e.Info.IsRowIndicator || e.RowHandle < 0) return;
            e.Info.DisplayText = (e.RowHandle + 1).ToString();
            e.Info.Appearance.Font = new Font("Tahoma", 13f);
        }
    }
}
