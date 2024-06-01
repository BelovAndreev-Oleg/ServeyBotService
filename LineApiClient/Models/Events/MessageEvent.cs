using LineApiClient.Models.Messages;

namespace LineApiClient.Models.Events;

/// <summary>
/// Event object for when your LINE Official Account recieved as message from a user.
/// </summary>
/// <param name="Type">Identifier for the type of event</param>
/// <param name="Timestamp">UNIX time of the event occurred (in milliseconds), not the time it was redelivered.</param>
/// <param name="Source">User, group chat, or multi-person chat object with information about the source of the event.</param>
/// <param name="WebhookEventId">An ID that uniquely identifies a webhook event. A string in ULID format.</param>
/// <param name="ReplyToken">Reply token used to send reply message to this event.</param>
/// <param name="Message">The contents of the message depends on from Type param.</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#message-event</remarks>
public record MessageEvent(
    string Type,
    long Timestamp,
    BaseSource? Source,
    string WebhookEventId,
    string ReplyToken,
    BaseMessage Message
) : BaseEvent(Type, Timestamp, Source, WebhookEventId);