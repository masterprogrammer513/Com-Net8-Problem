using ParentCOM;
using System.Runtime.InteropServices;

namespace InheritCOM
{
    /// <summary>
    /// Sample Class.
    /// </summary>
    [ComVisible(true)]
    [Guid(ContractGuids.SampleClass)]
    [ClassInterface(ClassInterfaceType.None)]
    public class Sample : ISample
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public Sample() { }

        /// <summary>
        /// Sum two numbers from <see cref="IBaseSetting"/>.
        /// </summary>
        /// <param name="baseSetting">Base setting <see cref="IBaseSetting"/>.</param>
        /// <returns> Sum two numbers from <see cref="IBaseSetting"/>.</returns>
        public int Sum(IBaseSetting baseSetting)
        {
            return baseSetting.Num1 + baseSetting.Num2;
        }
    }
}
