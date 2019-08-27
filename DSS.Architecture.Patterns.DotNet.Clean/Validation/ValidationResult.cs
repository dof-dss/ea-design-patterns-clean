using System.Collections.Generic;

namespace DSS.Architecture.Patterns.DotNet.Clean.Validation
{
    /// <summary>
    /// A class which contains the result of the validation operation
    /// </summary>
    public sealed class ValidationResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationResult"/> object
        /// </summary>
        public ValidationResult()
        {
            Errors = new Dictionary<string, List<string>>();
        }

        /// <summary>
        /// Gets or Sets a boolean which indicates whether the Entity was valid
        /// </summary>
        public bool IsValid
        {
            get
            {
                return !(Errors.Count > 0);
            }
        }

        /// <summary>
        /// Gets or Sets a <see cref="Dictionary{TKey, TValue}"/> which contains the names of the properties that contained errors and a list of errors raised against each property
        /// </summary>
        public Dictionary<string, List<string>> Errors { get; internal set; }

        /// <summary>
        /// Adds an error to the Error list
        /// </summary>
        /// <param name="propertyName">the name of the property to attach the error to</param>
        /// <param name="errorMessage">the error message</param>
        public void AddError(string propertyName, string errorMessage)
        {
            // If the collection of errors already contains a property then add the errorMessage value to the list of values
            if (Errors.ContainsKey(propertyName))
            {
                var propErrors = Errors[propertyName];
                propErrors.Add(errorMessage);
                Errors[propertyName] = propErrors;

            } // The property has not raised an error so add a new entry in the Errors Dictionary
            else
            {
                Errors.Add(propertyName, new List<string>(new string[] { errorMessage }));
            }
        }
    }
}
