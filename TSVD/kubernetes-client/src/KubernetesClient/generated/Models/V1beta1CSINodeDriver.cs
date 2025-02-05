// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// CSINodeDriver holds information about the specification of one CSI
    /// driver installed on a node
    /// </summary>
    public partial class V1beta1CSINodeDriver
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1CSINodeDriver class.
        /// </summary>
        public V1beta1CSINodeDriver()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1CSINodeDriver class.
        /// </summary>
        /// <param name="name">This is the name of the CSI driver that this
        /// object refers to. This MUST be the same name returned by the CSI
        /// GetPluginName() call for that driver.</param>
        /// <param name="nodeID">nodeID of the node from the driver point of
        /// view. This field enables Kubernetes to communicate with storage
        /// systems that do not share the same nomenclature for nodes. For
        /// example, Kubernetes may refer to a given node as "node1", but the
        /// storage system may refer to the same node as "nodeA". When
        /// Kubernetes issues a command to the storage system to attach a
        /// volume to a specific node, it can use this field to refer to the
        /// node name using the ID that the storage system will understand,
        /// e.g. "nodeA" instead of "node1". This field is required.</param>
        /// <param name="allocatable">allocatable represents the volume
        /// resources of a node that are available for scheduling.</param>
        /// <param name="topologyKeys">topologyKeys is the list of keys
        /// supported by the driver. When a driver is initialized on a cluster,
        /// it provides a set of topology keys that it understands (e.g.
        /// "company.com/zone", "company.com/region"). When a driver is
        /// initialized on a node, it provides the same topology keys along
        /// with values. Kubelet will expose these topology keys as labels on
        /// its own node object. When Kubernetes does topology aware
        /// provisioning, it can use this list to determine which labels it
        /// should retrieve from the node object and pass back to the driver.
        /// It is possible for different nodes to use different topology keys.
        /// This can be empty if driver does not support topology.</param>
        public V1beta1CSINodeDriver(string name, string nodeID, V1beta1VolumeNodeResources allocatable = default(V1beta1VolumeNodeResources), IList<string> topologyKeys = default(IList<string>))
        {
            Allocatable = allocatable;
            Name = name;
            NodeID = nodeID;
            TopologyKeys = topologyKeys;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allocatable represents the volume resources of a node
        /// that are available for scheduling.
        /// </summary>
        [JsonProperty(PropertyName = "allocatable")]
        public V1beta1VolumeNodeResources Allocatable { get; set; }

        /// <summary>
        /// Gets or sets this is the name of the CSI driver that this object
        /// refers to. This MUST be the same name returned by the CSI
        /// GetPluginName() call for that driver.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets nodeID of the node from the driver point of view. This
        /// field enables Kubernetes to communicate with storage systems that
        /// do not share the same nomenclature for nodes. For example,
        /// Kubernetes may refer to a given node as "node1", but the storage
        /// system may refer to the same node as "nodeA". When Kubernetes
        /// issues a command to the storage system to attach a volume to a
        /// specific node, it can use this field to refer to the node name
        /// using the ID that the storage system will understand, e.g. "nodeA"
        /// instead of "node1". This field is required.
        /// </summary>
        [JsonProperty(PropertyName = "nodeID")]
        public string NodeID { get; set; }

        /// <summary>
        /// Gets or sets topologyKeys is the list of keys supported by the
        /// driver. When a driver is initialized on a cluster, it provides a
        /// set of topology keys that it understands (e.g. "company.com/zone",
        /// "company.com/region"). When a driver is initialized on a node, it
        /// provides the same topology keys along with values. Kubelet will
        /// expose these topology keys as labels on its own node object. When
        /// Kubernetes does topology aware provisioning, it can use this list
        /// to determine which labels it should retrieve from the node object
        /// and pass back to the driver. It is possible for different nodes to
        /// use different topology keys. This can be empty if driver does not
        /// support topology.
        /// </summary>
        [JsonProperty(PropertyName = "topologyKeys")]
        public IList<string> TopologyKeys { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (NodeID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NodeID");
            }
        }
    }
}
