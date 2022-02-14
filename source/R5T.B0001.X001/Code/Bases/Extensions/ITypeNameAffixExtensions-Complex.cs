using System;

using R5T.B0001;
using R5T.B0001.X001;


namespace System
{
    public static partial class ITypeNameAffixExtensions
    {
        public static string AttributeSuffix(this ITypeNameAffix _)
        {
            return TypeNameAffixes.AttributeSuffix;
        }

        public static string ExceptionSuffix(this ITypeNameAffix _)
        {
            return TypeNameAffixes.ExceptionSuffix;
        }

        public static string ExtensionsSuffix(this ITypeNameAffix _)
        {
            return TypeNameAffixes.ExtensionsSuffix;
        }
    }
}