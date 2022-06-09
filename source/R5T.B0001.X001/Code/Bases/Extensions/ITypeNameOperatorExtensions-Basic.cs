using System;
using System.Linq;

using R5T.B0001;

using Instances = R5T.B0001.X001.Instances;


namespace System
{
    public static partial class ITypeNameOperatorExtensions
    {
        public static bool Equals(this ITypeNameOperator _,
            string typeName1,
            string typeName2)
        {
            var output = typeName1 == typeName2;
            return output;
        }

        public static string GetClassName(this ITypeNameOperator _,
            string typeNameStem)
        {
            // Just return the type name.
            return typeNameStem;
        }

        public static string GetImplementationClassNameForInterfaceName(this ITypeNameOperator _,
            string interfaceName)
        {
            // Use -checked for robustness.
            var output = _.GetTypeNameStemForInterfaceName_Checked(interfaceName);
            return output;
        }

        public static string GetInterfaceName(this ITypeNameOperator _,
            string typeNameStem)
        {
            var output = Instances.StringOperator.Prefix(
                Instances.TypeNameAffix.InterfacePrefix(),
                typeNameStem);

            return output;
        }

        /// <summary>
        /// Chooses <see cref="GetTypeNameStemForInterfaceName_Checked(ITypeNameOperator, string)"/> as the default.
        /// </summary>
        public static string GetTypeNameStemFromInterfaceName(this ITypeNameOperator _,
            string interfaceName)
        {
            var output = _.GetTypeNameStemForInterfaceName_Checked(interfaceName);
            return output;
        }

        public static string GetTypeNameStemForInterfaceName_Unchecked(this ITypeNameOperator _,
            string interfaceName)
        {
            var output = interfaceName[1..];
            return output;
        }

        public static string GetTypeNameStemForInterfaceName_Checked(this ITypeNameOperator _,
            string interfaceName)
        {
            // Verify the input is an interface name.
            _.VerifyIsInterface(interfaceName);

            var output = _.GetTypeNameStemForInterfaceName_Unchecked(interfaceName);
            return output;
        }

        /// <summary>
        /// If the type name is an interface, removes the interface name prefix character.
        /// Otherwise, just returns the class name.
        /// </summary>
        public static string GetTypeNameStem_HandleInterface(this ITypeNameOperator _,
            string typeName)
        {
            var isInterface = _.IsInterface(typeName);

            var output = isInterface
                ? _.GetTypeNameStemForInterfaceName_Unchecked(typeName)
                : typeName
                ;

            return output;
        }

        public static bool IsInterface(this ITypeNameOperator _,
            string typeName)
        {
            _.Verify(typeName);

            // 1) Is the name at least two characters long?
            // 2) Is the first character of the type name the interface name prefix character?
            // 3) Is the second character also capitalized (allowing for ImageData to be a class, while IImageData would be an interface)?
            var output = true
                && Instances.StringOperator.IsLengthAtLeast(2,
                    typeName)
                && Instances.StringOperator.FirstCharacterIs(Instances.TypeNameAffix.InterfacePrefix_Character(),
                    typeName)
                && Instances.CharacterOperator.IsUppercase(typeName.Second());

            return output;
        }

        public static bool IsNonNullAndNonEmpty(this ITypeNameOperator _,
            string typeName)
        {
            var output = Instances.StringOperator.IsNonNullAndNonEmpty(
                typeName);

            return output;
        }

        public static string Pluralize(this ITypeNameOperator _,
            string typeName)
        {
            var output = Instances.StringOperator.Suffix(
                typeName,
                Instances.Characters.s_Lowercase);

            return output;
        }

        /// <summary>
        /// Establishes the default rules for a type name.
        /// </summary>
        public static void Verify(this ITypeNameOperator _,
            string typeName)
        {
            _.VerifyIsNonNullAndNonEmpty(typeName);
        }

        public static void VerifyIsInterface(this ITypeNameOperator _,
            string typeName)
        {
            var isInterface = _.IsInterface(typeName);
            if (!isInterface)
            {
                throw new Exception($"'{typeName}': Type name not recognized as an interface name.");
            }
        }

        public static void VerifyIsNonNullAndNonEmpty(this ITypeNameOperator _,
            string typeName)
        {
            var isNonNullAndNonEmpty = _.IsNonNullAndNonEmpty(typeName);
            if (!isNonNullAndNonEmpty)
            {
                throw Instances.ExceptionOperator.TypeNameWasNullOrEmpty(
                    nameof(typeName));
            }
        }
    }
}
