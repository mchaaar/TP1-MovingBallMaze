using UnityEngine;
using UnityEngine.SceneManagement;

public class ParticleCollisionHandler : MonoBehaviour {
    private void OnParticleCollision(GameObject other){
        if (other.CompareTag("Ball")){
            Debug.Log("Particle collided with Ball! Restarting level...");
            RestartLevel();
        }
    }

    private void RestartLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
