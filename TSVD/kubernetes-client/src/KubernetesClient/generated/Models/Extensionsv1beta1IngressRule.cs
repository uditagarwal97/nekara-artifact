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
    /// IngressRule represents the rules mapping the paths under a specified
    /// host to the related backend services. Incoming requests are first
    /// evaluated for a host match, then routed to the backend associated with
    /// the matching IngressRuleValue.
    /// </summary>
    public partial class Extensionsv1beta1IngressRule
    {
        /// <summary>
        /// Initializes a new instance of the Extensionsv1beta1IngressRule
        /// class.
        /// </summary>
        public Extensionsv1beta1IngressRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Extensionsv1beta1IngressRule
        /// class.
        /// </summary>
        /// <param name="host">Host is the fully qualified domain name of a
        /// network host, as defined by RFC 3986. Note the following deviations
        /// from the "host" part of the URI as defined in RFC 3986: 1. IPs are
        /// not allowed. Currently an IngressRuleValue can only apply to
        /// the IP in the Spec of the parent Ingress.
        /// 2. The `:` delimiter is not respected because ports are not
        /// allowed.
        /// Currently the port of an Ingress is implicitly :80 for http and
        /// :443 for https.
        /// Both these may change in the future. Incoming requests are matched
        /// against the host before the IngressRuleValue. If the host is
        /// unspecified, the Ingress routes all traffic based on the specified
        /// IngressRuleValue.
        ///
        /// Host can be "precise" which is a domain name without the
        /// terminating dot of a network host (e.g. "foo.bar.com") or
        /// "wildcard", which is a domain name prefixed with a single wildcard
        /// label (e.g. "*.foo.com"). The wildcard character '*' must appear by
        /// itself as the first DNS label and matches only a single label. You
        /// cannot have a wildcard label by itself (e.g. Host == "*"). Requests
        /// will be matched against the Host field in the following way: 1. If
        /// Host is precise, the request matches this rule if the http host
        /// header is equal to Host. 2. If Host is a wildcard, then the request
        /// matches this rule if the http host header is to equal to the suffix
        /// (removing the first label) of the wildcard rule.</param>
        public Extensionsv1beta1IngressRule(string host = default(string), Extensionsv1beta1HTTPIngressRuleValue http = default(Extensionsv1beta1HTTPIngressRuleValue))
        {
            Host = host;
            Http = http;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets host is the fully qualified domain name of a network
        /// host, as defined by RFC 3986. Note the following deviations from
        /// the "host" part of the URI as defined in RFC 3986: 1. IPs are not
        /// allowed. Currently an IngressRuleValue can only apply to
        /// the IP in the Spec of the parent Ingress.
        /// 2. The `:` delimiter is not respected because ports are not
        /// allowed.
        /// Currently the port of an Ingress is implicitly :80 for http and
        /// :443 for https.
        /// Both these may change in the future. Incoming requests are matched
        /// against the host before the IngressRuleValue. If the host is
        /// unspecified, the Ingress routes all traffic based on the specified
        /// IngressRuleValue.
        ///
        /// Host can be "precise" which is a domain name without the
        /// terminating dot of a network host (e.g. "foo.bar.com") or
        /// "wildcard", which is a domain name prefixed with a single wildcard
        /// label (e.g. "*.foo.com"). The wildcard character '*' must appear by
        /// itself as the first DNS label and matches only a single label. You
        /// cannot have a wildcard label by itself (e.g. Host == "*"). Requests
        /// will be matched against the Host field in the following way: 1. If
        /// Host is precise, the request matches this rule if the http host
        /// header is equal to Host. 2. If Host is a wildcard, then the request
        /// matches this rule if the http host header is to equal to the suffix
        /// (removing the first label) of the wildcard rule.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "http")]
        public Extensionsv1beta1HTTPIngressRuleValue Http { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Http != null)
            {
                Http.Validate();
            }
        }
    }
}
