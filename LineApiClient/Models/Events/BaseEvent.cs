using LineApiClient.Models.Requests;

namespace LineApiClient.Models.Events;

/// <summary>
/// Abstract model to contain different types of events in <see cref="WebhookRequest"/>.
/// </summary>
/// <param name="Type">Property for polymorphic class build by JSON Provider</param>
/// <param name="Timestamp">UNIX time of the event occurred (in milliseconds), not the time it was redelivered.</param>
/// <param name="Source">User, group chat, or multi-person chat object with information about the source of the event.</param>
/// <param name="WebhookEventId">An ID that uniquely identifies a webhook event. A string in ULID format.</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#common-properties</remarks>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(FollowEvent), typeDiscriminator: "follow")]
[JsonDerivedType(typeof(MessageEvent), typeDiscriminator: "message")]
[JsonDerivedType(typeof(PostbackEvent), typeDiscriminator: "postback")]
public abstract record BaseEvent(
    string Type,
    long Timestamp,
    BaseSource? Source,
    string WebhookEventId
);

/// <summary>
/// User, group chat, or multi-person chat information as a source of the event.
/// </summary>
/// <param name="Type">Identifier for the type of source</param>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(UserSource), typeDiscriminator: "user")]
public abstract record BaseSource(
    string Type
);

/// <summary>
/// User chat information.
/// </summary>
/// <param name="Type">"user"</param>
/// <param name="UserId">ID of the source user</param>
public record UserSource(
    string Type,
    string UserId
) : BaseSource(Type);