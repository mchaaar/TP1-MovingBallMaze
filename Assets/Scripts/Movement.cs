using UnityEngine;

public class Movement : MonoBehaviour {
    public float speed = 5;
    private float speed2;

    [SerializeField]
    private float speed3;

    void Update(){
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(movementX, movementY);

        transform.Translate(movement * Time.deltaTime * speed);
    }
}
