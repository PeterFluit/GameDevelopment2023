using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Image))]
public class ImageBehaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    private Image img;

    void Start()
    {
        img = GetComponent<Image>();
        startEvent.Invoke();
    }

    public void UpdateImage(FloatData obj)
    {
        img.fillAmount = obj.value;
    }
}
