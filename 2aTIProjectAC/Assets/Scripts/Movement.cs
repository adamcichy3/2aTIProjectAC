using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] float vectorX ;
    [SerializeField] float vectorY = 0;
    [SerializeField] float vectorZ;
    [SerializeField] float speed = 10;

    // Stworzyc zmienna serializowana typu float o nazwie np. speed 
    // Niech zmienna speed okresla jak szybko porusza sie kostka (nalezy jej uzyc w dzialaniu w update)
    // mail adamzdzcichy@gmail.com  temat: Gra - zmienna Speed - imie, nazwisko, klasa
    void Start()
    {
        
    }

    
    void Update()
    {
        vectorX = Input.GetAxis("Horizontal");
        vectorZ = Input.GetAxis("Vertical");
        transform.Translate(vectorX * Time.deltaTime*speed, vectorY, vectorZ * Time.deltaTime * speed);
    }

}
