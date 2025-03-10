using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.CompareTag("Enemy")){
            FindObjectOfType<SoundFXController>().PlayEnemyDeath();
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
