using DevOps.Primitives.SourceGraph.Files;
using static DevOps.Primitives.SourceGraph.Helpers.Files.GitIgnoreConstants;

namespace DevOps.Primitives.SourceGraph.Helpers.Files
{
    public static class GitIgnore
    {
        public static GitIgnoreFile DotNetGitIgnore
               => new GitIgnoreFile(DotNetGitIgnoreText);
    }
}
