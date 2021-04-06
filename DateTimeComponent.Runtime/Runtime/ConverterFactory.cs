using NTI.iMeter.ComponentStandard.Runtime.Converter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;
using System.Xml;

namespace DateTimeComponent.Runtime
{
    public class ConverterFactory : ConverterRuntimeComponentFactoryBase
    {
        public override Guid Id => Ids.ConverterRuntime;

        public override bool IsThreadSafe => true;

        public override IReadOnlyCollection<Guid> SupportedSettingVersions => null;

        public override ConverterRuntimeComponentBase CreateRuntime(XmlDocument setting, Guid strongCustomizedTypeTypeId, Guid outputId)
        {
            if (outputId == Ids.ConverterOutputSct)
            {
                if (strongCustomizedTypeTypeId == Ids.SctTypeId)
                    return new ConverterSct(); 
                else
                    throw new ArgumentOutOfRangeException(nameof(strongCustomizedTypeTypeId));
            }
            else
                throw new ArgumentOutOfRangeException(nameof(outputId));
        }

        public override ConverterRuntimeComponentBase CreateRuntime(XmlDocument setting, DataType dataType, Guid outputId)
        {
            if (outputId == Ids.ConverterOutputDateTime)
            {
                if (dataType == DataType.DateTime)
                    return new Converter();
                else
                    throw new ArgumentOutOfRangeException(nameof(dataType));
            }
            else if (outputId == Ids.ConverterOutputTick)
            {
                if (dataType == DataType.Integer)
                    return new ConverterTick();
                else
                    throw new ArgumentOutOfRangeException(nameof(dataType));
            }
            else if (outputId == Ids.ConverterOutputIsUtc)
            {
                if (dataType == DataType.Boolean)
                    return new ConverterIsUtc();
                else
                    throw new ArgumentOutOfRangeException(nameof(dataType));
            }
            else
                throw new ArgumentOutOfRangeException(nameof(outputId));
        }
    }
}
