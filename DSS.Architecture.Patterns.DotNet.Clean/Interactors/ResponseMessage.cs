using System;
namespace DSS.Architecture.Patterns.DotNet.Clean.Interactors
{
    /// <summary>
    /// A class which represents a standard implementation of the <see cref="IResponseMessage"/>
    /// </summary>
    public class ResponseMessage : IResponseMessage
    {
        /// <inheritdoc />
        public ResponseTypes ResponseType { get; set; }

        /// <inheritdoc />
        public string OutputMessage { get; set; }
        
        /// <inheritdoc />
        public Exception InnerException { get; set; }
    }
}
