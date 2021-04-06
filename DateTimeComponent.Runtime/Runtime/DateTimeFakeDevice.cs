using NTI.iMeter.ComponentStandard.Runtime.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.Runtime
{
    public class DateTimeFakeDevice : DeviceRuntimeComponentBase
    {
        DateTimeFakeDeviceChannel channel = new DateTimeFakeDeviceChannel();

        public override void DisposeRuntime()
        {
            channel = null;
        }

        public override DeviceChannelRuntimeComponentBase OpenChannel(Guid channelId)
        {
            if (channelId != Ids.DeviceChannel)
                throw new ArgumentException();

            return channel;
        }
    }
}
