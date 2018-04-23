Imports Microsoft.VisualBasic
Imports System
Namespace XtraGauge_Animation
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim arcScaleRange25 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange26 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Dim arcScaleRange27 As New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
			Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
			Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
			Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
			Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
			Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
			Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
			Me.BackEase = New System.Windows.Forms.RadioButton()
			Me.ElasticEase = New System.Windows.Forms.RadioButton()
			Me.BounceEase = New System.Windows.Forms.RadioButton()
			Me.PowerEase = New System.Windows.Forms.RadioButton()
			Me.EaseMode = New System.Windows.Forms.ComboBox()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.QuadraticEase = New System.Windows.Forms.RadioButton()
			Me.CubicEase = New System.Windows.Forms.RadioButton()
			Me.QuinticEase = New System.Windows.Forms.RadioButton()
			Me.SineEase = New System.Windows.Forms.RadioButton()
			Me.ExponentialEase = New System.Windows.Forms.RadioButton()
			Me.CircleEase = New System.Windows.Forms.RadioButton()
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gaugeControl1
			' 
			Me.gaugeControl1.AutoLayout = False
			Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.circularGauge1})
			Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
			Me.gaugeControl1.Name = "gaugeControl1"
			Me.gaugeControl1.Size = New System.Drawing.Size(260, 376)
			Me.gaugeControl1.TabIndex = 0
			' 
			' circularGauge1
			' 
			Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() { Me.arcScaleBackgroundLayerComponent1})
			Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 248, 364)
			Me.circularGauge1.Name = "circularGauge1"
			Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() { Me.arcScaleNeedleComponent1})
			Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() { Me.arcScaleComponent1})
			Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() { Me.arcScaleSpindleCapComponent1})
			' 
			' arcScaleBackgroundLayerComponent1
			' 
			Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleBackgroundLayerComponent1.Name = "bg"
			Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style16
			Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
			' 
			' arcScaleComponent1
			' 
			Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 8.5F)
			Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
			Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
			Me.arcScaleComponent1.EndAngle = 60F
			Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
			Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -14F
			Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
			Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
			Me.arcScaleComponent1.MaxValue = 100F
			Me.arcScaleComponent1.MinorTickCount = 4
			Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -7F
			Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
			Me.arcScaleComponent1.Name = "scale1"
			arcScaleRange25.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968")
			arcScaleRange25.EndThickness = 14F
			arcScaleRange25.EndValue = 33F
			arcScaleRange25.Name = "Range0"
			arcScaleRange25.ShapeOffset = 0F
			arcScaleRange25.StartThickness = 14F
			arcScaleRange26.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FED96D")
			arcScaleRange26.EndThickness = 14F
			arcScaleRange26.EndValue = 66F
			arcScaleRange26.Name = "Range1"
			arcScaleRange26.ShapeOffset = 0F
			arcScaleRange26.StartThickness = 14F
			arcScaleRange26.StartValue = 33F
			arcScaleRange27.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EF8C75")
			arcScaleRange27.EndThickness = 14F
			arcScaleRange27.EndValue = 100F
			arcScaleRange27.Name = "Range2"
			arcScaleRange27.ShapeOffset = 0F
			arcScaleRange27.StartThickness = 14F
			arcScaleRange27.StartValue = 66F
			Me.arcScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() { arcScaleRange25, arcScaleRange26, arcScaleRange27})
			Me.arcScaleComponent1.StartAngle = -240F
			Me.arcScaleComponent1.Value = 80F
			' 
			' arcScaleNeedleComponent1
			' 
			Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleNeedleComponent1.EndOffset = 5F
			Me.arcScaleNeedleComponent1.Name = "needle"
			Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16
			Me.arcScaleNeedleComponent1.ZOrder = -50
			' 
			' arcScaleSpindleCapComponent1
			' 
			Me.arcScaleSpindleCapComponent1.ArcScale = Me.arcScaleComponent1
			Me.arcScaleSpindleCapComponent1.Name = "cGauge1_SpindleCap1"
			Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16
			Me.arcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(25F, 25F)
			Me.arcScaleSpindleCapComponent1.ZOrder = -100
			' 
			' BackEase
			' 
			Me.BackEase.AutoSize = True
			Me.BackEase.Checked = True
			Me.BackEase.Location = New System.Drawing.Point(269, 82)
			Me.BackEase.Name = "BackEase"
			Me.BackEase.Size = New System.Drawing.Size(77, 17)
			Me.BackEase.TabIndex = 1
			Me.BackEase.TabStop = True
			Me.BackEase.Text = "Back Ease"
			Me.BackEase.UseVisualStyleBackColor = True
