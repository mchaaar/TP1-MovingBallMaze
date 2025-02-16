using UnityEngine;
using UnityEngine.SceneManagement;

public class BallLevelRestarter : MonoBehaviour {
    [SerializeField] private float restartTime = 5f;

    private float timeSinceLastTouch = 0f;
    private bool isBallOnFloor = false;

    private void Update(){
        if (!isBallOnFloor){
            timeSinceLastTouch += Time.deltaTime;

            if (timeSinceLastTouch >= restartTime){
                Debug.Log("Ball has been off the floor for too long. Restarting level...");
                RestartLevel();
            }
        }
        else{
            timeSinceLastTouch = 0f;
        }
    }

    private void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Floor")){
            isBallOnFloor = true;
        }
    }

    private void OnCollisionExit(Collision collision){
        if (collision.gameObject.CompareTag("Floor")){
            isBallOnFloor = false;
        }
    }
}
