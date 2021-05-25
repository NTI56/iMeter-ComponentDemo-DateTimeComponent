using NTI.iMeter.ComponentStandard.UI.Device;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;
using NTI.iMeter.ComponentStandard.UI;
using System.Xml;

namespace DateTimeComponent.UI
{
    public class DateTimeFakeDeviceFactory : DeviceUIComponentFactoryBase
    {
        public override bool HasSettingControl => false;

	    /// <inheritdoc />
	    public override string BigPictureAddress { get; } = null;

	    /// <inheritdoc />
	    public override string SmallPictureAddress { get; } = null;

		public override string Description => "Return current datetime in DateTime.\nSize of data is 8 bytes. It fills the whole memory repeatly.";

        public override IReadOnlyCollection<string> ExtraRuntimeFiles => new Collection<string> {"DateTimeComponent.Runtime.deps.json"};

        public override IReadOnlyCollection<string> ExtraUIFiles => new Collection<string> {"DateTimeComponent.Designer.deps.json"};

        public override Guid Id => Ids.DeviceUI;

        public override string Name => "DateTime fake device";

        public override RuntimeTargetPoint RuntimeTargetPoint { get; } = new RuntimeTargetPoint(Ids.LibraryRuntime, Ids.DeviceRuntime, null);


        public override IReadOnlyCollection<LibraryComponentId> SupersededComponentIds => null;

        public override XmlDocument ConvertSetting(LibraryComponentId supersededComponentId, XmlDocument setting)
        {
            throw new NotSupportedException();
        }

        public override ICoeditorUIControl CreateControl() => null;

        public override DeviceUIComponentInstanceSettingOperatorBase CreateInstanceSettingOperator(XmlDocument setting)
        {
            return new DateTimeFakeDeviceInstanceSettingOperator();
        }

        public override void DisposeControl(ICoeditorUIControl control)
        {
            throw new NotSupportedException();
        }

        public override string GetBrief(XmlDocument setting)
        {
            return "Nothing to explain here.";
        }

        public override XmlDocument GetDefaultSetting()
        {
            throw new NotSupportedException();
        }
    }
}
