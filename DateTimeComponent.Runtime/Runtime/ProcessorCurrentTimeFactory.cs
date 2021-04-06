using NTI.iMeter.ComponentStandard.Runtime.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DateTimeComponent.Runtime
{
    public class ProcessorCurrentTimeFactory : ProcessorRuntimeComponentFactoryBase
    {
        public override Guid Id => Ids.ProcessorCurrentTimeRuntime;
        public override bool IsThreadSafe => true;

        public override IReadOnlyCollection<Guid> SupportedSettingVersions => null;

        public override ProcessorRuntimeComponentBase CreateRuntime(XmlDocument setting)
        {
            return new ProcessorCurrentTime();
        }
    }
}
