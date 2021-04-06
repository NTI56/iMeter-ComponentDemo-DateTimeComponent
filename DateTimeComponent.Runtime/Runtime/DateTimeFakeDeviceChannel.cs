using NTI.iMeter.ComponentStandard.Runtime.Device;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.Runtime
{
    public class DateTimeFakeDeviceChannel : DeviceChannelRuntimeComponentBase
    {
        public override void CloseChannel()
        {
            return;
        }

        public override int Fetch(byte[] buffer, Guid blockId, int offset, int length)
        {
            if (blockId == Ids.DeviceBlockMain)
                return FetchMain(buffer, offset, length, DateTime.UtcNow.ToBinary());
            else if (blockId == Ids.DeviceBlockSecondary)
                return FetchSecondary(buffer, offset, length);
            else
                throw new ArgumentException("Block id cannot be recognized.", nameof(blockId));
        }

        int FetchMain(byte[] buffer, int offset, int length, long timeBinary)
        {
            if (offset < 0 || offset >= 8192)
                throw new ArgumentOutOfRangeException(nameof(offset));
            if (length <= 0 || offset + length >= 8192)
                throw new ArgumentOutOfRangeException(nameof(length));

            byte[] source = BitConverter.GetBytes(timeBinary);

            int index = offset % 8;
            int nextIndex;
            //head
            if (index != 0)
            {
                if (length < 8 - index)
                {
                    Array.Copy(source, index, buffer, 0, length);
                    return length;
                }
                else
                {
                    Array.Copy(source, index, buffer, 0, 8 - index);
                    index = 8 - index;
                }
            }
            //main
            while ((nextIndex = index + 8) <= length)
            {
                Array.Copy(source, 0, buffer, index, 8);
                index = nextIndex;
            }
            //tail
            if (index < length)
            {
                Array.Copy(source, 0, buffer, index, length - index);
            }

            return length;
        }

        int FetchSecondary(byte[] buffer, int offset, int length)
        {
            return FetchMain(buffer, offset - 8192, length, DateTime.UtcNow.AddSeconds(-2).ToBinary());
        }
    }

}
