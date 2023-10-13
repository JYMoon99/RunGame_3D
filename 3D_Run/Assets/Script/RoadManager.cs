using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadManager : MonoBehaviour
{
    [SerializeField] float speed = 10f;
    [SerializeField] float offset = 40f;
    [SerializeField] List<GameObject> roads;

    public static Action roadCallback;

    public void Start()
    {
        roadCallback = NewPosition;
    }

    void Update()
    {
       // 내가 작성한 코드
       // foreach (GameObject road in roads)
       // {
       //     Vector3 position = road.transform.position;
       //     position.z -= speed * Time.deltaTime;
       //
       //     road.transform.position = position;
       // }
        
       // 선생님이 작성한 코드 
        for(int i = 0; i < roads.Count; i++)
        {
            roads[i].transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

    }

    //public void OnOffset(List<GameObject> roads)
    //{
    //    Vector3 offsetVec = Vector3.forward * offset;   
        
    //    for(int i = 0; i < roads.Count; i++)
    //    {
    //        roads.Remove(roads[i]);
    //        roads[i].transform.Translate(offsetVec);
    //        roads.Add(roads[i]);
    //    }
    //}

    public void NewPosition()
    {
        GameObject firstRoad = roads[0];

        roads.Remove(firstRoad);

        float newZ = roads[roads.Count -1].transform.position.z + offset;

        firstRoad.transform.position = Vector3.forward * newZ;

        roads.Add(firstRoad);

    }


}
