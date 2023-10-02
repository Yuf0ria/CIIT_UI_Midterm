using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    public Image imageToScale;
    private bool isFlipped = false, isFadeDown = false;
    public void Flip()
    {
        imageToScale.transform.DORotate(new Vector3(0f, 180f, 0f), 1.0f, RotateMode.FastBeyond360);
        isFlipped = !isFlipped;
        if (!isFlipped )
        {
            do
            {
                imageToScale.transform.DORotate(new Vector3(0f, -180f, 0f), 1.0f, RotateMode.FastBeyond360);
            }
            while (isFlipped);
        }

        
    }

    public void fadeDown()
    {
        float fadeVal = 0;
        float targetScale = isFadeDown ? 1.0f : fadeVal;
        imageToScale.transform.DOLocalMoveY(10, 2f).SetEase(Ease.Linear);
        imageToScale.DOFade(targetScale, 0.25f);
        isFadeDown = !isFadeDown;
        if (!isFadeDown)
        {
            do
            {
                imageToScale.transform.DOLocalMoveY(392, 0.25f).SetEase(Ease.Linear);
            }
            while (isFadeDown);
            
        }
    }





}
