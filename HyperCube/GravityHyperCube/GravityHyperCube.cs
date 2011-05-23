using System;
using System.Linq.Expressions;

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

        public void Insert(string myExpressionName, Expression myExpression)
        {
            throw new NotImplementedException();
        }

        public Expression Execute(string myExpressionName)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}