using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterialColor : MonoBehaviour
{
    public Material playerMaterial;
    public Color red;
    public Color blue;
    public Color green;
    public Color yellow;
    public Color orange;
    public Color pink;
    public Color black;
    public Color white;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setMaterialRed(){
        playerMaterial.SetColor("_Color", red);
    }
    public void setMaterialBlue(){
        playerMaterial.SetColor("_Color", blue);
    }
    public void setMaterialGreen(){
        playerMaterial.SetColor("_Color", green);
    }
    public void setMaterialYellow(){
        playerMaterial.SetColor("_Color", yellow);
    }
    public void setMaterialOrange(){
        playerMaterial.SetColor("_Color", orange);
    }
    public void setMaterialPink(){
        playerMaterial.SetColor("_Color", pink);
    }
    public void setMaterialBlack(){
        playerMaterial.SetColor("_Color", black);
    }
    public void setMaterialWhite(){
        playerMaterial.SetColor("_Color", white);
    }

}
