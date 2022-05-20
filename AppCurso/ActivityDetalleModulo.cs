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
    [Activity(Label = "ActivityDetalleModulo")]
    public class ActivityDetalleModulo : Activity
    {
        Modulo modulo;
        TextView txtnombre;
        ListView vlista;
      
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.detallemodulo);
            int id = Intent.GetIntExtra("id", 0);
            //Recuperamos el modulo 
            modulo = Global.Modulos.Where(x=>x.Id == id).FirstOrDefault();
            txtnombre = FindViewById<TextView>(Resource.Id.textView1);

            vlista = FindViewById<ListView>(Resource.Id.listView1);
           
            txtnombre.Text = modulo.Nombre;
            vlista.Adapter=new AdapterCursos(this,Global.Cursos.Where(x=>x.IdModulo==modulo.Id).ToList());
            vlista.ItemClick += Vlista_ItemClick;

        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this, typeof(ActivityVideocs));
            Curso c = Global.Cursos[e.Position];
            i.PutExtra("id", c.Id);
            StartActivity(i);
        }
    }
}