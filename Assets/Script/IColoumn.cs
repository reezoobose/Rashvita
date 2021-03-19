using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class IColoumn : MonoBehaviour
{
    [ContextMenu("Run animation")]
    public void RunAnimation()
    {
        LoadConfiguration();
        StartColoumnAnimation();
    }

    public abstract void LoadConfiguration();
    public abstract void StartColoumnAnimation();
    public abstract void CloseAnimationOfCell();
    public abstract void SetFinalItem();
}
