// ReSharper disable NotAccessedPositionalProperty.Global

using LineApiClient.Models.Messages;
using LineApiClient.Models.Requests;

namespace LineApiClient.Models.Responses;

/// <summary>
/// Model to send a push message to users, group chats or multi-person chats.
/// </summary>
/// <param name="To">ID of the target recipient. Use a userId, groupId, or roomId value returned in a <see cref="WebhookRequest"/>.</param>
/// <param name="Messages">Messages to send</param>
/// <param name="NotificationDisabled">Does the user receives a push notification when the message is sent.</param>
/// <param name="CustomAggregationUnits">Name of aggregation unit. Case-sensitive.</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#send-push-message</remarks>
internal record PushResponse(
    string To,
    IList<BaseMessage> Messages,
    bool? NotificationDisabled,
    string[]? CustomAggregationUnits
);