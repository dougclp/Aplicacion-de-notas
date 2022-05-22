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
    [Activity(Label = "ListarNotasActivity")]
    public class ListarNotasActivity : Activity {
        ListView vlista;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Activity_ListarNotas);
            int idEstudiante = Intent.GetIntExtra("idEstudiante", 0);
            int idMateria = Intent.GetIntExtra("idMateria", 0);
            vlista = FindViewById<ListView>(Resource.Id.listVNotas);
            vlista.Adapter = new ListarNotasAdapter(this, Global.nota.Where(x => x.IdEstudiante == idEstudiante)
                                                    .Where(y => y.IdMateria == idMateria).ToList());
        }
    }
}