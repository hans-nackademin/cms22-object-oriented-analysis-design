﻿namespace WebApi.Models.DTO;

public class SignInModel
{
    public string Email { get; set; } = null!;
    public string Password { get; set; } = null!;
    public bool RememberMe { get; set; }
}
