using NTI.iMeter.ComponentStandard.UI.StrongCustomizedType;
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
    public class SctFactory : StrongCustomizedTypeUIComponentFactoryBase
    {
        public override bool HasSettingControl => false;

	    /// <inheritdoc />
	    public override string BigPictureAddress { get; } = null;

	    /// <inheritdoc />
	    public override string SmallPictureAddress { get; } = null;

		public override string Description => "A demo strong customized type contains only a DateTime with property Second.";

        public override IReadOnlyCollection<string> ExtraRuntimeFiles => new Collection<string> {"DateTimeComponent.Runtime.deps.json"};

        public override IReadOnlyCollection<string> ExtraUIFiles => new Collection<string> {"DateTimeComponent.Designer.deps.json"};

        public override Guid Id => Ids.SctUI;

        public override string Name => "Customized DateTime";

        public override RuntimeTargetPoint RuntimeTargetPoint { get; } = new RuntimeTargetPoint(Ids.LibraryRuntime, Ids.SctRuntime, null);


        public override IReadOnlyCollection<LibraryComponentId> SupersededComponentIds => null;

        public override XmlDocument ConvertSetting(LibraryComponentId supersededComponentId, XmlDocument setting)
        {
            throw new NotSupportedException();
        }

        public override ICoeditorUIControl CreateControl()
        {
            throw new NotSupportedException();
        }

        public override StrongCustomizedTypeUIComponentInstanceSettingOperatorBase CreateInstanceSettingOperator(XmlDocument setting)
        {
            return new SctInstanceSettingOperator();
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
