using UnityEngine;

public class Gutter : MonoBehaviour
{
    private void OnTriggerEnter(Collider triggeredBody)
    {
        // get ball's rigidbody component
        Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

        // store the velocity magnitude
        float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

        // reset velocity
        ballRigidBody.linearVelocity = Vector3.zero;
        ballRigidBody.angularVelocity = Vector3.zero;

        ballRigidBody.AddForce(transform.forward * velocityMagnitude, ForceMode.VelocityChange);

    }
}
