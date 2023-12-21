using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace FPTBook.Models;

public partial class User : IdentityUser
{
    public string UserFullName { get; set; } = null!;

    public int UserType { get; set; }

    public string? UserImage { get; set; }

    public string? UserAddress { get; set; }

    public string? UserPhone { get; set; }

    public DateOnly? UserBirthday { get; set; }

    public string? UserSex { get; set; }

    public int UserSection { get; set; }

    public virtual ICollection<Cart>? Carts { get; set; } = new List<Cart>();

    public virtual ICollection<Order>? Orders { get; set; } = new List<Order>();
}
