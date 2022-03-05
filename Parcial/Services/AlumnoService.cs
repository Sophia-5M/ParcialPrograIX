using Dapper;
using Parcial.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial.Services
{
    public class AlumnoService
    {
        private SqlConnection _Conn = new SqlConnection();
        private static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(@"Data Source=localhost\DESKTOP-SSGKA2E\Sophia; Initial Catalog=ParcialPrograIX; Integrated Security=True; Pooling=False");
        }

        public Alumno GetClientById(int id)
        {
            _Conn = GetSqlConnection();
            _Conn.Open();
            //Select
            var cliente = _Conn.Query<Alumno>("SELECT * FROM Alumno").Where(f => f.id == id).ToList();
            return cliente.Count != 0 ? cliente.First() : null;
        }

        public IEnumerable<Alumno> GetClient()
        {
            _Conn = GetSqlConnection();
            _Conn.Open();
            //Select
            var clientes = _Conn.Query<Alumno>("SELECT * FROM Alumno").ToList();
            return clientes;
        }
    }
}
