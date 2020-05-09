using UnityEngine;


public class TestScript : MonoBehaviour
{
    unsafe void Start()
    {
        Debug.LogWarning("TestScript::Start");
        const string s = " ";
        char[] c = s.ToCharArray();
        fixed (char* a = &c[0])
        {
            *a = 'a';
        }
        Debug.Log(new string(c));
    }

    void Update()
    {
        float ts = Time.deltaTime;
        //Debug.Log("TestScript::OnUpdate");
    }
}