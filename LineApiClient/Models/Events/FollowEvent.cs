namespace LineApiClient.Models.Events;

/// <summary>
/// Event object for when your LINE Official Account is added as a friend (or unblocked).
/// </summary>
/// <param name="Type">Identifier for the type of event</param>
/// <param name="Timestamp">UNIX time of the event occurred (in milliseconds), not the time it was redelivered.</param>
/// <param name="Source">User, group chat, or multi-person chat object with information about the source of the event.</param>
/// <param name="WebhookEventId">An ID that uniquely identifies a webhook event. A string in ULID format.</param>
/// <param name="ReplyToken">Reply token used to send reply message to this event</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#follow-event</remarks>
public record FollowEvent(
    string Type,
    long Timestamp,
    BaseSource? Source,
    string WebhookEventId,
    string ReplyToken
) : BaseEvent(Type, Timestamp, Source, WebhookEventId);