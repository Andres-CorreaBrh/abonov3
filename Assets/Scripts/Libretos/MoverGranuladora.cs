using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverGranuladora : MonoBehaviour
{
    public Transform particulas;
    private ParticleSystem sistemaParticulasAbono;
    private Vector3 posicionGranuladora;
    public GameObject granuladora;
    // Start is called before the first frame update
    void Start()
    {
        sistemaParticulasAbono = particulas.GetComponent<ParticleSystem>();
        sistemaParticulasAbono.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void MoverGranu()
    {      
        StartCoroutine(MovimientoGranuladora());
    }
       
    public IEnumerator MovimientoGranuladora()
    {
       var i = 0;
        posicionGranuladora = granuladora.transform.position;
            for (; ; )
            {
                if (i == 1)
                {
                    yield return null;
                }
                else
                {
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z - 0.05f);

                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z - 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(2.0f);
                     granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z - 0.05f);

                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z - 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    granuladora.transform.position =
                        new Vector3(posicionGranuladora.x,
                            posicionGranuladora.y,
                            posicionGranuladora.z + 0.05f);
                    yield return new WaitForSecondsRealtime(2.0f);
                    sistemaParticulasAbono.Play();
                    yield return new WaitForSecondsRealtime(5.0f);
                    sistemaParticulasAbono.Stop();
                    i = 1;
                }
            }
    }
}
