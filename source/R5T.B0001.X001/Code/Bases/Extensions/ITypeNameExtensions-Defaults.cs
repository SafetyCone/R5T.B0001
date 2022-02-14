using System;

using R5T.B0001;
using R5T.B0001.X001;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string Class1(this ITypeName _)
        {
            return TypeNames.Class1;
        }

        public static string Interface1(this ITypeName _)
        {
            return TypeNames.Interface1;
        }

        public static string Program(this ITypeName _)
        {
            return TypeNames.Program;
        }

        public static string Startup(this ITypeName _)
        {
            return TypeNames.Startup;
        }
    }
}