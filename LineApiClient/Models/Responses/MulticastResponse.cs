// ReSharper disable NotAccessedPositionalProperty.Global

using LineApiClient.Models.Messages;
using LineApiClient.Models.Requests;

namespace LineApiClient.Models.Responses;

/// <summary>
/// Model to send the same message to multiple user IDs.
/// </summary>
/// <param name="To">Array of user IDs. Use userId values which are returned in <see cref="WebhookRequest"/>.</param>
/// <param name="Messages">Limited messages to send</param>
/// <param name="NotificationDisabled">Does the user receives a push notification when the message is sent.</param>
/// <param name="CustomAggregationUnits">Name of aggregation unit. Case-sensitive.</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#send-multicast-message</remarks>
internal record MulticastResponse(
    string[] To,
    IList<BaseMessage> Messages,
    bool? NotificationDisabled,
    string[]? CustomAggregationUnits
);