using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //se tiene que agregar esta linea de codigo para importar de las escenas o de lo contrario no las va a pasar

public class MenuPrincipalAppCargas : MonoBehaviour
{
    public string CTAWeb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Menu");
            Debug.Log("escape");
        }
    }

    // inicio de los metodos para empezar mis escenas

    public void MiMennuenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void CerrarApp()
    {
        Application.Quit();
    }

    public void EmpesarCargasPuntuales()
    {
        SceneManager.LoadScene("CargasPuntuales");
    }

    //metodo para el lick de lo que solos

    public void paginaWeb()
    {
        Application.OpenURL(CTAWeb);
    }

}
