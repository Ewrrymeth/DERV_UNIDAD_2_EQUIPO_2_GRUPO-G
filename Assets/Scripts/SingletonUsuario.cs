using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonUsuario : MonoBehaviour
{


    public static SingletonUsuario instancia;
    public int vida = 100;
    public int ataque = 50;



    private void Awake()
    {
        if (instancia == null)
        {
            instancia = this;
        }
        else
        {
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
