<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624535/15.2.10%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T368970)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
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


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-custom-print-cells-headers-in-print-preview&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-custom-print-cells-headers-in-print-preview&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
