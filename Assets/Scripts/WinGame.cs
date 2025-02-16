using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class WinGame : MonoBehaviour {
    [SerializeField] private TMP_Text winText;

    private void Start(){
        winText.enabled = false;
    }

    private void OnCollisionEnter(Collision collision){
        if (collision.gameObject.CompareTag("Win")){
            winText.enabled = true;
            winText.text = "You won";
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
