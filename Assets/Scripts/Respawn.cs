using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform spawn;
    public GameObject player;
    public void respawn()
    {
        player.transform.position = spawn.transform.position;
    }
}
