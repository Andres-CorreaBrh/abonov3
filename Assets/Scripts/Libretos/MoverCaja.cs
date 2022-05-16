using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoverCaja : MonoBehaviour
{
    private Vector3 posicionbandeja1;

    private Vector3 posicionbandeja2;

    private Vector3 posicionbandeja3;
     private Vector3 posicionbandeja4;

    public Transform particulas;

    private ParticleSystem sistemaParticulasAbono;

    private Vector3 posicionbascula;

    public GameObject bandeja1;

    public GameObject bandeja2;

    public GameObject bandeja3;

    public GameObject bandeja4;

    public Text letrero;

    public GameObject bascula;

    public GameObject AbonoCaja1;

    public GameObject AbonoCaja2;

    public GameObject AbonoCaja3;

    public GameObject AbonoCaja4;

    private string PesoEscogido = "100";

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

    public void calcularPeso(string interaccion, string numeroCaja)
    {
        Debug.Log("entro  mover caja");
        visualizarPeso (PesoEscogido, interaccion, numeroCaja);
    }

    public void moverCaja(string valor, string lugar)
    {
        if (valor == "1")
        {
            StartCoroutine(MovimientoCaja1(lugar));
        }
        else if (valor == "2")
        {
            StartCoroutine(MovimientoCaja2(lugar));
        }
        else if (valor == "3")
        {
            StartCoroutine(MovimientoCaja3(lugar));
        }
        else if (valor == "4")
        {
            //StartCoroutine(MovimientoCaja4(lugar));
        }
        else
        {
            Debug.Log("No entro");
        }
    }

    public IEnumerator MovimientoCaja1(string lugar)
    {
        if (lugar == "Tolva")
        {
            posicionbascula = bascula.transform.position;

            for (; ; )
            {
                posicionbandeja1 = bandeja1.transform.position;
                if (posicionbandeja1.x < 7.8)
                {
                    yield return null;
                }
                else
                {
                    bandeja1.transform.position =
                        new Vector3(posicionbandeja1.x - 0.1f,
                            posicionbandeja1.y,
                            posicionbandeja1.z);
                    Debug.Log(posicionbandeja1.x);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        }
        else if (lugar == "bascula")
        {
            posicionbascula = bascula.transform.position;

            for (; ; )
            {
                posicionbandeja1 = bandeja1.transform.position;
                if (posicionbandeja1.x < -2.1f)
                {
                    yield return null;
                }
                else
                {
                    bandeja1.transform.position =
                        new Vector3(posicionbandeja1.x - 0.1f,
                            posicionbandeja1.y,
                            posicionbandeja1.z);
                    Debug.Log(posicionbandeja1.x);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        }
        else if (lugar == "quimicos")
        {
            posicionbascula = bascula.transform.position;

            for (; ; )
            {
                posicionbandeja1 = bandeja1.transform.position;
                if (posicionbandeja1.x < -6.03)
                {
                    yield return null;
                }
                else
                {
                    bandeja1.transform.position =
                        new Vector3(posicionbandeja1.x - 0.1f,
                            posicionbandeja1.y,
                            posicionbandeja1.z);
                    Debug.Log(posicionbandeja1.x);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        }
        else if (lugar == "revolver")
        {
            var i = 0;
            Debug.Log("Entro");
            for (; ; )
            {
                if (i == 1)
                {
                    yield return null;
                }
                else
                {
                    bandeja1.transform.position =
                        new Vector3(posicionbandeja1.x,
                            posicionbandeja1.y,
                            posicionbandeja1.z - 0.1f);

                    yield return new WaitForSecondsRealtime(0.09f);
                    bandeja1.transform.position =
                        new Vector3(posicionbandeja1.x,
                            posicionbandeja1.y,
                            posicionbandeja1.z + 0.1f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    bandeja1.transform.position =
                        new Vector3(posicionbandeja1.x,
                            posicionbandeja1.y,
                            posicionbandeja1.z - 0.1f);
                    yield return new WaitForSecondsRealtime(0.09f);
                    bandeja1.transform.position =
                        new Vector3(posicionbandeja1.x,
                            posicionbandeja1.y,
                            posicionbandeja1.z + 0.1f);
                    i = 1;
                }
            }
        }
        else if (lugar == "secado")
        {
            posicionbascula = bascula.transform.position;

            for (; ; )
            {
                posicionbandeja1 = bandeja1.transform.position;
                if (posicionbandeja1.x < -15.06)
                {
                    yield return null;
                }
                else
                {
                    bandeja1.transform.position =
                        new Vector3(posicionbandeja1.x - 0.1f,
                            posicionbandeja1.y,
                            posicionbandeja1.z);
                    Debug.Log(posicionbandeja1.x);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        }
        else if (lugar == "contenedor")
        {
            posicionbascula = bascula.transform.position;

            for (; ; )
            {
                posicionbandeja1 = bandeja1.transform.position;
                if (posicionbandeja1.y > 0.84f)
                {
                    if (posicionbandeja1.x < -17.06)
                    {
                        bandeja1.transform.localRotation = Quaternion.Euler(-30.98f,0,0); 
                        Destroy(gameObject, 0.5f);
                        yield return null;
                    }
                    else
                    {
                        bandeja1.transform.position =
                            new Vector3(posicionbandeja1.x - 0.1f,
                                posicionbandeja1.y,
                                posicionbandeja1.z);
                        Debug.Log(posicionbandeja1.x);
                        yield return new WaitForSecondsRealtime(0.1f);
                        
                    }
                }
                else
                {
                    bandeja1.transform.position =
                        new Vector3(posicionbandeja1.x,
                            posicionbandeja1.y + 0.1f,
                            posicionbandeja1.z);
                    Debug.Log(posicionbandeja1.y);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        }
    }

    public IEnumerator MovimientoCaja2(string lugar)
    {
        if (lugar == "Tolva")
        {
            posicionbascula = bascula.transform.position;

            for (; ; )
            {
                posicionbandeja2 = bandeja2.transform.position;
                if (posicionbandeja2.z > 62.5)
                {
                    yield return null;
                }
                else
                {
                    bandeja2.transform.position =
                        new Vector3(posicionbandeja2.x,
                            posicionbandeja2.y,
                            posicionbandeja2.z + 0.1f);

                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        }
        else if (lugar == "bascula")
        {
            posicionbascula = bascula.transform.position;

            for (; ; )
            {
                posicionbandeja2 = bandeja2.transform.position;
                if (posicionbandeja2.z > 72.5)
                {
                    yield return null;
                }
                else
                {
                    bandeja2.transform.position =
                        new Vector3(posicionbandeja2.x,
                            posicionbandeja2.y,
                            posicionbandeja2.z + 0.1f);

                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        }
    }

    public IEnumerator MovimientoCaja3(string lugar)
    {
        posicionbascula = bascula.transform.position;

        for (; ; )
        {
            posicionbandeja3 = bandeja1.transform.position;
            if (posicionbandeja3.z > 62.5)
            {
                yield return null;
            }
            else
            {
                bandeja1.transform.position =
                    new Vector3(posicionbandeja3.x,
                        posicionbandeja3.y,
                        posicionbandeja3.z + 0.1f);

                yield return new WaitForSecondsRealtime(0.1f);
            }
        }
    }

    public void caerAbonoTolva()
    {
        sistemaParticulasAbono.Play();
    }

    public void DetenerCaidaAbono()
    {
        sistemaParticulasAbono.Stop();
    }

    public void visualizarPeso(
        string peso,
        string iteraccion,
        string numeroCaja
    )
    {
        Debug.Log("entro  metodo");
        if (numeroCaja == "1")
        {
            Debug.Log("entro numero caja 1");
            if (peso == "10")
            {
                if (iteraccion == "1")
                {
                    Debug.Log("entro  iteracion 1 peso 10");
                    letrero.text = "8,000";
                }
                else if (iteraccion == "2")
                {
                    Debug.Log("entro  iteracion 2 peso 10");
                    letrero.text = "6,000";
                }
                else if (iteraccion == "3")
                {
                    Debug.Log("entro  iteracion 3 peso 10");
                    letrero.text = "5,000";
                }
            }
            else if (peso == "100")
            {
                if (iteraccion == "1")
                {
                    letrero.text = "75,000";
                }
                else if (iteraccion == "2")
                {
                    letrero.text = "65,000";
                }
                else if (iteraccion == "3")
                {
                    letrero.text = "50,000";
                }
            }
            else if (peso == "1000")
            {
                if (iteraccion == "1")
                {
                    letrero.text = "900,000";
                }
                else if (iteraccion == "2")
                {
                    letrero.text = "765,000";
                }
                else if (iteraccion == "3")
                {
                    letrero.text = "500,000";
                }
            }
        }
        else if (numeroCaja == "2")
        {
            if (peso == "10")
            {
                if (iteraccion == "1")
                {
                    letrero.text = "4,500";
                }
                else if (iteraccion == "2")
                {
                    letrero.text = "4,000";
                }
                else if (iteraccion == "3")
                {
                    letrero.text = "3,000";
                }
            }
            else if (peso == "100")
            {
                if (iteraccion == "1")
                {
                    letrero.text = "40,000";
                }
                else if (iteraccion == "2")
                {
                    letrero.text = "35,000";
                }
                else if (iteraccion == "3")
                {
                    letrero.text = "30,000";
                }
            }
            else if (peso == "1000")
            {
                if (iteraccion == "1")
                {
                    letrero.text = "433,000";
                }
                else if (iteraccion == "2")
                {
                    letrero.text = "395,000";
                }
                else if (iteraccion == "3")
                {
                    letrero.text = "300,000";
                }
            }
        }
        else if (numeroCaja == "3")
        {
            if (peso == "10")
            {
                if (iteraccion == "1")
                {
                    letrero.text = "3,500";
                }
                else if (iteraccion == "2")
                {
                    letrero.text = "3,000";
                }
                else if (iteraccion == "3")
                {
                    letrero.text = "2,000";
                }
            }
            else if (peso == "100")
            {
                if (iteraccion == "1")
                {
                    letrero.text = "29,000";
                }
                else if (iteraccion == "2")
                {
                    letrero.text = "25,000";
                }
                else if (iteraccion == "3")
                {
                    letrero.text = "20,000";
                }
            }
            else if (peso == "1000")
            {
                if (iteraccion == "1")
                {
                    letrero.text = "300,000";
                }
                else if (iteraccion == "2")
                {
                    letrero.text = "250,000";
                }
                else if (iteraccion == "3")
                {
                    letrero.text = "200,000";
                }
            }
        }
    }

    public void activarAbono(string numeroCaja)
    {
        if (numeroCaja == "1")
        {
            AbonoCaja1.SetActive(true);
        }
        else if (numeroCaja == "2")
        {
            AbonoCaja2.SetActive(true);
        }
        else if (numeroCaja == "3")
        {
            AbonoCaja3.SetActive(true);
        }
        else if (numeroCaja == "4")
        {
            AbonoCaja4.SetActive(true);
        }
        
    }

    public void eliminarCaja(string numeroCaja)
    {
         if (numeroCaja == "1")
        {
            Destroy(bandeja1);
        }
        else if (numeroCaja == "2")
        {
            Destroy(bandeja2);
        }
        else if (numeroCaja == "3")
        {
            Destroy(bandeja3);
        }
    }
   
    
}