'			Me.BackEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' ElasticEase
			' 
			Me.ElasticEase.AutoSize = True
			Me.ElasticEase.Location = New System.Drawing.Point(269, 105)
			Me.ElasticEase.Name = "ElasticEase"
			Me.ElasticEase.Size = New System.Drawing.Size(83, 17)
			Me.ElasticEase.TabIndex = 2
			Me.ElasticEase.Text = "Elastic Ease"
			Me.ElasticEase.UseVisualStyleBackColor = True
'			Me.ElasticEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' BounceEase
			' 
			Me.BounceEase.AutoSize = True
			Me.BounceEase.Location = New System.Drawing.Point(269, 128)
			Me.BounceEase.Name = "BounceEase"
			Me.BounceEase.Size = New System.Drawing.Size(89, 17)
			Me.BounceEase.TabIndex = 3
			Me.BounceEase.Text = "Bounce Ease"
			Me.BounceEase.UseVisualStyleBackColor = True
'			Me.BounceEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' PowerEase
			' 
			Me.PowerEase.AutoSize = True
			Me.PowerEase.Location = New System.Drawing.Point(269, 151)
			Me.PowerEase.Name = "PowerEase"
			Me.PowerEase.Size = New System.Drawing.Size(82, 17)
			Me.PowerEase.TabIndex = 4
			Me.PowerEase.Text = "Power Ease"
			Me.PowerEase.UseVisualStyleBackColor = True
'			Me.PowerEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' EaseMode
			' 
			Me.EaseMode.FormattingEnabled = True
			Me.EaseMode.Location = New System.Drawing.Point(265, 23)
			Me.EaseMode.Name = "EaseMode"
			Me.EaseMode.Size = New System.Drawing.Size(121, 21)
			Me.EaseMode.TabIndex = 5
			Me.EaseMode.Text = "EaseIn"
'			Me.EaseMode.SelectedIndexChanged += New System.EventHandler(Me.EaseMode_SelectedIndexChanged);
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New System.Drawing.Point(264, 7)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(61, 13)
			Me.label1.TabIndex = 6
			Me.label1.Text = "Ease Mode"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New System.Drawing.Point(266, 57)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(75, 13)
			Me.label2.TabIndex = 7
			Me.label2.Text = "Ease Function"
			' 
			' QuadraticEase
			' 
			Me.QuadraticEase.AutoSize = True
			Me.QuadraticEase.Location = New System.Drawing.Point(269, 197)
			Me.QuadraticEase.Name = "QuadraticEase"
			Me.QuadraticEase.Size = New System.Drawing.Size(98, 17)
			Me.QuadraticEase.TabIndex = 8
			Me.QuadraticEase.TabStop = True
			Me.QuadraticEase.Text = "Quadratic Ease"
			Me.QuadraticEase.UseVisualStyleBackColor = True
'			Me.QuadraticEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' CubicEase
			' 
			Me.CubicEase.AutoSize = True
			Me.CubicEase.Location = New System.Drawing.Point(269, 174)
			Me.CubicEase.Name = "CubicEase"
			Me.CubicEase.Size = New System.Drawing.Size(79, 17)
			Me.CubicEase.TabIndex = 9
			Me.CubicEase.TabStop = True
			Me.CubicEase.Text = "Cubic Ease"
			Me.CubicEase.UseVisualStyleBackColor = True
