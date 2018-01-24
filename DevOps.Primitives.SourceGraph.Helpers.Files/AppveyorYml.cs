using DevOps.Primitives.SourceGraph.Files;
using static DevOps.Primitives.SourceGraph.Helpers.Files.AppveyorYmlContants;

namespace DevOps.Primitives.SourceGraph.Helpers.Files
{
    public static class AppveyorYml
    {
        public static AppveyorYmlFile CDorstNuGetAppveyor
            => new AppveyorYmlFile(CDorstNuGetAppveyorText);

        public static AppveyorYmlFile DotNetAppveyor
            => new AppveyorYmlFile(DotNetAppveyorText);
    }
}
