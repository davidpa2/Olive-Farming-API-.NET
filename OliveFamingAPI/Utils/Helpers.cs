using System.Security.Claims;

namespace OliveFarmingAPI.Utils;

public static class Helpers
{
    public static int GetCurrentUserId(this ClaimsPrincipal user)
    {
        var userIdString = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        
        if (string.IsNullOrEmpty(userIdString) || !int.TryParse(userIdString, out int userId))
        {
            throw new UnauthorizedAccessException("ID de usuario no válido en el token JWT.");
        }

        return userId;
    }
}