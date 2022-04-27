using System;


namespace R5T.B0001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeNameToken : ITypeNameToken
    {
        #region Static
        
        public static TypeNameToken Instance { get; } = new();

        #endregion
    }
}