'			Me.CubicEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' QuinticEase
			' 
			Me.QuinticEase.AutoSize = True
			Me.QuinticEase.Location = New System.Drawing.Point(269, 220)
			Me.QuinticEase.Name = "QuinticEase"
			Me.QuinticEase.Size = New System.Drawing.Size(85, 17)
			Me.QuinticEase.TabIndex = 10
			Me.QuinticEase.TabStop = True
			Me.QuinticEase.Text = "Quintic Ease"
			Me.QuinticEase.UseVisualStyleBackColor = True
'			Me.QuinticEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' SineEase
			' 
			Me.SineEase.AutoSize = True
			Me.SineEase.Location = New System.Drawing.Point(269, 243)
			Me.SineEase.Name = "SineEase"
			Me.SineEase.Size = New System.Drawing.Size(73, 17)
			Me.SineEase.TabIndex = 11
			Me.SineEase.TabStop = True
			Me.SineEase.Text = "Sine Ease"
			Me.SineEase.UseVisualStyleBackColor = True
'			Me.SineEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' ExponentialEase
			' 
			Me.ExponentialEase.AutoSize = True
			Me.ExponentialEase.Location = New System.Drawing.Point(269, 266)
			Me.ExponentialEase.Name = "ExponentialEase"
			Me.ExponentialEase.Size = New System.Drawing.Size(107, 17)
			Me.ExponentialEase.TabIndex = 12
			Me.ExponentialEase.TabStop = True
			Me.ExponentialEase.Text = "Exponential Ease"
			Me.ExponentialEase.UseVisualStyleBackColor = True
'			Me.ExponentialEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' CircleEase
			' 
			Me.CircleEase.AutoSize = True
			Me.CircleEase.Location = New System.Drawing.Point(269, 289)
			Me.CircleEase.Name = "CircleEase"
			Me.CircleEase.Size = New System.Drawing.Size(78, 17)
			Me.CircleEase.TabIndex = 13
			Me.CircleEase.TabStop = True
			Me.CircleEase.Text = "Circle Ease"
			Me.CircleEase.UseVisualStyleBackColor = True
'			Me.CircleEase.CheckedChanged += New System.EventHandler(Me.ChangeEaseFunction);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(400, 376)
			Me.Controls.Add(Me.CircleEase)
			Me.Controls.Add(Me.ExponentialEase)
			Me.Controls.Add(Me.SineEase)
			Me.Controls.Add(Me.QuinticEase)
			Me.Controls.Add(Me.CubicEase)
			Me.Controls.Add(Me.QuadraticEase)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.EaseMode)
			Me.Controls.Add(Me.PowerEase)
			Me.Controls.Add(Me.BounceEase)
			Me.Controls.Add(Me.ElasticEase)
			Me.Controls.Add(Me.BackEase)
			Me.Controls.Add(Me.gaugeControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
		Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
		Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
		Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
		Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
		Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
		Private WithEvents BackEase As System.Windows.Forms.RadioButton
		Private WithEvents ElasticEase As System.Windows.Forms.RadioButton
		Private WithEvents BounceEase As System.Windows.Forms.RadioButton
		Private WithEvents PowerEase As System.Windows.Forms.RadioButton
		Private WithEvents EaseMode As System.Windows.Forms.ComboBox
		Private label1 As System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents QuadraticEase As System.Windows.Forms.RadioButton
		Private WithEvents CubicEase As System.Windows.Forms.RadioButton
		Private WithEvents QuinticEase As System.Windows.Forms.RadioButton
		Private WithEvents SineEase As System.Windows.Forms.RadioButton
		Private WithEvents ExponentialEase As System.Windows.Forms.RadioButton
		Private WithEvents CircleEase As System.Windows.Forms.RadioButton
	End Class
End Namespace

