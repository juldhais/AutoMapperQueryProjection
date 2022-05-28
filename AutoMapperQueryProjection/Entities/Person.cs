﻿namespace AutoMapperQueryProjection.Entities;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Country Country { get; set; }
    public int? CountryId { get; set; }

    public Job Job { get; set; }
    public int? JobId { get; set; }
}