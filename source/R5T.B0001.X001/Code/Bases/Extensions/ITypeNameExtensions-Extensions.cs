using System;

using R5T.B0001;

using Instances = R5T.B0001.X001.Instances;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string IServiceCollectionExtensions(this ITypeName _)
        {
            var output = Instances.TypeNameOperator.GetExtensionsSuffixedTypeName(
                _.IServiceCollection());

            return output;
        }
    }
}