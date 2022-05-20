using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AppCurso
{
    [Activity(Label = "ActivityVideocs")]
    
    public class ActivityVideocs : Activity
    {
        Curso c;
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            
            int id = Intent.GetIntExtra("id", 0);
            c = Global.Cursos.Where(x=> x.Id == id).FirstOrDefault();   

            
            //Definimos el ttipo de accion a realizar
            Intent i = new Intent(Intent.ActionView);

            // //Definimos el parametro de la acción
            //direccion del sitio web
            string url = c.Url;

            //Se establece el parametro que se compartira con la sig app
            i.SetData(Android.Net.Uri.Parse(url));
            //Iniciamos o lamzamos la nueva actividad
            StartActivity(i);
        }
    }
}