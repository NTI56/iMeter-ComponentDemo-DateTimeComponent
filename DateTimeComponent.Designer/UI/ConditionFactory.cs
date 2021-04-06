using NTI.iMeter.ComponentStandard.UI.Condition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;
using NTI.iMeter.ComponentStandard.UI;
using System.Xml;
using DateTimeComponent.Common;

namespace DateTimeComponent.UI
{
    public class ConditionFactory : ConditionUIComponentFactoryBase
    {
        public ConditionFactory()
        {
            supportedDataType.Add(DataType.DateTime);
            supportedDataType.Add(DataType.Integer);
            supportedDataType.Add(DataType.StrongCustomizedType);
            supportedSct.Add(Ids.SctTypeId);
        }
        public override bool HasSettingControl => true;


        public override string Description => "Condition based on second of DateTime.";

        public override IReadOnlyCollection<string> ExtraRuntimeFiles => null;

        public override IReadOnlyCollection<string> ExtraUIFiles => null;

        public override Guid Id => Ids.ConditionUI;

        public override string Name => "Second filter";

        public override RuntimeTargetPoint RuntimeTargetPoint { get; } = new RuntimeTargetPoint(Ids.LibraryRuntime, Ids.ConditionRuntime, Ids.ConditionSettingVersion);

	    /// <inheritdoc />
	    public override string SmallPictureAddress { get; } = null;

	    /// <inheritdoc />
	    public override string BigPictureAddress { get; } = null;

        public override IReadOnlyCollection<LibraryComponentId> SupersededComponentIds => null;

        List<Guid> supportedSct = new List<Guid>();
        public override IEnumerable<Guid> SupportedStrongCustomizedTypesForFiltering => supportedSct;

        List<DataType> supportedDataType = new List<DataType>();

        public override IEnumerable<DataType> SupportedTypesForFiltering => supportedDataType;

        public override XmlDocument ConvertSetting(LibraryComponentId supersededComponentId, XmlDocument setting)
        {
            throw new NotSupportedException();
        }

        public override ICoeditorUIControl CreateControl(Guid selectedStrongCustomizedType)
        {
            var result = new ConditionUI();
            if (selectedStrongCustomizedType == Ids.SctTypeId)
                result.ShowTextOnScreen("The format of data source is SCT.");
            else
                throw new ArgumentOutOfRangeException(nameof(selectedStrongCustomizedType));
            return result;
        }

        public override ICoeditorUIControl CreateControl(DataType selectedDataType)
        {
            var result = new ConditionUI();
            if (selectedDataType == DataType.DateTime)
                result.ShowTextOnScreen("The format of data source is DateTime.");
            else if (selectedDataType == DataType.Integer)
                result.ShowTextOnScreen("The format of data source is Integer (DateTime.Ticks).");
            else
                throw new ArgumentOutOfRangeException(nameof(selectedDataType));
            return result;
        }

        public override ConditionUIComponentInstanceSettingOperatorBase CreateInstanceSettingOperator(XmlDocument setting)
        {
            ConditionSetting entity = ConditionSetting.FromXml(setting);

            return new ConditionInstanceSettingOperator(entity);
        }

        public override void DisposeControl(ICoeditorUIControl control)
        {
            return;
        }

        public override string GetBrief(XmlDocument setting)
        {
            ConditionSetting entity = ConditionSetting.FromXml(setting);

            if (entity.Allow.Any(i => i))
            {
                StringBuilder builder = new StringBuilder("Pass when second is: ");
                for (int i = 0; i < 60; i++)
                {
                    if (entity.Allow[i])
                    {
                        builder.Append(i);
                        builder.Append(", ");
                    }
                }
                builder.Remove(builder.Length - 2, 2);
                builder.Append(".");
                return builder.ToString();
            }
            else
            {
                return "Decline all data.";
            }
        }

        public override XmlDocument GetDefaultSetting()
        {
            return ConditionSetting.GetDefault();
        }
    }
}
