using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.Models.Suchimnu
{
  [Table("Games", Schema = "dbo")]
  public partial class Game
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
    public string Title
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string Description
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string ShortDescription
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public string ImageUrl
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public double Price
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public double OriginalPrice
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public bool IsActive
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public int CategoryId
    {
      get;
      set;
    }
    public Category Category { get; set; }
    [ConcurrencyCheck]
    public int StudioId
    {
      get;
      set;
    }
    public Studio Studio { get; set; }
    [ConcurrencyCheck]
    public DateTime CreateDate
    {
      get;
      set;
    }
    [ConcurrencyCheck]
    public DateTime LatestUpdate
    {
      get;
      set;
    }
  }
}
