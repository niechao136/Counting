using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Counting.Shared.Stores;

public static class AppStore
{
  #region Loading

  public static readonly BehaviorSubject<List<string>> Loading = new([]);

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

  #endregion Loading
  #region Header Title

  public static readonly BehaviorSubject<List<string>> TitleList = new([]);
  public static readonly BehaviorSubject<int> TitleCount = new(0);

  public static void SetTitle(List<string> list)
  {
    TitleList.OnNext(list);
    TitleCount.OnNext(0);
  }
  public static void AddTitle(string title)
  {
    TitleList.OnNext(TitleList.Value.Concat([title]).ToList());
    TitleCount.OnNext(TitleCount.Value + 1);
  }
  public static void PopTitle()
  {
    if (TitleCount.Value <= 0) return;
    TitleList.OnNext(TitleList.Value.Take(TitleList.Value.Count - 1).ToList());
    TitleCount.OnNext(TitleCount.Value - 1);
  }
  public static void JumpToTitle(int index = 0)
  {
    var min = TitleCount.Value > index ? TitleCount.Value - index : 0;
    TitleList.OnNext(TitleList.Value[..^min].ToList());
    TitleCount.OnNext(TitleCount.Value - min);
  }

  #endregion Header Title
}