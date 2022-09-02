using System;
// ReSharper disable CompareOfFloatsByEqualityOperator

namespace TeamZero.Core
{
    [Serializable]
    public struct Range
    {
        public float Min { get => _min; set => _min = value; }
        private float _min;
        
        public float Max { get => _max; set => _max = value; }
        private float _max;

        public Range(float min, float max)
        {
            _min = min;
            _max = max;
        }
        
        public float Length() => _max - _min; 
        
        public bool IsInside(float x) => x >= _min && x <= _max;
        
        public bool IsInside(Range range) => IsInside(range._min) && IsInside(range._max);
        
        public bool IsOverlapping(Range range) => IsInside(range._min) || IsInside(range._max) || range.IsInside(_min) || range.IsInside(_max);

        public static bool operator ==(Range range1, Range range2) => range1._min == range2._min && range1._max == range2._max;
        
        public static bool operator !=(Range range1, Range range2) => range1._min != range2._min || range1._max != range2._max;

        public override bool Equals(object obj) => obj is Range range && this == range;
        
        public override int GetHashCode() => _min.GetHashCode() + _max.GetHashCode();
        
        public override string ToString() 
            => string.Format( System.Globalization.CultureInfo.InvariantCulture, "{0}, {1}", _min, _max );
        
        public IntRange ToIntRange( bool provideInnerRange )
        {
            int iMin, iMax;

            if ( provideInnerRange )
            {
                iMin = (int) Math.Ceiling( _min );
                iMax = (int) Math.Floor( _max );
            }
            else
            {
                iMin = (int) Math.Floor( _min );
                iMax = (int) Math.Ceiling( _max );
            }

            return new IntRange( iMin, iMax );
        }
    }
}

