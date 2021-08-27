<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128597952/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E20053)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/dx_sample/Form1.cs) (VB: [Form1.vb](./VB/dx_sample/Form1.vb))
* [Program.cs](./CS/dx_sample/Program.cs) (VB: [Program.vb](./VB/dx_sample/Program.vb))
* [XtraReport1.cs](./CS/dx_sample/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/dx_sample/XtraReport1.vb))
* [XtraReport2.cs](./CS/dx_sample/XtraReport2.cs) (VB: [XtraReport2.vb](./VB/dx_sample/XtraReport2.vb))
<!-- default file list end -->
# Customizing row height at runtime to a maximum best fit value


<p>This example demonstrates how to set XRTable.Height at runtime for all generated details to the best-fit value given by the maximum row height. Here, each data row is represented by an XRTable object but the approach is easily generalizable to any data-bound XRControl (e.g. XRLabel).</p>


<h3>Description</h3>

<p>CreateCustomDocument calls CreateDocument twice. On the second pass, row heights are set appropriately.</p>

<br/>


