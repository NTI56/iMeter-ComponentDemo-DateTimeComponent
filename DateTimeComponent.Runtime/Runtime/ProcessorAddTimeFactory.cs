using DateTimeComponent.Common;
using NTI.iMeter.ComponentStandard.Runtime.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DateTimeComponent.Runtime
{
    public class ProcessorAddTimeFactory : ProcessorRuntimeComponentFactoryBase
    {
        public override Guid Id => Ids.ProcessorAddTimeRuntime;
        public override bool IsThreadSafe => true;

        static Guid[] supportedSettingVersions = { Ids.ProcessorAddTimeSetting };
        public override IReadOnlyCollection<Guid> SupportedSettingVersions => supportedSettingVersions;

        public override ProcessorRuntimeComponentBase CreateRuntime(XmlDocument setting)
        {
            ProcessorAddTimeSetting entity = ProcessorAddTimeSetting.FromXml(setting);

            return new ProcessorAddTime(entity.Seconds);
        }
    }
}
