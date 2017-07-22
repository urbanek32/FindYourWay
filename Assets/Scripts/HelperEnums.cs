using System.ComponentModel;
using System.Reflection;

namespace Assets.Scripts
{
    public enum Items
    {
        [Description("Ancient scroll which can teleport you outside. I need magical place to use it")]
        EXIT_SCROLL = 1,
        [Description("Flask full of mana")]
        MANA_POTION,
        [Description("Used gloves. Protect firm from wood and dragons")]
        GLOVES,
        [Description("Old rusty key. I wonder if still works")]
        KEY_1,
        [Description("Botle of really holy woly water")]
        HOLY_WATER,
        [Description("You feel bleesed by ancient dragon goddes")]
        BLESSING,
        [Description("Box of matches. I wonder if I can set fire somewhere")]
        MATCHES,
        [Description("Ancient sword of great dragon slayer. Very sharp")]
        SWORD,
        [Description("Cotton curtain. Someone can hide behind it")]
        CURTAIN,
        [Description("Nice tassel. Probably from ripped rope.")]
        TASSEL
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