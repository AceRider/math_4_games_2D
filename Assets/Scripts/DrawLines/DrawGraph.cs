﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawGraph : MonoBehaviour
{
    public int size = 20;
    public int xmax = 200;
    public int ymax = 200;

    Coords startPointXAxis;
    Coords endPointXAxis;

    Coords startPointYAxis;
    Coords endPointYAxis;

    // Start is called before the first frame update
    void Start()
    {
        startPointXAxis = new Coords(xmax, 0);
        endPointXAxis = new Coords(-xmax, 0);

        startPointYAxis = new Coords(0, ymax);
        endPointYAxis = new Coords(0, -ymax);

        // x axis
        Coords.DrawLine(startPointXAxis, endPointXAxis, 1, Color.red);
        // y axis
        Coords.DrawLine(startPointYAxis, endPointYAxis, 1, Color.green);

        int xoffset = (int)(xmax / (float)size);
        for (int x = -xoffset*size; x <= xoffset * size; x += size)
        {
            Coords.DrawLine(new Coords(x, -ymax), new Coords(x, ymax), 0.5f, Color.white);
        }

        int yoffset = (int)(ymax / (float)size);
        for (int y = -yoffset * size; y <= yoffset * size; y += size)
        {
            Coords.DrawLine(new Coords(-xmax, y), new Coords(xmax, y), 0.5f, Color.white);
        }
    }   
}
