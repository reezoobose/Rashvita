using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICell
{
    void StartAnimation(float animationSpeed, Sprite[] listOfSprite, MonoBehaviour instance);
    void SetSprite(Sprite tobeset);
    void StopAnimation(MonoBehaviour instance);
}
