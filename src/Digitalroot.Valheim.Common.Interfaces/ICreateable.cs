using UnityEngine;

namespace Digitalroot.Valheim.Common.Interfaces
{
  public interface ICreateable
  {
    string Name { get; }
    string Token { get; }
    GameObject Create();
  }
}
