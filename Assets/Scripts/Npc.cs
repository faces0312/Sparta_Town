using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : MonoBehaviour
{
    public GameObject talk_Tool;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && GameManager.manager.talk.activeSelf == false)
        {
            talk_Tool.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            talk_Tool.SetActive(false);
            GameManager.manager.talk.SetActive(false);
        }
    }
}
