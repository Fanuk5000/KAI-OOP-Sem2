using System;

namespace StringsApp
{
    interface IString
    {
        int Length { get; }
        void Replace(char oldChar, char newChar);
        bool Contains(string substring);
        string GetContent(); // Added method for content retrieval
    }

    class MyString : IString
    {
        private string content;

        public MyString(string content)
        {
            this.content = content;
        }

        public int Length => content.Length;

        public void Replace(char oldChar, char newChar)
        {
            content = content.Replace(oldChar, newChar);
        }

        public bool Contains(string substring)
        {
            return content.Contains(substring);
        }

        public string GetContent()
        {
            return content;
        }
    }
}