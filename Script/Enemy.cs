using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Enemy : MonoBehaviour
{
    Transform target;
    NavMeshAgent nav;
    // Start is called before the first frame update
    void Start()
    {
        if (target==null)
        {
            target = GameObject.FindGameObjectWithTag("Player").transform;
            //SceneManager.LoadScene(2);
            
        }
        nav = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        nav.destination = target.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}
