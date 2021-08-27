<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128623770/11.2.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3969)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/XtraGauge_Animation/Form1.cs) (VB: [Form1.vb](./VB/XtraGauge_Animation/Form1.vb))
<!-- default file list end -->
# How to customize animation


<p>This example demonstrates how to use animation effects in XtraGauges.</p>


<h3>Description</h3>

<p>Analog gauges (circular and linear) provide numerous animation effects by specifying easing functions. </p><p>To do this, assign the easing mode for a Circular (Linear) Gauge via the  <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesCircularArcScaleComponent_EasingModetopic"><u>ArcScaleComponent.EasingMode</u></a> (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesLinearLinearScaleComponent_EasingModetopic"><u>LinearScaleComponent.EasingMode</u></a>) property. And then, select the desired easing function using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesCircularArcScaleComponent_EasingFunctiontopic"><u>ArcScaleComponent.EasingFunction</u></a> (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesLinearLinearScaleComponent_EasingFunctiontopic"><u>LinearScaleComponent.EasingFunction</u></a>) property.</p><p>To start using animation effects, activate the gauge animation for the Circular Gauge (Linear Gauge) by setting the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesCircularArcScaleComponent_EnableAnimationtopic"><u>ArcScaleComponent.EnableAnimation</u></a>  (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesLinearLinearScaleComponent_EnableAnimationtopic"><u>LinearScaleComponent.EnableAnimation</u></a> ) property to  <strong>true</strong>. </p><p>You also need to update scale&#39;s values in the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraGaugesCoreModelArcScale_Valuetopic"><u>ArcScale.Value</u></a> (<a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraGaugesCoreModelLinearScale_Valuetopic"><u>LinearScale.Value</u></a>) property. Note that in this example this is done for each timer tick. </p>

<br/>


