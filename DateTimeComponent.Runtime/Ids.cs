using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeComponent
{
    static class Ids
    {
        internal static Guid LibraryRuntime { get; } = new Guid("3AB65156-C754-4DDD-B87A-050FCF97CFCD");

        internal static Guid DeviceRuntime { get; } = new Guid("7FD184D0-D93D-4E41-8666-B7F98AF229DD");
        internal static Guid DeviceBlockMain { get; } = new Guid("D7DD5D32-7D9D-45A8-8F45-918C62F2BA46");
        internal static Guid DeviceBlockSecondary { get; } = new Guid("3E7ECA08-69A2-4049-87BC-B420F25D9BE4");
        internal static Guid DeviceChannel { get; } = new Guid("0491DC78-8998-415F-80CE-C2C404E79090");

        internal static Guid ConverterRuntime { get; } = new Guid("F3E13524-B686-4CB4-9DED-273B069ECCEB");
        internal static Guid ConverterOutputDateTime { get; } = new Guid("F6BE0F6C-6C2C-4701-98A4-78418AFDC671");
        internal static Guid ConverterOutputTick { get; } = new Guid("752E3657-2BF8-4B58-AADC-3EB48F563698");
        internal static Guid ConverterOutputIsUtc { get; } = new Guid("D32BFBC1-CEA7-4173-92D8-067DC1506BCE");
        internal static Guid ConverterOutputSct { get; } = new Guid("A74A7EA6-0301-4D91-8879-F35E630F67BA");

        internal static Guid ConditionRuntime { get; } = new Guid("7B2D741C-39B9-4114-958E-F7369160F916");
        internal static Guid ConditionSettingVersion { get; } = new Guid("15BF9232-19EA-41AA-AAB1-B09FF47DEF23");

        internal static Guid SctRuntime { get; } = new Guid("633785D1-A769-49A7-AFAD-C7AE5716DE43");
        internal static Guid SctTypeId { get; } = new Guid("02A04621-8EE6-4060-9CD7-D336652BE1E3");


        internal static Guid ProcessorCurrentTimeRuntime { get; } = new Guid("ea17ba80-d539-4b02-827e-76d1487755e8");
        internal static Guid ProcessorCurrentTimeOutput { get; } = new Guid("43bbacbc-d1b4-493d-aa0c-433ab76efad7");


        internal static Guid ProcessorAddTimeRuntime { get; } = new Guid("37513982-02d9-4352-8005-f25fc6bc05d1");
        internal static Guid ProcessorAddTimeInput { get; } = new Guid("8876cedf-b09d-4945-aa5f-355db5096d73");
        internal static Guid ProcessorAddTimeOutput { get; } = new Guid("211781f7-267c-4b04-99f1-ba599103520c");
        internal static Guid ProcessorAddTimeSetting { get; } = new Guid("1aec06a2-a4da-42c9-bdf0-8771c516c3d3");
    }
}
