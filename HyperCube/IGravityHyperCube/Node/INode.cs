using System.Collections;
using System.Linq.Expressions;

namespace cosh.HyperCube.Node
{
    public interface INode
    {
        /// <summary>
        /// The graycode of the node
        /// </summary>
        BitArray Coordinate { get; }

        /// <summary>
        /// Executes the expression of the node
        /// </summary>
        /// <returns></returns>
        Expression Execute();
    }
}