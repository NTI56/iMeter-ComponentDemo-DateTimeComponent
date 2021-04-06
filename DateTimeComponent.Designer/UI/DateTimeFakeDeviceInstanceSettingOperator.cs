using NTI.iMeter.ComponentStandard.UI.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.UI
{
    public class DateTimeFakeDeviceInstanceSettingOperator : DeviceUIComponentInstanceSettingOperatorBase
    {
        List<DeviceBlock> blocks = new List<DeviceBlock>();
        List<DeviceChannel> channels = new List<DeviceChannel>();

        public DateTimeFakeDeviceInstanceSettingOperator()
        {
            blocks.Add(new DeviceBlock(Ids.DeviceBlockMain, "Main Block", 0, 8192));
            blocks.Add(new DeviceBlock(Ids.DeviceBlockSecondary, "Secondary Block (Time -2 sec)", 8192, 8192));
            channels.Add(new DeviceChannel(Ids.DeviceChannel, "Default Channel", 1024, 8192, 55, false));
        }

        public override IEnumerable<DeviceBlock> Blocks => blocks;

        public override IEnumerable<DeviceChannel> Channels => channels;

        public override IReadOnlyList<ReadingWorkloadCheckingFailed> CheckWorkload(IReadOnlyList<ReadingWorkloadCheckingChannelItem> items)
        {
            return null;
        }

        public override bool ValidateSetting()
        {
            return true;
        }
    }
}
