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
    class ListarNotasAdapter : BaseAdapter {
        Activity context;
        List<Nota> list;

        public ListarNotasAdapter(Activity context, List<Nota> list) {
            this.context = context;
            this.list = list;
        }

        public override int Count => list.Count;

        public override Java.Lang.Object GetItem(int position) {
            throw new NotImplementedException();
        }

        public override long GetItemId(int position) {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent) {
            View view = convertView;
            var item = list[position];
            if (view == null) {
                view = context.LayoutInflater.Inflate(Resource.Layout.Adapter_ListViewNotas,null);
            }

            view.FindViewById<TextView>(Resource.Id.txtPrimerNota).Text = item.PrimerNota.ToString();
            view.FindViewById<TextView>(Resource.Id.txtSegundaNota).Text = item.SegundaNota.ToString();
            view.FindViewById<TextView>(Resource.Id.txtPromedioNota).Text = item.NotaFinal.ToString();

            return view;
        }
    }
}