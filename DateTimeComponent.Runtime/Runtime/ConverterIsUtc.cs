using NTI.iMeter;
using NTI.iMeter.ComponentStandard.Runtime.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.Runtime
{
    public class ConverterIsUtc : ConverterRuntimeComponentBase
    {
        public override ValuePackageSlim<T> Convert<T>(byte[] data, int start)
        {
            if (typeof(T) != typeof(bool))
                throw new ArgumentException();

            bool value = DateTime.FromBinary(BitConverter.ToInt64(data, start)).Kind == DateTimeKind.Utc;
            return new ValuePackageSlim<T>(__refvalue(__makeref(value), T), SerializingMethodType.SystemType, DataType.Boolean, null);
        }

        public override void DisposeRuntime()
        {
            return;
        }
    }
}
