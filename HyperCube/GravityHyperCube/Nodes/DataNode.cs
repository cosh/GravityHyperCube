using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using cosh.HyperCube.Nodes;
using System.Collections;

namespace cosh.HyperCube.Test.Application.Nodes
{
    public sealed class DataNode : INode
    {
        #region data

        public readonly Byte[] Payload;

        private readonly BitArray _coordinate;

        #endregion

        #region constructor

        public DataNode(BitArray myCoordinate, Byte[] myData)
        {
            Payload = myData;
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
