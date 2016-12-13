using System;

namespace TravisTest
{
    public class Class1
    {
        private Func<string, int> function = (s) => s.Length;

        public int Method1()
        {
            return 123;
        }
    }
}
