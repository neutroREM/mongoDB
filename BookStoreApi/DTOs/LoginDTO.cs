﻿namespace BookStoreApi.DTOs
{
    public class LoginDTO
    {
        public string Email { get; set; } = null!;

        public string Password { get; set; } = null!;

        public bool KeepSession{ get; set; }
    }
}
