using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float velocidad = 0f;
    public GameObject obj1;
    public GameObject obj2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mh = Input.GetAxis("Horizontal");
        float mv = Input.GetAxis("Vertical");

        float s = Input.GetAxis("Jump");

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            s = -10;
        }

        Vector3 movimiento = new Vector3(mh, s, mv);

        transform.Translate(movimiento * velocidad * Time.deltaTime);

        
        //Objeto Cubo
        if (Input.GetKeyDown(KeyCode.P))
        {
            Instantiate(obj1, transform.position + transform.forward, Quaternion.identity);
        }

        //Objeto bala
        if (Input.GetKeyDown(KeyCode.RightControl))
        {
            var objBala = Instantiate(obj2, transform.position + transform.forward * 2, Quaternion.identity);

            objBala.GetComponent<moverBala>().Inicializar(transform.forward );

            Destroy(objBala, 10);

        }

       

    }
    
}