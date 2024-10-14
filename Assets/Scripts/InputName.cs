using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputName : MonoBehaviour
{
    public GameObject character;
    //�̸� ����
    public GameObject input_tool;
    public InputField inputField;
    public TextMeshProUGUI playerName = null;
    public Button inputButton;
    //�ִ� �ּ� ���ڼ� ����
    public int minCharacters = 2;
    public int maxCharacters = 10;
    // Start is called before the first frame update
    void Start()
    {
        input_tool.gameObject.SetActive(true);
        inputButton.interactable = false;
        inputField.onValueChanged.AddListener(OnInputValueChanged);
    }

    void OnInputValueChanged(string newValue)
    {
        if (newValue.Length < 2 || newValue.Length > 10)
        {
            inputButton.interactable = false;
        }
        else
        {
            inputButton.interactable = true;
        }
    }

    //���콺
    public void Input()
    {
        character.SetActive(false);
        playerName.text = inputField.text;

        if (GameManager.manager.player_num == 1)
        {
            GameManager.manager.player1_Sprite.gameObject.SetActive(true);
            GameManager.manager.player2_Sprite.gameObject.SetActive(false);
        }
        else if (GameManager.manager.player_num == 2)
        {
            GameManager.manager.player1_Sprite.gameObject.SetActive(false);
            GameManager.manager.player2_Sprite.gameObject.SetActive(true);
        }
        GameManager.manager.player.SetActive(true);
        input_tool.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
