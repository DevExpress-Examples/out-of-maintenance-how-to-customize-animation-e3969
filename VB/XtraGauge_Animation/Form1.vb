Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGauges.Core.Model
Imports System.Collections.Generic

Namespace XtraGauge_Animation
	Partial Public Class Form1
		Inherits Form
		Private functions As New Dictionary(Of String, IEasingFunction)()
		Private modes As New Dictionary(Of String, EasingMode)()
		Private timer As Timer
		Private random As New Random(DateTime.Now.Millisecond)

		Public Sub New()
			InitializeComponent()
			InitData()
			AddHandler Load, AddressOf Form1_Load
		End Sub

		Private Sub InitData()
			functions.Add("BackEase", New BackEase())
			functions.Add("ElasticEase", New ElasticEase())
			functions.Add("PowerEase", New PowerEase(1))
			functions.Add("QuadraticEase", New QuadraticEase())
			functions.Add("QuinticEase", New QuinticEase())
			functions.Add("SineEase", New SineEase())
			functions.Add("ExponentialEase", New ExponentialEase())
			functions.Add("CircleEase", New CircleEase())
			functions.Add("BounceEase", New BounceEase())
			functions.Add("CubicEase", New CubicEase())
			modes.Add("EaseIn", EasingMode.EaseIn)
			modes.Add("EaseOut", EasingMode.EaseOut)
			modes.Add("EaseInOut", EasingMode.EaseInOut)
			For Each item In modes
				EaseMode.Items.Add(item.Key)
			Next item
			arcScaleComponent1.EnableAnimation = True
		End Sub

		Private Sub ChangeEaseFunction(ByVal sender As Object, ByVal e As EventArgs) Handles BackEase.CheckedChanged, ElasticEase.CheckedChanged, BounceEase.CheckedChanged, PowerEase.CheckedChanged, QuadraticEase.CheckedChanged, CubicEase.CheckedChanged, QuinticEase.CheckedChanged, SineEase.CheckedChanged, ExponentialEase.CheckedChanged, CircleEase.CheckedChanged
			Dim radioButton As RadioButton = TryCast(sender, RadioButton)
			If radioButton.Checked Then
				arcScaleComponent1.EasingFunction = functions((CType(sender, RadioButton)).Name)
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			timer = New Timer()
			timer.Interval = 2000
			AddHandler timer.Tick, AddressOf OnTimerTick
			timer.Start()
		End Sub

		Private Sub OnTimerTick(ByVal sender As Object, ByVal e As EventArgs)
			arcScaleComponent1.Value = AnimateScaleValue(arcScaleComponent1)
		End Sub

		Private Function AnimateScaleValue(ByVal scale As IScale) As Single
			Return random.Next(0, 100)
		End Function

		Private Sub EaseMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles EaseMode.SelectedIndexChanged
			arcScaleComponent1.EasingMode = modes(EaseMode.SelectedItem.ToString())
		End Sub

	End Class
End Namespace
