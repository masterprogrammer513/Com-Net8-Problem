using System.Runtime.InteropServices;

namespace ParentCOM
{
    /// <summary>
    /// Base setting class.
    /// </summary>
    [ComVisible(true)]
    [Guid(ContractGuids.BaseSettingClass)]
    [ClassInterface(ClassInterfaceType.None)]
    public class BaseSetting : IBaseSetting
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public BaseSetting() { }

        /// <summary>
        /// First number.
        /// </summary>
        public int Num1 { get; set; }

        /// <summary>
        /// Second number.
        /// </summary>
        public int Num2 { get; set; }
    }
}
