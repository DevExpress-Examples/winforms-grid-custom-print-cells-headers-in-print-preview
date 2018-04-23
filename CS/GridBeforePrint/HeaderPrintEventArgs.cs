using DevExpress.XtraGrid.Views.Printing;
using DevExpress.XtraPrinting;

namespace GridBeforePrint
{
    public class HeaderPrintEventArgs
    {
        public ITextBrick Brick { get; private set; }

        public PrintColumnInfo ColumnInfo { get; private set; }

        public HeaderPrintEventArgs(ITextBrick brick, PrintColumnInfo columnInfo)
        {
            Brick = brick;
            ColumnInfo = columnInfo;
        }
    }
}
