using System;
using System.Linq.Expressions;
using cosh.HyperCube.Node;
using System.Collections.Generic;

namespace cosh.HyperCube
{
    /// <summary>
    /// An incomplete hypercube
    /// This means it does not have to contain 2^d nodes, where d is the dimension of the cube
    /// </summary>
    public sealed class GravityHyperCube : IGravityHyperCube
    {
        #region data

        #endregion

        #region constructor

        #endregion


        #region IGravityHyperCube Members

        public long Dimension
        {
            get { throw new NotImplementedException(); }
        }

        public TResult Insert<TResult>(string myExpressionName, Expression myExpression, Converter<INode, TResult> myConverter)
        {
            throw new NotImplementedException();
        }

        public TResult Execute<TResult>(string myExpressionName, Converter<Expression, TResult> myConverter)
        {
            throw new NotImplementedException();
        }

        public TResult Broadcast<TResult>(Converter<INode, bool> myFilter, Converter<IEnumerable<Expression>, TResult> myConverter)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}