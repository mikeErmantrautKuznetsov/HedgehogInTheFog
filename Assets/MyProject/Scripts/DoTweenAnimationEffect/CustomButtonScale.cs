using UnityEngine.EventSystems;
using DG.Tweening;
using UnityEngine;

public class CustomButtonScale : ButtonEvent
{
    private const float _scale = 1f;
    [SerializeField]
    private float _toScale;
    [SerializeField]
    private float _duration;

    public override void OnPointerEnter(PointerEventData eventData)
    {
        base.OnPointerEnter(eventData);

        transform.DOScale(_toScale, _duration)
            .SetEase(Ease.InOutSine);
    }

    public override void OnPointerExit(PointerEventData eventData)
    {
        base.OnPointerExit(eventData);

        transform.DOScale(_scale, _duration)
            .SetEase(Ease.InOutSine);
    }
}
