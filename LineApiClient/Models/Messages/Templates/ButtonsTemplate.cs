using LineApiClient.Models.Messages.Actions;

namespace LineApiClient.Models.Messages.Templates;

/// <summary>
/// Template with an image, title, text, and multiple action buttons.
/// </summary>
/// <param name="Type">"buttons"</param>
/// <param name="Title">Title.</param>
/// <param name="Text">Message text.</param>
/// <param name="DefaultAction">Action when image, title or text area is tapped.</param>
/// <param name="Actions">Button actions.</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#template-messages</remarks>
internal record ButtonsTemplate(
    string Type,
    string? Title,
    string Text,
    BaseAction? DefaultAction,
    List<BaseAction> Actions
) : BaseTemplate(Type);