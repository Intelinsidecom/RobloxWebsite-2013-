// Minimal shim for GraphemeSplitter used by ConversationBuilder
// This does NOT implement true grapheme cluster logic; it approximates by single-char segments.
// If accurate grapheme counting is required, replace with the real GraphemeSplitter package.
using System.Collections.Generic;

namespace GraphemeSplitter
{
    public struct StringSegment
    {
        public string Value { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(Value)) return string.Empty;
            if (Start < 0 || Length <= 0 || Start + Length > Value.Length) return string.Empty;
            return Value.Substring(Start, Length);
        }
    }

    public static class StringSplitter
    {
        public static IEnumerable<StringSegment> GetGraphemes(string input)
        {
            if (string.IsNullOrEmpty(input)) yield break;
            // Approximate: yield each UTF-16 code unit as a segment
            for (int i = 0; i < input.Length; i++)
            {
                yield return new StringSegment
                {
                    Value = input,
                    Start = i,
                    Length = 1
                };
            }
        }
    }
}
