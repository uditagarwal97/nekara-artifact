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
    /// ControllerRevision implements an immutable snapshot of state data.
    /// Clients are responsible for serializing and deserializing the objects
    /// that contain their internal state. Once a ControllerRevision has been
    /// successfully created, it can not be updated. The API Server will fail
    /// validation of all requests that attempt to mutate the Data field.
    /// ControllerRevisions may, however, be deleted. Note that, due to its use
    /// by both the DaemonSet and StatefulSet controllers for update and
    /// rollback, this object is beta. However, it may be subject to name and
    /// representation changes in future releases, and clients should not
    /// depend on its stability. It is primarily for internal use by
    /// controllers.
    /// </summary>
    public partial class V1ControllerRevision
    {
        /// <summary>
        /// Initializes a new instance of the V1ControllerRevision class.
        /// </summary>
        public V1ControllerRevision()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ControllerRevision class.
        /// </summary>
        /// <param name="revision">Revision indicates the revision of the state
        /// represented by Data.</param>
        /// <param name="apiVersion">APIVersion defines the versioned schema of
        /// this representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources</param>
        /// <param name="data">Data is the serialized representation of the
        /// state.</param>
        /// <param name="kind">Kind is a string value representing the REST
        /// resource this object represents. Servers may infer this from the
        /// endpoint the client submits requests to. Cannot be updated. In
        /// CamelCase. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds</param>
        /// <param name="metadata">Standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata</param>
        public V1ControllerRevision(long revision, string apiVersion = default(string), object data = default(object), string kind = default(string), V1ObjectMeta metadata = default(V1ObjectMeta))
        {
            ApiVersion = apiVersion;
            Data = data;
            Kind = kind;
            Metadata = metadata;
            Revision = revision;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets aPIVersion defines the versioned schema of this
        /// representation of an object. Servers should convert recognized
        /// schemas to the latest internal value, and may reject unrecognized
        /// values. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets data is the serialized representation of the state.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

        /// <summary>
        /// Gets or sets kind is a string value representing the REST resource
        /// this object represents. Servers may infer this from the endpoint
        /// the client submits requests to. Cannot be updated. In CamelCase.
        /// More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets standard object's metadata. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public V1ObjectMeta Metadata { get; set; }

        /// <summary>
        /// Gets or sets revision indicates the revision of the state
        /// represented by Data.
        /// </summary>
        [JsonProperty(PropertyName = "revision")]
        public long Revision { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
