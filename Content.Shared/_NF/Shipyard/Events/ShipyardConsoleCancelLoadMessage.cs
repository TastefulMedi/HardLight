using Robust.Shared.GameObjects;

namespace Content.Shared._NF.Shipyard.Events;

/// <summary>
/// Client UI message to cancel a pending ship load action.
/// Provides a simple way for the client to signal the server-side console
/// that any ephemeral load state should be discarded.
/// </summary>
public sealed class ShipyardConsoleCancelLoadMessage : BoundUserInterfaceMessage
{
}
