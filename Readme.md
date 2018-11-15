<!-- default file list -->
*Files to look at*:

* [Customer.cs](./CS/GridBeforePrint/Customer.cs) (VB: [Customer.vb](./VB/GridBeforePrint/Customer.vb))
* [Form1.cs](./CS/GridBeforePrint/Form1.cs) (VB: [Form1.vb](./VB/GridBeforePrint/Form1.vb))
* [HeaderPrintEventArgs.cs](./CS/GridBeforePrint/HeaderPrintEventArgs.cs) (VB: [HeaderPrintEventArgs.vb](./VB/GridBeforePrint/HeaderPrintEventArgs.vb))
* [MyGridControl.cs](./CS/GridBeforePrint/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/GridBeforePrint/MyGridControl.vb))
* [MyGridViewPrintInfo.cs](./CS/GridBeforePrint/MyGridViewPrintInfo.cs) (VB: [MyGridViewPrintInfo.vb](./VB/GridBeforePrint/MyGridViewPrintInfo.vb))
* [Program.cs](./CS/GridBeforePrint/Program.cs) (VB: [Program.vb](./VB/GridBeforePrint/Program.vb))
* [SamplePrintEventArgs.cs](./CS/GridBeforePrint/SamplePrintEventArgs.cs) (VB: [SamplePrintEventArgs.vb](./VB/GridBeforePrint/SamplePrintEventArgs.vb))
<!-- default file list end -->
# GridControl - How to implement events for custom printing cells and headers


<p>This is an example of a GridControl that has two custom events. These events can be used for custom drawing cells and headers in PrintPreview.<br>The MyGridViewPrintInfo class inherits from the GridViewPrintInfo and contains overridden methods: <br>1) PrintRowCell - for raising events for custom drawing cells;<br>2) PrintHeader - for raising events for custom drawing headers.</p>

<br/>


