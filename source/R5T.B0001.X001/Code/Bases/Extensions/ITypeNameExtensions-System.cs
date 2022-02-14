using System;

using R5T.B0001;
using R5T.B0001.X001;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string String(this ITypeName _)
        {
            return TypeNames.String;
        }

        public static string Task(this ITypeName _)
        {
            return TypeNames.Task;
        }
    }
}