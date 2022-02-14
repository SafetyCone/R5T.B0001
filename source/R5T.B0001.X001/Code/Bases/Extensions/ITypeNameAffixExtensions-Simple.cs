using System;

using R5T.B0001;
using R5T.B0001.X001;


namespace System
{
    public static partial class ITypeNameAffixExtensions
    {
        public static string InterfacePrefix(this ITypeNameAffix _)
        {
            return TypeNameAffixes.InterfacePrefix;
        }

        public static char InterfacePrefix_Character(this ITypeNameAffix _)
        {
            return TypeNameAffixes.InterfacePrefix_Character;
        }
    }
}