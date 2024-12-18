using System.Reactive.Subjects;
using Counting.Shared.Models;
using Newtonsoft.Json.Linq;

namespace Counting.Shared.Stores;

public static class LoginStore
{
  #region Login

  public static readonly BehaviorSubject<JToken?> Token = new(null);
  public static readonly BehaviorSubject<string> UserId = new(string.Empty);

  #endregion
  #region Owner

  public static readonly BehaviorSubject<JToken?> Owner = new(null);

  #endregion
  #region Version

  public static readonly BehaviorSubject<string> Version = new(string.Empty);
  public static readonly BehaviorSubject<bool> IsPrivate = new(false);

  #endregion
}