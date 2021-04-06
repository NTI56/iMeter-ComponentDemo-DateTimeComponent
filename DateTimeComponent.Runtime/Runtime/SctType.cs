using NTI.iMeter;
using NTI.iMeter.ComponentStandard.Runtime.StrongCustomizedType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent.Runtime
{
    public class SctType : ISequencerTimeSource, IStrongCustomizedTypeStringBasedSerializable
    {
        public DateTime DateTime;
        public int Second => DateTime.Second;

        DateTime ISequencerTimeSource.GetDateTime() => DateTime;

        string IStrongCustomizedTypeStringBasedSerializable.Serialize() => DateTime.ToBinary().ToString();
    }
}
