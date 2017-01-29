using EnsureThat;
using System.Text.RegularExpressions;

namespace Projbook.Core.Snippet
{
    /// <summary>
    /// Represents a snippet extraction rule.
    /// </summary>
    public class SnippetExtractionRule
    {
        /// <summary>
        /// The language.
        /// </summary>
        public string Language { get; private set; }

        /// <summary>
        /// The targe path.
        /// </summary>
        public string TargetPath { get; private set; }

        /// <summary>
        /// The pattern.
        /// </summary>
        public string Pattern { get; private set; }

        /// <summary>
        /// Capture an expression following this format: <syntax> [<file>] <pattern>
        /// syntax:  The snippet syntax, typically a language name like xml or csharp.
        ///          This value will be used for syntax highlighting and is optional.
        ///          If no value is specified, no syntax highlighting will be applied.
        /// file:    The file where the snippet exists that have to exist either under
        ///          the current documentation project or in one of the referenced projects.
        /// pattern: Syntax specific format identifying which part of the file to extract.
        ///          The value is optional and the whole file will be extracted if no pattern
        ///          is defined.
        /// </summary>
        private static Regex regex = new Regex(@"^([^\[\(]+)?\[([^\]]+)\](.*)$", RegexOptions.Compiled);

        /// <summary>
        /// Parses the provided expression representing snippet extraction details.
        /// </summary>
        /// <param name="snippetExtractionExpression">The snippet extraction expression.</param>
        /// <returns></returns>
        public static SnippetExtractionRule Parse(string snippetExtractionExpression)
        {
            // Data validation
            Ensure.That(() => snippetExtractionExpression).IsNotNullOrWhiteSpace();

            // Try to match the regex
            Match match = SnippetExtractionRule.regex.Match(snippetExtractionExpression);
            if (!match.Success)
            {
                return null;
            }

            // Return a new instance of snippet extraction rule
            return new SnippetExtractionRule
            {
                Language = match.Groups[1].Value.Trim(),
                TargetPath = match.Groups[2].Value.Trim(),
                Pattern = match.Groups[3].Value.Trim(),
                // TODO parse and set the title here
                // and compute a generated one if needed
            };
        }
    }
}