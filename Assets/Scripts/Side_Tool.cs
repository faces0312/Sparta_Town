using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Side_Tool : MonoBehaviour
{
    public TextMeshProUGUI name_List;
    private List<string> npc_List = new List<string>();

    private void Start()
    {
        npc_List.Add("NPC1");
        //npc_List.Add("NPC2");

        name_List.text = GameManager.manager.playerName.text + "\n";

        foreach (string npc in npc_List)
        {
            name_List.text += (npc + "\n");
        }
    }

}
