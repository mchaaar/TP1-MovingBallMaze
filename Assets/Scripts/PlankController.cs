using UnityEngine;

public class PlankController : MonoBehaviour {
    [SerializeField] private float rotationSpeed = 50f;
    [SerializeField] private float maxRotationAngle = 40f;

    private float currentRotationX = 0f;
    private float currentRotationZ = 0f;

    void Update(){
        float inputX = Input.GetAxis("Vertical");
        float inputZ = -Input.GetAxis("Horizontal");

        currentRotationX += inputX * rotationSpeed * Time.deltaTime;
        currentRotationZ += inputZ * rotationSpeed * Time.deltaTime;

        currentRotationX = Mathf.Clamp(currentRotationX, -maxRotationAngle, maxRotationAngle);
        currentRotationZ = Mathf.Clamp(currentRotationZ, -maxRotationAngle, maxRotationAngle);

        transform.rotation = Quaternion.Euler(currentRotationX, 0f, currentRotationZ);
    }
}
    