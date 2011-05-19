using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using cosh.HyperCube.Nodes;

namespace cosh.HyperCube
{
    public sealed class GravityHyperCube : IGravityHyperCube
    {
        #region data

        private int _dimension;
        private readonly ConcurrentDictionary<BitArray, INode> _nodes;

        #endregion

        #region Constructor

        public GravityHyperCube()
        {
            _dimension = 0;
            _nodes = new ConcurrentDictionary<BitArray, INode>();
        }

        #endregion

        #region IGravityHyperCube Members

        public void InsertData(string myDataName, byte[] myData)
        {
            throw new NotImplementedException();            
        }

        public void InsertExpression(string myExpressionName, Expression myExpression)
        {
            throw new NotImplementedException();
        }

        #endregion

        //private int _dimension;
        //private ConcurrentDictionary<BitArray, Node> _nodes;

        //#region constructor

        //public GravityHyperCube()
        //{
        //    _dimension = 0;
        //    _nodes = new ConcurrentDictionary<GrayCode, Node>();
        //    _unusedCodes = new ConcurrentBag<GrayCode>();

        //    _unusedCodes.Add(new GrayCode(new BitArray(new bool[1] { false })));
        //}

        //#endregion

        //#region insert

        //#region methods

        //public void InsertMethod(String myExpressionName, Expression myExpression, uint myRedundanz)
        //{
        //    var neededNodes = Convert.ToInt32(myRedundanz) + 1;

        //    lock (_unusedCodes)
        //    {

        //        while (GetFreeNodesCount() < neededNodes)
        //        {
        //            GrowHyperCube();
        //        }

        //        if (myRedundanz == 0)
        //        {
        //            var newNode = GetFreeNodes(neededNodes).FirstOrDefault();

        //            newNode.SetNodeAsExpression(myExpressionName, myExpression);

        //            _nodes.AddOrUpdate(newNode.GrayCode, newNode, (grayCode, node) =>
        //            {
        //                return node;
        //            });
        //        }
        //        else
        //        {
        //            Parallel.ForEach(GetFreeNodes(neededNodes), aNode =>
        //            {
        //                aNode.SetNodeAsExpression(myExpressionName, myExpression);

        //                _nodes.AddOrUpdate(aNode.GrayCode, aNode, (grayCode, node) =>
        //                {
        //                    return node;
        //                });
        //            }
        //            );
        //        }
        //    }
        //}

        //public void InsertMethod(String myExpressionName, Expression myExpression)
        //{
        //    InsertMethod(myExpressionName, myExpression, 0);
        //}

        //#endregion

        //#region data

        //public void InsertData(String myDataName, Byte[] myData, uint myRedundanz)
        //{
        //    lock (_unusedCodes)
        //    {

        //        var neededNodes = Convert.ToInt32(myRedundanz) + 1;

        //        while (GetFreeNodesCount() < neededNodes)
        //        {
        //            GrowHyperCube();
        //        }

        //        if (myRedundanz == 0)
        //        {
        //            var newNode = GetFreeNodes(neededNodes).FirstOrDefault();

        //            newNode.SetNodeAsData(myDataName, myData);

        //            _nodes.AddOrUpdate(newNode.GrayCode, newNode, (grayCode, node) =>
        //            {
        //                return node;
        //            });
        //        }
        //        else
        //        {
        //            Parallel.ForEach(GetFreeNodes(neededNodes), aNode =>
        //            {
        //                aNode.SetNodeAsData(myDataName, myData);

        //                _nodes.AddOrUpdate(aNode.GrayCode, aNode, (grayCode, node) =>
        //                {
        //                    return node;
        //                });
        //            }
        //            );
        //        }
        //    }
        //}

        //public void InsertData(String myDataName, Byte[] myData)
        //{
        //    InsertData(myDataName, myData, 0);
        //}

        //#endregion

        //#endregion

        //#region get

        //public bool ExecuteExpression(String expressionName)
        //{
        //    Expression expression = null;

        //    expression = GetExpression(expressionName);

        //    if (expression == null)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        throw new NotImplementedException();

        //        return true;
        //    }
        //}

        //#endregion

        //#region helper

        //private Expression GetExpression(string expressionName)
        //{
        //    throw new NotImplementedException();
        //}

        //private int GetFreeNodesCount()
        //{
        //    return _unusedCodes.Count;
        //}

        //private void GrowHyperCube()
        //{
        //    lock (this)
        //    {
        //        if (_dimension == 0)
        //        {
        //            var newGrayCode = new GrayCode(new BitArray(new bool[1] { true }));
        //            _unusedCodes.Add(newGrayCode);
        //        }
        //        else
        //        {
        //            ConcurrentBag<GrayCode> newGrayCodes = new ConcurrentBag<GrayCode>();

        //            Parallel.ForEach(_nodes, item =>
        //            {
        //                List<Boolean> payLoad = new List<bool>() { true };

        //                for (int i = 0; i < item.Key.GrayCodeBitArray.Length; i++)
        //                {
        //                    payLoad.Add(item.Key.GrayCodeBitArray.Get(i));
        //                }

        //                newGrayCodes.Add(new GrayCode(new BitArray(payLoad.ToArray())));
        //            });
        //            Parallel.ForEach(_nodes, item => item.Key.AddLeadingBit(false));

        //            Parallel.ForEach(_unusedCodes, item =>
        //            {
        //                List<Boolean> payLoad = new List<bool>() { true };

        //                for (int i = 0; i < item.GrayCodeBitArray.Length; i++)
        //                {
        //                    payLoad.Add(item.GrayCodeBitArray.Get(i));
        //                }

        //                newGrayCodes.Add(new GrayCode(new BitArray(payLoad.ToArray())));

        //                item.AddLeadingBit(false);
        //            });

        //            Parallel.ForEach(newGrayCodes, item => _unusedCodes.Add(item));
        //        }

        //        _dimension++;
        //    }
        //}

        //private List<Node> GetFreeNodes(int myCount)
        //{
        //    List<Node> freeNodes = new List<Node>();

        //    for (int i = 0; i < myCount; i++)
        //    {
        //        GrayCode newGrayCode = null;

        //        while (!_unusedCodes.TryTake(out newGrayCode))
        //        {

        //        }

        //        freeNodes.Add(new Node(newGrayCode));
        //    }

        //    return freeNodes;
        //}

        //#endregion

    }
}
