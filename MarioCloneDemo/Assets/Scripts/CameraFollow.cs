using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;

    [SerializeField] private bool isFollowing = true;
    [SerializeField] private bool xFollow = true;
    [SerializeField] private bool yFollow = true;

    [SerializeField] private Vector3 vector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        follow();
    }

    private void follow()
    {
        if (isFollowing)
        {
            Vector3 targetPosition = new Vector3(player.position.x, player.position.y);
            if (!xFollow)
            {
                targetPosition.x = transform.position.x;
            }
            if (!yFollow)
            {
                targetPosition.y = transform.position.y;
            }
        }
    }
}
