using System.ComponentModel;
using System.Reflection;

namespace Assets.Scripts
{
    public enum Items
    {
        [Description("This scroll might take me outside! If only there was a place with enough magical power...")]
        EXIT_SCROLL = 1,
        [Description("The flask contains liquid which restores magical powers.")]
        MANA_POTION,
        [Description("Old used leather gloves. Protect from splinters, recoil vibrations and dragon breath.")]
        GLOVES,
        [Description("An old rusty iron key. I am pretty sure that it will break when used.")]
        KEY_1,
        [Description("Angel piss. Gods tears. Latest tech in demon banishing. Or simply holy water.")]
        HOLY_WATER,
        [Description("I am either blessed or this dragon goddess is really hot.")]
        BLESSING,
        [Description("Oh boy! Let's hope I do not set something on fire with those matches!")]
        MATCHES,
        [Description("This dragon slayer blade is as sharp as my father. I mean head off in a swing sharp.")]
        SWORD,
        [Description("Cotton curtain. Large enough to hide my mother under it! She liked to eat.")]
        CURTAIN,
        [Description("A decorative tassel made from yarn. Looks good.")]
        TASSEL
    }

    public enum ItemTips
    {
        [Description("As far as I am concerned I am not fireproof. I need to extinguish this first.")]
        CAMPFIRE = 1,
        [Description("It's most surely, absolutely, 100% locked and without a key I won't get far.")]
        SAFE,
        [Description("The goddess can bless me only withinh her sexy rays.")]
        BLESSING,
        [Description("If only I had dragon breath... Or some fire summoning spell... Or something... ")]
        TORCH,
        [Description("This rope lacks a coherent and happy ending...")]
        ROPE,
        [Description("I'm surely need more god in my life to do that...")]
        HOLYWATER,
        [Description("Can't touch this... Till I am well equipped with hand protecting gear!")]
        BOXES,
        [Description("I am sure I missed something... That or I don't have this key item I need...")]
        PENTAGRAM,
        [Description("I am sure I heard something...")]
        SECRET_ROOM_UNLOCKED,
        [Description("I wonder what would happen if I cut it in half?")]
        CURTAIN,
        [Description("Yep, for me that can be fire, but I'm not a dragon to know it...")]
        LAMP,
        [Description("He's doing completly nothing. I don't even have to cover him.            \"Paulo Naked Bones\"")]
        SKELETON,
        [Description("My only hope to understand that is Gandalf or sexy dragon mom I guess...")]
        BOARD
    }

    public class HelperEnums
    {
        public static string GetItemDescription(Items value)
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

        public static string GetItemTip(ItemTips value)
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