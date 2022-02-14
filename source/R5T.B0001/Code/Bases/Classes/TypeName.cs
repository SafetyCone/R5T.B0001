using System;


namespace R5T.B0001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeName : ITypeName
    {
        #region Static
        
        public static TypeName Instance { get; } = new();

        #endregion
    }
}