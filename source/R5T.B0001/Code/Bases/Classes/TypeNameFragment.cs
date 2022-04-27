using System;


namespace R5T.B0001
{
    /// <summary>
    /// Empty implementation as base for extension methods.
    /// </summary>
    public class TypeNameFragment : ITypeNameFragment
    {
        #region Static
        
        public static TypeNameFragment Instance { get; } = new();

        #endregion
    }
}