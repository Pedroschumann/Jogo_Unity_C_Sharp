using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CriarPlataformas : MonoBehaviour{
    public int NovoY;
    public GameObject Spawn;
    public GameObject Plataformas;
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject PlataformaPrefab;
    public int sorteio;
    public int sorteio2;
    public GameObject DuplaPlataforma;
    void Start()
    {
        //sortear números de 1 a 5
        sorteio = Random.Range(1,6);
        //Gerar plataforma correspondente ao número sorteado
        if (sorteio == 1){
         
            Spawn.transform.position = new Vector2(-20f, Spawn.transform.position.y);
            PlataformaPrefab = Instantiate(Plataformas) as GameObject;
            PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, Spawn.transform.position.y);
         
            //regular o y do Spawn
            NovoY += 16;
         
            //definir esta plataforma como p2
            p2 = PlataformaPrefab;            
         
            //Spawn da próxima plataforma inicial 2

            Spawn.transform.position = new Vector2(-10f, Spawn.transform.position.y);
            PlataformaPrefab = Instantiate(Plataformas) as GameObject;
            PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
         
            //A próxima plataforma depois da p2 será chamada de p3
            p3 = PlataformaPrefab;
        }
        
        else if (sorteio == 2){
            
            Spawn.transform.position = new Vector2(-10f, Spawn.transform.position.y);
            PlataformaPrefab = Instantiate(Plataformas) as GameObject;
            PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, Spawn.transform.position.y);
            
            //regular o y do Spawn
            NovoY += 16;
            
            //definir esta plataforma como p2
            p2 = PlataformaPrefab;            
            
            //Condicionar o sorteador para as possíveis plataformas que serão geradas após a p2
            sorteio = Random.Range(1,3);
            
            if (sorteio == 1){
            
                Spawn.transform.position = new Vector2(-20f, Spawn.transform.position.y);
                PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
            
                //A próxima plataforma depois da p2 será chamada de p3
                p3 = PlataformaPrefab;
            }
            
            else if(sorteio == 2){
            
                Spawn.transform.position = new Vector2(0f, Spawn.transform.position.y);
                PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
            
                //A próxima plataforma depois da p2 será chamada de p3
                p3 = PlataformaPrefab;
            }
        }

        else if (sorteio == 3){
            
            Spawn.transform.position = new Vector2(0f, Spawn.transform.position.y);
            PlataformaPrefab = Instantiate(Plataformas) as GameObject;
            PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, Spawn.transform.position.y);
            
            //regular o y do Spawn
            NovoY += 16;
            
            //definir esta plataforma como p2
            p2 = PlataformaPrefab;            
            
            //Condicionar o sorteador para as possíveis plataformas que serão geradas após a p2
            sorteio = Random.Range(1,3);
            
            if (sorteio == 1){
            
                Spawn.transform.position = new Vector2(-10f, Spawn.transform.position.y);
                PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
            
                //A próxima plataforma depois da p2 será chamada de p3
                p3 = PlataformaPrefab;
            }
            
            else if(sorteio == 2){
            
                Spawn.transform.position = new Vector2(10f, Spawn.transform.position.y);
                PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
            
                //A próxima plataforma depois da p2 será chamada de p3
                p3 = PlataformaPrefab;
            }
        }

        else if (sorteio == 4){
            
            Spawn.transform.position = new Vector2(10f, Spawn.transform.position.y);
            PlataformaPrefab = Instantiate(Plataformas) as GameObject;
            PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, Spawn.transform.position.y);
            
            //regular o y do Spawn
            NovoY += 16;
            
            //definir esta plataforma como p2
            p2 = PlataformaPrefab;            
            
            //Condicionar o sorteador para as possíveis plataformas que serão geradas após a p2
            sorteio = Random.Range(1,3);
            
            if (sorteio == 1){
                Spawn.transform.position = new Vector2(0f, Spawn.transform.position.y);
                PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
            
                //A próxima plataforma depois da p2 será chamada de p3
                p3 = PlataformaPrefab;
            }
            
            else if(sorteio == 2){
                Spawn.transform.position = new Vector2(20f, Spawn.transform.position.y);
                PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
            
                //A próxima plataforma depois da p2 será chamada de p3
                p3 = PlataformaPrefab;
            }
        }

        if (sorteio == 5){
            
            Spawn.transform.position = new Vector2(20f, Spawn.transform.position.y);
            PlataformaPrefab = Instantiate(Plataformas) as GameObject;
            PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, Spawn.transform.position.y);
            
            //regular o y do Spawn
            NovoY += 16;
            
            //Definir esta plataforma como p2
            p2 = PlataformaPrefab;            
            
            //Criar a plataforma inicial 2    
            Spawn.transform.position = new Vector2(10f, Spawn.transform.position.y);
            PlataformaPrefab = Instantiate(Plataformas) as GameObject;
            PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
            
            //A próxima plataforma depois da p2 será chamada de p3
            p3 = PlataformaPrefab;
        }
    }
    void Update()
    {
        //Quando pisar no chão da plataforma p2. 
        if (Player.colidiu){
            Player.colidiu = false;
            
            //p1 antiga é destruída 
            NovoY += 8;
            Destroy (p1.gameObject);

            //A p2 se torna p1 e p3 se torna p2
            p1 = p2;
            p2 = p3;

            sorteio2 = Random.Range(1,3);
            if (sorteio2 == 1){
                //Observar qual é o x da plataforma 2 para definir a próxima plataforma
                if (p2.transform.position.x == -20f){
        
                    //Condicionar o sorteador para as possíveis plataformas que serão geradas após a p2
                    Spawn.transform.position = new Vector2(-10f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
    
                    //A próxima plataforma depois da p2 será chamada de p3
                    p3 = PlataformaPrefab;
                }
    
                else if (p2.transform.position.x == -10f){
    
                    //Condicionar o sorteador para as possíveis plataformas que serão geradas após a p2
                    sorteio = Random.Range(1,3);
    
                    if (sorteio == 1){
    
                        Spawn.transform.position = new Vector2(-20f, Spawn.transform.position.y);
                        PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                        PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
    
                        //A próxima plataforma depois da p2 será chamada de p3
                        p3 = PlataformaPrefab;
                    }
    
                    else if (sorteio == 2){
                        Spawn.transform.position = new Vector2(0f, Spawn.transform.position.y);
                        PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                        PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
    
                        //A próxima plataforma depois da p2 será chamada de p3
                        p3 = PlataformaPrefab;
                    }
                }
    
                else if (p2.transform.position.x == 0f){
    
                    //Condicionar o sorteador para as possíveis plataformas que serão geradas após a p2
                    sorteio = Random.Range(1,3);
    
                    if (sorteio == 1){
    
                        Spawn.transform.position = new Vector2(-10f, Spawn.transform.position.y);
                        PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                        PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
    
                        //A próxima plataforma depois da p2 será chamada de p3
                        p3 = PlataformaPrefab;
                    }
    
                    else if (sorteio == 2){
    
                        Spawn.transform.position = new Vector2(10f, Spawn.transform.position.y);
                        PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                        PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
    
                        //A próxima plataforma depois da p2 será chamada de p3
                        p3 = PlataformaPrefab;
                    }
                }
    
                else if (p2.transform.position.x == 10f){
                    
                    //Condicionar o sorteador para as possíveis plataformas que serão geradas após a p2
                    sorteio = Random.Range(1,3);
                    
                    if (sorteio == 1){
                    
                        Spawn.transform.position = new Vector2(0f, Spawn.transform.position.y);
                        PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                        PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
                    
                        //A próxima plataforma depois da p2 será chamada de p3
                        p3 = PlataformaPrefab;
                    }
                    
                    else if (sorteio == 2){
                    
                        Spawn.transform.position = new Vector2(20f, Spawn.transform.position.y);
                        PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                        PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
                    
                        //A próxima plataforma depois da p2 será chamada de p3
                        p3 = PlataformaPrefab;
                    }
                }
    
                else if (p2.transform.position.x == 20f){
                    
                    //Condicionar o sorteador para as possíveis plataformas que serão geradas após a p2
                    Spawn.transform.position = new Vector2(10f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
                        
                    //A próxima plataforma depois da p2 será chamada de p3
                    p3 = PlataformaPrefab;
                }
            }
            else if (sorteio2 == 2){

                if (p2.transform.position.x == -10f){
                    
                    //Condicionar o sorteador para as possíveis plataformas que serão geradas após a p2
                    Spawn.transform.position = new Vector2(-20f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(DuplaPlataforma) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
    
                    Spawn.transform.position = new Vector2(0f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(DuplaPlataforma) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
                    
                    NovoY += 8;

                    Spawn.transform.position = new Vector2(-10f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
                    //A próxima plataforma depois da p2 será chamada de p3
                    p3 = PlataformaPrefab;
                }
    
                else if (p2.transform.position.x == 0f){

                    Spawn.transform.position = new Vector2(-10f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(DuplaPlataforma) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
    
                    Spawn.transform.position = new Vector2(10f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(DuplaPlataforma) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
                    
                    NovoY += 8;

                    Spawn.transform.position = new Vector2(0f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
                    //A próxima plataforma depois da p2 será chamada de p3
                    p3 = PlataformaPrefab;
                }
                else if (p2.transform.position.x == 10f){

                    Spawn.transform.position = new Vector2(0f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(DuplaPlataforma) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
    
                    Spawn.transform.position = new Vector2(20f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(DuplaPlataforma) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
                    
                    NovoY += 8;

                    Spawn.transform.position = new Vector2(10f, Spawn.transform.position.y);
                    PlataformaPrefab = Instantiate(Plataformas) as GameObject;
                    PlataformaPrefab.transform.position = new Vector2(Spawn.transform.position.x, NovoY);
                    //A próxima plataforma depois da p2 será chamada de p3
                    p3 = PlataformaPrefab;
                }
            }
        }
    }
}