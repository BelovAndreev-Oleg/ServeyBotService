namespace LineApiClient.Models.Messages;

/// <summary>
/// Simple text message
/// </summary>
/// <param name="Type">"text"</param>
/// <param name="Text">Message contents</param>
/// <param name="QuoteToken">Quoted message ID</param>
/// <remarks>https://developers.line.biz/en/docs/messaging-api/message-types/#text-messages</remarks>
internal record TextMessage(
    string Type,
    string Text,
    string? QuoteToken
) : BaseMessage(Type);