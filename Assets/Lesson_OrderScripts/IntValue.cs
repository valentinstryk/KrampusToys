using System;

namespace Lesson_OrderScripts
{
    [Serializable]
    public class IntValue
    {
        public int Value;

        public IntValue(int value)
        {
            Value = value;
        }
    }
}