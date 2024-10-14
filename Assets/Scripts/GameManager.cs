using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;
    public InputName inputName;

    public int player_num;
    public GameObject player;
    public GameObject player1_Sprite;
    public GameObject player2_Sprite;

    public GameObject input_Tool;
    public GameObject side_Tool;

    public TextMeshProUGUI timeText;

    public GameObject input_Character;

    public GameObject talk_Tool;
    public GameObject talk;

    private void Awake()
    {
        manager = this;
        player_num = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        player.gameObject.SetActive(false);
        player1_Sprite.gameObject.SetActive(false);
        player2_Sprite.gameObject.SetActive(false);
    }

    void Update()
    {
        DateTime currentTime = DateTime.Now;
        timeText.text = currentTime.ToString("HH : mm");
    }

    public void Change_Name()
    {
        input_Tool.SetActive(true);
    }

    public void SideTool()
    {
        if (side_Tool.activeSelf == true)
            side_Tool.SetActive(false);
        else
            side_Tool.SetActive(true);
    }

    public void InputCharacter()
    {
        input_Character.SetActive(true);
    }

    public void InputTalk()
    {
        talk.SetActive(true);
        talk_Tool.SetActive(false);
    }

    public void CheckTalk()
    {
        talk.SetActive(false);
        talk_Tool.SetActive(false);
    }
}
