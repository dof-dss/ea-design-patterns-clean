namespace DSS.Architecture.Patterns.DotNet.Clean.Interactors
{
    /// <summary>
    /// Defines what type of response can be returned from an <see cref="IRequestHandler{TRequest, TResponse}"/>
    /// </summary>
    public enum ResponseTypes
    {
        /// <summary>
        /// Indicates that the Request was successful
        /// </summary>
        Success,
        /// <summary>
        /// Indicates that there was an error processing the request
        /// </summary>
        Error,
        /// <summary>
        /// Indicates the input supplied to the Request handler was invalid
        /// </summary>
        RequestNotValid,
        /// <summary>
        /// Indicates the that the operation was not successfull
        /// </summary>
        Failure
    }
}