using System;

using R5T.B0001;
using R5T.B0001.X001;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        #region Value Types

#pragma warning disable IDE1006 // Naming Styles

        public static string @bool(this ITypeName _)
        {
            return TypeNames.@bool;
        }

        public static string @byte(this ITypeName _)
        {
            return TypeNames.@byte;
        }

        public static string @sbyte(this ITypeName _)
        {
            return TypeNames.@sbyte;
        }

        public static string @char(this ITypeName _)
        {
            return TypeNames.@char;
        }

        public static string @decimal(this ITypeName _)
        {
            return TypeNames.@decimal;
        }

        public static string @double(this ITypeName _)
        {
            return TypeNames.@double;
        }

        public static string @float(this ITypeName _)
        {
            return TypeNames.@float;
        }

        public static string @int(this ITypeName _)
        {
            return TypeNames.@int;
        }

        public static string @nint(this ITypeName _)
        {
            return TypeNames.@nint;
        }

        public static string @nuint(this ITypeName _)
        {
            return TypeNames.@nuint;
        }

        public static string @long(this ITypeName _)
        {
            return TypeNames.@long;
        }

        public static string @ulong(this ITypeName _)
        {
            return TypeNames.@ulong;
        }

        public static string @short(this ITypeName _)
        {
            return TypeNames.@short;
        }

        public static string @ushort(this ITypeName _)
        {
            return TypeNames.@ushort;
        }

        #endregion

        #region Reference Types

        public static string @object(this ITypeName _)
        {
            return TypeNames.@object;
        }

        public static string @string(this ITypeName _)
        {
            return TypeNames.@string;
        }

        public static string @dynamic(this ITypeName _)
        {
            return TypeNames.@dynamic;
        }

        #endregion

        public static string @var(this ITypeName _)
        {
            return TypeNames.@var;
        }

        public static string @void(this ITypeName _)
        {
            return TypeNames.@void;
        }

#pragma warning restore IDE1006 // Naming Styles
    }
}