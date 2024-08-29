<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624535/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T368970)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - Custom paint data cells and column headers in Print Preview

This example creates a custom Grid Control with new custom draw events (`SamplePrintEvent`, `HeaderPrintEvent`) that allow you to paint data cells and column headers in print preview:

![WinForms Data Grid - Custom print data cells and column headers in Print Preview](https://raw.githubusercontent.com/DevExpress-Examples/gridcontrol-how-to-implement-events-for-custom-printing-cells-and-headers-t368970/23.1.2%2B/media/winforms-grid-custom-paint-print.png)

```csharp
private void MyGridView1_HeaderPrintEvent(object sender, HeaderPrintEventArgs args) {
    args.Brick.Style.BackColor = Color.PowderBlue;
}
private void simpleButton2_Click(object sender, EventArgs e) {
    myGridControl1.ShowPrintPreview();
}
```


## Files to Review

* [Customer.cs](./CS/GridBeforePrint/Customer.cs) (VB: [Customer.vb](./VB/GridBeforePrint/Customer.vb))
* [Form1.cs](./CS/GridBeforePrint/Form1.cs) (VB: [Form1.vb](./VB/GridBeforePrint/Form1.vb))
* [HeaderPrintEventArgs.cs](./CS/GridBeforePrint/HeaderPrintEventArgs.cs) (VB: [HeaderPrintEventArgs.vb](./VB/GridBeforePrint/HeaderPrintEventArgs.vb))
* [MyGridControl.cs](./CS/GridBeforePrint/MyGridControl.cs) (VB: [MyGridControl.vb](./VB/GridBeforePrint/MyGridControl.vb))
* [MyGridViewPrintInfo.cs](./CS/GridBeforePrint/MyGridViewPrintInfo.cs) (VB: [MyGridViewPrintInfo.vb](./VB/GridBeforePrint/MyGridViewPrintInfo.vb))
* [SamplePrintEventArgs.cs](./CS/GridBeforePrint/SamplePrintEventArgs.cs) (VB: [SamplePrintEventArgs.vb](./VB/GridBeforePrint/SamplePrintEventArgs.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-custom-print-cells-headers-in-print-preview&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-custom-print-cells-headers-in-print-preview&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
