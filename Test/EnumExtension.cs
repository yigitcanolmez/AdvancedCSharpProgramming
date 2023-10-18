﻿namespace Test
{
    public static class EnumExtension
    {
        public static string AsString<T>(this T value) where T : Enum
        {
            return Enum.GetName(typeof(T), value);
        }
        public static TEnum ToEnum<TEnum>(this string value) where TEnum : struct
        {
            return (TEnum)Enum.Parse(typeof(TEnum), value, true);
        }
        public static TEnum ToEnum<TEnum>(this string value, TEnum defaultValue) where TEnum : struct
        {
            if (string.IsNullOrEmpty(value)) return defaultValue;

            return Enum.TryParse(value, true, out TEnum result) ? result : defaultValue;
        }
        public static T AsEnum<T>(this int value) where T : Enum
        {
            if (Enum.IsDefined(typeof(T), value))
            {
                return (T)Enum.ToObject(typeof(T), value);
            }
            else
            {
                throw new ArgumentException($"{value} is not a valid value for enum {typeof(T).Name}");
            }
        }
        public static int AsInt<T>(this T value) where T : Enum
        {
            return (int)(object)value;
        }
    }
}
