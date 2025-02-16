using UnityEngine;

public class GetSpeedPlayer : MonoBehaviour {
    void Update(){
        if (Input.GetKeyDown(KeyCode.P)){
            GetSpeed();
        }
    }

    void GetSpeed(){
        GameObject Player;
        Player = GameObject.Find("Player");
        Player.GetComponent<Movement>().speed = 0;
        GameObject.Find("Player").GetComponent<Movement>().speed = 0;
    }
}
