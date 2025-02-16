// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure;

namespace Azure.Communication.JobRouter
{
    public partial class RouterRule
    {
        internal static RouterRule DeserializeRouterRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "directMap": return DirectMapRouterRule.DeserializeDirectMapRouterRule(element);
                    case "expression": return ExpressionRouterRule.DeserializeExpressionRouterRule(element);
                    case "function": return FunctionRouterRule.DeserializeFunctionRouterRule(element);
                    case "static": return StaticRouterRule.DeserializeStaticRouterRule(element);
                    case "webhook": return WebhookRouterRule.DeserializeWebhookRouterRule(element);
                }
            }
            return UnknownRouterRule.DeserializeUnknownRouterRule(element);
        }

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RouterRule FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRouterRule(document.RootElement);
        }
    }
}
