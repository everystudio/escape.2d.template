using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    public static T Instance;
    public virtual void Initialize() { }
    private void Awake()
    {
        Debug.Log("SingletonAwake");
        if (Instance == null)
        {
            System.Type type = typeof(T);
            Instance = GameObject.FindObjectOfType(type) as T;
            Initialize();
        }
        else
        {
            if (Instance != this)
            {
                Destroy(gameObject);
            }
        }
        //DontDestroyOnLoad(gameObject);
    }
}
