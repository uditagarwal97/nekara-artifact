// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// APIServiceCondition describes the state of an APIService at a
    /// particular point
    /// </summary>
    public partial class V1APIServiceCondition
    {
        /// <summary>
        /// Initializes a new instance of the V1APIServiceCondition class.
        /// </summary>
        public V1APIServiceCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1APIServiceCondition class.
        /// </summary>
        /// <param name="status">Status is the status of the condition. Can be
        /// True, False, Unknown.</param>
        /// <param name="type">Type is the type of the condition.</param>
        /// <param name="lastTransitionTime">Last time the condition
        /// transitioned from one status to another.</param>
        /// <param name="message">Human-readable message indicating details
        /// about last transition.</param>
        /// <param name="reason">Unique, one-word, CamelCase reason for the
        /// condition's last transition.</param>
        public V1APIServiceCondition(string status, string type, System.DateTime? lastTransitionTime = default(System.DateTime?), string message = default(string), string reason = default(string))
        {
            LastTransitionTime = lastTransitionTime;
            Message = message;
            Reason = reason;
            Status = status;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets last time the condition transitioned from one status
        /// to another.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public System.DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets human-readable message indicating details about last
        /// transition.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets unique, one-word, CamelCase reason for the condition's
        /// last transition.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets status is the status of the condition. Can be True,
        /// False, Unknown.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets type is the type of the condition.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Status == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Status");
            }
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
