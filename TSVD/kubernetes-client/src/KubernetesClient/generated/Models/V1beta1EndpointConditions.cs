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
    /// EndpointConditions represents the current condition of an endpoint.
    /// </summary>
    public partial class V1beta1EndpointConditions
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1EndpointConditions class.
        /// </summary>
        public V1beta1EndpointConditions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1EndpointConditions class.
        /// </summary>
        /// <param name="ready">ready indicates that this endpoint is prepared
        /// to receive traffic, according to whatever system is managing the
        /// endpoint. A nil value indicates an unknown state. In most cases
        /// consumers should interpret this unknown state as ready. For
        /// compatibility reasons, ready should never be "true" for terminating
        /// endpoints.</param>
        /// <param name="serving">serving is identical to ready except that it
        /// is set regardless of the terminating state of endpoints. This
        /// condition should be set to true for a ready endpoint that is
        /// terminating. If nil, consumers should defer to the ready condition.
        /// This field can be enabled with the
        /// EndpointSliceTerminatingCondition feature gate.</param>
        /// <param name="terminating">terminating indicates that this endpoint
        /// is terminating. A nil value indicates an unknown state. Consumers
        /// should interpret this unknown state to mean that the endpoint is
        /// not terminating. This field can be enabled with the
        /// EndpointSliceTerminatingCondition feature gate.</param>
        public V1beta1EndpointConditions(bool? ready = default(bool?), bool? serving = default(bool?), bool? terminating = default(bool?))
        {
            Ready = ready;
            Serving = serving;
            Terminating = terminating;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ready indicates that this endpoint is prepared to
        /// receive traffic, according to whatever system is managing the
        /// endpoint. A nil value indicates an unknown state. In most cases
        /// consumers should interpret this unknown state as ready. For
        /// compatibility reasons, ready should never be "true" for terminating
        /// endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "ready")]
        public bool? Ready { get; set; }

        /// <summary>
        /// Gets or sets serving is identical to ready except that it is set
        /// regardless of the terminating state of endpoints. This condition
        /// should be set to true for a ready endpoint that is terminating. If
        /// nil, consumers should defer to the ready condition. This field can
        /// be enabled with the EndpointSliceTerminatingCondition feature gate.
        /// </summary>
        [JsonProperty(PropertyName = "serving")]
        public bool? Serving { get; set; }

        /// <summary>
        /// Gets or sets terminating indicates that this endpoint is
        /// terminating. A nil value indicates an unknown state. Consumers
        /// should interpret this unknown state to mean that the endpoint is
        /// not terminating. This field can be enabled with the
        /// EndpointSliceTerminatingCondition feature gate.
        /// </summary>
        [JsonProperty(PropertyName = "terminating")]
        public bool? Terminating { get; set; }

    }
}
