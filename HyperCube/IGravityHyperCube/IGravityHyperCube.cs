using System;
using System.Linq.Expressions;

namespace cosh.HyperCube
{
    /// <summary>
    /// The interface for the gravity hypercube
    /// </summary>
    public interface IGravityHyperCube
    {
        /// <summary>
        /// Inserts an expression
        /// </summary>
        /// <param name="myExpressionName">The name of the expression</param>
        /// <param name="myExpression"></param>
        void Insert(String myExpressionName, Expression myExpression);

        /// <summary>
        /// Executes a certain expression
        /// </summary>
        /// <param name="myExpressionName">The name of the expression</param>
        /// <returns>The resulting expression</returns>
        Expression Execute(String myExpressionName);
    }
}