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
    [Activity(Label = "ListarMateriasActivity")]
    public class ListarMateriasActivity : Activity {
        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Activity_ListarMaterias);
            vlista = FindViewById<ListView>(Resource.Id.listVMaterias);

            vlista.Adapter = new ListarMateriasAdapter(this, Global.materia.ToList());

            vlista.ItemClick += Vlista_ItemClick;
        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e) {
            var item = Global.materia[e.Position];
            Intent i = new Intent(this, typeof(ListarEstudiantesActivity));
            i.PutExtra("idMateria", item.Id);
            i.PutExtra("nombreMateria", item.NombreMateria);
            StartActivity(i);
        }
    }
}