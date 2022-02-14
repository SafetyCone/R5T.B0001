using System;

using R5T.B0001;
using R5T.B0001.X001;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string IHostBuilder(this ITypeName _)
        {
            return TypeNames.IHostBuilder;
        }

        public static string IServiceCollection(this ITypeName _)
        {
            return TypeNames.IServiceCollection;
        }
    }
}