using LineApiClient.Models.Messages.Templates;

namespace LineApiClient.Models.Messages;

/// <summary>
/// Message with predefined layouts
/// </summary>
/// <param name="Type">"template"</param>
/// <param name="AltText">
/// When a user receives a message, it will appear in the device's notifications, chat list,
/// and quote messages as an alternative to the template message.
/// </param>
/// <param name="BaseTemplate">A "Buttons", "Confirm", "Carousel", or "Image Carousel" object</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#template-messages</remarks>
internal record TemplateBaseMessage(
    string Type,
    string AltText,
    BaseTemplate BaseTemplate
) : BaseMessage(Type);