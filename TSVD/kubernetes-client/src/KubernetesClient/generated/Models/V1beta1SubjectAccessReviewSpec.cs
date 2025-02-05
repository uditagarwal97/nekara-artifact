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
    /// SubjectAccessReviewSpec is a description of the access request.
    /// Exactly one of ResourceAuthorizationAttributes and
    /// NonResourceAuthorizationAttributes must be set
    /// </summary>
    public partial class V1beta1SubjectAccessReviewSpec
    {
        /// <summary>
        /// Initializes a new instance of the V1beta1SubjectAccessReviewSpec
        /// class.
        /// </summary>
        public V1beta1SubjectAccessReviewSpec()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1beta1SubjectAccessReviewSpec
        /// class.
        /// </summary>
        /// <param name="extra">Extra corresponds to the user.Info.GetExtra()
        /// method from the authenticator.  Since that is input to the
        /// authorizer it needs a reflection here.</param>
        /// <param name="group">Groups is the groups you're testing
        /// for.</param>
        /// <param name="nonResourceAttributes">NonResourceAttributes describes
        /// information for a non-resource access request</param>
        /// <param name="resourceAttributes">ResourceAuthorizationAttributes
        /// describes information for a resource access request</param>
        /// <param name="uid">UID information about the requesting
        /// user.</param>
        /// <param name="user">User is the user you're testing for. If you
        /// specify "User" but not "Group", then is it interpreted as "What if
        /// User were not a member of any groups</param>
        public V1beta1SubjectAccessReviewSpec(IDictionary<string, IList<string>> extra = default(IDictionary<string, IList<string>>), IList<string> group = default(IList<string>), V1beta1NonResourceAttributes nonResourceAttributes = default(V1beta1NonResourceAttributes), V1beta1ResourceAttributes resourceAttributes = default(V1beta1ResourceAttributes), string uid = default(string), string user = default(string))
        {
            Extra = extra;
            Group = group;
            NonResourceAttributes = nonResourceAttributes;
            ResourceAttributes = resourceAttributes;
            Uid = uid;
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets extra corresponds to the user.Info.GetExtra() method
        /// from the authenticator.  Since that is input to the authorizer it
        /// needs a reflection here.
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public IDictionary<string, IList<string>> Extra { get; set; }

        /// <summary>
        /// Gets or sets groups is the groups you're testing for.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public IList<string> Group { get; set; }

        /// <summary>
        /// Gets or sets nonResourceAttributes describes information for a
        /// non-resource access request
        /// </summary>
        [JsonProperty(PropertyName = "nonResourceAttributes")]
        public V1beta1NonResourceAttributes NonResourceAttributes { get; set; }

        /// <summary>
        /// Gets or sets resourceAuthorizationAttributes describes information
        /// for a resource access request
        /// </summary>
        [JsonProperty(PropertyName = "resourceAttributes")]
        public V1beta1ResourceAttributes ResourceAttributes { get; set; }

        /// <summary>
        /// Gets or sets UID information about the requesting user.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or sets user is the user you're testing for. If you specify
        /// "User" but not "Group", then is it interpreted as "What if User
        /// were not a member of any groups
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

    }
}
