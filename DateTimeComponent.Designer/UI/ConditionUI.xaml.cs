using NTI.iMeter.ComponentStandard.UI;
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
using Size = NTI.iMeter.ComponentStandard.UI.Size;

namespace DateTimeComponent.UI
{
	/// <summary>
	/// Interaction logic for Condition.xaml
	/// </summary>
	public partial class ConditionUI : UserControl, ICoeditorUIControl
	{
		public ConditionUI()
		{
			InitializeComponent();
		}

		private SettingItem[] DataSource
		{
			get { return CheckListControl.ItemsSource as SettingItem[]; }
			set { CheckListControl.ItemsSource = value; }
		}

		public bool IsSettingChanged { get; protected set; } = false;

		Size ICoeditorUIControl.MaximumSize { get; } = new Size(double.PositiveInfinity, double.PositiveInfinity);

		Size ICoeditorUIControl.MinimumSize => (this as ICoeditorUIControl).PreferredSize;

		Size ICoeditorUIControl.PreferredSize => new Size(400, 300);

		public static readonly DependencyProperty ReadOnlyProperty = DependencyProperty.Register(nameof(ReadOnly), typeof(bool), typeof(ConditionUI), new FrameworkPropertyMetadata(false));

		public bool ReadOnly
		{
			get { return (bool)GetValue(ReadOnlyProperty); }
			set { SetValue(ReadOnlyProperty, value); }
		}

		public XmlDocument Setting
		{
			get { return GetDocumentCore(); }

			set { SetDocumentCore(value); }
		}

		protected void SetDocumentCore(XmlDocument setting)
		{
			bool[] values;

			if (setting == null)
			{
				values = new bool[60];
			}
			else
			{
				var realData = ConditionSetting.FromXml(setting);
				values = realData.Allow;
			}


			DataSource = CreateSettingItems(values);
		}

		protected XmlDocument GetDocumentCore()
		{
			var result = new ConditionSetting
			{
				Allow = GetValues(DataSource)
			};

			return result.ToXml();
		}

		public bool Validate(bool popup) => true;

		public void ShowTextOnScreen(string text)
		{
			TipTextBlock.Text = text;
		}

		public static SettingItem[] CreateSettingItems(bool[] items)
		{
			var result = new SettingItem[items.Length];

			for (var i = 0; i < items.Length; i++)
			{
				result[i] = new SettingItem(i, items[i]);
			}

			return result;
		}

		public static bool[] GetValues(SettingItem[] items)
		{
			return Array.ConvertAll(items, i => i.Value);
		}

		private void CheckBox_Click(object sender, RoutedEventArgs e)
		{
			IsSettingChanged = true;
		}
	}

	public class SettingItem
	{
		public int Index { get; set; }
		public bool Value { get; set; }

		public SettingItem()
		{

		}

		public SettingItem(int index, bool value)
		{
			Index = index;
			Value = value;
		}
	}
}
