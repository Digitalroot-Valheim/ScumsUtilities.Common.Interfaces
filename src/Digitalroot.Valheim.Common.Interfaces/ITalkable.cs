using UnityEngine;

namespace Digitalroot.Valheim.Common.Interfaces
{
  public interface ITalkable
  {
    Transform Head { get; set; }
    GameObject Talker { get; set; }

    void Say(string topic, string msg);
  }
}
