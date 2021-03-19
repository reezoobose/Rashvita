using System;
using UnityEngine;

[RequireComponent(typeof(ColoumnConfiguration))]
public class Coloumn : IColoumn
{
    private ColoumnConfiguration _currentConfig;

    public override void LoadConfiguration()
    {
        _currentConfig = GetComponent<ColoumnConfiguration>();
        if (_currentConfig == null) throw new NullReferenceException("Unable to load config");
        if (_currentConfig.cells == null) throw new NullReferenceException("Unable to load config");
    }

    public override void StartColoumnAnimation()
    {
        foreach (var item in _currentConfig.cells) item.StartAnimation(_currentConfig.animtionSpeed, _currentConfig.listOfSprite, this);
        Invoke(nameof(CloseAnimationOfCell), _currentConfig.animationInterval);
    }

    public override void CloseAnimationOfCell()
    {
        foreach (var item in _currentConfig.cells) item.StopAnimation(this);
        SetFinalItem();
    }

    public override void SetFinalItem()
    {
        foreach (var item in _currentConfig.cells)
        {
            var rand = UnityEngine.Random.Range(0, _currentConfig.listOfSprite.Length);
            item.SetSprite(_currentConfig.listOfSprite[rand]);
        }

    }
}
