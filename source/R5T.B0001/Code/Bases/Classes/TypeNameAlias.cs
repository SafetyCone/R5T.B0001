using System;


namespace R5T.B0001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeNameAlias : ITypeNameAlias
    {
        #region Static
        
        public static TypeNameAlias Instance { get; } = new();

        #endregion
    }
}