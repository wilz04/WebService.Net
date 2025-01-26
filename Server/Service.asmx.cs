using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Web;
using MySql.Data.MySqlClient;
using System.Web.Services;
using System;


namespace Server 
{

	public class Service: System.Web.Services.WebService 
	{

		public Service() 
		{
			InitializeComponent();
		}

		#region Código generado por el Diseñador de componentes

		private IContainer components = null;

		private void InitializeComponent() {}

		protected override void Dispose( bool disposing ) 
		{
			if (disposing && components != null) 
			{
				components.Dispose();
			}
			base.Dispose(disposing);		
		}
		
		#endregion

		// EJEMPLO DE SERVICIO WEB
		// El servicio de ejemplo HelloWorld() devuelve la cadena Hola a todos
		// Para generar, quite la marca de comentario de las siguientes líneas y, después, guarde y genere el proyecto
		// Para probar el servicio Web, presione F5

		
	
		[WebMethod]
		public string[] Consult1(string[] patientId) 
		{
			string[] dataResult = new string[10];
			try
			{

				DataBase dataB = new DataBase();
				DataSet ds = dataB.Select("select PACIENTES.IDPACIENTE,PACIENTES.NOMBRE,PACIENTES.PRIMERAPELLIDO,PACIENTES.FECHANACIMIENTO,EXAMENP.IDEXAMEN,EXAMENP.ESTADO,EXAMENP.FECHAEXAMEN,EXAMENP.FECHARESULTADO from PACIENTES,EXAMENP where PACIENTES.IDPACIENTE = '"+ patientId[0] +"'");
			    int i = 0;
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					string text = "";
					text += row["IDPACIENTE"].ToString() + ","; 
					text += row["NOMBRE"].ToString() + ","; 
					text += row["PRIMERAPELLIDO"].ToString() + ",";
					text += row["FECHANACIMIENTO"].ToString() + ","; 
					text += row["IDEXAMEN"].ToString() + ","; 
					text += row["ESTADO"].ToString() + ","; 
					text += row["FECHAEXAMEN"].ToString() + ","; 
					text += row["FECHARESULTADO"].ToString(); 
					dataResult[i] = text;
					i++;

				}
			}
			catch (Exception exc)
			{
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return dataResult;
		}

		[WebMethod]
		public string[] Consult2(string[] examenId) 
		{
			string[] dataResult = new string[10];
			try
			{

				DataBase dataB = new DataBase();
				DataSet ds = dataB.Select("select PACIENTES.IDPACIENTE,PACIENTES.NOMBRE,PACIENTES.PRIMERAPELLIDO,EXAMENP.ESTADO,EXAMENP.IDEXAMEN,EXAMENDETALLE.IDTIPO from PACIENTES,EXAMENP,EXAMENDETALLE where PACIENTES.IDPACIENTE = EXAMENP.IDPACIENTE and EXAMENP.IDEXAMEN = EXAMENDETALLE.IDEXAMEN AND EXAMENDETALLE.IDEXAMEN = '" +examenId +"'");
				int i = 0;
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					string text = "";
					text += row["IDPACIENTE"].ToString() + ","; 
					text += row["NOMBRE"].ToString() + ","; 
					text += row["PRIMERAPELLIDO"].ToString() + ",";
					text += row["ESTADO"].ToString() + ","; 
					text += row["IDEXAMEN"].ToString() + ",";  
					text += row["IDTIPO"].ToString() + ",";  
					dataResult[i] = text;
					i++;

				}
			}
			catch (Exception exc)
			{
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return dataResult;
			//return null;
		}
		[WebMethod]
		public string[] Consult3(string[] examenId) 
		{
			string[] dataResult = new string[10];
			try
			{

				DataBase dataB = new DataBase();
				DataSet ds = dataB.Select("select PACIENTES.NOMBRE,PACIENTES.PRIMERAPELLIDO,PACIENTES.SEGUNDOAPELLIDO,EXAMENP.ESTADO,TIPOSEXAMEN.DESCRIPCION,TIPOSEXAMEN.VALOR from PACIENTES,EXAMENP,EXAMENDETALLE,TIPOSEXAMEN where PACIENTES.IDPACIENTE = EXAMENP.IDPACIENTE and EXAMENP.IDEXAMEN = EXAMENDETALLE.IDEXAMEN AND EXAMENDETALLE.IDEXAMEN = TIPOSEXAMEN.IDTIPOEXAMEN AND EXAMENP.IDEXAMEN = '" +examenId +"'");
				int i = 0;
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					string text = "";
					text += row["NOMBRE"].ToString() + ","; 
					text += row["PRIMERAPELLIDO"].ToString() + ",";
					text += row["SEGUNDOAPELLIDO"].ToString() + ",";
					text += row["ESTADO"].ToString() + ","; 
					text += row["DESCRIPCION"].ToString() + ",";  
					text += row["VALOR"].ToString() + ",";  
					dataResult[i] = text;
					i++;

				}
			}
			catch (Exception exc)
			{
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return dataResult;
			//return null;
		}

