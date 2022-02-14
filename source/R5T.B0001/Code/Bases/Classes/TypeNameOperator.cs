using System;


namespace R5T.B0001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeNameOperator : ITypeNameOperator
    {
        #region Static
        
        public static TypeNameOperator Instance { get; } = new();

        #endregion
    }
}