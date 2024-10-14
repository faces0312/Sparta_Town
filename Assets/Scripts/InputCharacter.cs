using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputCharacter : MonoBehaviour
{
    public GameObject player1_Image;
    public GameObject player2_Image;
    
    public void Select_Player1()
    {
        GameManager.manager.player_num = 1;

        player1_Image.SetActive(true);
        player2_Image.SetActive(false);

        GameManager.manager.player1_Sprite.gameObject.SetActive(true);
        GameManager.manager.player2_Sprite.gameObject.SetActive(false);

        gameObject.SetActive(false);
    }

    public void Select_Player2()
    {
        GameManager.manager.player_num = 2;

        player1_Image.SetActive(false);
        player2_Image.SetActive(true);

        GameManager.manager.player1_Sprite.gameObject.SetActive(false);
        GameManager.manager.player2_Sprite.gameObject.SetActive(true);

        gameObject.SetActive(false);
    }
}
