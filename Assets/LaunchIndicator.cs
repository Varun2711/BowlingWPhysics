using Unity.Cinemachine;
using UnityEngine;

public class LaunchIndicator : MonoBehaviour
{
    [SerializeField] private CinemachineCamera freelookCamera;

    // Update is called once per frame
    void Update()
    {
        transform.forward = freelookCamera.transform.forward;
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);
    }
}
