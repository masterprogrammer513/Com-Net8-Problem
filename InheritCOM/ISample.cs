using ParentCOM;
using System.Runtime.InteropServices;

namespace InheritCOM
{
    /// <summary>
    /// Interface for <see cref="Sample"/>.
    /// </summary>
    [ComVisible(true)]
    [Guid(ContractGuids.SampleInterface)]
    [InterfaceType(ComInterfaceType.InterfaceIsDual)]
    public interface ISample
    {
        /// <summary>
        /// Sum two numbers from <see cref="IBaseSetting"/>.
        /// </summary>
        /// <param name="baseSetting">Base setting <see cref="IBaseSetting"/>.</param>
        /// <returns> Sum two numbers from <see cref="IBaseSetting"/>.</returns>
        public int Sum(IBaseSetting baseSetting);
    }
}
