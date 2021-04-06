using NTI.iMeter.ComponentStandard.Runtime.Processor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTI.iMeter;

namespace DateTimeComponent.Runtime
{
    public class ProcessorCurrentTime : ProcessorRuntimeComponentBase
    {
        DateTime waveStartTime, waveEndTime, currentRequest;
        IVariableWriter<DateTime> variableWriter = null;
        public override void DisposeRuntime()
        {
        }

        public override byte[] GenerateState()
        {
            return null;
        }

        public override void GetReady()
        {
            RequestRefreshing(currentRequest, null);
        }

        public override void ImportValuePackageReader<T>(Guid inputId, Guid strongCustomizedTypeTypeId, IVariableReader<T> variableReader)
        {
            throw new NotSupportedException();
        }

        public override void ImportValuePackageReader<T>(Guid inputId, DataType dataType, IVariableReader<T> variableReader)
        {
            throw new NotSupportedException();
        }

        public override void ImportValuePackageReader<T>(Guid inputId, Guid strongCustomizedTypeTypeId, int[] index, IVariableReader<T> variableReader)
        {
            throw new NotSupportedException();
        }

        public override void ImportValuePackageReader<T>(Guid inputId, DataType dataType, int[] index, IVariableReader<T> variableReader)
        {
            throw new NotSupportedException();
        }

        public override void ImportValuePackageWriter<T>(Guid outputId, IVariableWriter<T> variableWriter)
        {
            if (outputId == Ids.ProcessorCurrentTimeOutput)
            {
                if (typeof(T) != typeof(DateTime))
                    throw new ArgumentException();

                this.variableWriter = __refvalue(__makeref(variableWriter), IVariableWriter<DateTime>);
            }
            else
                throw new ArgumentOutOfRangeException(nameof(outputId));
        }

        public override void ImportValuePackageWriter<T>(Guid outputId, int[] index, IVariableWriter<T> variableWriter)
        {
            throw new NotSupportedException();
        }

        public override void Initialize(byte[] previousState, DateTime waveStartTime, DateTime waveEndTime)
        {
            this.waveStartTime = waveStartTime;
            this.waveEndTime = waveEndTime;
            currentRequest = waveStartTime;
        }

        public override void Refresh(DateTime currentSystemProcessingTime, object state)
        {
            variableWriter.WriteWithEventTriggeringPreferred(currentRequest);
            
            currentRequest = currentRequest.AddSeconds(1);
            RequestRefreshing(currentRequest, null);
        }
    }
}
