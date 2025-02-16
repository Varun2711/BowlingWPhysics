using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private Transform ballAnchor;
    [SerializeField] private Transform launchIndicator;

    private Rigidbody ballRB;
    private bool isBallLaunched;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // grab reference to rigidbody
        ballRB = GetComponent<Rigidbody>();

        // add listener to the onSpacedPressed event
        inputManager.OnSpacePressed.AddListener(LaunchBall);

        // anchor ball to the player
        transform.parent = ballAnchor;
        transform.localPosition = Vector3.zero;

        // set isKinematic to true
        ballRB.isKinematic = true;
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

        // don't move the parent
        transform.parent = null;

        // turn of isKinematic flag
        ballRB.isKinematic = false;

        // add force to the ball i.e launch the ball
        ballRB.AddForce(launchIndicator.forward*force, ForceMode.Impulse);
        launchIndicator.gameObject.SetActive(false);
    }
}
