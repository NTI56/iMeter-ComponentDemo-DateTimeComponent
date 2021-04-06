using NTI.iMeter;
using NTI.iMeter.ComponentStandard.Runtime.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.Runtime
{
    public class ConverterSct : ConverterRuntimeComponentBase
    {
        public override ValuePackageSlim<T> Convert<T>(byte[] data, int start)
        {
            if (typeof(T) != typeof(SctType))
                throw new ArgumentException();

            DateTime time = DateTime.FromBinary(BitConverter.ToInt64(data, start));
            SctType value = new SctType() { DateTime = time };
            return new ValuePackageSlim<T>(__refvalue(__makeref(value), T), SerializingMethodType.String, DataType.StrongCustomizedType, Ids.SctTypeId);
        }

        public override void DisposeRuntime()
        {
            return;
        }
    }
}
