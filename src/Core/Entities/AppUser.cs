﻿using Microsoft.AspNetCore.Identity;

namespace Core.Entities;

public class AppUser : IdentityUser
{
    public string Fullname { get; set; } = null!;
}
