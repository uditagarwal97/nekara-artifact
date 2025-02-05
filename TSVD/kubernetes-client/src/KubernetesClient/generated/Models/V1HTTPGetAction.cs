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
    /// HTTPGetAction describes an action based on HTTP Get requests.
    /// </summary>
    public partial class V1HTTPGetAction
    {
        /// <summary>
        /// Initializes a new instance of the V1HTTPGetAction class.
        /// </summary>
        public V1HTTPGetAction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1HTTPGetAction class.
        /// </summary>
        /// <param name="port">Name or number of the port to access on the
        /// container. Number must be in the range 1 to 65535. Name must be an
        /// IANA_SVC_NAME.</param>
        /// <param name="host">Host name to connect to, defaults to the pod IP.
        /// You probably want to set "Host" in httpHeaders instead.</param>
        /// <param name="httpHeaders">Custom headers to set in the request.
        /// HTTP allows repeated headers.</param>
        /// <param name="path">Path to access on the HTTP server.</param>
        /// <param name="scheme">Scheme to use for connecting to the host.
        /// Defaults to HTTP.</param>
        public V1HTTPGetAction(IntstrIntOrString port, string host = default(string), IList<V1HTTPHeader> httpHeaders = default(IList<V1HTTPHeader>), string path = default(string), string scheme = default(string))
        {
            Host = host;
            HttpHeaders = httpHeaders;
            Path = path;
            Port = port;
            Scheme = scheme;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets host name to connect to, defaults to the pod IP. You
        /// probably want to set "Host" in httpHeaders instead.
        /// </summary>
        [JsonProperty(PropertyName = "host")]
        public string Host { get; set; }

        /// <summary>
        /// Gets or sets custom headers to set in the request. HTTP allows
        /// repeated headers.
        /// </summary>
        [JsonProperty(PropertyName = "httpHeaders")]
        public IList<V1HTTPHeader> HttpHeaders { get; set; }

        /// <summary>
        /// Gets or sets path to access on the HTTP server.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets name or number of the port to access on the container.
        /// Number must be in the range 1 to 65535. Name must be an
        /// IANA_SVC_NAME.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public IntstrIntOrString Port { get; set; }

        /// <summary>
        /// Gets or sets scheme to use for connecting to the host. Defaults to
        /// HTTP.
        /// </summary>
        [JsonProperty(PropertyName = "scheme")]
        public string Scheme { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Port == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Port");
            }
            if (HttpHeaders != null)
            {
                foreach (var element in HttpHeaders)
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
