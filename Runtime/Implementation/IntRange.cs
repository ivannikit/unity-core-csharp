using System;

namespace TeamZero.Core
{
    [Serializable]
    public struct IntRange
    {
        public int Min { get => _min; set => _min = value; }
        private int _min;
        
        public int Max { get => _max; set => _max = value; }
        private int _max;

        public IntRange(int min, int max)
        {
            _min = min;
            _max = max;
        }
        
        public int Length() => _max - _min;
        
        public bool IsInside(int x) => x >= _min && x <= _max;
        
        public bool IsInside(IntRange range) => IsInside(range._min) && IsInside(range._max);
        
        public bool IsOverlapping( IntRange range ) => IsInside(range._min) || IsInside(range._max) || range.IsInside(_min) || range.IsInside(_max);
        
        public static implicit operator Range(IntRange range) => new Range(range.Min, range.Max);
        
        public static bool operator ==(IntRange range1, IntRange range2) => range1._min == range2._min && range1._max == range2._max;
        
        public static bool operator !=(IntRange range1, IntRange range2) => range1._min != range2._min || range1._max != range2._max;
        
        public override bool Equals(object obj) => obj is IntRange range && this == range;
        
        public override int GetHashCode() => _min.GetHashCode() + _max.GetHashCode();
        
        public override string ToString() => string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}, {1}", _min, _max);
    }
}
