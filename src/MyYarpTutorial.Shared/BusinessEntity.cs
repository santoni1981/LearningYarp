﻿namespace MyYarpTutorial.Shared;

public abstract class BusinessEntity : EntityBase
{
    public enum BusinessEntityType
    {
        Unknown,
        Customer,
        Supplier,
    }
    
    private BusinessEntity(Guid uuid) : base(uuid)
    {
    }
    
    public BusinessEntity() : base(Guid.NewGuid())
    {
    }
    
    public abstract BusinessEntityType EntityType { get; }
    
    public string Name { get; set; } = string.Empty;
    
    public string VatNumber { get; set; } = string.Empty;
}