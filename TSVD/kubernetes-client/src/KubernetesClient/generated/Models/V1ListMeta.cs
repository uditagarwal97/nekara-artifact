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
    /// ListMeta describes metadata that synthetic resources must have,
    /// including lists and various status objects. A resource may have only
    /// one of {ObjectMeta, ListMeta}.
    /// </summary>
    public partial class V1ListMeta
    {
        /// <summary>
        /// Initializes a new instance of the V1ListMeta class.
        /// </summary>
        public V1ListMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ListMeta class.
        /// </summary>
        /// <param name="continueProperty">continue may be set if the user set
        /// a limit on the number of items returned, and indicates that the
        /// server has more data available. The value is opaque and may be used
        /// to issue another request to the endpoint that served this list to
        /// retrieve the next set of available objects. Continuing a consistent
        /// list may not be possible if the server configuration has changed or
        /// more than a few minutes have passed. The resourceVersion field
        /// returned when using this continue value will be identical to the
        /// value in the first response, unless you have received this token
        /// from an error message.</param>
        /// <param name="remainingItemCount">remainingItemCount is the number
        /// of subsequent items in the list which are not included in this list
        /// response. If the list request contained label or field selectors,
        /// then the number of remaining items is unknown and the field will be
        /// left unset and omitted during serialization. If the list is
        /// complete (either because it is not chunking or because this is the
        /// last chunk), then there are no more remaining items and this field
        /// will be left unset and omitted during serialization. Servers older
        /// than v1.15 do not set this field. The intended use of the
        /// remainingItemCount is *estimating* the size of a collection.
        /// Clients should not rely on the remainingItemCount to be set or to
        /// be exact.</param>
        /// <param name="resourceVersion">String that identifies the server's
        /// internal version of this object that can be used by clients to
        /// determine when objects have changed. Value must be treated as
        /// opaque by clients and passed unmodified back to the server.
        /// Populated by the system. Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency</param>
        /// <param name="selfLink">selfLink is a URL representing this object.
        /// Populated by the system. Read-only.
        ///
        /// DEPRECATED Kubernetes will stop propagating this field in 1.20
        /// release and the field is planned to be removed in 1.21
        /// release.</param>
        public V1ListMeta(string continueProperty = default(string), long? remainingItemCount = default(long?), string resourceVersion = default(string), string selfLink = default(string))
        {
            ContinueProperty = continueProperty;
            RemainingItemCount = remainingItemCount;
            ResourceVersion = resourceVersion;
            SelfLink = selfLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets continue may be set if the user set a limit on the
        /// number of items returned, and indicates that the server has more
        /// data available. The value is opaque and may be used to issue
        /// another request to the endpoint that served this list to retrieve
        /// the next set of available objects. Continuing a consistent list may
        /// not be possible if the server configuration has changed or more
        /// than a few minutes have passed. The resourceVersion field returned
        /// when using this continue value will be identical to the value in
        /// the first response, unless you have received this token from an
        /// error message.
        /// </summary>
        [JsonProperty(PropertyName = "continue")]
        public string ContinueProperty { get; set; }

        /// <summary>
        /// Gets or sets remainingItemCount is the number of subsequent items
        /// in the list which are not included in this list response. If the
        /// list request contained label or field selectors, then the number of
        /// remaining items is unknown and the field will be left unset and
        /// omitted during serialization. If the list is complete (either
        /// because it is not chunking or because this is the last chunk), then
        /// there are no more remaining items and this field will be left unset
        /// and omitted during serialization. Servers older than v1.15 do not
        /// set this field. The intended use of the remainingItemCount is
        /// *estimating* the size of a collection. Clients should not rely on
        /// the remainingItemCount to be set or to be exact.
        /// </summary>
        [JsonProperty(PropertyName = "remainingItemCount")]
        public long? RemainingItemCount { get; set; }

        /// <summary>
        /// Gets or sets string that identifies the server's internal version
        /// of this object that can be used by clients to determine when
        /// objects have changed. Value must be treated as opaque by clients
        /// and passed unmodified back to the server. Populated by the system.
        /// Read-only. More info:
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
        /// </summary>
        [JsonProperty(PropertyName = "resourceVersion")]
        public string ResourceVersion { get; set; }

        /// <summary>
        /// Gets or sets selfLink is a URL representing this object. Populated
        /// by the system. Read-only.
        ///
        /// DEPRECATED Kubernetes will stop propagating this field in 1.20
        /// release and the field is planned to be removed in 1.21 release.
        /// </summary>
        [JsonProperty(PropertyName = "selfLink")]
        public string SelfLink { get; set; }

    }
}
