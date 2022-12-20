using System;

using R5T.B0001;

using Instances = R5T.B0001.X001.Instances;


namespace System
{
    public static partial class ITypeNameOperatorExtensions
    {
        [Obsolete("See R5T.F0000.ITypeNameOperator.AddSuffix().")]
        public static string AddSuffix(this ITypeNameOperator _,
            string typeName,
            string suffix)
        {
            var output = Instances.StringOperator.Suffix(
                typeName,
                suffix);

            return output;
        }

        [Obsolete("See R5T.F0000.ITypeNameOperator.GetAttributeSuffixedTypeName().")]
        public static string GetAttributeSuffixedTypeName(this ITypeNameOperator _,
            string typeName)
        {
            var output = Instances.StringOperator.Suffix(
                typeName,
                Instances.TypeNameAffix.AttributeSuffix());

            return output;
        }

        [Obsolete("See R5T.F0000.ITypeNameOperator.GetEnsuredAttributeSuffixedTypeName().")]
        public static string GetEnsuredAttributeSuffixedTypeName(this ITypeNameOperator _,
            string typeName)
        {
            var isAttributeSuffixedTypeName = _.IsAttributeSuffixedTypeName(typeName);
            if (!isAttributeSuffixedTypeName)
            {
                var output = _.GetAttributeSuffixedTypeName(typeName);
                return output;
            }
            else
            {
                return typeName;
            }
        }

        [Obsolete("See R5T.F0000.ITypeNameOperator.GetEnsuredNonAttributeSuffixedTypeName().")]
        public static string GetEnsuredNonAttributeSuffixedTypeName(this ITypeNameOperator _,
            string typeName)
        {
            var isAttributeSuffixedTypeName = _.IsAttributeSuffixedTypeName(typeName);
            if (isAttributeSuffixedTypeName)
            {
                var output = _.GetNonAttributeSuffixedTypeName(typeName);
                return output;
            }
            else
            {
                return typeName;
            }
        }

        [Obsolete("See R5T.F0000.ITypeNameOperator.GetNonAttributeSuffixedTypeName().")]
        public static string GetNonAttributeSuffixedTypeName(this ITypeNameOperator _,
            string attributeSuffixedTypeName)
        {
            var output = Instances.StringOperator.ExceptEnding(
                attributeSuffixedTypeName,
                Instances.TypeNameAffix.AttributeSuffix());

            return output;
        }

        public static string GetAttributeNameFromAttributeTypeName(this ITypeNameOperator _,
            string attributeTypeName)
        {
            var hasAttributeTypeNameSuffix = _.HasAttributeTypeNameSuffix(attributeTypeName);
            if (hasAttributeTypeNameSuffix)
            {
                var output = _.GetNonAttributeSuffixedTypeName(attributeTypeName);
                return output;
            }
            else
            {
                throw new ArgumentException($"Attribute type name '{attributeTypeName}' did not have attribute suffix.");
            }
        }

        [Obsolete("See R5T.F0000.ITypeNameOperator.Is_AttributeSuffixedTypeName.")]
        public static bool IsAttributeSuffixedTypeName(this ITypeNameOperator _,
            string typeName)
        {
            var output = Instances.StringOperator.EndsWith(
                typeName,
                Instances.TypeNameAffix.AttributeSuffix());

            return output;
        }

        [Obsolete("See R5T.F0000.ITypeNameOperator.HasAttributeTypeNameSuffix().")]
        public static bool HasAttributeTypeNameSuffix(this ITypeNameOperator _,
            string typeName)
        {
            var output = _.IsAttributeSuffixedTypeName(typeName);
            return output;
        }
    }
}
