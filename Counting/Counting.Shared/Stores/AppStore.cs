using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Counting.Shared.Stores;

public static class AppStore
{
  public static BehaviorSubject<List<string>> Loading = new([]);

  public static void CloseLoading()
  {
    Loading.OnNext([]);
  }

  public static void StartLoading(string key)
  {
    Loading.OnNext(Loading.Value.Concat([key]).ToList());
  }

  public static void StopLoading(string key)
  {
    Loading.OnNext(Loading.Value.Where(s => s != key).ToList());
  }

}