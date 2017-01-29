using System.Collections.Generic;

namespace Projbook.Core.Model
{
    public class SnippetReferencePage
    {
        /// <summary>
        /// The page title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The list of snippet references.
        /// </summary>
        public List<SnippetReference> SnippetReferenceList { get; set; }
    }
}
