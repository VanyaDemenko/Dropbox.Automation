﻿using System.ComponentModel;

namespace Dropbox.Core.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDescription(this Enum en)
        {
            var type = en.GetType();

            var memInfo = type.GetMember(en.ToString());

            if (memInfo != null && memInfo.Length > 0)
            {
                var attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }

            return en.ToString();
        }

        public static T GetEnumByDescription<T>(string description) where T : struct, IConvertible
        {
            foreach (T item in Enum.GetValues(typeof(T)))
            {
                if (string.Equals((item as Enum).GetDescription(), description, StringComparison.InvariantCultureIgnoreCase))
                {
                    return item;
                }
            }
            throw new ArgumentException($"There no enum values for description '{description}' in '{typeof(T)}' type");
        }
    }
}
