using System;

namespace LearningTDD.RomanNumbers.Tests
{
    public class RomanNumber
    {
        public string Convert(int number)
        {
            return Enum.GetName(typeof(RomaNumbersMask), number);
        }
    }
}