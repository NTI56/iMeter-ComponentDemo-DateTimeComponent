using NTI.iMeter.ComponentStandard.UI.Processor;
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
    public class ProcessorCurrentTimeFactory : ProcessorUIComponentFactoryBase
    {

        public override string Description => "Get current time every second.";
	    /// <inheritdoc />
	    public override string BigPictureAddress { get; } = null;

	    /// <inheritdoc />
	    public override string SmallPictureAddress { get; } = null;

        public override IReadOnlyCollection<string> ExtraRuntimeFiles => new Collection<string> {"DateTimeComponent.Runtime.deps.json"};

        public override IReadOnlyCollection<string> ExtraUIFiles => new Collection<string> {"DateTimeComponent.Designer.deps.json"};

        public override bool HasSettingControl => false;

        public override Guid Id => Ids.ProcessorCurrentTimeUI;

        public override string Name => "Current DateTime Feed";

        public override RuntimeTargetPoint RuntimeTargetPoint { get; } = new RuntimeTargetPoint(Ids.LibraryRuntime, Ids.ProcessorCurrentTimeRuntime, null);


        public override IReadOnlyCollection<LibraryComponentId> SupersededComponentIds => null;

        public override XmlDocument ConvertSetting(LibraryComponentId supersededComponentId, XmlDocument setting)
        {
            throw new NotSupportedException();
        }

        public override ICoeditorUIControl CreateControl() => null;

        public override ProcessorUIComponentInstanceSettingOperatorBase CreateInstanceSettingOperator(XmlDocument setting)
        {
            return new ProcessorCurrentTimeInstanceSettingOperator();
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
