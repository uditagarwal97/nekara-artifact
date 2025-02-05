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
    /// SubjectAccessReviewStatus
    /// </summary>
    public partial class V1SubjectAccessReviewStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1SubjectAccessReviewStatus
        /// class.
        /// </summary>
        public V1SubjectAccessReviewStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1SubjectAccessReviewStatus
        /// class.
        /// </summary>
        /// <param name="allowed">Allowed is required. True if the action would
        /// be allowed, false otherwise.</param>
        /// <param name="denied">Denied is optional. True if the action would
        /// be denied, otherwise false. If both allowed is false and denied is
        /// false, then the authorizer has no opinion on whether to authorize
        /// the action. Denied may not be true if Allowed is true.</param>
        /// <param name="evaluationError">EvaluationError is an indication that
        /// some error occurred during the authorization check. It is entirely
        /// possible to get an error and be able to continue determine
        /// authorization status in spite of it. For instance, RBAC can be
        /// missing a role, but enough roles are still present and bound to
        /// reason about the request.</param>
        /// <param name="reason">Reason is optional.  It indicates why a
        /// request was allowed or denied.</param>
        public V1SubjectAccessReviewStatus(bool allowed, bool? denied = default(bool?), string evaluationError = default(string), string reason = default(string))
        {
            Allowed = allowed;
            Denied = denied;
            EvaluationError = evaluationError;
            Reason = reason;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allowed is required. True if the action would be
        /// allowed, false otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "allowed")]
        public bool Allowed { get; set; }

        /// <summary>
        /// Gets or sets denied is optional. True if the action would be
        /// denied, otherwise false. If both allowed is false and denied is
        /// false, then the authorizer has no opinion on whether to authorize
        /// the action. Denied may not be true if Allowed is true.
        /// </summary>
        [JsonProperty(PropertyName = "denied")]
        public bool? Denied { get; set; }

        /// <summary>
        /// Gets or sets evaluationError is an indication that some error
        /// occurred during the authorization check. It is entirely possible to
        /// get an error and be able to continue determine authorization status
        /// in spite of it. For instance, RBAC can be missing a role, but
        /// enough roles are still present and bound to reason about the
        /// request.
        /// </summary>
        [JsonProperty(PropertyName = "evaluationError")]
        public string EvaluationError { get; set; }

        /// <summary>
        /// Gets or sets reason is optional.  It indicates why a request was
        /// allowed or denied.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
