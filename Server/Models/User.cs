using Microsoft.AspNetCore.Identity;

namespace MachineLearning.Server.Models;

public class User
{
    public long Id { get; set; }
    public IdentityUser IdentityUser { get; set; }
    public string ImageUrl { get; set; }
}