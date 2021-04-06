using NTI.iMeter.ComponentStandard.Runtime.Condition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;
using System.Xml;
using DateTimeComponent.Common;

namespace DateTimeComponent.Runtime
{
    public class ConditionFactory : ConditionRuntimeComponentFactoryBase
    {
        List<Guid> supportedSettingVersions = new List<Guid>();

        public ConditionFactory()
        {
            supportedSettingVersions.Add(Ids.ConditionSettingVersion);
        }

        public override Guid Id => Ids.ConditionRuntime;
        public override bool IsThreadSafe => true;

        public override IReadOnlyCollection<Guid> SupportedSettingVersions => supportedSettingVersions;

        public override ConditionRuntimeComponentBase CreateRuntime(XmlDocument setting, Guid strongCustomizedTypeTypeId)
        {
            var entity = ConditionSetting.FromXml(setting);

            if (strongCustomizedTypeTypeId == Ids.SctTypeId)
                return new ConditionSct(entity);
            else
                throw new ArgumentOutOfRangeException(nameof(strongCustomizedTypeTypeId));
        }

        public override ConditionRuntimeComponentBase CreateRuntime(XmlDocument setting, DataType dataType)
        {
            var entity = ConditionSetting.FromXml(setting);

            if (dataType == DataType.DateTime)
                return new ConditionDateTime(entity);
            else if (dataType == DataType.Integer)
                return new ConditionTick(entity);
            else
                throw new ArgumentOutOfRangeException(nameof(dataType));
        }
    }
}
