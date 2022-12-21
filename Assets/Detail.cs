using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character
{
    public string name { get; set; }
    public Character(string name)
    {
        this.name = name;
        Debug.Log("The Player Name is : " + name);
    }
}
public class Detail : MonoBehaviour
{
    Character character;
    // Start is called before the first frame update
    void Start()
    {
       character = new Character("ZadKieL");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
