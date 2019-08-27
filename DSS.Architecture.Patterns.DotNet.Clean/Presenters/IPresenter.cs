using System;
using System.Collections.Generic;
using System.Text;

namespace DSS.Architecture.Patterns.DotNet.Clean.Presenters
{
    /// <summary>
    /// A simple interface which provide a single method which all Presenter objects must implement
    /// </summary>
    /// <typeparam name="TInput">specifies the type of object that the presenter will accept</typeparam>
    /// <typeparam name="TOutput">specifies the type of object the presenter will return</typeparam>
    public interface IPresenter<TInput, TOutput>
    {
        /// <summary>
        /// When implemented in a derived class converts the input specified by <see cref="TInput"/> and returns <see cref="TOutput"/>
        /// </summary>
        /// <param name="source">accepts an object of type <see cref="TInput"/></param>
        /// <returns>returns an object of type <see cref="TOutput"/></returns>
        TOutput Build(TInput source);
    }
}
