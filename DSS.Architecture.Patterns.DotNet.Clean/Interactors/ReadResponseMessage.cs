using System;
using System.Collections;
using System.Collections.Generic;

namespace DSS.Architecture.Patterns.DotNet.Clean.Interactors
{
    /// <summary>
    /// A standard Response Message returned from a read request handler
    /// </summary>
    public class ReadResponseMessage<T> : ResponseMessage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadResponseMessage{T}"/> object
        /// </summary>
        public ReadResponseMessage()
        {
        }

        /// <summary>
        /// Gets an <see cref="IEnumerable"/> which contains the records returned from the request
        /// </summary>
        public IEnumerable<T> Data { get; private set; }

        internal void SetData(IEnumerable<T> data)
        {
            Data = data;
        }
    }
}
