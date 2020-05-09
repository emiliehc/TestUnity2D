using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using static CStdLib;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private GameObject m_Player;

    void Start()
    {
        m_Player = GameObject.Find("Player");
    }

    void Update()
    {
        float ts = Time.deltaTime;
        
        Transform playerTransform = m_Player.GetComponent<Transform>();
        Vector3 playerPos = playerTransform.position;

        Vector3 cameraPos = GetComponent<Transform>().position;
        
        Vector3 currentPosition = transform.position;
        transform.position = Vector3.Lerp(currentPosition, playerPos, ts * 3.0f);
    }
};
