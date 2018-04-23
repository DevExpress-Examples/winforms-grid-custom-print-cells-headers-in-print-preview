using DevExpress.Utils;
using DevExpress.Utils.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Printing;
using DevExpress.XtraPrinting;
using System;
using System.Drawing;

namespace GridBeforePrint
{
    public class MyGridViewPrintInfo : GridViewPrintInfo
    {
        public MyGridViewPrintInfo(PrintInfoArgs args) : base(args) { }

        public override void PrintHeader(DevExpress.XtraPrinting.IBrickGraphics graph)
        {
            if (!View.OptionsPrint.PrintHeader) return;
            Point indent = new Point(Indent, HeaderY);
            Rectangle r = Rectangle.Empty;
            bool usePrintStyles = View.OptionsPrint.UsePrintStyles;
            SetDefaultBrickStyle(graph, Bricks["HeaderPanel"]);
            foreach (PrintColumnInfo col in Columns)
            {
                if (!usePrintStyles)
                {
                    AppearanceObject temp = new AppearanceObject();
                    AppearanceHelper.Combine(temp, new AppearanceObject[] { col.Column.AppearanceHeader, View.Appearance.HeaderPanel, AppearancePrint.HeaderPanel });
                    SetDefaultBrickStyle(graph, Bricks.Create(temp, BorderSide.All, temp.BorderColor, 1));
                }
                r = col.Bounds;
                r.Offset(indent);
                string caption = GetTextCaptionForPrinting(col.Column);
                if (!col.Column.OptionsColumn.ShowCaption) caption = string.Empty;
                ITextBrick itb = DrawTextBrick(graph, caption, r);

                (View as MyGridView).RaiseHeaderPrintEvent(this, new HeaderPrintEventArgs(itb, col));

                if (caption.Contains(Environment.NewLine)) itb.Style.StringFormat = BrickStringFormat.Create(itb.Style.TextAlignment, true);
                if (AppearancePrint.HeaderPanel.TextOptions.WordWrap == WordWrap.NoWrap && View.OptionsPrint.UsePrintStyles)
                {
                    using (Graphics g = this.View.GridControl.CreateGraphics())
                    {
                        SizeF s = g.MeasureString(itb.Text, itb.Font, 1000, itb.StringFormat.Value);
                        if (s.Width + 5 >= r.Width)
                        {
                            itb.Text = "";
                            itb.TextValue = "";
                        }
                    }
                }
            }
        }

        protected string GetTextCaptionForPrinting(GridColumn column)
        {
            if (View == null) return column.Caption;
            var gview = View.OptionsPrint as GridOptionsPrint;
            if (gview != null && !gview.AllowMultilineHeaders) return column.GetTextCaption();
            return (View as MyGridView).GoAndGetNonFormattedCaption(column.GetCaption());
        }

        protected override void PrintRowCell(int rowHandle, GridCellInfo cell, Rectangle r)
        {
            View.OptionsPrint.PrintPreview = true;
            string displayText = (View as MyGridView).GoAndGetRowCellDisplayTextCore(rowHandle, cell.Column, cell.ViewInfo, cell.CellValue, false);
            MyGridViewInfo myGridViewInfo = new MyGridViewInfo(View as MyGridView);
            myGridViewInfo.GoAndUpdateCellAppearanceCore(cell);
            if (cell.ViewInfo.AllowHtmlString)
            {
                displayText = StringPainter.Default.RemoveFormat(displayText, true);
            }
            HorzAlignment horzAlignment = (View as MyGridView).GetHorzAlignment(rowHandle, cell.Column, cell.Appearance.HAlignment);
            PrintCellHelperInfo info = new PrintCellHelperInfo(new Point(cell.Column == null ? -1 : cell.Column.AbsoluteIndex, rowHandle),
                LineColor,
                PS,
                cell.CellValue,
                cell.Appearance,
                displayText,
                r,
                Graph,
                horzAlignment,
                View.OptionsPrint.PrintHorzLines,
                View.OptionsPrint.PrintVertLines,
                cell.ColumnInfo.Column.DisplayFormat.FormatString,
                CalcBrickBordersEX(),
                new PaddingInfo(2, GraphicsDpi.Pixel)
                );

            IVisualBrick brick = cell.Editor.GetBrick(info);

            MyGridView view = this.View as MyGridView;
            view.RaiseSamplePrintEvent(this, new SamplePrintEventArgs(cell.RowHandle, cell.Column, brick, false));
            
            if (AllowProcessMergedInfo)
            {
                brick.Rect = r;
                UpdateMergedStatus(cell, (VisualBrick)brick);
            }
            Graph.DrawBrick(brick, r);
        }

        DevExpress.XtraPrinting.BorderSide CalcBrickBordersEX()
        {
            BorderSide border = BorderSide.None;
            if (View.OptionsPrint.PrintHorzLines) border |= BorderSide.Top | BorderSide.Bottom;
            if (View.OptionsPrint.PrintVertLines) border |= BorderSide.Left | BorderSide.Right;
            return border;
        }

    }
}
