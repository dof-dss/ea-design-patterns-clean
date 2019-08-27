using System;

namespace DSS.Architecture.Patterns.DotNet.Clean.Interactors
{
    /// <summary>
    /// An interface which defines a response from an <see cref="IRequestMessage"/>
    /// </summary>
    public interface IResponseMessage
    {
        /// <summary>
        /// Gets the Response Type
        /// </summary>
        ResponseTypes ResponseType { get; set; }

        /// <summary>
        /// Gets a string containing a friendly message from the <see cref="IRequestHandler{TRequest, TResponse}.Handle(TRequest)"/>
        /// </summary>
        string OutputMessage { get; set; }

        /// <summary>
        /// Gets or Sets an Exception encountered by a request
        /// </summary>
        Exception InnerException { get; set; }
    }
}
