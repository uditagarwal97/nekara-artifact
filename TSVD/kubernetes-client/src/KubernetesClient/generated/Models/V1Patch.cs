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
    /// Patch is provided to give a concrete name and type to the Kubernetes
    /// PATCH request body.
    /// </summary>
    public partial class V1Patch
    {
        /// <summary>
        /// Initializes a new instance of the V1Patch class.
        /// </summary>
        public V1Patch()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1Patch class.
        /// </summary>
        public V1Patch(object content = default(object))
        {
            Content = content;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "content")]
        public object Content { get; private set; }

    }
}
