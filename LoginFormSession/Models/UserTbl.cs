using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginFormSession.Models;

public partial class UserTbl
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Gender { get; set; }

    [Required]
    public int? Age { get; set; }

    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }

    [DataType(DataType.Password)]
    public string Password { get; set; }
}
