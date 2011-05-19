using System;
using System.Linq.Expressions;

namespace cosh.HyperCube
{
    public interface IGravityHyperCube
    {
        void InsertData(String myDataName, Byte[] myData);


        void InsertExpression(String myExpressionName, Expression myExpression);
    }
}