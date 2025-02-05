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

    public partial class V1beta1CertificateSigningRequestCondition
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CertificateSigningRequestCondition class.
        /// </summary>
        public V1beta1CertificateSigningRequestCondition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1beta1CertificateSigningRequestCondition class.
        /// </summary>
        /// <param name="type">type of the condition. Known conditions include
        /// "Approved", "Denied", and "Failed".</param>
        /// <param name="lastTransitionTime">lastTransitionTime is the time the
        /// condition last transitioned from one status to another. If unset,
        /// when a new condition type is added or an existing condition's
        /// status is changed, the server defaults this to the current
        /// time.</param>
        /// <param name="lastUpdateTime">timestamp for the last update to this
        /// condition</param>
        /// <param name="message">human readable message with details about the
        /// request state</param>
        /// <param name="reason">brief reason for the request state</param>
        /// <param name="status">Status of the condition, one of True, False,
        /// Unknown. Approved, Denied, and Failed conditions may not be "False"
        /// or "Unknown". Defaults to "True". If unset, should be treated as
        /// "True".</param>
        public V1beta1CertificateSigningRequestCondition(string type, System.DateTime? lastTransitionTime = default(System.DateTime?), System.DateTime? lastUpdateTime = default(System.DateTime?), string message = default(string), string reason = default(string), string status = default(string))
        {
            LastTransitionTime = lastTransitionTime;
            LastUpdateTime = lastUpdateTime;
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
        /// Gets or sets lastTransitionTime is the time the condition last
        /// transitioned from one status to another. If unset, when a new
        /// condition type is added or an existing condition's status is
        /// changed, the server defaults this to the current time.
        /// </summary>
        [JsonProperty(PropertyName = "lastTransitionTime")]
        public System.DateTime? LastTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets timestamp for the last update to this condition
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdateTime")]
        public System.DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Gets or sets human readable message with details about the request
        /// state
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets brief reason for the request state
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets status of the condition, one of True, False, Unknown.
        /// Approved, Denied, and Failed conditions may not be "False" or
        /// "Unknown". Defaults to "True". If unset, should be treated as
        /// "True".
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets type of the condition. Known conditions include
        /// "Approved", "Denied", and "Failed".
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
            if (Type == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Type");
            }
        }
    }
}
