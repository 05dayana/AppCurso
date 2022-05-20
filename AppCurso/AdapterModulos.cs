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
    internal class AdapterModulos : BaseAdapter
    {
        //campo
        Activity context;
        List<Modulo> lista;

        public AdapterModulos(Activity context, List<Modulo> lista)
        {
            this.context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position)
        {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            //elemento devuelto
            var item=lista[position];
            //definimos el formato de la fila
            View view = convertView;
            if (view == null)
                view= context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2,null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nombre;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text =
                Global.Cursos.Where(x=>x.IdModulo==item.Id).Count().ToString();
            return view;

        }
    }
}