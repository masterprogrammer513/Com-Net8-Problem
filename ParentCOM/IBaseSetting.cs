using System.Runtime.InteropServices;

namespace ParentCOM
{
    /// <summary>
    /// Interface for BaseSetting.
    /// </summary>
    [ComVisible(true)]
    [Guid(ContractGuids.BaseSettingInterface)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface IBaseSetting
    {
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
