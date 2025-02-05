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
    /// ConfigMapEnvSource selects a ConfigMap to populate the environment
    /// variables with.
    ///
    /// The contents of the target ConfigMap's Data field will represent the
    /// key-value pairs as environment variables.
    /// </summary>
    public partial class V1ConfigMapEnvSource
    {
        /// <summary>
        /// Initializes a new instance of the V1ConfigMapEnvSource class.
        /// </summary>
        public V1ConfigMapEnvSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ConfigMapEnvSource class.
        /// </summary>
        /// <param name="name">Name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names</param>
        /// <param name="optional">Specify whether the ConfigMap must be
        /// defined</param>
        public V1ConfigMapEnvSource(string name = default(string), bool? optional = default(bool?))
        {
            Name = name;
            Optional = optional;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the referent. More info:
        /// https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets specify whether the ConfigMap must be defined
        /// </summary>
        [JsonProperty(PropertyName = "optional")]
        public bool? Optional { get; set; }

    }
}
