using System.Collections;

namespace cosh.HyperCube.GrayCode
{
    /// <summary>
    /// The interface for all gray code server
    /// </summary>
    public interface IGrayCodeServer
    {
        /// <summary>
        /// Returns a gray code corresponding to an expression name.
        /// If the given name exists, an exception is thrown.
        /// </summary>
        /// <param name="myExpressionName">The name of the expression</param>
        /// <returns>The generated gray code</returns>
        BitArray GenerateGrayCode(string myExpressionName);
    }
}