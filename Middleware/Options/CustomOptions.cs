using System;

namespace Middleware.Options
{
    public class CustomOptions
    {
        public CustomOptions()
        {
            SerializeAsV2 = false;
        }
        /// <summary>
        /// Sets a custom route for the customMiddleware JSON-YAMML endpoint(s)
        /// </summary>
        public string RouteTemplate { get; set; } = "customMiddleware/{documentName}/custom.{json|yaml}";
        /// <summary>
        /// Returns JSON-YAML in the v2 format instead of v3
        /// </summary>
        public bool SerializeAsV2 { get; set; }
    }
}
