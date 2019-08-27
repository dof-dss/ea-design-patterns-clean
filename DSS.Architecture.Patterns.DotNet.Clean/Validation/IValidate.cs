using System;
using System.Text;

namespace DSS.Architecture.Patterns.DotNet.Clean.Validation
{
    /// <summary>
    /// Defines how validation logic should be handled on a derived class
    /// </summary>
    /// <typeparam name="T">the Type of object to validate</typeparam>
    public interface IValidate
    {
        /// <summary>
        /// When implemented in a derived class handles validation of the specified object
        /// </summary>
        /// <param name="obj">the object to validate</param>
        /// <returns>the supplied method which contains the validation logic should return an object of type <see cref="ValidationResult"/></returns>
        ValidationResult Validate();
    }
}
