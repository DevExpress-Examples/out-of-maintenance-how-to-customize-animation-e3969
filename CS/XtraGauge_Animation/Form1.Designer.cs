namespace XtraGauge_Animation {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange25 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange26 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            DevExpress.XtraGauges.Core.Model.ArcScaleRange arcScaleRange27 = new DevExpress.XtraGauges.Core.Model.ArcScaleRange();
            this.gaugeControl1 = new DevExpress.XtraGauges.Win.GaugeControl();
            this.circularGauge1 = new DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge();
            this.arcScaleBackgroundLayerComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent();
            this.arcScaleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent();
            this.arcScaleNeedleComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent();
            this.arcScaleSpindleCapComponent1 = new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent();
            this.BackEase = new System.Windows.Forms.RadioButton();
            this.ElasticEase = new System.Windows.Forms.RadioButton();
            this.BounceEase = new System.Windows.Forms.RadioButton();
            this.PowerEase = new System.Windows.Forms.RadioButton();
            this.EaseMode = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QuadraticEase = new System.Windows.Forms.RadioButton();
            this.CubicEase = new System.Windows.Forms.RadioButton();
            this.QuinticEase = new System.Windows.Forms.RadioButton();
            this.SineEase = new System.Windows.Forms.RadioButton();
            this.ExponentialEase = new System.Windows.Forms.RadioButton();
            this.CircleEase = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).BeginInit();
            this.SuspendLayout();
            // 
            // gaugeControl1
            // 
            this.gaugeControl1.AutoLayout = false;
            this.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gaugeControl1.Gauges.AddRange(new DevExpress.XtraGauges.Base.IGauge[] {
            this.circularGauge1});
            this.gaugeControl1.Location = new System.Drawing.Point(0, 0);
            this.gaugeControl1.Name = "gaugeControl1";
            this.gaugeControl1.Size = new System.Drawing.Size(260, 376);
            this.gaugeControl1.TabIndex = 0;
            // 
            // circularGauge1
            // 
            this.circularGauge1.BackgroundLayers.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent[] {
            this.arcScaleBackgroundLayerComponent1});
            this.circularGauge1.Bounds = new System.Drawing.Rectangle(6, 6, 248, 364);
            this.circularGauge1.Name = "circularGauge1";
            this.circularGauge1.Needles.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent[] {
            this.arcScaleNeedleComponent1});
            this.circularGauge1.Scales.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent[] {
            this.arcScaleComponent1});
            this.circularGauge1.SpindleCaps.AddRange(new DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent[] {
            this.arcScaleSpindleCapComponent1});
            // 
            // arcScaleBackgroundLayerComponent1
            // 
            this.arcScaleBackgroundLayerComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleBackgroundLayerComponent1.Name = "bg";
            this.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style16;
            this.arcScaleBackgroundLayerComponent1.ZOrder = 1000;
            // 
            // arcScaleComponent1
            // 
            this.arcScaleComponent1.AppearanceTickmarkText.Font = new System.Drawing.Font("Tahoma", 8.5F);
            this.arcScaleComponent1.AppearanceTickmarkText.TextBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A");
            this.arcScaleComponent1.Center = new DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F);
            this.arcScaleComponent1.EndAngle = 60F;
            this.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}";
            this.arcScaleComponent1.MajorTickmark.ShapeOffset = -14F;
            this.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1;
            this.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight;
            this.arcScaleComponent1.MaxValue = 100F;
            this.arcScaleComponent1.MinorTickCount = 4;
            this.arcScaleComponent1.MinorTickmark.ShapeOffset = -7F;
            this.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2;
            this.arcScaleComponent1.Name = "scale1";
            arcScaleRange25.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#9EC968");
            arcScaleRange25.EndThickness = 14F;
            arcScaleRange25.EndValue = 33F;
            arcScaleRange25.Name = "Range0";
            arcScaleRange25.ShapeOffset = 0F;
            arcScaleRange25.StartThickness = 14F;
            arcScaleRange26.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FED96D");
            arcScaleRange26.EndThickness = 14F;
            arcScaleRange26.EndValue = 66F;
            arcScaleRange26.Name = "Range1";
            arcScaleRange26.ShapeOffset = 0F;
            arcScaleRange26.StartThickness = 14F;
            arcScaleRange26.StartValue = 33F;
            arcScaleRange27.AppearanceRange.ContentBrush = new DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#EF8C75");
            arcScaleRange27.EndThickness = 14F;
            arcScaleRange27.EndValue = 100F;
            arcScaleRange27.Name = "Range2";
            arcScaleRange27.ShapeOffset = 0F;
            arcScaleRange27.StartThickness = 14F;
            arcScaleRange27.StartValue = 66F;
            this.arcScaleComponent1.Ranges.AddRange(new DevExpress.XtraGauges.Core.Model.IRange[] {
            arcScaleRange25,
            arcScaleRange26,
            arcScaleRange27});
            this.arcScaleComponent1.StartAngle = -240F;
            this.arcScaleComponent1.Value = 80F;
            // 
            // arcScaleNeedleComponent1
            // 
            this.arcScaleNeedleComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleNeedleComponent1.EndOffset = 5F;
            this.arcScaleNeedleComponent1.Name = "needle";
            this.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16;
            this.arcScaleNeedleComponent1.ZOrder = -50;
            // 
            // arcScaleSpindleCapComponent1
            // 
            this.arcScaleSpindleCapComponent1.ArcScale = this.arcScaleComponent1;
            this.arcScaleSpindleCapComponent1.Name = "cGauge1_SpindleCap1";
            this.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16;
            this.arcScaleSpindleCapComponent1.Size = new System.Drawing.SizeF(25F, 25F);
            this.arcScaleSpindleCapComponent1.ZOrder = -100;
            // 
            // BackEase
            // 
            this.BackEase.AutoSize = true;
            this.BackEase.Checked = true;
            this.BackEase.Location = new System.Drawing.Point(269, 82);
            this.BackEase.Name = "BackEase";
            this.BackEase.Size = new System.Drawing.Size(77, 17);
            this.BackEase.TabIndex = 1;
            this.BackEase.TabStop = true;
            this.BackEase.Text = "Back Ease";
            this.BackEase.UseVisualStyleBackColor = true;
            this.BackEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // ElasticEase
            // 
            this.ElasticEase.AutoSize = true;
            this.ElasticEase.Location = new System.Drawing.Point(269, 105);
            this.ElasticEase.Name = "ElasticEase";
            this.ElasticEase.Size = new System.Drawing.Size(83, 17);
            this.ElasticEase.TabIndex = 2;
            this.ElasticEase.Text = "Elastic Ease";
            this.ElasticEase.UseVisualStyleBackColor = true;
            this.ElasticEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // BounceEase
            // 
            this.BounceEase.AutoSize = true;
            this.BounceEase.Location = new System.Drawing.Point(269, 128);
            this.BounceEase.Name = "BounceEase";
            this.BounceEase.Size = new System.Drawing.Size(89, 17);
            this.BounceEase.TabIndex = 3;
            this.BounceEase.Text = "Bounce Ease";
            this.BounceEase.UseVisualStyleBackColor = true;
            this.BounceEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // PowerEase
            // 
            this.PowerEase.AutoSize = true;
            this.PowerEase.Location = new System.Drawing.Point(269, 151);
            this.PowerEase.Name = "PowerEase";
            this.PowerEase.Size = new System.Drawing.Size(82, 17);
            this.PowerEase.TabIndex = 4;
            this.PowerEase.Text = "Power Ease";
            this.PowerEase.UseVisualStyleBackColor = true;
            this.PowerEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // EaseMode
            // 
            this.EaseMode.FormattingEnabled = true;
            this.EaseMode.Location = new System.Drawing.Point(265, 23);
            this.EaseMode.Name = "EaseMode";
            this.EaseMode.Size = new System.Drawing.Size(121, 21);
            this.EaseMode.TabIndex = 5;
            this.EaseMode.Text = "EaseIn";
            this.EaseMode.SelectedIndexChanged += new System.EventHandler(this.EaseMode_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ease Mode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ease Function";
            // 
            // QuadraticEase
            // 
            this.QuadraticEase.AutoSize = true;
            this.QuadraticEase.Location = new System.Drawing.Point(269, 197);
            this.QuadraticEase.Name = "QuadraticEase";
            this.QuadraticEase.Size = new System.Drawing.Size(98, 17);
            this.QuadraticEase.TabIndex = 8;
            this.QuadraticEase.TabStop = true;
            this.QuadraticEase.Text = "Quadratic Ease";
            this.QuadraticEase.UseVisualStyleBackColor = true;
            this.QuadraticEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // CubicEase
            // 
            this.CubicEase.AutoSize = true;
            this.CubicEase.Location = new System.Drawing.Point(269, 174);
            this.CubicEase.Name = "CubicEase";
            this.CubicEase.Size = new System.Drawing.Size(79, 17);
            this.CubicEase.TabIndex = 9;
            this.CubicEase.TabStop = true;
            this.CubicEase.Text = "Cubic Ease";
            this.CubicEase.UseVisualStyleBackColor = true;
            this.CubicEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // QuinticEase
            // 
            this.QuinticEase.AutoSize = true;
            this.QuinticEase.Location = new System.Drawing.Point(269, 220);
            this.QuinticEase.Name = "QuinticEase";
            this.QuinticEase.Size = new System.Drawing.Size(85, 17);
            this.QuinticEase.TabIndex = 10;
            this.QuinticEase.TabStop = true;
            this.QuinticEase.Text = "Quintic Ease";
            this.QuinticEase.UseVisualStyleBackColor = true;
            this.QuinticEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // SineEase
            // 
            this.SineEase.AutoSize = true;
            this.SineEase.Location = new System.Drawing.Point(269, 243);
            this.SineEase.Name = "SineEase";
            this.SineEase.Size = new System.Drawing.Size(73, 17);
            this.SineEase.TabIndex = 11;
            this.SineEase.TabStop = true;
            this.SineEase.Text = "Sine Ease";
            this.SineEase.UseVisualStyleBackColor = true;
            this.SineEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // ExponentialEase
            // 
            this.ExponentialEase.AutoSize = true;
            this.ExponentialEase.Location = new System.Drawing.Point(269, 266);
            this.ExponentialEase.Name = "ExponentialEase";
            this.ExponentialEase.Size = new System.Drawing.Size(107, 17);
            this.ExponentialEase.TabIndex = 12;
            this.ExponentialEase.TabStop = true;
            this.ExponentialEase.Text = "Exponential Ease";
            this.ExponentialEase.UseVisualStyleBackColor = true;
            this.ExponentialEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // CircleEase
            // 
            this.CircleEase.AutoSize = true;
            this.CircleEase.Location = new System.Drawing.Point(269, 289);
            this.CircleEase.Name = "CircleEase";
            this.CircleEase.Size = new System.Drawing.Size(78, 17);
            this.CircleEase.TabIndex = 13;
            this.CircleEase.TabStop = true;
            this.CircleEase.Text = "Circle Ease";
            this.CircleEase.UseVisualStyleBackColor = true;
            this.CircleEase.CheckedChanged += new System.EventHandler(this.ChangeEaseFunction);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 376);
            this.Controls.Add(this.CircleEase);
            this.Controls.Add(this.ExponentialEase);
            this.Controls.Add(this.SineEase);
            this.Controls.Add(this.QuinticEase);
            this.Controls.Add(this.CubicEase);
            this.Controls.Add(this.QuadraticEase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EaseMode);
            this.Controls.Add(this.PowerEase);
            this.Controls.Add(this.BounceEase);
            this.Controls.Add(this.ElasticEase);
            this.Controls.Add(this.BackEase);
            this.Controls.Add(this.gaugeControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circularGauge1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleBackgroundLayerComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleNeedleComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arcScaleSpindleCapComponent1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGauges.Win.GaugeControl gaugeControl1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge circularGauge1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent arcScaleBackgroundLayerComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent arcScaleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent arcScaleNeedleComponent1;
        private DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent arcScaleSpindleCapComponent1;
        private System.Windows.Forms.RadioButton BackEase;
        private System.Windows.Forms.RadioButton ElasticEase;
        private System.Windows.Forms.RadioButton BounceEase;
        private System.Windows.Forms.RadioButton PowerEase;
        private System.Windows.Forms.ComboBox EaseMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton QuadraticEase;
        private System.Windows.Forms.RadioButton CubicEase;
        private System.Windows.Forms.RadioButton QuinticEase;
        private System.Windows.Forms.RadioButton SineEase;
        private System.Windows.Forms.RadioButton ExponentialEase;
        private System.Windows.Forms.RadioButton CircleEase;
    }
}

