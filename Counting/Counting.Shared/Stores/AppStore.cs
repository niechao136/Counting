using System.Reactive.Linq;
using System.Reactive.Subjects;

namespace Counting.Shared.Stores;

public class AppStore
{
  private IObservable<int> _observable = Observable.Range(1, 5);
}