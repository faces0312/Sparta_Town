using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Player : MonoBehaviour
{
    public GameObject player;

    private void Update()
    {
        gameObject.transform.position =
            new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
    }
}
