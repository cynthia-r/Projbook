using System.Collections.Generic;
using CommonMark.Syntax;

namespace Projbook.Core.Snippet
{
    public class SnippetRef
    {
        public string PageTitle { get; set; }

        public SnippetExtractionRule SnippetExtractionRule { get; set; }

        public Block Block { get; set; }

        public List<string> Refs { get; set; }
    }
}
