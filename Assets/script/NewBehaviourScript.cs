using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject targetObject; // Etraf�nda d�nmek istedi�imiz obje
    public float selfRotationSpeed = 60f; // Nesnenin kendi etraf�nda d�nme h�z�
    public float orbitSpeed = 20f; // Nesnenin etraf�nda d�nme h�z�

    void Update()
    {
        // Nesneyi her frame'de kendi etraf�nda y ekseninde belirtilen h�zda d�nd�r
        transform.Rotate(Vector3.up, selfRotationSpeed * Time.deltaTime);

        // Nesneyi her frame'de y ekseninde belirtilen h�zda ve belirledi�imiz obje etraf�nda d�nd�r
        if (targetObject != null)
        {
            transform.RotateAround(targetObject.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
        }
    }
}



