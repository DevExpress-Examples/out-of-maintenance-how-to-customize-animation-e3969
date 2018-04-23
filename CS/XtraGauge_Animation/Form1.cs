using System;
using System.Windows.Forms;
using DevExpress.XtraGauges.Core.Model;
using System.Collections.Generic;

namespace XtraGauge_Animation {
    public partial class Form1 : Form {
        Dictionary<string, IEasingFunction> functions = new Dictionary<string, IEasingFunction>();
        Dictionary<string, EasingMode> modes = new Dictionary<string, EasingMode>();
        Timer timer;
        Random random = new Random(DateTime.Now.Millisecond);

        public Form1() {
            InitializeComponent();
            InitData();
            this.Load += new EventHandler(Form1_Load);
        }

        private void InitData() {
            functions.Add("BackEase", new BackEase());
            functions.Add("ElasticEase", new ElasticEase());
            functions.Add("PowerEase", new PowerEase(1));
            functions.Add("QuadraticEase", new QuadraticEase());
            functions.Add("QuinticEase", new QuinticEase());
            functions.Add("SineEase", new SineEase());
            functions.Add("ExponentialEase", new ExponentialEase());
            functions.Add("CircleEase", new CircleEase());
            functions.Add("BounceEase", new BounceEase());
            functions.Add("CubicEase", new CubicEase());
            modes.Add("EaseIn", EasingMode.EaseIn);
            modes.Add("EaseOut", EasingMode.EaseOut);
            modes.Add("EaseInOut", EasingMode.EaseInOut);
            foreach (var item in modes) {
                EaseMode.Items.Add(item.Key);
            }
            arcScaleComponent1.EnableAnimation = true;
        }

        private void ChangeEaseFunction(object sender, EventArgs e) {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton.Checked) {
                arcScaleComponent1.EasingFunction = functions[((RadioButton)sender).Name];
            }
        }

        void Form1_Load(object sender, EventArgs e) {
            timer = new Timer();
            timer.Interval = 2000;
            timer.Tick += new EventHandler(OnTimerTick);
            timer.Start();
        }

        void OnTimerTick(object sender, EventArgs e) {
            arcScaleComponent1.Value = AnimateScaleValue(arcScaleComponent1);
        }

        float AnimateScaleValue(IScale scale) {
            return random.Next(0, 100);
        }

        private void EaseMode_SelectedIndexChanged(object sender, EventArgs e) {
            arcScaleComponent1.EasingMode = modes[EaseMode.SelectedItem.ToString()];
        }

    }
}
