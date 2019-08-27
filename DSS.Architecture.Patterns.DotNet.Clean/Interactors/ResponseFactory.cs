using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DSS.Architecture.Patterns.DotNet.Clean.Interactors
{
    /// <summary>
    /// A static class which provides methods to build new Response messages
    /// </summary>
    public static class ResponseFactory
    {
        /// <summary>
        /// Creates a new instance of the specified <see cref="IResponseMessage"/> type
        /// </summary>
        /// <typeparam name="TResponse">specifies the type of IResponseMessage to create</typeparam>
        /// <param name="responseType">specifies the selected <see cref="ResponseTypes"/> value</param>
        /// <param name="outputMessage">specifies the message to return</param>
        /// <param name="validationResult">specifies the <see cref="ValidationResult"/> to return [Optional]</param>
        /// <returns>returns a new ResponseMessage object</returns>
        public static TResponse BuildResponse<TResponse>(ResponseTypes responseType, string outputMessage, Exception innerException = null)
            where TResponse : IResponseMessage
        {
            var obj = Activator.CreateInstance<TResponse>();
            obj.ResponseType = responseType;
            obj.OutputMessage = outputMessage;          
            obj.InnerException = innerException;

            return obj;
        }

        /// <summary>
        /// Creates a new <see cref="ReadResponseMessage{T}"/> object
        /// </summary>
        /// <param name="outputMessage">specifies the message to return</param>
        /// <param name="data">specifies the data to return from the request</param>
        /// <returns>returns a new <see cref="ReadResponseMessage{T}"/> which contains the data</returns>
        public static ReadResponseMessage<T> BuildReadResponse<T>(string outputMessage, IEnumerable<T> data = null)
        {
            var response = BuildResponse<ReadResponseMessage<T>>(ResponseTypes.Success, outputMessage, null);
            response.SetData(data);
            return response;
        }

        /// <summary>
        /// Creates a new <typeparamref name="TResponse"/> with <see cref="ResponseTypes.Success"/>
        /// </summary>
        /// <param name="outputMessage">specifies the message to return</param>
        /// <returns>returns a new object of type <typeparamref name="TResponse"/></returns>
        public static TResponse BuildSuccessResponse<TResponse>(string outputMessage)
            where TResponse : IResponseMessage
        {
            return BuildResponse<TResponse>(ResponseTypes.Success, outputMessage, null);
        }

        /// <summary>
        /// Creates a new <typeparamref name="TResponse"/> with <see cref="ResponseTypes.Success"/>
        /// </summary>
        /// <param name="outputMessage">specifies the message to return</param>
        /// <returns>returns a new object of type <typeparamref name="TResponse"/></returns>
        public static TResponse BuildInvalidResponse<TResponse>(string outputMessage)
           where TResponse : IResponseMessage
        {
            return BuildResponse<TResponse>(ResponseTypes.RequestNotValid, outputMessage);
        }

        /// <summary>
        /// Creates a new <typeparamref name="TResponse"/> with <see cref="ResponseTypes.Error"/>
        /// </summary>
        /// <param name="outputMessage">specifies the message to return</param>
        /// <param name="validationResult">specifies the <see cref="ValidationResult"/> to be returned with the Response</param>
        /// <returns>returns a new object of type <typeparamref name="TResponse"/></returns>
        public static TResponse BuildErrorResponse<TResponse>(string outputMessage)
            where TResponse : IResponseMessage
        {
            return BuildResponse<TResponse>(ResponseTypes.Error, outputMessage);
        }

        /// <summary>
        /// Creates a new <typeparamref name="TResponse"/> with <see cref="ResponseTypes.Failure"/>
        /// </summary>
        /// <param name="outputMessage">specifies the message to return</param>
        /// <param name="validationResult">specifies the <see cref="ValidationResult"/> to be returned with the Response</param>
        /// <returns>returns a new object of type <typeparamref name="TResponse"/></returns>
        public static TResponse BuildFailureResponse<TResponse>(string outputMessage)
            where TResponse : IResponseMessage
        {
            return BuildResponse<TResponse>(ResponseTypes.Failure, outputMessage);
        }
    }
}
