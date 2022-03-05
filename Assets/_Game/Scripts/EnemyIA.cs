using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform playerToFollow;
    // Start is called before the first frame update
    void Start()
    {
        playerToFollow = GameObject.Find("Player").transform;
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = playerToFollow.position;
    }

    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Jumpscare");
        }
    }
}
