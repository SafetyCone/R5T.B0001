using System;

using R5T.B0001;

using Instances = R5T.B0001.X001.Instances;


// N0 is the namespace for low-dependency implementations.
namespace System.N0
{
    public static partial class ITypeNameOperatorExtensions
    {
        /// <summary>
        /// Works on both type name or namespaced type name strings.
        /// </summary>
        public static string GetGenericOfTypeNameTypeName(this ITypeNameOperator _,
            string genericTypeName,
            string typeParameterTypeName)
        {
            // String construction works for both type names and namespaced type names.
            var output = $"{genericTypeName}<{typeParameterTypeName}>";
            return output;
        }

        /// <summary>
        /// Tests for whether the type name contains the type parameter arity marker '`' (tick).
        /// </summary>
        public static bool IsGeneric(this ITypeNameOperator _,
            string typeName)
        {
            var output = typeName.Contains('`');
            return output;
        }

        /// <summary>
        /// Removes everything trailing the `# in a type name X`#. For example: IList`1 becomes IList.
        /// </summary>
        public static string RemoveGenericTypeParameterArityFromTypeName(this ITypeNameOperator _,
            string typeName)
        {
            var indexOfTick = typeName.IndexOf('`');

            var isFound = IndexHelper.IsFound(indexOfTick);

            var output = isFound
                ? typeName.Substring(0, IndexHelper.ToLength_Exclusive(indexOfTick))
                : typeName
                ;

            return output;
        }
    }
}
