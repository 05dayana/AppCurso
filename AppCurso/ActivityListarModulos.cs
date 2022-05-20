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
    [Activity(Label = "ActivityListarModulos"/*, MainLauncher = true*/)]
    public class ActivityListarModulos : Activity
    {
        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.ListaModulos);
            vlista = FindViewById<ListView>(Resource.Id.listView1);

            //Vinculamos la fuente de los datos con el listview mediante el adaptador
            vlista.Adapter=new AdapterModulos(this,Global.Modulos);

            vlista.ItemClick += Vlista_ItemClick;


        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Intent i = new Intent(this,typeof(ActivityDetalleModulo));
            //obtener el id del modulo seleccionado
            Modulo modulo =Global.Modulos[e.Position];
            i.PutExtra("id",modulo.Id);
            StartActivity(i);
        }
    }
}