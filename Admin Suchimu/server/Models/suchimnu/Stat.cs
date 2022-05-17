using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models.Suchimnu
{
  [Table("Stats", Schema = "dbo")]
  public partial class Stat
  {
    [NotMapped]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("@odata.etag")]
    public string ETag
    {
        get;
        set;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public int Visits
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public DateTime? LastVisit
    {
      get;
      set;
    }
  }
}
