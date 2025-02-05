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
    /// Represents a Fibre Channel volume. Fibre Channel volumes can only be
    /// mounted as read/write once. Fibre Channel volumes support ownership
    /// management and SELinux relabeling.
    /// </summary>
    public partial class V1FCVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1FCVolumeSource class.
        /// </summary>
        public V1FCVolumeSource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1FCVolumeSource class.
        /// </summary>
        /// <param name="fsType">Filesystem type to mount. Must be a filesystem
        /// type supported by the host operating system. Ex. "ext4", "xfs",
        /// "ntfs". Implicitly inferred to be "ext4" if unspecified.</param>
        /// <param name="lun">Optional: FC target lun number</param>
        /// <param name="readOnlyProperty">Optional: Defaults to false
        /// (read/write). ReadOnly here will force the ReadOnly setting in
        /// VolumeMounts.</param>
        /// <param name="targetWWNs">Optional: FC target worldwide names
        /// (WWNs)</param>
        /// <param name="wwids">Optional: FC volume world wide identifiers
        /// (wwids) Either wwids or combination of targetWWNs and lun must be
        /// set, but not both simultaneously.</param>
        public V1FCVolumeSource(string fsType = default(string), int? lun = default(int?), bool? readOnlyProperty = default(bool?), IList<string> targetWWNs = default(IList<string>), IList<string> wwids = default(IList<string>))
        {
            FsType = fsType;
            Lun = lun;
            ReadOnlyProperty = readOnlyProperty;
            TargetWWNs = targetWWNs;
            Wwids = wwids;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets filesystem type to mount. Must be a filesystem type
        /// supported by the host operating system. Ex. "ext4", "xfs", "ntfs".
        /// Implicitly inferred to be "ext4" if unspecified.
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets optional: FC target lun number
        /// </summary>
        [JsonProperty(PropertyName = "lun")]
        public int? Lun { get; set; }

        /// <summary>
        /// Gets or sets optional: Defaults to false (read/write). ReadOnly
        /// here will force the ReadOnly setting in VolumeMounts.
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets optional: FC target worldwide names (WWNs)
        /// </summary>
        [JsonProperty(PropertyName = "targetWWNs")]
        public IList<string> TargetWWNs { get; set; }

        /// <summary>
        /// Gets or sets optional: FC volume world wide identifiers (wwids)
        /// Either wwids or combination of targetWWNs and lun must be set, but
        /// not both simultaneously.
        /// </summary>
        [JsonProperty(PropertyName = "wwids")]
        public IList<string> Wwids { get; set; }

    }
}
