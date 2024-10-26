using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public interface IEventObserver {
    void OnEventUpdate(GameEventBase gameEvent);
}