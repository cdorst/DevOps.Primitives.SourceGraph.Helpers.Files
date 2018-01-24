using DevOps.Primitives.SourceGraph.Files;
using static DevOps.Primitives.SourceGraph.Helpers.Files.GitAttributesConstants;

namespace DevOps.Primitives.SourceGraph.Helpers.Files
{
    public static class GitAttributes
    {
        public static GitAttributesFile DotNetGitAttributes
               => new GitAttributesFile(DotNetGitAttributesText);
    }
}
