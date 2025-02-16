using System;
using UnityEngine;
using UnityEngine.Events;

public class InputManager : MonoBehaviour
{
    // for player
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

    // for ball
    public UnityEvent OnSpacePressed = new UnityEvent();

    // for reset
    public UnityEvent OnResetPressed = new UnityEvent();

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSpacePressed?.Invoke();
        }

        Vector2 input = Vector2.zero;
        if (Input.GetKey(KeyCode.A))
        {
            input += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input += Vector2.right;
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            OnResetPressed?.Invoke();
        }

        OnMove?.Invoke(input);
    }
}
