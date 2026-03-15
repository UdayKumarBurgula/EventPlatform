namespace EventPlatform.Api.Modules.Events;

public record TicketTypeResponse(
    Guid Id,
    Guid EventId,
    string Name,
    decimal Price,
    int QuantityAvailable);