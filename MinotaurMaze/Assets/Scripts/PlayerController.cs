using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
       float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        transform.position += moveDirection;
    }
}

//code by Sorcerer https://www.youtube.com/watch?v=KiVL5rfVdTw&ab_channel=Sorcerer