using System.ComponentModel;
using System.Reflection;

namespace Assets.Scripts
{
    public enum Items
    {
        [Description("Key which leads to exit")]
        EXIT_KEY = 1,
        [Description("Flask full of mana")]
        MANA_POTION,
        [Description("Rusted key")]
        KEY_1,
        [Description("Really old key")]
        KEY_2,
        [Description("Dry matches")]
        MATCHES,
    }

    public class HelperEnums
    {
        public static string GetEnumDescription(Items value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = 
                (DescriptionAttribute[])fi.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false);

            if (attributes != null &&
                attributes.Length > 0)
                return attributes[0].Description;
            else
                return value.ToString();
        }
    }

    
}