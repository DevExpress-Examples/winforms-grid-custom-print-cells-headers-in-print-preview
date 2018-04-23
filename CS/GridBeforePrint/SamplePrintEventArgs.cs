using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;

namespace GridBeforePrint
{
    public class SamplePrintEventArgs
    {
        public bool IsPreview { get; private set; }

        public IVisualBrick Brick { get; private set; }

        public GridColumn Column { get; private set; }

        public int RowHandle { get; private set; }

        public SamplePrintEventArgs(int rowHandle, GridColumn column, IVisualBrick brick, bool isPreview)
        {
            RowHandle = rowHandle;
            Column = column;
            Brick = brick;
            IsPreview = isPreview;
        }
    }
}
