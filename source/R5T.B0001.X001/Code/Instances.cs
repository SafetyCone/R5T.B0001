using System;

using R5T.B0000;


namespace R5T.B0001.X001
{
    public static class Instances
    {
        public static ICharacter Character { get; } = B0000.Character.Instance;
        public static ICharacterOperator CharacterOperator { get; } = B0000.CharacterOperator.Instance;
        public static IExceptionMessage ExceptionMessage { get; } = B0000.ExceptionMessage.Instance;
        public static IExceptionOperator ExceptionOperator { get; } = B0000.ExceptionOperator.Instance;
        public static IStringOperator StringOperator { get; } = B0000.StringOperator.Instance;
        public static ITypeNameAffix TypeNameAffix { get; } = B0001.TypeNameAffix.Instance;
    }
}
