// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// StatusCause provides more information about an api.Status failure,
    /// including cases when multiple errors are encountered.
    /// </summary>
    public partial class V1StatusCause
    {
        /// <summary>
        /// Initializes a new instance of the V1StatusCause class.
        /// </summary>
        public V1StatusCause()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1StatusCause class.
        /// </summary>
        /// <param name="field">The field of the resource that has caused this
        /// error, as named by its JSON serialization. May include dot and
        /// postfix notation for nested attributes. Arrays are zero-indexed.
        /// Fields may appear more than once in an array of causes due to
        /// fields having multiple errors. Optional.
        ///
        /// Examples:
        /// "name" - the field "name" on the current resource
        /// "items[0].name" - the field "name" on the first array entry in
        /// "items"</param>
        /// <param name="message">A human-readable description of the cause of
        /// the error.  This field may be presented as-is to a reader.</param>
        /// <param name="reason">A machine-readable description of the cause of
        /// the error. If this value is empty there is no information
        /// available.</param>
        public V1StatusCause(string field = default(string), string message = default(string), string reason = default(string))
        {
            Field = field;
            Message = message;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the field of the resource that has caused this error,
        /// as named by its JSON serialization. May include dot and postfix
        /// notation for nested attributes. Arrays are zero-indexed.  Fields
        /// may appear more than once in an array of causes due to fields
        /// having multiple errors. Optional.
        ///
        /// Examples:
        /// "name" - the field "name" on the current resource
        /// "items[0].name" - the field "name" on the first array entry in
        /// "items"
        /// </summary>
        [JsonProperty(PropertyName = "field")]
        public string Field { get; set; }

        /// <summary>
        /// Gets or sets a human-readable description of the cause of the
        /// error.  This field may be presented as-is to a reader.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets a machine-readable description of the cause of the
        /// error. If this value is empty there is no information available.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

    }
}
