using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class security : MonoBehaviour
{
    public float speed;
    public Transform[] moveSpots;
    private float weitTime;
    public float startWeitTime;
    private int randomSpot;

    void Start()
    {
        randomSpot = Random.Range(0, moveSpots.Length);
        weitTime = startWeitTime;
    }

   
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (weitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpots.Length);
                weitTime = startWeitTime;
            }
            else
            {
                weitTime -= Time.deltaTime;
            }

        }
    }
}
