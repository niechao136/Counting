using Newtonsoft.Json.Linq;

namespace Counting.Shared.Models;

public class CountingToken
{
  public string User_id { get; set; } = string.Empty;
  public JObject Token { get; set; } = new();
  public int Status { get; set; }
}