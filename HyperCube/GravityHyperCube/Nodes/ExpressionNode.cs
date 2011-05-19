using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cosh.HyperCube.Nodes;
using System.Linq.Expressions;
using System.Collections;

namespace cosh.HyperCube.Test.Application.Nodes
{
    public sealed class ExpressionNode : INode
    {
        #region data

        public readonly Expression Payload;

        private readonly List<Expression> _parameter;

        private readonly BitArray _coordinate;

        #endregion

        #region constructor

        public ExpressionNode (BitArray myCoordinate, Expression myExpression, List<Expression> myParameter)
        {
            Payload = myExpression;
            _parameter = myParameter;
            _coordinate = myCoordinate;
        }

        #endregion

        #region INode Members

        public BitArray Coordinate
        {
            get { return _coordinate; }
        }

        #endregion

    }
}
