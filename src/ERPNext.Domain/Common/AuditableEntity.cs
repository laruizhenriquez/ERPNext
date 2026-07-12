using System;
using System.Collections.Generic;
using System.Text;

namespace ERPNext.Domain.Common;

public abstract class AuditableEntity : BaseEntity
{
    public DateTime CreatedAt { get; protected set; }

    public string? CreatedBy { get; protected set; }

    public DateTime? UpdatedAt { get; protected set; }

    public string? UpdatedBy { get; protected set; }

    public DateTime? DeletedAt { get; protected set; }

    public string? DeletedBy { get; protected set; }

    public bool IsDeleted { get; protected set; }
}