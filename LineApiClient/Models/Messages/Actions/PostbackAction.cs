using LineApiClient.Models.Events;

namespace LineApiClient.Models.Messages.Actions;

/// <summary>
/// When a control associated with this action is tapped, a <see cref="PostbackEvent"/> is returned via webhook
/// with the specified string in the data property.
/// </summary>
/// <param name="Type">"postback"</param>
/// <param name="Label">Label for the action. Max char limit is 20.</param>
/// <param name="Data">String returned via webhook in the data property of the event. Max char limit is 300. </param>
/// <param name="DisplayText">
/// Text displayed on the LINE chat screen as a message sent by the user when the action is performed.
/// Max char limit is 300.
/// </param>
/// <param name="InputOption">The display method of such as rich menu based on user action.</param>
/// <param name="FillInText">String to be pre-filled in the input field when the keyboard is opened.</param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#postback-action</remarks>
internal record PostbackAction(
    string Type,
    string Label,
    string Data,
    string? DisplayText,
    InputOption? InputOption,
    string? FillInText
) : BaseAction(Type);

/// <summary>
/// An option to call a special input method of such as rich menu, based on user action.
/// </summary>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#postback-action (inputOption section)</remarks>
internal enum InputOption
{
    OpenKeyboard
}