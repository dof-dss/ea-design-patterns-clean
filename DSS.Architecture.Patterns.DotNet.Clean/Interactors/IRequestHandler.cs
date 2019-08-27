using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DSS.Architecture.Patterns.DotNet.Clean.Interactors
{
    /// <summary>
    /// Defines a handler for a request that has a response
    /// </summary>
    /// <typeparam name="TRequest">The type of request to be handled</typeparam>
    /// <typeparam name="TResponse">The type of response to be returned from the handler</typeparam>
    public interface IRequestHandler<in TRequest, out TResponse>
    {
        /// <summary>
        /// When implemented in a derived class handles a request and returns a response
        /// </summary>
        /// <param name="message">The request message</param>
        /// <returns>Response from the request</returns>
        TResponse Handle(TRequest message);
    }

    /// <summary>
    /// Defines a handler for a request that has a response
    /// </summary>
    /// <typeparam name="TRequest">The type of request to be handled</typeparam>
    /// <typeparam name="TResponse">The type of response to be returned from the handler</typeparam>
    public interface IRequestHandlerAsync<TRequest, TResponse>    
    {
        /// <summary>
        /// When implemented in a derived class handles a request and returns a response
        /// </summary>
        /// <param name="message">The request message</param>
        /// <returns>Response from the request</returns>
        Task<TResponse> Handle(TRequest message);
    }

    /// <summary>
    /// Defines a handler for a request that does not accept a request message
    /// </summary>
    /// <typeparam name="TResponse">The type of response to be returned</typeparam>
    public interface IRequestHandlerAsync<TResponse>
    {
        /// <summary>
        /// When implemented in a derived class handles a request but does not return a response
        /// </summary>
        Task<TResponse> Handle();
    }

    /// <summary>
    /// Defines a handler for a request that does not have a response
    /// </summary>
    /// <typeparam name="TRequest">The type of request being handled</typeparam>
    public interface IRequestHandler<in TRequest>
        where TRequest : IRequestMessage
    {
        /// <summary>
        /// When implemented in a derived class handles a request but does not return a response
        /// </summary>
        /// <param name="message">The request message</param>
        void Handle(TRequest message);
    }
}
