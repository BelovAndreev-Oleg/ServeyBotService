// ReSharper disable NotAccessedPositionalProperty.Global

using LineApiClient.Models.Messages;
using LineApiClient.Models.Requests;

namespace LineApiClient.Models.Responses;

/// <summary>
/// Model to send a push message to users, group chats or multi-person chats.
/// </summary>
/// <param name="ReplyToken">Reply token received in a <see cref="WebhookRequest"/>.</param>
/// <param name="Messages">Messages to send</param>
/// <param name="NotificationDisabled">Does the user receives a push notification when the message is sent.</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#send-reply-message</remarks>
internal record ReplyResponse(
    string ReplyToken,
    IList<BaseMessage> Messages,
    bool? NotificationDisabled
);