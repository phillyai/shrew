﻿namespace shrew.Syntax
{
    public partial class SyntaxToken
    {
        public SyntaxTokenType TokenType { get; }

        public int FullWidth { get; set; }

        internal SyntaxToken(SyntaxTokenType type)
        {
            TokenType = type;
            FullWidth = Text.Length;
        }

        protected SyntaxToken(SyntaxTokenType type, int width)
        {
            TokenType = type;
            FullWidth = width;
        }

        public virtual string Text
            => SyntaxFactory.GetText(TokenType);

        public virtual object Value
        {
            get
            {
                switch (TokenType)
                {
                    case SyntaxTokenType.TrueKeyword:
                        return true;
                    case SyntaxTokenType.FalseKeyword:
                        return false;
                    default:
                        return Text;
                }
            }
        }

        internal static SyntaxToken WithValue<T>(SyntaxTokenType type, string text, T value)
            => new SyntaxTokenWithValue<T>(type, text, value);
    }
}
