using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public GameObject carPrefab;

    public string[] fases = { "Car 1", "Car 2", "Car 3" }; //Lista criada para randomização e apresentação no console

    public int speed = 20;
    public int gear = 5;

    public int TotalSpeed
    {
        get { return speed * gear; }
    }

    public void CreateCar()
    {
        var a = Instantiate(carPrefab);
        a.transform.position = Vector3.zero;

        Debug.Log(fases.GetRandom());
    }

    [UnityEditor.MenuItem("Ebac/CreateCar")]
    public static void CreateCarTest()
    {
        Car instancia = FindFirstObjectByType<Car>();
        instancia.CreateCar();
    }
}
