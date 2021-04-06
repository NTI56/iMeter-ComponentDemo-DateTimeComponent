using NTI.iMeter.ComponentStandard.Runtime.StrongCustomizedType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;

namespace DateTimeComponent.Runtime
{
    public class Sct : StrongCustomizedTypeRuntimeComponentBase
    {
        public override void DisposeRuntime()
        {
            return;
        }

        public override ValuePackageSlim GetNewValueObject()
        {
            return new ValuePackageSlim<SctType>(SerializingMethodType.String, Ids.SctTypeId);
        }

        public override ValuePackageSlim GetValueObjectFromSerializedData(byte[] data)
        {
            throw new NotSupportedException();
        }

        public override ValuePackageSlim GetValueObjectFromSerializedData(string data)
        {
            DateTime date = DateTime.FromBinary(long.Parse(data));
            return new ValuePackageSlim<SctType>(new SctType() { DateTime = date }, SerializingMethodType.String, DataType.StrongCustomizedType, Ids.SctTypeId);
        }
    }
}
