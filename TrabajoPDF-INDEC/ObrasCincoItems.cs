using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoPDF_INDEC
{
    public class ObraCincoItem
    {

		private float manoDeObra;

		public float ManoDeObra
		{
			get { return manoDeObra; }
			set { manoDeObra = value; }
		}

		private float equipo;

		public float Equipo
		{
			get { return equipo; }
			set { equipo = value; }
		}

		private float asfaltosCombustibleLubricante;

		public float AsfaltoCombustibleLubricante
		{
			get { return asfaltosCombustibleLubricante; }
			set { asfaltosCombustibleLubricante = value; }
		}

		private float gastoGeneral;

		public float GastoGeneral
		{
			get { return gastoGeneral; }
			set { gastoGeneral = value; }
		}

		private float costoFinanciero;

		public float CostoFinanciero
		{
			get { return costoFinanciero; }
			set { costoFinanciero = value; }
		}

		private float total;

		public float Total
		{
			get { return total; }
			set { total = value; }
		}
	}
}