namespace LineApiClient.Models.Messages.Actions;

/// <summary>
/// Abstract model to contain different types of actions in <see cref="BaseMessage"/>.
/// </summary>
/// <param name="Type">Property for polymorphic class build by JSON Provider</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#action-objects</remarks>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(PostbackAction), typeDiscriminator: "postback")]
internal abstract record BaseAction(
    string Type
);