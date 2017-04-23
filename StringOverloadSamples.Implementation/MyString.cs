using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringOverloadSamples.Implementation
{
    public class MyString
    {
        private string text;

        public MyString(string text)
        {
            this.text = text;
        }

        public override string ToString()
        {
            return text;
        }

        public static MyString operator ++(MyString str)
        {
            if (String.IsNullOrEmpty(str.ToString()))
            {
                return new MyString(string.Empty);
            }
            return new MyString(str.text + str.text);
        }
    }
}
