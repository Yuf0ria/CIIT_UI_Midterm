using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonsManager : MonoBehaviour
{
    public Image imageToScale;
    private bool isFlipVertical= false, isFadeDown = false;
    public void flip()
    {
        imageToScale.transform.DORotate(new Vector3(0f, 180f, 0f), 2.0f, RotateMode.FastBeyond360);
        isFlipVertical = !isFlipVertical;
        if(!isFlipVertical)
        {
            do
            {
                imageToScale.transform.DORotate(new Vector3(0f, 360f, 0f), 2.0f, RotateMode.FastBeyond360);
            }
            while (isFlipVertical);
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
                imageToScale.transform.DOLocalMoveY(392, 2f).SetEase(Ease.Linear);
            }
            while (isFadeDown);
            
        }
    }

    public void drop()
    {

    }

    public void swingRight()
    {

    }

    public void slideLeft()
    {

    }

    public void flyDown()
    {

    }




}
