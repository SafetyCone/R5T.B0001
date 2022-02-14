using System;

using R5T.B0000;

using Instances = R5T.B0001.X001.Instances;


namespace System
{
    public static partial class IExceptionOperatorExtensions
    {
        public static ArgumentException TypeNameWasNullOrEmpty(this IExceptionOperator _,
            string typeNameParameterName)
        {
            var output = new ArgumentException(
                Instances.ExceptionMessage.TypeNameWasNullOrEmpty(),
                typeNameParameterName);

            return output;
        }
    }
}
