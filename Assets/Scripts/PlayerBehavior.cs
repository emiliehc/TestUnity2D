using System;
using System.Collections;
using System.Collections.Generic;
using static CStdLib;
using UnityEngine;

public unsafe class PlayerBehavior : MonoBehaviour
{
    private PlayerProps* m_PlayerProps;
    private const float MoveSpeed = 10.0f;

    PlayerProps* GetPlayerProps()
    {
        return m_PlayerProps;
    }

    void Start()
    {
        m_PlayerProps = PlayerProps.CreatePlayerProps();
    }

    void Update()
    {
        // player controller
        float ts = Time.deltaTime;
        Vector3 playerPos = transform.position;
        if (Input.GetKey(KeyCode.W))
        {
            playerPos.y += MoveSpeed * ts;
        }

        if (Input.GetKey(KeyCode.A))
        {
            playerPos.x -= MoveSpeed * ts;
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            playerPos.y -= MoveSpeed * ts;
        }

        if (Input.GetKey(KeyCode.D))
        {
            playerPos.x += MoveSpeed * ts;
        }

        transform.position = playerPos;
    }

    private void OnDestroy()
    {
        free(m_PlayerProps);
    }
}