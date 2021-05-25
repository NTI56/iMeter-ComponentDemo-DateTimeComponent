using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;
using NTI.iMeter.ComponentStandard.UI;
using System.Xml;
using NTI.iMeter.ComponentStandard.UI.Converter;

namespace DateTimeComponent.UI
{
	public class ConverterFactory : ConverterUIComponentFactoryBase
	{
		public ConverterFactory()
		{
			supportedDataType.Add(DataType.DateTime);
			supportedDataType.Add(DataType.Boolean);
			supportedDataType.Add(DataType.Integer);
			supportedDataType.Add(DataType.StrongCustomizedType);
			supportedSct.Add(Ids.SctTypeId);
		}

		public override bool HasSettingControl => false;

		public override string Description => "Reading byte[8] into DateTime.";

		/// <inheritdoc />
		public override string BigPictureAddress { get; } = null;

		/// <inheritdoc />
		public override string SmallPictureAddress { get; } = null;

        public override IReadOnlyCollection<string> ExtraRuntimeFiles => new Collection<string> {"DateTimeComponent.Runtime.deps.json"};

        public override IReadOnlyCollection<string> ExtraUIFiles => new Collection<string> {"DateTimeComponent.Designer.deps.json"};

		public override Guid Id => Ids.ConverterUI;

		public override string Name => "DateTime Converter";

		public override RuntimeTargetPoint RuntimeTargetPoint { get; } = new RuntimeTargetPoint(Ids.LibraryRuntime, Ids.ConverterRuntime, null);

		public override IReadOnlyCollection<LibraryComponentId> SupersededComponentIds => null;

		List<Guid> supportedSct = new List<Guid>();
		public override IEnumerable<Guid> SupportedStrongCustomizedTypesForFiltering => supportedSct;

		List<DataType> supportedDataType = new List<DataType>();

		public override IEnumerable<DataType> SupportedTypesForFiltering => supportedDataType;

		public override XmlDocument ConvertSetting(LibraryComponentId supersededComponentId, XmlDocument setting)
		{
			throw new NotSupportedException();
		}

		public override ICoeditorUIControl CreateControl(Guid selectedStrongCustomizedType) => null;

		public override ICoeditorUIControl CreateControl(DataType selectedDataType) => null;

		public override ConverterUIComponentInstanceSettingOperatorBase CreateInstanceSettingOperator(XmlDocument setting)
		{
			return new ConverterInstanceSettingOperator();
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
