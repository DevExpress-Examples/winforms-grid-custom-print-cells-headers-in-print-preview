using DevExpress.Utils;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Printing;
using DevExpress.XtraPrinting;
using System.ComponentModel;

namespace GridBeforePrint
{
    [ToolboxItem(true)]
    public class MyGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            return CreateView("MyGridView");
        }
        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new MyGridViewInfoRegistrator());
        }
    }

    public class MyGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName { get { return "MyGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid as GridControl); }
    }

    public class MyGridView : GridView
    {
        protected override BaseViewPrintInfo CreatePrintInfoInstance(PrintInfoArgs args)
        {
            return new MyGridViewPrintInfo(args);
        }
        public delegate void SampleEventHandler(object sender, SamplePrintEventArgs args);

        public delegate void HeaderPainterEventHandler(object sender, HeaderPrintEventArgs args);

        public event HeaderPainterEventHandler HeaderPrintEvent;

        public event SampleEventHandler SamplePrintEvent;

        public void RaiseHeaderPrintEvent(object sender, HeaderPrintEventArgs args)
        {
            if (HeaderPrintEvent != null)
                HeaderPrintEvent(sender, args);
        }

        public void RaiseSamplePrintEvent(object sender, SamplePrintEventArgs args)
        {
            if (SamplePrintEvent != null)
                SamplePrintEvent(sender, args);
        }

        public MyGridView() : this(null) { }
        public MyGridView(DevExpress.XtraGrid.GridControl grid) : base(grid) { }

        public MyGridView(MyGridControl grid) : base(grid) { }

        protected override string ViewName { get { return "MyGridView"; } }

        protected internal string GoAndGetNonFormattedCaption(string caption)
        {
            return GetNonFormattedCaption(caption);
        }

        internal string GoAndGetRowCellDisplayTextCore(int rowHandle, GridColumn column, BaseEditViewInfo bev, object value, bool forGroupRow)
        {
            return base.GetRowCellDisplayTextCore(rowHandle, column, bev, value, forGroupRow);
        }

        public HorzAlignment GetHorzAlignment(int rowHandle, GridColumn column, HorzAlignment currentAlignment)
        {
            return base.GetRowCellDefaultAlignment(rowHandle, column, currentAlignment);
        }
    }

    public class MyGridViewInfo : GridViewInfo
    {
        public MyGridViewInfo(MyGridView gridView) : base(gridView) { }

        protected internal void GoAndUpdateCellAppearanceCore(GridCellInfo cell)
        {
            base.UpdateCellAppearanceCore(cell);
        }
    }
}
