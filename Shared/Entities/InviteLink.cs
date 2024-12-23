﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Remotely.Shared.Entities;

public class InviteLink
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public string ID { get; set; } = null!;
    public string? InvitedUser { get; set; }
    public bool IsAdmin { get; set; }
    public DateTimeOffset DateSent { get; set; }
    [JsonIgnore]
    public Organization? Organization { get; set; }
    public string OrganizationID { get; set; } = null!;
    public string? ResetUrl { get; set; }
}
