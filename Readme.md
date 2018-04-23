# How to customize animation


<p>This example demonstrates how to use animation effects in XtraGauges.</p>


<h3>Description</h3>

<p>Analog gauges (circular and linear) provide numerous animation effects by specifying easing functions. </p><p>To do this, assign the easing mode for a Circular (Linear) Gauge via the  <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesCircularArcScaleComponent_EasingModetopic"><u>ArcScaleComponent.EasingMode</u></a> (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesLinearLinearScaleComponent_EasingModetopic"><u>LinearScaleComponent.EasingMode</u></a>) property. And then, select the desired easing function using the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesCircularArcScaleComponent_EasingFunctiontopic"><u>ArcScaleComponent.EasingFunction</u></a> (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesLinearLinearScaleComponent_EasingFunctiontopic"><u>LinearScaleComponent.EasingFunction</u></a>) property.</p><p>To start using animation effects, activate the gauge animation for the Circular Gauge (Linear Gauge) by setting the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesCircularArcScaleComponent_EnableAnimationtopic"><u>ArcScaleComponent.EnableAnimation</u></a>  (<a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesWinGaugesLinearLinearScaleComponent_EnableAnimationtopic"><u>LinearScaleComponent.EnableAnimation</u></a> ) property to  <strong>true</strong>. </p><p>You also need to update scale&#39;s values in the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraGaugesCoreModelArcScale_Valuetopic"><u>ArcScale.Value</u></a> (<a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraGaugesCoreModelLinearScale_Valuetopic"><u>LinearScale.Value</u></a>) property. Note that in this example this is done for each timer tick. </p>

<br/>


