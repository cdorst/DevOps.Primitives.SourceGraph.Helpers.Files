using DevOps.Primitives.SourceGraph.Files;
using static DevOps.Primitives.SourceGraph.Helpers.Files.LicensesConstants;

namespace DevOps.Primitives.SourceGraph.Helpers.Files
{
    public static class Licenses
    {
        public static LicenseFile GnuGpl3
               => new LicenseFile(GnuGpl3Text);
    }
}