		[WebMethod]
		public string[] Consult4(string[] patientEstado) 
		{
			string[] dataResult = new string[10];
			try
			{

				DataBase dataB = new DataBase();
				DataSet ds = dataB.Select("select PACIENTES.NOMBRE,PACIENTES.PRIMERAPELLIDO,EXAMENP.ESTADO,EXAMENP.IDEXAMEN,EXAMENDETALLE.IDTIPO from PACIENTES,EXAMENP,EXAMENDETALLE where PACIENTES.IDPACIENTE = EXAMENP.IDPACIENTE and EXAMENP.IDEXAMEN = EXAMENDETALLE.IDEXAMEN AND EXAMENP.ESTADO ='" + patientEstado[0] + "'");
				int i = 0;
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					string text = "";
					text += row["IDPACIENTE"].ToString() + ","; 
					text += row["NOMBRE"].ToString() + ","; 
					text += row["PRIMERAPELLIDO"].ToString() + ",";
					text += row["ESTADO"].ToString() + ","; 
					text += row["IDEXAMEN"].ToString() + ",";  
					text += row["IDTIPO"].ToString() + ",";  
					dataResult[i] = text;
					i++;

				}
			}
			catch (Exception exc)
			{
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return dataResult;
			//return null;
		}

		[WebMethod]
		public string[] Consult5(string[] saldo)   
		{
			string[] dataResult = new string[10];
			try
			{

				DataBase dataB = new DataBase();
				DataSet ds = dataB.Select("select EMPLEADOS.NOMBRE,EMPLEADOS.PRIMERAPELLIDO,EMPLEADOS.CEDULA,EMPLEADOS.DIRECCION,EMPLEADOS.IDDEPARTAMENTO,ESPECIALIDAD.NOMBRE AS NOMBREESPE,ESPECIALIDAD.DESCRIPCION,ESPECIALIDAD.SALDO from EMPLEADOS,ESPECIALIDADXEMPLEADO,ESPECIALIDAD where EMPLEADOS.CEDULA = ESPECIALIDADXEMPLEADO.CEDULA and ESPECIALIDADXEMPLEADO.IDESPECIALIDAD = ESPECIALIDAD.IDESPECIALIDAD and ESPECIALIDAD.SALDO = '" + saldo +"'");
				int i = 0;
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					string text = "";
					text += row["NOMBRE"].ToString() + ","; 
					text += row["PRIMERAPELLIDO"].ToString() + ",";
					text += row["CEDULA"].ToString() + ",";
					text += row["DIRECION"].ToString() + ","; 
					text += row["IDDEPARTAMENTO"].ToString() + ",";  
					text += row["NOMBREESPE"].ToString() + ",";  
					text += row["DESCRIPCION"].ToString() + ","; 
					text += row["SALDO"].ToString() + ",";
					dataResult[i] = text;
					i++;

				}
			}
			catch (Exception exc)
			{
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return dataResult;
			//return null;
		}
		[WebMethod]
		public string[] Consult6(string[] espeId)   
		{
			string[] dataResult = new string[10];
			try
			{

				DataBase dataB = new DataBase();
				DataSet ds = dataB.Select("select EMPLEADOS.NOMBRE,EMPLEADOS.PRIMERAPELLIDO,EMPLEADOS.CEDULA,EMPLEADOS.DIRECCION,EMPLEADOS.IDDEPARTAMENTO,ESPECIALIDAD.NOMBRE AS NOMBRESPE,ESPECIALIDAD.DESCRIPCION,ESPECIALIDAD.SALDO from EMPLEADOS,ESPECIALIDADXEMPLEADO,ESPECIALIDAD where EMPLEADOS.CEDULA = ESPECIALIDADXEMPLEADO.CEDULA and ESPECIALIDADXEMPLEADO.IDESPECIALIDAD = ESPECIALIDAD.IDESPECIALIDAD and  ESPECIALIDAD.DESCRIPCION = '"+ espeId[0] + "'");
				int i = 0;
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					string text = "";
					text += row["NOMBRE"].ToString() + ","; 
					text += row["PRIMERAPELLIDO"].ToString() + ",";
					text += row["CEDULA"].ToString() + ",";
					text += row["DIRECION"].ToString() + ","; 
					text += row["IDDEPARTAMENTO"].ToString() + ",";  
					text += row["NOMBRESPE"].ToString() + ",";  
					text += row["DESCRIPCION"].ToString() + ","; 
					text += row["SALDO"].ToString() + ",";
					dataResult[i] = text;
					i++;

				}
			}
			catch (Exception exc)
			{
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return dataResult;
			//return null;
		}
		[WebMethod]
		public string[] Consult7(string[] receId)   
		{
			string[] dataResult = new string[10];
			try
			{

				DataBase dataB = new DataBase();
				DataSet ds = dataB.Select("select PACIENTES.NOMBRE,PACIENTES.PRIMERAPELLIDO,PACIENTES.DOMICILIO,PACIENTES.TELEFONO,RECETAS.IDTIPORECETA,RECETAS.TIPO,RECETASDETALLE.CANTIDAD from PACIENTES,RECETAS,RECETASDETALLE where PACIENTES.IDPACIENTE = RECETAS.IDPACIENTE and RECETAS.IDTIPORECETA = '" + receId[0] + "'");
					int i = 0;
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					string text = "";
					text += row["NOMBRE"].ToString() + ","; 
					text += row["PRIMERAPELLIDO"].ToString() + ",";
					text += row["DOMICILIO"].ToString() + ",";
					text += row["TELEFONO"].ToString() + ","; 
					text += row["IDTIPORECETA"].ToString() + ",";  
					text += row["TIPO"].ToString() + ",";  
					text += row["CANTIDAD"].ToString() + ","; 
					dataResult[i] = text;
					i++;

				}
			}
			catch (Exception exc)
			{
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return dataResult;
		}
		[WebMethod]
		public string[] Consult8(string[] name)   
		{
			string[] dataResult = new string[10];
			try
			{

				DataBase dataB = new DataBase();
				DataSet ds = dataB.Select("select PACIENTES.NOMBRE,PACIENTES.PRIMERAPELLIDO,PACIENTES.DOMICILIO,PACIENTES.TELEFONO,RECETAS.IDTIPORECETA,RECETAS.TIPO,RECETASDETALLE.CANTIDAD from PACIENTES,RECETAS,RECETASDETALLE where PACIENTES.IDPACIENTE = RECETAS.IDPACIENTE and RECETAS.IDTIPORECETA = RECETASDETALLE.IDRECETA and RECETAS.TIPO = '"+ name[0] +"'");
				int i = 0;
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					string text = "";
					text += row["NOMBRE"].ToString() + ","; 
					text += row["PRIMERAPELLIDO"].ToString() + ",";
					text += row["DOMICILIO"].ToString() + ",";
					text += row["TELEFONO"].ToString() + ","; 
					text += row["TIPORECETA"].ToString() + ",";  
					text += row["TIPO"].ToString() + ",";  
					text += row["CANTIDAD"].ToString() + ","; 
					dataResult[i] = text;
					i++;

				}
			}
			catch (Exception exc)
			{
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return dataResult;
		}
		[WebMethod]
		public string[] Consult9(string[] idCuarto)   
		{
			string[] dataResult = new string[10];
			try
			{

				DataBase dataB = new DataBase();
				DataSet ds = dataB.Select("select EQUIPOS.IDEQUIPO,DESCRIPCIONEQUIPO.DESCRIPCION,CUARTOSPACIENTE.DESCRIPCION AS DESCRIPUARTO,EQUIPOS.ESTADO,EQUIPOS.DISPONIBILIDAD,DESCRIPCIONEQUIPO.CANTIDAD,EQUIPOSXCUARTO.FECHADEENTREGA,CUARTOSPACIENTE.COSTO from EQUIPOS,DESCRIPCIONEQUIPO,EQUIPOSXCUARTO,CUARTOSPACIENTE where EQUIPOS.IDEQUIPO = DESCRIPCIONEQUIPO.IDTIPO and DESCRIPCIONEQUIPO.IDTIPO = EQUIPOSXCUARTO.IDEQUIPO and EQUIPOSXCUARTO.IDCUARTO = '"+ idCuarto[0] +"'");
				int i = 0;
				foreach(DataRow row in ds.Tables[0].Rows)
				{
					string text = "";
					text += row["IDEQUIPO"].ToString() + ","; 
					text += row["DESCRIPCION"].ToString() + ",";
					text += row["DESCRIPUARTO"].ToString() + ",";
					text += row["ESTADO"].ToString() + ","; 
					text += row["DISPONIBILIDAD"].ToString() + ",";  
					text += row["CANTIDAD"].ToString() + ","; 
					text += row["FECHAENTREGA"].ToString() + ","; 
					text += row["COSTO"].ToString() + ","; 
					dataResult[i] = text;
					i++;

				}
			}
			catch (Exception exc)
			{
				throw new Exception("Error obteniendo las llaves foráneas DBManager.GetForeignKeys", exc);
			}
			return dataResult;
		}
	}

}
