using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace SegundoParcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Transito mTrans = new Transito();

        private void Form1_Load(object sender, EventArgs e)
        {
            mTrans.Agregar(new Ambulancia { Nombre = "Ambulancia EMERGENCIA", EnEmergencia = true });
            mTrans.Agregar(new Ambulancia { Nombre = "Ambulancia", EnEmergencia = false });
            mTrans.Agregar(new Auto { Nombre = "Auto 1000cc", Deportivo = false, Cilindrada = 1000 });
            mTrans.Agregar(new Auto { Nombre = "Auto 2000cc", Deportivo = false, Cilindrada = 2000 });
            mTrans.Agregar(new Auto { Nombre = "Auto DEPO 2000cc", Deportivo = true, Cilindrada = 2000 });
            mTrans.Agregar(new Colectivo { Nombre = "Colectivo 100P", Pasajeros = 100 });
            mTrans.Agregar(new Colectivo { Nombre = "Colectivo 99P", Pasajeros = 99 });
            
            Colectivo c = new Colectivo { Nombre = "Colectivo OP+ 100+75P", Pasajeros = 100 };
            mTrans.Agregar(c+75);

            mTrans.Agregar(new Moto { Nombre = "Moto Scooter 500cc", mTipo = Moto.TipoMoto.Scooter, Cilindrada = 500 });
            mTrans.Agregar(new Moto { Nombre = "Moto Enduro 250cc", mTipo = Moto.TipoMoto.Enduro, Cilindrada = 250 });
            mTrans.Agregar(new Moto { Nombre = "Moto Enduro 500cc", mTipo = Moto.TipoMoto.Enduro, Cilindrada = 500 });
            mTrans.Agregar(new Moto { Nombre = "Moto GT 250cc", mTipo = Moto.TipoMoto.GranTurismo, Cilindrada = 250 });
            mTrans.Agregar(new Moto { Nombre = "Moto GT 500cc", mTipo = Moto.TipoMoto.GranTurismo, Cilindrada = 500 });

            grdVehiculos.Columns.Add("Nombre", "Nombre");
            grdVehiculos.Columns.Add("Marca", "Marca");
            grdVehiculos.Columns.Add("Velocidad", "Velocidad");
            grdVehiculos.AllowUserToDeleteRows = false;
            grdVehiculos.AutoResizeRows();
            grdVehiculos.ReadOnly = true;

            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            grdVehiculos.Rows.Clear();
            foreach (Vehiculo v in mTrans)
            {
                grdVehiculos.Rows.Add(v.Nombre, v.Marca, v.Velocidad);
            }
        }
        private void btnSemaRojo_Click(object sender, EventArgs e)
        {
            mTrans.PonerSemaforoRojo();
            ActualizarGrid();
        }

        private void btnSemaVerde_Click(object sender, EventArgs e)
        {
            mTrans.PonerSemaforoVerde();
            ActualizarGrid();
        }
    }
}
