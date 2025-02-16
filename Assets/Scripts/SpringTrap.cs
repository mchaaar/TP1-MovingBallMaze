using UnityEngine;
using System.Collections;

public class SpringTrap : MonoBehaviour {
    [SerializeField] private float launchForce = 10f;
    [SerializeField] private float resetTime = 0.5f;
    private Vector3 originalPosition;

    private void Start(){
        originalPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other){
        if (other.CompareTag("Ball")){
            Rigidbody rb = other.GetComponent<Rigidbody>();
            if (rb != null){
                rb.linearVelocity = Vector3.zero;
                rb.AddForce(Vector3.up * launchForce, ForceMode.Impulse);
                StartCoroutine(ResetTrap());
            }
        }
    }

    private IEnumerator ResetTrap(){
        Vector3 loweredPosition = originalPosition - new Vector3(0, 0.2f, 0);
        transform.position = loweredPosition;

        yield return new WaitForSeconds(resetTime);

        transform.position = originalPosition;
    }
}
