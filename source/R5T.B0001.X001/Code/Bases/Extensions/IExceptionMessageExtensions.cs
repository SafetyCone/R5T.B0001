using System;

using R5T.B0000;
using R5T.B0001.X001;


namespace System
{
    public static partial class IExceptionMessageExtensions
    {
        public static string TypeNameWasNullOrEmpty(this IExceptionMessage _)
        {
            return ExceptionMessages.TypeNameWasNullOrEmpty;
        }
    }
}
