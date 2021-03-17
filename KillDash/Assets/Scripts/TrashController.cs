using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashController : MonoBehaviour
{
    public AudioSource trashEffect;
    public PlayerInventory player;
    public void ThrowAway()
    {
        if (player.isEmpty())
        {

        }
        else
        {
            trashEffect.Play();
            player.throwAway();
        }
    }

}
