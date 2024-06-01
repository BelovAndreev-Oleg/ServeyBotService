namespace LineApiClient.Models.Messages.Templates;

/// <summary>
/// Abstract model to contain different types of templates.
/// </summary>
/// <param name="Type">Property for polymorphic class build by JSON Provider</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#template-messages</remarks>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(ButtonsTemplate), typeDiscriminator: "buttons")]
internal abstract record BaseTemplate(
    string Type
);