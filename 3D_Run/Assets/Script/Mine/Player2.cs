using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
   // [SerializeField] float move = 3.5f;

    Vector3 moveVec;

    bool leftDown;
    bool rightDown;


    void Start()
    {
        moveVec = Vector3.zero;
        transform.position = moveVec;
    }

    void GetInput()
    {
        leftDown = Input.GetKeyDown(KeyCode.A);
        rightDown = Input.GetKeyDown(KeyCode.D);
    }

    void Update()
    {
        GetInput();
        Move();
    }

    //void Move()
    //{

    //    if(leftDown) 
    //    {

    //        Vector3 targetPosition = transform.position + Vector3.left * 3.5f;
    //        moveVec = Vector3.Lerp(transform.position, targetPosition, 0.05f);

    //        if (transform.position.x <= -move)
    //            moveVec.x = -move;

    //    }
    //    else if (rightDown)
    //    {
    //        Vector3 targetPosition = transform.position + Vector3.right * 3.5f;
    //        moveVec = Vector3.Lerp(transform.position, targetPosition, 0.05f);

    //        if (transform.position.x >= move)
    //            moveVec.x = move;
    //    }

    //    transform.position = moveVec;
    //}
    void Move()
    {
        if (leftDown)
        {
            StartCoroutine(MoveSmoothly(Vector3.left * 3.5f));
        }
        else if (rightDown)
        {
            StartCoroutine(MoveSmoothly(Vector3.right * 3.5f));
        }
    }

    IEnumerator MoveSmoothly(Vector3 direction)
    {
        leftDown = false;
        rightDown = false;
        float elapsedTime = 0f; // ���� �ð�
        Vector3 curPos = transform.position;
        Vector3 targetPos = curPos + direction;

        while (elapsedTime < 0.3f) // 0.5�� ���� �ε巴�� �̵�
        {
            transform.position = Vector3.Lerp(curPos, targetPos, (elapsedTime / 0.3f));
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        transform.position = targetPos; // ���� ��ǥ ��ġ�� �̵�

        leftDown = true;
        rightDown = true;
    }
}
