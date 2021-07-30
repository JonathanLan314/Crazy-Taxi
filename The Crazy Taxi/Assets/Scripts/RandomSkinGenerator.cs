using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSkinGenerator : MonoBehaviour
{

    float rand;
    public SkinnedMeshRenderer BusinessManShirt;
    public SkinnedMeshRenderer BusinessManSuit;
    public SkinnedMeshRenderer BusinessWoman;
    public SkinnedMeshRenderer WomanCoat;
    public SkinnedMeshRenderer WomanJacket;
    public SkinnedMeshRenderer ManHoodie;
    public SkinnedMeshRenderer ManJacket;

    public SkinnedMeshRenderer RagdollBusinessManShirt;
    public SkinnedMeshRenderer RagdollBusinessManSuit;
    public SkinnedMeshRenderer RagdollBusinessWoman;
    public SkinnedMeshRenderer RagdollWomanCoat;
    public SkinnedMeshRenderer RagdollWomanJacket;
    public SkinnedMeshRenderer RagdollManHoodie;
    public SkinnedMeshRenderer RagdollManJacket;

    public bool character1;
    public bool character2;
    public bool character3;
    public bool character4;
    public bool character5;
    public bool character6;
    public bool character7;

    void Start()
    {
        RagdollBusinessManShirt.enabled = false;
        RagdollBusinessManSuit.enabled = false;
        RagdollBusinessWoman.enabled = false;
        RagdollWomanCoat.enabled = false;
        RagdollWomanJacket.enabled = false;
        RagdollManHoodie.enabled = false;
        RagdollManJacket.enabled = false;

        rand = Random.Range(1, 7);

        if (rand == 1)
        {
            BusinessManShirt.enabled = true;
            BusinessManSuit.enabled = false;
            BusinessWoman.enabled = false;
            WomanCoat.enabled = false;
            WomanJacket.enabled = false;
            ManHoodie.enabled = false;
            ManJacket.enabled = false;
            character1 = true;
        }

        if (rand == 2)
        {
            BusinessManShirt.enabled = false;
            BusinessManSuit.enabled = true;
            BusinessWoman.enabled = false;
            WomanCoat.enabled = false;
            WomanJacket.enabled = false;
            ManHoodie.enabled = false;
            ManJacket.enabled = false;
            character2 = true;
        }

        if (rand == 3)
        {
            BusinessManShirt.enabled = false;
            BusinessManSuit.enabled = false;
            BusinessWoman.enabled = true;
            WomanCoat.enabled = false;
            WomanJacket.enabled = false;
            ManHoodie.enabled = false;
            ManJacket.enabled = false;
            character3 = true;
        }

        if (rand == 4)
        {
            BusinessManShirt.enabled = false;
            BusinessManSuit.enabled = false;
            BusinessWoman.enabled = false;
            WomanCoat.enabled = true;
            WomanJacket.enabled = false;
            ManHoodie.enabled = false;
            ManJacket.enabled = false;
            character4 = true;
        }

        if (rand == 5)
        {
            BusinessManShirt.enabled = false;
            BusinessManSuit.enabled = false;
            BusinessWoman.enabled = false;
            WomanCoat.enabled = false;
            WomanJacket.enabled = true;
            ManHoodie.enabled = false;
            ManJacket.enabled = false;
            character5 = true;
        }

        if (rand == 6)
        {
            BusinessManShirt.enabled = false;
            BusinessManSuit.enabled = false;
            BusinessWoman.enabled = false;
            WomanCoat.enabled = false;
            WomanJacket.enabled = false;
            ManHoodie.enabled = true;
            ManJacket.enabled = false;
            character6 = true;
        }

        if (rand == 7)
        {
            BusinessManShirt.enabled = false;
            BusinessManSuit.enabled = false;
            BusinessWoman.enabled = false;
            WomanCoat.enabled = false;
            WomanJacket.enabled = false;
            ManHoodie.enabled = false;
            ManJacket.enabled = true;
            character7 = true;
        }
    }

    void Update()
    {
        
        if (rand == 1)
        {
            RagdollBusinessManShirt.enabled = true;
        }

        if (rand == 2)
        {
            RagdollBusinessManSuit.enabled = true;
        }

        if (rand == 3)
        {
            RagdollBusinessWoman.enabled = true;
        }

        if (rand == 4)
        {
            RagdollWomanCoat.enabled = true;
        }

        if (rand == 5)
        {
            RagdollWomanJacket.enabled = true;
        }

        if (rand == 6)
        {
            RagdollManHoodie.enabled = true;
        }

        if (rand == 7)
        {
            RagdollManJacket.enabled = true;
        }
    }
}
