using System.Collections.Generic;
using System.Linq.Expressions;
using System.Collections;

namespace cosh.HyperCube.Node
{
    /// <summary>
    /// The actual node implementation
    /// </summary>
    public sealed class Node : INode
    {
        #region data

        /// <summary>
        /// The payload expression of the node
        /// </summary>
        public readonly Expression Payload;

        /// <summary>
        /// The coordinate of the node
        /// </summary>
        private readonly BitArray _coordinate;

        #endregion

        #region constructor

        /// <summary>
        /// Creates a new node
        /// </summary>
        /// <param name="myCoordinate">The coordinate of the node</param>
        /// <param name="myExpression">The payload expression of the node</param>
        public Node(BitArray myCoordinate, Expression myExpression)
        {
            Payload = myExpression;
            _coordinate = myCoordinate;
        }

        #endregion

        #region INode Members

        public BitArray Coordinate
        {
            get { return _coordinate; }
        }

        public Expression Execute()
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}
