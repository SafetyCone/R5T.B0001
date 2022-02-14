using System;

using R5T.B0001;

using Instances = R5T.B0001.X001.Instances;


namespace System
{
    public static partial class ITypeNameOperatorExtensions
    {
        public static string GetExtensionsOfTypeNameTypeName(this ITypeNameOperator _,
            string typeName)
        {
            var output = _.GetExtensionsSuffixedTypeName(typeName);
            return output;
        }

        public static string GetExtensionsSuffixedTypeName(this ITypeNameOperator _,
            string typeName)
        {
            var output = Instances.StringOperator.Suffix(
                typeName,
                Instances.TypeNameAffix.ExtensionsSuffix());

            return output;
        }
    }
}
