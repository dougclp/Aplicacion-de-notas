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
    class ListarMateriasAdapter : BaseAdapter {
        Activity context;
        List<Materia> lista;

        public ListarMateriasAdapter(Activity context, List<Materia> lista) {
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
                view = context.LayoutInflater.Inflate(Resource.Layout.Adapter_ListViewMaterias, null);
            }

            var estudiantes = Global.estudiantes.Where(x => x.Idmateria == item.Id).ToList();


            double suma = 0.0;
            foreach(var nota in Global.nota.Where(x => x.IdMateria == item.Id).ToList()) {
                suma += nota.NotaFinal;
            }

            view.FindViewById<TextView>(Resource.Id.txtNombreMateria).Text = item.NombreMateria;
            view.FindViewById<TextView>(Resource.Id.txtCantidadEst).Text = estudiantes.Count.ToString();
            view.FindViewById<TextView>(Resource.Id.txtNotaPr).Text = Math.Round((suma / estudiantes.Count), 2).ToString();
            
            
            return view;
        }
    }
}