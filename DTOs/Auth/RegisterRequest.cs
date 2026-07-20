namespace rideflow.DTOs.Auth;

public record RegisterRequest(
    [Required, MinLength(2), MaxLength(50)]
    string FirstName,

    [Required, MinLength(2), MaxLength(50)]
    string LastName,

    [Required, EmailAddress]
    string Email,

    [Required, MinLength(8)]
    string Password
);
