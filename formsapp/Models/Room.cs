﻿using System;
using System.Collections.Generic;

namespace formsapp.Models;

public partial class Room
{
    public int RoomSk { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Lesson> Lesson { get; } = new List<Lesson>();
}
