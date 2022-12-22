using System;
using System.Collections.Generic;

namespace api_ub8ljw.Models;

public partial class Instructor
{
    public int InstructorSk { get; set; }

    public string? Salutation { get; set; }

    public string Name { get; set; } = null!;

    public byte StatusId { get; set; }

    public string EmployementId { get; set; } = null!;
}
