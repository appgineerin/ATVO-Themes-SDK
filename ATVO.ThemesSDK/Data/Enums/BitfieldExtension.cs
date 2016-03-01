using System;

namespace ATVO.ThemesSDK.Data.Enums
{
    public static class BitfieldExtension
    {
        public static T SetBit<T>(this T bitfield, T bit) where T : struct, IConvertible
        {
            var values = getValues(bitfield, bit);
            return (T)(object)(values.Item1 | values.Item2);
        }

        public static T ClearBit<T>(this T bitfield, T bit) where T : struct, IConvertible
        {
            var values = getValues(bitfield, bit);
            return (T)(object)(values.Item1 & (~values.Item2));
        }

        public static bool CheckBit<T>(this T bitfield, T bit) where T : struct, IConvertible
        {
            var values = getValues(bitfield, bit);
            return (values.Item1 & values.Item2) == values.Item2;
        }

        private static Tuple<int, int> getValues<T>(T bitfield, T bit) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new ArgumentException(string.Format("The type of T has to be an enumerated type, but it was {0}.", typeof(T).Name));

            return new Tuple<int, int>((int)(object)bitfield, (int)(object)bit);
        }
    }
}
