using NTI.iMeter.ComponentStandard.Runtime.StrongCustomizedType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DateTimeComponent.Runtime
{
    public class SctFactory : StrongCustomizedTypeRuntimeComponentFactoryBase
    {
        public override Guid Id => Ids.SctRuntime;

        public override bool IsThreadSafe => true;

        public override IReadOnlyCollection<Guid> SupportedSettingVersions => null;

        public override StrongCustomizedTypeRuntimeComponentBase CreateRuntime(XmlDocument setting)
        {
            return new Sct();
        }
    }
}
