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
    internal class AdapterCursos : BaseAdapter
    {
        Activity contetx;
        List<Curso> lista;
        

        public AdapterCursos(Activity contetx, List<Curso> lista)
        {
            this.contetx = contetx;
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
            var item=lista[position];
            View view= convertView;
            if (convertView == null)
                view=contetx.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2,null);
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Nom_curso;
            view.FindViewById<TextView>(Android.Resource.Id.Text2).Text = item.Desc;
            return view;
        }
    }
}