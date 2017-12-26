using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour {

    public static GameControl entity;

    public int borderSize = 1;
    public int fillPercentage = 45;
    public int smoothLevel = 4;
    public bool randomSeed = true;
    public string seed = "vladyslav";

	void Awake () {
        if (entity == null)
        {
            DontDestroyOnLoad(gameObject);
            entity = this;
        }
        else if (entity != this)
        {
            Destroy(gameObject);
        }
       
	}
	
	void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 120, 20), "Fill Percentage: " + fillPercentage);

        if (GUI.Button(new Rect(130, 10, 20, 20), "+"))
        {
            fillPercentage++;
            if (fillPercentage < 2)
                fillPercentage = 2;
            if (fillPercentage > 98)
                fillPercentage = 98;
        }

        if (GUI.Button(new Rect(150, 10, 20, 20), "-"))
        {
            fillPercentage--;
            if (fillPercentage < 2)
                fillPercentage = 2;
            if (fillPercentage > 98)
                fillPercentage = 98;
        }

        GUI.Label(new Rect(10, 30, 100, 20), "Border size: " + borderSize);

        if (GUI.Button(new Rect(110, 30, 20, 20), "+"))
        {
            if (borderSize <= 40)
                borderSize += 2;

        }

        if (GUI.Button(new Rect(130, 30, 20, 20), "-"))
        {
            if (borderSize >= 3)
                borderSize -= 2;
        }

        GUI.Label(new Rect(210, 10, 50, 20), "Seed: ");
        seed = GUI.TextArea(new Rect(270, 10, 100, 20), seed, 15);
        GUI.Label(new Rect(210, 30, 120, 20), "Random seed: " + randomSeed);
        if (GUI.Button(new Rect(330, 30, 30, 20), "On"))
        {
            randomSeed = true;

        }

        if (GUI.Button(new Rect(360, 30, 30, 20), "Off"))
        {
            randomSeed = false;
        }




    }
}
