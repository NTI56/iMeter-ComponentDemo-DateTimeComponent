using DateTimeComponent.Common;
using NTI.iMeter;
using NTI.iMeter.ComponentStandard.UI;
using NTI.iMeter.ComponentStandard.UI.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DateTimeComponent.UI
{
	public class ProcessorAddTimeFactory : ProcessorUIComponentFactoryBase
	{

		public override string Description => "Add some seconds.";

		public override string BigPictureAddress { get; } = null;

		public override string SmallPictureAddress { get; } = null;

		public override IReadOnlyCollection<string> ExtraRuntimeFiles => null;

		public override IReadOnlyCollection<string> ExtraUIFiles => null;

		public override bool HasSettingControl => true;

		public override Guid Id => Ids.ProcessorAddTimeUI;

		public override string Name => "Add Time";

		public override RuntimeTargetPoint RuntimeTargetPoint { get; } = new RuntimeTargetPoint(Ids.LibraryRuntime, Ids.ProcessorAddTimeRuntime, Ids.ProcessorAddTimeSetting);


		public override IReadOnlyCollection<LibraryComponentId> SupersededComponentIds => null;

		public override XmlDocument ConvertSetting(LibraryComponentId supersededComponentId, XmlDocument setting)
		{
			throw new NotSupportedException();
		}

		public override ICoeditorUIControl CreateControl()
		{
			return new ProcessorAddTimePanel();
		}

		public override ProcessorUIComponentInstanceSettingOperatorBase CreateInstanceSettingOperator(XmlDocument setting)
		{
			//ProcessorAddTimeSetting entity = ProcessorAddTimeSetting.FromXml(setting);

			return new ProcessorAddTimeInstanceSettingOperator();
		}

		public override void DisposeControl(ICoeditorUIControl control)
		{
			return;
		}

		public override string GetBrief(XmlDocument setting)
		{
			return "Nothing to explain here.";
		}

		public override XmlDocument GetDefaultSetting()
		{
			return ProcessorAddTimeSetting.GetDefault();
		}
	}
}
