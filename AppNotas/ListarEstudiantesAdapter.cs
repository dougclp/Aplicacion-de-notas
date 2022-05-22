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

namespace AppNotas {
    class ListarEstudiantesAdapter : BaseAdapter {
        Activity context;
        List<Estudiante> lista;

        public ListarEstudiantesAdapter(Activity context, List<Estudiante> lista) {
            this.context = context;
            this.lista = lista;
        }

        public override int Count => lista.Count;

        public override Java.Lang.Object GetItem(int position) {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position) {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent) {
            View view = convertView;
            var item = lista[position];
            if (view == null) {
                view = context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem1,null);
            }
            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.PrimerNombre + " " + item.SegundoNombre + " " + item.Apellidos;

            return view;
        }
    }
}