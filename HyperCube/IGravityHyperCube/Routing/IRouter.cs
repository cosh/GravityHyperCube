using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cosh.HyperCube.Node;

namespace cosh.HyperCube.Routing
{
    /// <summary>
    /// The interface for all router
    /// </summary>
    public interface IRouter
    {
        /// <summary>
        /// Finds a node corresponding to its expression name
        /// </summary>
        /// <param name="myExpressionName">The name of the expression</param>
        /// <returns>The desired INode</returns>
        INode FindNode(String myExpressionName);
    }
}
