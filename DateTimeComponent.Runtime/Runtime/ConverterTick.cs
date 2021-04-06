using NTI.iMeter.ComponentStandard.Runtime.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;

namespace DateTimeComponent.Runtime
{
    public class ConverterTick : ConverterRuntimeComponentBase
    {
        public override ValuePackageSlim<T> Convert<T>(byte[] data, int start)
        {
            if (typeof(T) != typeof(long))
                throw new ArgumentException();

            long value = DateTime.FromBinary(BitConverter.ToInt64(data, start)).Ticks;
            return new ValuePackageSlim<T>(__refvalue(__makeref(value), T), SerializingMethodType.SystemType, DataType.Integer, null);
        }

        public override void DisposeRuntime()
        {
            return;
        }
    }
}
