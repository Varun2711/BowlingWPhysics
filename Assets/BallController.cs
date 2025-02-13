using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;

    private Rigidbody ballRB;
    private bool isBallLaunched;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // grab reference to rigidbody
        ballRB = GetComponent<Rigidbody>();

        // add listener to the onSpacedPressed event
        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        // check if ball has already been launched
        // if so, then return immediately without adding force
        if (isBallLaunched)
        {
            return;
        }

        // activate the isBallLaunched flag
        isBallLaunched = true;

        // add force to the ball i.e launch the ball
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
