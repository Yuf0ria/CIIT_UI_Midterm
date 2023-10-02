using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
public class ButtonsManager : MonoBehaviour
{
    public Image imageToScale;
    private bool isZoomOut = false;
    public void Zoom()
    {
        float zoomVal = 0;
        float targetScale = isZoomOut ? 1.0f : zoomVal;
        imageToScale.transform.DOScale(targetScale, 0.25f);
        isZoomOut = !isZoomOut;
    }
   
}
