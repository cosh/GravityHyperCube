using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using cosh.HyperCube.Node;

namespace cosh.HyperCube
{
    /// <summary>
    /// The interface for the gravity hypercube
    /// </summary>
    public interface IGravityHyperCube
    {
        /// <summary>
        /// The dimension of the hypercube
        /// </summary>
        Int64 Dimension { get; }

        /// <summary>
        /// Inserts an expression into the hypercube
        /// </summary>
        /// <typeparam name="TResult">The type of the result</typeparam>
        /// <param name="myExpressionName">The name of the expression</param>
        /// <param name="myExpression">The expression itself</param>
        /// <param name="myConverter">The converter method from INode to TResult</param>
        /// <returns>A TResult</returns>
        TResult Insert<TResult>(String myExpressionName, Expression myExpression, Converter<INode, TResult> myConverter);

        /// <summary>
        /// Executes a certain expression
        /// </summary>
        /// <typeparam name="TResult">The type of the result</typeparam>
        /// <param name="myExpressionName">The name of the expression that should be executed</param>
        /// <param name="myConverter">The output converter</param>
        /// <returns>A TResult</returns>
        TResult Execute<TResult>(String myExpressionName, Converter<Expression, TResult> myConverter);

        /// <summary>
        /// Executes every node of the cube
        /// </summary>
        /// <typeparam name="TResult">The resulting type</typeparam>
        /// <param name="myFilter">A filter function... maybe certain nodes shouldn't be executed</param>
        /// <param name="myConverter">The result converter</param>
        /// <returns>A TResult</returns>
        TResult Broadcast<TResult>(Converter<INode, Boolean> myFilter, Converter<IEnumerable<Expression>, TResult> myConverter);
    }
}