using System;

using R5T.B0000;
using R5T.Z0000;


namespace R5T.B0001.X001
{
    public static class Instances
    {
        public static ICharacters Characters { get; } = Z0000.Characters.Instance;
        public static ICharacterOperator CharacterOperator { get; } = B0000.CharacterOperator.Instance;
        public static IExceptionMessage ExceptionMessage { get; } = B0000.ExceptionMessage.Instance;
        public static IExceptionOperator ExceptionOperator { get; } = B0000.ExceptionOperator.Instance;
        public static IStringOperator StringOperator { get; } = B0000.StringOperator.Instance;
        public static IStrings Strings { get; } = Z0000.Strings.Instance;
        public static ITypeName TypeName { get; } = B0001.TypeName.Instance;
        public static ITypeNameAffix TypeNameAffix { get; } = B0001.TypeNameAffix.Instance;
        public static ITypeNameOperator TypeNameOperator { get; } = B0001.TypeNameOperator.Instance;
    }
}
