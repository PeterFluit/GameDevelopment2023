using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent startEvent;
    private Image img;

    void Start()
    {
        gameActionObj.raiseNoArgs += RunStartEvent;
        img = GetComponent<Image>();
        startEvent.Invoke();
    }

    private void RunStartEvent()
    {
        startEvent.Invoke();
    }

    public void UpdateImage(FloatData obj)
    {
        img.fillAmount = obj.value;
    }
}
