using System.Collections;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class Cell : MonoBehaviour, ICell
{
    private Image _currentImage;
    private Coroutine _routine;

    private Image GetImage
    {
        get
        {
            if (_currentImage == null) _currentImage = GetComponent<Image>();
            return _currentImage;
        }
    }

    public void SetSprite(Sprite spriteToBeSet)
    {
        GetImage.sprite = spriteToBeSet;
    }

    public void StartAnimation(float animationSpeed, Sprite[] listOfSprite, MonoBehaviour instance = null)
    {
        if (instance == null) instance = this;
        var routine = StartAnimation(animationSpeed, listOfSprite);
        _routine = instance.StartCoroutine(routine);

    }

    private IEnumerator StartAnimation(float animationSpeed, Sprite[] listOfSprite)
    {
        while (true)
        {

            for (var i = 0; i < listOfSprite.Length; i++)
            {
                if (i == listOfSprite.Length - 1) i = 0;
                GetImage.sprite = listOfSprite[i];
                yield return new WaitForSeconds(animationSpeed);
            }
        }
    }

    public void StopAnimation(MonoBehaviour instance = null)
    {
        if (instance == null) instance = this;
        if (_routine != null) instance.StopCoroutine(_routine);
    }
}
