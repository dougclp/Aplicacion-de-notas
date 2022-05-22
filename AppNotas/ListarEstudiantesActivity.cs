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
    [Activity(Label = "ListarEstudiantesActivity")]
    public class ListarEstudiantesActivity : Activity {
        ListView vlista;
        TextView txtNombreMateria;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Activity_ListarEstudiantes);

            vlista = FindViewById<ListView>(Resource.Id.listVEstudiantes);
            txtNombreMateria = FindViewById<TextView>(Resource.Id.txtNomMateria);
            int idMateria = Intent.GetIntExtra("idMateria", 0);
            txtNombreMateria.Text = Intent.GetStringExtra("nombreMateria");
            vlista.Adapter = new ListarEstudiantesAdapter(this, Global.estudiantes.Where(x => x.Idmateria == idMateria).ToList());


            vlista.ItemClick += Vlista_ItemClick;
        }

        private void Vlista_ItemClick(object sender, AdapterView.ItemClickEventArgs e) {
            var item = Global.estudiantes[e.Position];
            Intent i = new Intent(this, typeof(ListarNotasActivity));
            i.PutExtra("idEstudiante", item.Id);
            i.PutExtra("idMateria", item.Idmateria);
            StartActivity(i);
            
        }
    }
}