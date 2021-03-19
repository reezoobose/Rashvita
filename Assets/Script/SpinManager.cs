using UnityEngine;
using UnityEngine.UI;

public class SpinManager : MonoBehaviour
{
    public Coloumn[] litofcoloumns;
    public int ColoumMacAnimationTime;
    public Button speen;

    public void StartAnimation()
    {
        speen.gameObject.SetActive(false);
        foreach (var item in litofcoloumns) item.RunAnimation();
        Invoke("ActivateButton", ColoumMacAnimationTime);
    }

    private void ActivateButton()
    {
        speen.gameObject.SetActive(true);
    }
}
