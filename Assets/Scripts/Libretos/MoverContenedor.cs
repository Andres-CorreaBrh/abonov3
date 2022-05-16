using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverContenedor : MonoBehaviour
{
    private Vector3 posicionContenedor;
    public GameObject contenedor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoverCont()
    {      
    StartCoroutine(MovimientoContenedor());
    }
       
    public IEnumerator MovimientoContenedor()
    {
        for (; ; )
            {
                posicionContenedor = contenedor.transform.position;
                if (posicionContenedor.y > 3.85f)
                {
                    if (posicionContenedor.x < -15.06)
                    {
                        //contenedor.transform.localRotation = Quaternion.Euler(-30.98f,0,0); 
                         Destroy(gameObject, 0.5f);
                        yield return null;
                    }
                    else
                    {
                        contenedor.transform.position =
                            new Vector3(posicionContenedor.x - 0.1f,
                                posicionContenedor.y,
                                posicionContenedor.z);
                        Debug.Log(posicionContenedor.x);
                        yield return new WaitForSecondsRealtime(0.1f);
                        
                    }
                }
                else
                {
                    contenedor.transform.position =
                        new Vector3(posicionContenedor.x,
                            posicionContenedor.y + 0.1f,
                            posicionContenedor.z);
                    Debug.Log(posicionContenedor.y);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
    }
}
