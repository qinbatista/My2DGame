using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Receiver : MonoBehaviour
{
    void OnEnable()
    {
        Sender.playerDiedInfo+= PlayerDiedListener;
    }
    void OnDisable()
    {
        Sender.playerDiedInfo -= PlayerDiedListener;
    }
    float PlayerDiedListener(Vector3 player, Vector3 target)
    {
        print("function is called"+ Vector3.Distance(player, target));
        return Vector3.Distance(player, target);
    }
}
