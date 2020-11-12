using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitFire : MonoBehaviour
{
    private static int p1 = 3;//max hp for player 1
    private static int p2 = 3;//max hp for player 2

    private void OnTriggerEnter2D(Collider2D collision) //When fire ball get collision with some object
    {
        if (this.tag == "P3" && collision.tag == "P2") { // if the fire ball come out of player 1 "&&" hit player 2
            Destroy(this.gameObject); 
            p2--;
            if (p2 == 0) { // Player 1 Win
                Destroy(collision.gameObject);
                SceneManager.LoadScene("VictoryScene");
            }
        }
        if (this.tag == "P4" && collision.tag == "P1") { // if the fire ball come out of player 2 "&&" hit player 1
            Destroy(this.gameObject); 
            p1--;
            if (p1 == 0) { // Player 2 Win
                Destroy(collision.gameObject);
                SceneManager.LoadScene("VictoryScene");
            }
        }
    }
}
