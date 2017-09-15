using System;

namespace FalconSharp
{
    // Kudos to @aaronpowell for `PullRequestRequiredException` idea!
    // https://gist.github.com/aaronpowell/2708280
    internal class PullRequestRequiredException : NotImplementedException
    {
        public PullRequestRequiredException()
            : this("The feature you are trying to use has not yet been implemented. If you would like to implemented it, please send a pull request at: https://github.com/UmbrellaInc/FalconSharp")
        {
        }

        public PullRequestRequiredException(string message)
            : base(message)
        {
        }
    }
}