using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : MonoBehaviour
{
    public Transform player;
    public float currentDistance, minimumDistance;
    bool doorOpen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentDistance = Vector3.Distance(player.position, transform.position);

        if(currentDistance <= minimumDistance && !doorOpen)
        {
            doorOpen = true;
            GetComponent<Animator>().Play("DoorOpen");
        }
        else if(currentDistance > minimumDistance && doorOpen)
        {
            doorOpen = false;
            GetComponent<Animator>().Play("DoorClose");
        }
    }
}
