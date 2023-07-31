using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TrabajoPDF_INDEC
{
    public class ObraSieteItem : ObraCincoItem //Esta obra hereda de ObraCincoItem y agrega 2 item mas para las obras que usan 7 items
    {

		private float hormigon; //Item Hormigon

		public float Hormigon
		{
			get { return hormigon; }
			set { hormigon = value; }
		}

		private float acero; //Item Acero

		public float Acero
		{
			get { return acero; }
			set { acero = value; }
		}


	}
}