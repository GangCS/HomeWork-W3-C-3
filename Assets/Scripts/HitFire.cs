using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HitFire : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision) //When fire ball get collision with some object
    {
        if (this.tag == "P1_fireball" && collision.tag == "P2") { // if the fire ball come out of player 1 "&&" hit player 2
            Destroy(this.gameObject);
            collision.gameObject.GetComponent<Life>().getHit(collision.gameObject); // reducing by player2 life (P2 got hit)
            if (!collision.gameObject.GetComponent<Life>().isAlive()) { // Player 1 Win
                Destroy(collision.gameObject);
                SceneManager.LoadScene("VictoryScene");
            }
        }
        if (this.tag == "P2_fireball" && collision.tag == "P1") { // if the fire ball come out of player 2 "&&" hit player 1
            Destroy(this.gameObject); 
            collision.gameObject.GetComponent<Life>().getHit(collision.gameObject);//  reducing by player1 life (P1 got hit)
            if (!collision.gameObject.GetComponent<Life>().isAlive()) { // Player 2 Win
                Destroy(collision.gameObject);
                SceneManager.LoadScene("VictoryScene");
            }
        }
    }
}
