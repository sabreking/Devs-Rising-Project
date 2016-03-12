using UnityEngine;
using System.Collections;

/// <summary>
/// Persistant Version of the Singleton Class.V1.0
/// </summary>
/// <typeparam name="T">Pass the name of this class so a proper typed static instance is created</typeparam>
public class UnitySingletonPersistent<T> : MonoBehaviour
where T : Component
{
    private static T _instance;
    public static T Instance
    {
        get
        {
            if ( _instance == null )
            {
                _instance = FindObjectOfType<T> ();
                if ( _instance == null )
                {
                    GameObject obj = new GameObject ();
                    obj.hideFlags = HideFlags.HideAndDontSave;
                    _instance = obj.AddComponent<T> ();
                }
            }
            return _instance;
        }
    }

    public virtual void Awake ()
    {
        DontDestroyOnLoad (this.gameObject);
        if ( _instance == null )
        {
            _instance = this as T;
        }
        else
        {
            Destroy (gameObject);
        }
    }
}