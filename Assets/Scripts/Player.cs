using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Range(0,20)]
   [SerializeField]
    [Tooltip("velocidad actual del coche")]
    private float speed=5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mover el vehiculo
        //this.transform.Translate(0,0,1);
        //this.transform.Translate(Vector3.forward);// es lo mismo que (0,0,1)
        //para mover un auto nesesitamos la formula de 
        //espacio = velocidad * tiempo
        // espacio = espacio antiguo + v*t*(direcion(delante o atras))
        //delta time es la cantidad de tiempo que ha pasado 
       // this.transform.Translate(10*Time.deltaTime*Vector3.forward);
       this.transform.Translate(speed*Time.deltaTime*Vector3.forward);
    }  
}
