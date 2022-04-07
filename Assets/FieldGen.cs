using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGen : MonoBehaviour
{
    
    [SerializeField] GameObject white, black, Pawn;

    string[] sAlpha = new string[8] { "A", "B", "C", "D", "E", "F", "G", "H"};

    int counter;
    
    // Start is called before the first frame update
    void Start()
    {


        Generation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Generation()
    {        
        for(int j = 0; j < 8; j++)
        {
            if(j%2==0)
            {
                for (int i = 0; i < 8; i++)
                {
                    if(i%2==0)
                    {                     
                    white.name = sAlpha[j] + i;
                    Instantiate(white, new Vector2(i,j), Quaternion.identity);                  
                    }else if(i%2!=0)
                    {                        
                        black.name = sAlpha[j] + i;
                        Instantiate(black, new Vector2(i,j), Quaternion.identity);                   
                    }            
                }
            }else if(j%2!=0)
            {
                for (int i = 0; i < 8; i++)
                {                    
                     if(i%2!=0)
                    {
                        white.name = sAlpha[j] + i;
                        Instantiate(white, new Vector2(i,j), Quaternion.identity);
                    }else if(i%2==0)
                    { 
                        black.name = sAlpha[j] + i;
                        Instantiate(black, new Vector2(i,j), Quaternion.identity);
                    }                  
                }
            }
        }

        for(int j = 0; j < 8; j++)
        {

            if(j==1||j==6)
            {
                for(int i = 0; i < 8; i++)
                {                
                    Instantiate(Pawn, new Vector2(i,j), Quaternion.identity);   
                }
            }

        }


    }
}
