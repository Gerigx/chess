using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGen : MonoBehaviour
{
    
    [SerializeField] GameObject white, black;

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
                        Debug.Log("Counter: " + counter + " Buchstabe: " + sAlpha[j] + " Spalte: " + i + " Kontrolle: " + j );
                    white.name = sAlpha[j] + i;
                    Instantiate(white, new Vector2(i,j), Quaternion.identity);  
                    

                    counter ++;
                    //Debug.Log(counter + " " + sAlpha[j] + "" + i);

                    }else if(i%2!=0)
                    {
                        Debug.Log("Counter: " + counter + " Buchstabe: " + sAlpha[j] + " Spalte: " + i + "Kontrolle: " + j );
                        black.name = sAlpha[j] + i;
                        Instantiate(black, new Vector2(i,j), Quaternion.identity);
                        

                                            counter ++;
                   //Debug.Log(counter + " " + sAlpha[j] + "" + i);;
                    }            
                }
            }else if(j%2!=0)
            {
                for (int i = 0; i < 8; i++)
                {
                    
                     if(i%2!=0)
                    {
                        Debug.Log("Counter: " + counter + " Buchstabe: " + sAlpha[j] + " Spalte: " + i + "Kontrolle: " + j );
                        white.name = sAlpha[j] + i;
                        Instantiate(white, new Vector2(i,j), Quaternion.identity);
                        
                    counter ++;
                    //Debug.Log(counter + " " + sAlpha[j] + "" + i);

                    }else if(i%2==0)
                    {
                        Debug.Log("Counter: " + counter + " Buchstabe: " + sAlpha[j] + " Spalte: " + i + "Kontrolle: " + j );
                    black.name = sAlpha[j] + i;
                    Instantiate(black, new Vector2(i,j), Quaternion.identity);  
                    
                    counter ++;
                    //Debug.Log(counter + " " + sAlpha[j] + "" + i);

                    }
                    
           
                }
            }

        }


    }
}
