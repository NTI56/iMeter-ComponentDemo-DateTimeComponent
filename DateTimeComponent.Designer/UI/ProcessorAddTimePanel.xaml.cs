using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;
using DateTimeComponent.Common;
using NTI.iMeter.ComponentStandard.UI;
using Size = NTI.iMeter.ComponentStandard.UI.Size;

namespace DateTimeComponent.UI
{
	/// <summary>
	/// ProcessorAddTimePanel.xaml 的交互逻辑
	/// </summary>
	public partial class ProcessorAddTimePanel : UserControl, ICoeditorUIControl
	{
		public ProcessorAddTimePanel()
		{
			InitializeComponent();
		}

		public static readonly DependencyProperty DataProperty = DependencyProperty.Register(nameof(Data), typeof(ProcessorAddTimeSetting), typeof(ProcessorAddTimePanel), new FrameworkPropertyMetadata(null));

		public ProcessorAddTimeSetting Data
		{
			get => (ProcessorAddTimeSetting)GetValue(DataProperty);
			set => SetValue(DataProperty, value);
		}

		public bool Validate(bool popup) => true;

		public bool IsSettingChanged { get; } = true;

		public XmlDocument Setting
		{
			get => Data?.ToXml();
			set => Data = ProcessorAddTimeSetting.FromXml(value);
		}
		public bool ReadOnly { get; set; }
		public Size MinimumSize { get; } = new Size(double.PositiveInfinity, double.PositiveInfinity);
		public Size MaximumSize { get; } = new Size(0, 0);
		public Size PreferredSize { get; } = new Size(300, 300);
	}
}
