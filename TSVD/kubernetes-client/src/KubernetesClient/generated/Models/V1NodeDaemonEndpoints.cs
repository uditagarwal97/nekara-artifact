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
    /// NodeDaemonEndpoints lists ports opened by daemons running on the Node.
    /// </summary>
    public partial class V1NodeDaemonEndpoints
    {
        /// <summary>
        /// Initializes a new instance of the V1NodeDaemonEndpoints class.
        /// </summary>
        public V1NodeDaemonEndpoints()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1NodeDaemonEndpoints class.
        /// </summary>
        /// <param name="kubeletEndpoint">Endpoint on which Kubelet is
        /// listening.</param>
        public V1NodeDaemonEndpoints(V1DaemonEndpoint kubeletEndpoint = default(V1DaemonEndpoint))
        {
            KubeletEndpoint = kubeletEndpoint;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets endpoint on which Kubelet is listening.
        /// </summary>
        [JsonProperty(PropertyName = "kubeletEndpoint")]
        public V1DaemonEndpoint KubeletEndpoint { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KubeletEndpoint != null)
            {
                KubeletEndpoint.Validate();
            }
        }
    }
}
