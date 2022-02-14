using System;


namespace R5T.B0001.X001
{
    /// <summary>
    /// These are type names of the built-in types of the C# language.
    /// </summary>
    /// <remarks>
    /// See:
    /// * Void type: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/void
    /// * Var type: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var
    /// * Built-In types: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
    /// </remarks>
    public static partial class TypeNames
    {
#pragma warning disable IDE1006 // Naming Styles

        #region Value Types

        public static string @bool => "bool";
        public static string @byte => "byte";
        public static string @sbyte => "sbyte";
        public static string @char => "char";
        public static string @decimal => "decimal";
        public static string @double => "double";
        public static string @float => "float";
        public static string @int => "int";
        /// <summary>
        /// Native sized integers (32-bit size on a 32-bit process, 62-bit size on a 64-bit process).
        /// </summary>
        public static string @nint => "nint";
        public static string @nuint => "nuint";
        public static string @long => "long";
        public static string @ulong => "ulong";
        public static string @short => "short";
        public static string @ushort => "ushort";

        #endregion

        #region Reference Types

        public static string @object => "object";
        public static string @string => "string";
        public static string @dynamic => "dynamic";

        #endregion

        public static string @var => "var";

        public static string @void => "void";

#pragma warning restore IDE1006 // Naming Styles
    }
}
