using System.Collections.Generic;

namespace Projbook.Core.Model
{
    public class SnippetReference
    {
        public string Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public List<SnippetLink> Links { get; set; }
    }
}
