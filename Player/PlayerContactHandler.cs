using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerContactHandler : MonoBehaviour
{
    public Image itemImage;
    bool canWinLevel = false;
    public PlayerAudioController audioController;

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Enemy")){
            Debug.Log("PLAYER TOCOU NO INIMIGO, ENTÃO PERDEU!!!");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("Item")){
            Debug.Log("PLAYER PEGOU O ITEM!");
            Destroy(collision.gameObject);
            itemImage.color = Color.white;
            canWinLevel = true;
            audioController.PlayGetItem();
        }

        if (collision.gameObject.CompareTag("FinalPoint")){
            if (canWinLevel){
                Debug.Log("PLAYER GANHOU O LEVEL");
            } else {
                Debug.Log("PLAYER NAO GANHOU O LEVEL");
            }
        }
    }
}
