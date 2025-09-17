using UnityEngine;
using UnityEngine.EventSystems;

public class ClickButton : ButtonEvent
{
    [SerializeField]
    private int _numberScene;

    public async override void OnPointerClick(PointerEventData eventData)
    {
        base.OnPointerClick(eventData);

        await Loader.SceneLoad(_numberScene);
    }
}
