// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// ReplicaSetStatus represents the current status of a ReplicaSet.
    /// </summary>
    public partial class V1ReplicaSetStatus
    {
        /// <summary>
        /// Initializes a new instance of the V1ReplicaSetStatus class.
        /// </summary>
        public V1ReplicaSetStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1ReplicaSetStatus class.
        /// </summary>
        /// <param name="replicas">Replicas is the most recently oberved number
        /// of replicas. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller</param>
        /// <param name="availableReplicas">The number of available replicas
        /// (ready for at least minReadySeconds) for this replica set.</param>
        /// <param name="conditions">Represents the latest available
        /// observations of a replica set's current state.</param>
        /// <param name="fullyLabeledReplicas">The number of pods that have
        /// labels matching the labels of the pod template of the
        /// replicaset.</param>
        /// <param name="observedGeneration">ObservedGeneration reflects the
        /// generation of the most recently observed ReplicaSet.</param>
        /// <param name="readyReplicas">The number of ready replicas for this
        /// replica set.</param>
        public V1ReplicaSetStatus(int replicas, int? availableReplicas = default(int?), IList<V1ReplicaSetCondition> conditions = default(IList<V1ReplicaSetCondition>), int? fullyLabeledReplicas = default(int?), long? observedGeneration = default(long?), int? readyReplicas = default(int?))
        {
            AvailableReplicas = availableReplicas;
            Conditions = conditions;
            FullyLabeledReplicas = fullyLabeledReplicas;
            ObservedGeneration = observedGeneration;
            ReadyReplicas = readyReplicas;
            Replicas = replicas;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of available replicas (ready for at least
        /// minReadySeconds) for this replica set.
        /// </summary>
        [JsonProperty(PropertyName = "availableReplicas")]
        public int? AvailableReplicas { get; set; }

        /// <summary>
        /// Gets or sets represents the latest available observations of a
        /// replica set's current state.
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<V1ReplicaSetCondition> Conditions { get; set; }

        /// <summary>
        /// Gets or sets the number of pods that have labels matching the
        /// labels of the pod template of the replicaset.
        /// </summary>
        [JsonProperty(PropertyName = "fullyLabeledReplicas")]
        public int? FullyLabeledReplicas { get; set; }

        /// <summary>
        /// Gets or sets observedGeneration reflects the generation of the most
        /// recently observed ReplicaSet.
        /// </summary>
        [JsonProperty(PropertyName = "observedGeneration")]
        public long? ObservedGeneration { get; set; }

        /// <summary>
        /// Gets or sets the number of ready replicas for this replica set.
        /// </summary>
        [JsonProperty(PropertyName = "readyReplicas")]
        public int? ReadyReplicas { get; set; }

        /// <summary>
        /// Gets or sets replicas is the most recently oberved number of
        /// replicas. More info:
        /// https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
        /// </summary>
        [JsonProperty(PropertyName = "replicas")]
        public int Replicas { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Conditions != null)
            {
                foreach (var element in Conditions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
