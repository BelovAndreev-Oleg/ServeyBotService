namespace LineApiClient.Models.Messages;

/// <summary>
/// Abstract model to contain different types of messages.
/// </summary>
/// <param name="Type">Property for polymorphic class build by JSON Provider</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#message-objects</remarks>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(TextMessage), typeDiscriminator: "text")]
[JsonDerivedType(typeof(TemplateBaseMessage), typeDiscriminator: "template")]
public abstract record BaseMessage(
    string Type
);