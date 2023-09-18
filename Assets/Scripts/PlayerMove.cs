using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public int moveDist;
    void Start()
    {
        
    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            StartCoroutine(MovePlayerY(moveDist));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            StartCoroutine(MovePlayerY(-moveDist));
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            StartCoroutine(MovePlayerX(-moveDist));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            StartCoroutine(MovePlayerX(moveDist));
        }
    }

    IEnumerator MovePlayerY(int num)
    {
        transform.position += new Vector3(0f, num);

        yield return null;
    }

    IEnumerator MovePlayerX(int num)
    {
        transform.position += new Vector3(num, 0f);

        yield return null;
    }
}
