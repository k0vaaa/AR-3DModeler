using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BtnClicker : MonoBehaviour
{
    [SerializeField] GameObject meow;
    private GameObject meow1;
    public void Start()
    {

    }

    public void CreateSomething()
    {
        meow1 = GameObject.Find("NearMenu4x2");
        meow1.SetActive(false);
        Instantiate(meow);
    }

    public void DestroySomething()
    {
        Destroy(meow);
        meow1.SetActive(true);
    }


}
