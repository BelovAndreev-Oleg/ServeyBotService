// ReSharper disable ClassNeverInstantiated.Global
// ReSharper disable UnusedAutoPropertyAccessor.Global

using LineApiClient.Models.Events;

namespace LineApiClient.Models.Requests;

/// <summary>
/// Message that was sent to the bot by LineApp webhook.
/// </summary>
/// <param name="Destination">User ID of a bot that should receive webhook events.</param>
/// <param name="Events">
/// Array of <see cref="BaseEvent"/>.
/// The LINE Platform may send an empty array that doesn't include a webhook event object to confirm communication.
/// </param>
/// <remarks>https://developers.line.biz/en/reference/messaging-api/#request-headers</remarks>
public record WebhookRequest(
    string Destination,
    IReadOnlyCollection<BaseEvent> Events
);