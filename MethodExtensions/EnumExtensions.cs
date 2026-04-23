using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MethodExtensions
{
    public static class EnumExtensions
    {
        /// <summary>
        /// Gets the description of an enum value if it has a DescriptionAttribute, otherwise returns null.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static string GetDescription(Enum source)
        {
            var str = GetEnumAttribute<DescriptionAttribute>(source);
            if (str == null)
                return null;
            return str.Description;
        }

        // *****************************************
        /// <summary>
        /// Gets the specified attribute of an enum value if it exists, otherwise returns null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <returns></returns>
        private static T GetEnumAttribute<T>(Enum source) where T : Attribute
        {
            Type type = source.GetType();
            var sourceName = Enum.GetName(type, source);
            FieldInfo field = type.GetField(sourceName);
            object[] attributes = field.GetCustomAttributes(typeof(T), false);
            foreach (var o in attributes)
            {
                if (o is T)
                    return (T)o;
            }
            return null;
        }
    }
}