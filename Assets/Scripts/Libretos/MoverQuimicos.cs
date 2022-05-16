using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoverQuimicos : MonoBehaviour
{
       public GameObject quimicoA;
       public GameObject quimicoB;
       public GameObject quimicoC;
        private ParticleSystem sistemaParticulasQuimico;
        public Transform particulasQuimico;
        public bool detener=false;
    // Start is called before the first frame update
    void Start()
    {
        sistemaParticulasQuimico = particulasQuimico.GetComponent<ParticleSystem>();
        sistemaParticulasQuimico.Stop();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void moverQuimico(string quimico)
    {
        if (quimico == "A")
        {
            StartCoroutine(MovimientoQuimicoA());
        }else if (quimico == "B")
        {
            StartCoroutine(MovimientoQuimicoB());
        }else if (quimico == "C")
        {
            StartCoroutine(MovimientoQuimicoC());
        }
       
    }
     public void destruirQuimico(string quimico)
    {
        if (quimico == "A")        {
            sistemaParticulasQuimico.Stop();             
            
             
        }
        if (quimico == "B")
        {
             sistemaParticulasQuimico.Stop();             
             
             
        }
        if (quimico == "C")
        {
             sistemaParticulasQuimico.Stop();             
                 
            
        }
        Destroy(gameObject, 0.5f);
    }
    public IEnumerator MovimientoQuimicoA(){  

            for (; ; )
            {                 
                var posicionQuimicoA = quimicoA.transform.position;
                if (posicionQuimicoA.x > -9.58)
                {
                   quimicoA.transform.localRotation = Quaternion.Euler(90, 90f, -90);  
                    sistemaParticulasQuimico.Play();                                   
                    yield return null;
                }
                else
                {
                    quimicoA.transform.position =
                        new Vector3(posicionQuimicoA.x + 0.1f,
                            posicionQuimicoA.y,
                            posicionQuimicoA.z);
                    Debug.Log(posicionQuimicoA.x);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
    }
    public IEnumerator MovimientoQuimicoB(){           
            
            for (; ; )
            {                 
                var posicionQuimicoB = quimicoB.transform.position;
                if (posicionQuimicoB.x > -9.58)
                {
                   quimicoB.transform.localRotation = Quaternion.Euler(90, 90f, -90);  
                    sistemaParticulasQuimico.Play();                                                   
                    
                    yield return null;
                }
                else
                {
                    quimicoB.transform.position =
                        new Vector3(posicionQuimicoB.x + 0.1f,
                            posicionQuimicoB.y,
                            posicionQuimicoB.z);
                    Debug.Log(posicionQuimicoB.x);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        
    }
    public IEnumerator MovimientoQuimicoC(){     
         
            
            for (; ; )
            {                 
                var posicionQuimicoC = quimicoC.transform.position;
                if (posicionQuimicoC.x > -9.58)
                {
                   quimicoC.transform.localRotation = Quaternion.Euler(90, 90f, -90);  
                    sistemaParticulasQuimico.Play(); 
                    yield return new WaitForSecondsRealtime(2f);                                  
                    sistemaParticulasQuimico.Stop(); 
                    yield return null;
                }
                else
                {
                    quimicoC.transform.position =
                        new Vector3(posicionQuimicoC.x + 0.1f,
                            posicionQuimicoC.y,
                            posicionQuimicoC.z);
                    Debug.Log(posicionQuimicoC.x);
                    yield return new WaitForSecondsRealtime(0.1f);
                }
            }
        
    }
   
    
}
