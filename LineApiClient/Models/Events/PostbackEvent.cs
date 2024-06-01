// ReSharper disable ClassNeverInstantiated.Global
namespace LineApiClient.Models.Events;

/// <summary>
/// Event object for when a user performs a postback action which initiates a postback.
/// </summary>
/// <param name="Type">Identifier for the type of event</param>
/// <param name="Timestamp">UNIX time of the event occurred (in milliseconds), not the time it was redelivered.</param>
/// <param name="Source">User, group chat, or multi-person chat object with information about the source of the event.</param>
/// <param name="WebhookEventId">An ID that uniquely identifies a webhook event. A string in ULID format.</param>
/// <param name="ReplyToken">Reply token used to send reply message to this event</param>
/// <param name="Postback"></param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#postback-event</remarks>
public record PostbackEvent(
    string Type,
    long Timestamp,
    BaseSource? Source,
    string WebhookEventId,
    string ReplyToken,
    PostbackData Postback
) : BaseEvent(Type, Timestamp, Source, WebhookEventId);

/// <summary>
/// Data, attached to the event
/// </summary>
/// <param name="Data">String with data. Limited to 300 chars.</param>
public record PostbackData(string Data);