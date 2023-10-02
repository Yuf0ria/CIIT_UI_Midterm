using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;

public class ButtonsManager : MonoBehaviour
{
    public Image imageToScale;
    private bool isFlipVertical= false, isFadeDown = false, isDrop = false, isSwingRight = false, isSlideLeft = false, isFlyDown = false;
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
        float dropVal = 0;
        float targetScale = isDrop ? 1.0f : dropVal;
        imageToScale.transform.DORotate(new Vector3(0f, 90f, 180f), 2.0f).SetEase(Ease.InBounce);
        imageToScale.DOFade(targetScale, 0.25f);
        isDrop = !isDrop;
        if (!isDrop)
        {
            do
            {
                imageToScale.transform.DORotate(new Vector3(0f, 180f, 0f), 2.0f).SetEase(Ease.OutBounce);
            }
            while (isDrop);

        }
    }

    public void swingRight()
    {
        float swingRightVal = 0;
        float targetScale = isSwingRight ? 1.0f : swingRightVal;
        imageToScale.transform.DORotate(new Vector3(0f, 0f, -90f), 2.0f);
        imageToScale.transform.DORotate(new Vector3(0f, 0f, 90f), 2.0f);
        imageToScale.transform.DORotate(new Vector3(0f, 90f, 0f), 2.0f).SetEase(Ease.OutBounce);
        imageToScale.DOFade(targetScale, 2);
        isSwingRight = !isSwingRight;
        if (!isSwingRight)
        {
            do
            {
                imageToScale.transform.DORotate(new Vector3(0f, 180f, 0f), 2.0f).SetEase(Ease.InBounce);
            }
            while(isSwingRight);
        }
    }

    public void slideLeft()
    {
        float slideLeftVal = 0;
        float targetScale = isSlideLeft ? 1.0f : slideLeftVal;
        imageToScale.transform.DOLocalMoveX(-30, 2f).SetEase(Ease.Linear);
        imageToScale.DOFade(targetScale, 1f);
        isSlideLeft = !isSlideLeft;
        if (!isSlideLeft)
        {
            do
            {
                imageToScale.transform.DOLocalMoveX(0, 2f).SetEase(Ease.Linear);
                imageToScale.DOFade(targetScale, 1f);
            }
            while (isSlideLeft);

        }
    }

    public void flyDown()
    {
        imageToScale.transform.DOLocalMoveY(1000, 1f).SetEase(Ease.InElastic);
        isFlyDown = !isFlyDown;
        if (!isFlyDown)
        {
            do
            {
                imageToScale.transform.DOLocalMoveY(392, 1f).SetEase(Ease.OutElastic);
            }
            while (isFlyDown);

        }
    }




}
