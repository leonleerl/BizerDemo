﻿namespace BizerDemo.Contracts;

public class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
}