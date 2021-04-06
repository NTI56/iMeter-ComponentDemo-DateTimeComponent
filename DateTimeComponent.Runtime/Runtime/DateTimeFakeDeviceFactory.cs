using NTI.iMeter.ComponentStandard.Runtime.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace DateTimeComponent.Runtime
{
    public class DateTimeFakeDeviceFactory : DeviceRuntimeComponentFactoryBase
    {
        public override Guid Id => Ids.DeviceRuntime;

        public override bool IsThreadSafe => true;

        public override IReadOnlyCollection<Guid> SupportedSettingVersions => null;

        public override DeviceRuntimeComponentBase CreateRuntime(XmlDocument setting)
        {
            return new DateTimeFakeDevice();
        }
    }
}
